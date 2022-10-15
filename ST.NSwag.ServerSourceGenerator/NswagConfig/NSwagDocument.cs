namespace ST.NSwag.ServerSourceGenerator.NswagConfig;

public class FromDocument
{
    public string Json { get; set; }
    public string Url { get; set; }
    public object Output { get; set; }
    public string NewLineBehavior { get; set; }
}

public class DocumentGenerator
{
    public FromDocument FromDocument { get; set; }
}

public class CodeGenerators
{
    public CSharpControllerGeneratorSettingsDto OpenApiToCSharpController { get; set; }
}

public class NSwagDocument
{
    public string Runtime { get; set; }
    public object DefaultVariables { get; set; }
    public DocumentGenerator DocumentGenerator { get; set; }
    public CodeGenerators CodeGenerators { get; set; }
}
