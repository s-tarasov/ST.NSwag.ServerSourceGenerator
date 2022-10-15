using Newtonsoft.Json;
using NSwag.CodeGeneration.CSharp;
using ST.NSwag.ServerSourceGenerator.NswagConfig;

namespace ST.NSwag.ServerSourceGenerator;

public class NswagSettingsReader
{
    private readonly JsonSerializerSettings _settings;

    public NswagSettingsReader(bool strictMode)
    {
        _settings = new()
        {
            MissingMemberHandling = strictMode ? MissingMemberHandling.Error : MissingMemberHandling.Ignore
        };
    }

    public CSharpControllerGeneratorSettings Read(string nswagFilePath)
    {
        string nswagFileContent = File.ReadAllText(nswagFilePath);
        var document = JsonConvert.DeserializeObject<NSwagDocument>(nswagFileContent, _settings)
            ?? throw new InvalidOperationException("Document is null.");
        var generatorSettings = document.CodeGenerators.OpenApiToCSharpController;

        generatorSettings.TemplateDirectory = RelativeToAbsolutePath(generatorSettings.TemplateDirectory, nswagFilePath);

        return generatorSettings;
    }

    private static string RelativeToAbsolutePath(string path, string nswagFilePath)
    {
        if (IsRelative(path))
        {
            var nswagFileDirectory = Path.GetDirectoryName(nswagFilePath);
            return Path.Combine(nswagFileDirectory, path);
        }

        return path;

        static bool IsRelative(string path) => path?.StartsWith(".") == true;
    }
}
