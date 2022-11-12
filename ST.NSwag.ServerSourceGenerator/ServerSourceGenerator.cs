using H.Generators.Extensions;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;

namespace ST.NSwag.ServerSourceGenerator
{
    [Generator]
    public class ServerSourceGenerator : IIncrementalGenerator
    {
        public void Initialize(IncrementalGeneratorInitializationContext context)
        {
            var openapiFiles = context.AdditionalTextsProvider
                .Where(file => file.Path.EndsWith(".openapi.yaml"));

            var PathAndContents = openapiFiles
                .Combine(context.AnalyzerConfigOptionsProvider)
                .Select((pair, cancellationToken) => Generate(pair.Left, pair.Right, cancellationToken));

            context.RegisterSourceOutput(PathAndContents, (spc, nameAndContent)
                => spc.AddSource(nameAndContent.name, nameAndContent.content));
        }

        private static (string name, string content) Generate(AdditionalText openapiText, 
            AnalyzerConfigOptionsProvider optionProvider, CancellationToken cancellationToken)
        {
            var openapiContent = openapiText.GetText(cancellationToken)!.ToString();
            var nswagFilePath = GetNswagFilePath(openapiText, optionProvider);
            var fileContent = CSharpControllerGeneratorRunner.GenerateController(nswagFilePath, openapiText.Path, openapiContent, cancellationToken);
            return (name: ToSourceHint(openapiText), content: fileContent);
        }

        private static string GetNswagFilePath(AdditionalText openapiText, AnalyzerConfigOptionsProvider optionProvider)
        {
            string openapiFilePath = GetOpenapiFilePath(openapiText, optionProvider);
            return $"{openapiFilePath}.nswag";

            static string GetOpenapiFilePath(AdditionalText openapiText, AnalyzerConfigOptionsProvider optionProvider)
            {
                string? linkValue = optionProvider.GetOption(openapiText, "Link");
                if (linkValue == null)
                    return openapiText.Path;

                return Path.Combine(optionProvider.GetRequiredGlobalOption("MSBuildProjectDirectory"), linkValue);
            }
        }

        private static string ToSourceHint(AdditionalText openapiText) 
            => Path.GetFileNameWithoutExtension(openapiText.Path) + ".cs";
    }
}
