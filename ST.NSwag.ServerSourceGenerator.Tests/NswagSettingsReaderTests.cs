using NSwag.CodeGeneration.CSharp.Models;
using ST.NSwag.ServerSourceGenerator;

namespace H.NSwag.Generator.SnapshotTests;

public class NswagSettingsReaderTests
{
    [Fact]
    public void ReadSettingsWithStrictMode()
    {
        var result = new NswagSettingsReader(strictMode: true).Read("example.nswag");

        Assert.Equal(CSharpControllerTarget.AspNetCore, result.ControllerTarget);
    }
}
