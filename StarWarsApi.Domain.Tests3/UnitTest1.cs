using StarWarsApi.Domain.Extensions;

namespace StarWarsApi.Domain.Tests3;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        // Arrange
        var entry = "São Paulo";
        var expectedResult = "Sao Paulo";

        // Act
        var result = entry.SubstituteSpecialChars();

        // Assert
        Assert.AreEqual(expectedResult, result);
    }

    [DataTestMethod]
    [DataRow("Alçafrão", "Alcafrao")]
    [DataRow("São Paulo", "Sao Paulo")]
    public void Test3(string entry, string expectedResult)
    {
        // Act
        var result = entry.SubstituteSpecialChars();

        // Assert
        Assert.AreEqual(expectedResult, result);
    }
}
