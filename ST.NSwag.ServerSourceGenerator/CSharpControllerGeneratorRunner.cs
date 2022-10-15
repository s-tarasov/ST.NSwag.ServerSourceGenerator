using NSwag;
using NSwag.CodeGeneration.CSharp;

namespace ST.NSwag.ServerSourceGenerator
{
    internal static class CSharpControllerGeneratorRunner
    {
        private static readonly NswagSettingsReader _settingsReader = new NswagSettingsReader(false);

        public static string GenerateController(string nswagFilePath, string openapiDocumentContent,
            CancellationToken cancellationToken = default)
        {
            return Async().GetAwaiter().GetResult();

            async Task<string> Async()
            {
                var settings = _settingsReader.Read(nswagFilePath);
                var openapiDocument = await OpenApiYamlDocument.FromYamlAsync(openapiDocumentContent, cancellationToken);
                var generator = new CSharpControllerGenerator(openapiDocument, settings);

                return generator.GenerateFile();
            }
        }
    }
}
