using NSwag.CodeGeneration.OperationNameGenerators;

namespace ST.NSwag.ServerSourceGenerator.NswagConfig;

public enum OperationGenerationMode
{
    /// <summary>Multiple clients from the Swagger operation ID in the form '{controller}_{action}'.</summary>
    MultipleClientsFromOperationId,

    /// <summary>From path segments (operation name = last segment, client name = second to last segment).</summary>
    MultipleClientsFromPathSegments,

    /// <summary>From the first operation tag and path segments (operation name = last segment, client name = first operation tag).</summary>
    MultipleClientsFromFirstTagAndPathSegments,

    /// <summary>From the first operation tag and operation ID (operation name = operation ID, client name = first operation tag).</summary>
    MultipleClientsFromFirstTagAndOperationId,

    /// <summary>From the Swagger operation ID.</summary>
    SingleClientFromOperationId,

    /// <summary>From path segments suffixed by HTTP operation name</summary>
    SingleClientFromPathSegments,
}

internal class OperationGenerationModeConverter
{

    internal static IOperationNameGenerator GetOperationNameGenerator(OperationGenerationMode operationGenerationMode)
    {
        if (operationGenerationMode == OperationGenerationMode.MultipleClientsFromOperationId)
        {
            return new MultipleClientsFromOperationIdOperationNameGenerator();
        }
        else if (operationGenerationMode == OperationGenerationMode.MultipleClientsFromPathSegments)
        {
            return new MultipleClientsFromPathSegmentsOperationNameGenerator();
        }
        else if (operationGenerationMode == OperationGenerationMode.MultipleClientsFromFirstTagAndPathSegments)
        {
            return new MultipleClientsFromFirstTagAndPathSegmentsOperationNameGenerator();
        }
        else if (operationGenerationMode == OperationGenerationMode.MultipleClientsFromFirstTagAndOperationId)
        {
            return new MultipleClientsFromFirstTagAndOperationIdGenerator();
        }
        else if (operationGenerationMode == OperationGenerationMode.SingleClientFromOperationId)
        {
            return new SingleClientFromOperationIdOperationNameGenerator();
        }
        else if (operationGenerationMode == OperationGenerationMode.SingleClientFromPathSegments)
        {
            return new SingleClientFromPathSegmentsOperationNameGenerator();
        }
        else
        {
            return new MultipleClientsFromOperationIdOperationNameGenerator();
        }
    }
}
