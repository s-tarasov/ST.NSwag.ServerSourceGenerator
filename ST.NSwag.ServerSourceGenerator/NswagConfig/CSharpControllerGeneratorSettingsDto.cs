using System.Runtime;
using NJsonSchema.CodeGeneration.CSharp;
using NSwag.CodeGeneration.CSharp;

namespace ST.NSwag.ServerSourceGenerator.NswagConfig;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

public class CSharpControllerGeneratorSettingsDto : CSharpControllerGeneratorSettings
{
    public OperationGenerationMode OperationGenerationMode
    {
        set
        {
            OperationNameGenerator = OperationGenerationModeConverter.GetOperationNameGenerator(value);
        }
    }

    // Not applicable to source generators
    public string Output { get; set; }

    // Not applicable to source generators
    public string NewLineBehavior { get; set; }

    public bool GenerateJsonMethods
    {
        get => CSharpGeneratorSettings.GenerateJsonMethods;
        set => CSharpGeneratorSettings.GenerateJsonMethods = value;
    }

    public bool EnforceFlagEnums
    {
        get { return CSharpGeneratorSettings.EnforceFlagEnums; }
        set { CSharpGeneratorSettings.EnforceFlagEnums = value; }
    }

    public string Namespace
    {
        get { return CSharpGeneratorSettings.Namespace; }
        set { CSharpGeneratorSettings.Namespace = value; }
    }

    public bool RequiredPropertiesMustBeDefined
    {
        get { return CSharpGeneratorSettings.RequiredPropertiesMustBeDefined; }
        set { CSharpGeneratorSettings.RequiredPropertiesMustBeDefined = value; }
    }

    public string DateType
    {
        get { return CSharpGeneratorSettings.DateType; }
        set { CSharpGeneratorSettings.DateType = value; }
    }

    public string[] JsonConverters
    {
        get { return CSharpGeneratorSettings.JsonConverters; }
        set { CSharpGeneratorSettings.JsonConverters = value; }
    }


    public string AnyType
    {
        get { return CSharpGeneratorSettings.AnyType; }
        set { CSharpGeneratorSettings.AnyType = value; }
    }

    public string DateTimeType
    {
        get { return CSharpGeneratorSettings.DateTimeType; }
        set { CSharpGeneratorSettings.DateTimeType = value; }
    }

    public string TimeType
    {
        get { return CSharpGeneratorSettings.TimeType; }
        set { CSharpGeneratorSettings.TimeType = value; }
    }

    public string TimeSpanType
    {
        get { return CSharpGeneratorSettings.TimeSpanType; }
        set { CSharpGeneratorSettings.TimeSpanType = value; }
    }

    public string ArrayType
    {
        get { return CSharpGeneratorSettings.ArrayType; }
        set { CSharpGeneratorSettings.ArrayType = value; }
    }

    public string ArrayInstanceType
    {
        get { return CSharpGeneratorSettings.ArrayInstanceType; }
        set { CSharpGeneratorSettings.ArrayInstanceType = value; }
    }

    public string DictionaryType
    {
        get { return CSharpGeneratorSettings.DictionaryType; }
        set { CSharpGeneratorSettings.DictionaryType = value; }
    }

    public string DictionaryInstanceType
    {
        get { return CSharpGeneratorSettings.DictionaryInstanceType; }
        set { CSharpGeneratorSettings.DictionaryInstanceType = value; }
    }

    public string ArrayBaseType
    {
        get { return CSharpGeneratorSettings.ArrayBaseType; }
        set { CSharpGeneratorSettings.ArrayBaseType = value; }
    }

    public string DictionaryBaseType
    {
        get { return CSharpGeneratorSettings.DictionaryBaseType; }
        set { CSharpGeneratorSettings.DictionaryBaseType = value; }
    }

    public CSharpClassStyle ClassStyle
    {
        get { return CSharpGeneratorSettings.ClassStyle; }
        set { CSharpGeneratorSettings.ClassStyle = value; }
    }

    public CSharpJsonLibrary JsonLibrary
    {
        get { return CSharpGeneratorSettings.JsonLibrary; }
        set { CSharpGeneratorSettings.JsonLibrary = value; }
    }

    public bool GenerateDefaultValues
    {
        get { return CSharpGeneratorSettings.GenerateDefaultValues; }
        set { CSharpGeneratorSettings.GenerateDefaultValues = value; }
    }

    public bool GenerateDataAnnotations
    {
        get { return CSharpGeneratorSettings.GenerateDataAnnotations; }
        set { CSharpGeneratorSettings.GenerateDataAnnotations = value; }
    }

    public string[] ExcludedTypeNames
    {
        get { return CSharpGeneratorSettings.ExcludedTypeNames; }
        set { CSharpGeneratorSettings.ExcludedTypeNames = value; }
    }

    public bool HandleReferences
    {
        get { return CSharpGeneratorSettings.HandleReferences; }
        set { CSharpGeneratorSettings.HandleReferences = value; }
    }

    public bool GenerateImmutableArrayProperties
    {
        get { return CSharpGeneratorSettings.GenerateImmutableArrayProperties; }
        set { CSharpGeneratorSettings.GenerateImmutableArrayProperties = value; }
    }

    public bool GenerateImmutableDictionaryProperties
    {
        get { return CSharpGeneratorSettings.GenerateImmutableDictionaryProperties; }
        set { CSharpGeneratorSettings.GenerateImmutableDictionaryProperties = value; }
    }

    public string JsonSerializerSettingsTransformationMethod
    {
        get { return CSharpGeneratorSettings.JsonSerializerSettingsTransformationMethod; }
        set { CSharpGeneratorSettings.JsonSerializerSettingsTransformationMethod = value; }
    }

    public bool InlineNamedArrays
    {
        get { return CSharpGeneratorSettings.InlineNamedArrays; }
        set { CSharpGeneratorSettings.InlineNamedArrays = value; }
    }

    public bool InlineNamedDictionaries
    {
        get { return CSharpGeneratorSettings.InlineNamedDictionaries; }
        set { CSharpGeneratorSettings.InlineNamedDictionaries = value; }
    }

    public bool InlineNamedTuples
    {
        get { return CSharpGeneratorSettings.InlineNamedTuples; }
        set { CSharpGeneratorSettings.InlineNamedTuples = value; }
    }

    public bool InlineNamedAny
    {
        get { return CSharpGeneratorSettings.InlineNamedAny; }
        set { CSharpGeneratorSettings.InlineNamedAny = value; }
    }

    public bool GenerateOptionalPropertiesAsNullable
    {
        get { return CSharpGeneratorSettings.GenerateOptionalPropertiesAsNullable; }
        set { CSharpGeneratorSettings.GenerateOptionalPropertiesAsNullable = value; }
    }

    public bool GenerateNullableReferenceTypes
    {
        get { return CSharpGeneratorSettings.GenerateNullableReferenceTypes; }
        set { CSharpGeneratorSettings.GenerateNullableReferenceTypes = value; }
    }

    public string TemplateDirectory
    {
        get { return CodeGeneratorSettings.TemplateDirectory; }
        set { CodeGeneratorSettings.TemplateDirectory = value; }
    }

    public string? TypeNameGeneratorType
    {
        get => null;
        set
        {
            if (!string.IsNullOrEmpty(value))
                throw new NotImplementedException("TypeNameGeneratorType");
        }
    }

    public string PropertyNameGeneratorType
    {
        get => null;
        set
        {
            if (!string.IsNullOrEmpty(value))
                throw new NotImplementedException("PropertyNameGeneratorType");
        }
    }

    public string EnumNameGeneratorType
    {
        get => null;
        set
        {
            if (!string.IsNullOrEmpty(value))
                throw new NotImplementedException("EnumNameGeneratorType");
        }
    }

    // Not applicable to server geneartion
    public string ServiceHost { get; set; }


    // Not applicable to server geneartion
    public string ServiceBasePath { get; set; }

    // Not applicable to server geneartion
    public string[] ServiceSchemes { get; set; }
}
