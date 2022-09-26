using StarWarsApi.Domain.Extensions;

namespace StarWarsApi.Domain.Tests2;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }

    [Test]
    public void Test2()
    {
        // Arrange
        var entry = "São Paulo";
        var expectedResult = "Sao Paulo";

        // Act
        var result = entry.SubstituteSpecialChars();

        // Assert
        //Assert.AreEqual(expectedResult, result);
        Assert.That(result, Is.EqualTo(expectedResult));
    }


    [TestCase("Alçafrão", "Alcafrao")]
    [TestCase("São Paulo", "Sao Paulo")]
    public void Test3(string entry, string expectedResult)
    {
        // Act
        var result = entry.SubstituteSpecialChars();

        // Assert
        //Assert.AreEqual(expectedResult, result);
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}
