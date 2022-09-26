using System;
using StarWarsApi.Domain.Extensions;

namespace StarWarsApi.Domain.Tests.Extensions
{
    public class StringExtensionsTests
    {
        public StringExtensionsTests()
        {
        }

        [Fact]
        public void GetNumericsFromANormalString()
        {
            //Arrange
            var entry = "09891-050";

            //Act
            var result = entry.GetNumerics();

            //Assert
            Assert.DoesNotContain("-", result);
        }

        //[Fact] // Comentando o [Fact] para ele não ser listado como teste 
        public void GetNumericsFromANullString_()
        {
            //Arrange
            string entry = null;

            //Act / Assert
            Assert.ThrowsAny<Exception>(() => entry.GetNumerics());
        }

        [Fact]
        public void GetNumericsFromANullString()
        {
            //Arrange
            string entry = null;

            //Act
            var result = entry.GetNumerics();

            //Assert
            Assert.Null(result);
        }

        [Fact]
        public void GetNumericsFromAnEmptyString()
        {
            //Arrange
            string entry = "";

            //Act
            var result = entry.GetNumerics();

            //Assert
            Assert.Equal("", result);
        }

        [Fact]
        public void GetNumericsFromAStringWithWhite()
        {
            //Arrange
            string entry = " ";

            //Act
            var result = entry.GetNumerics();

            //Assert
            Assert.Equal(" ", result);
        }

        [Fact]
        public void GetNumericsFromAStringWithoutNumbers()
        {
            //Arrange
            var entry = "Heber Henrique da Silva";

            //Act
            var result = entry.GetNumerics();

            //Assert
            Assert.Equal("", result);
        }

        #region GetInteger

        [Fact]
        public void GetIntegerFromACpfString()
        {
            //Arrange
            var entry = "935.715.960-64";
            var expectedResult = "935715960-64";

            //Act
            var result = entry.GetInteger();

            //Assert
            Assert.Equal(expectedResult, result);
        }
        #endregion

        // Exemplo de método que representa um Action delegate
        public void MyAction()
        {
            //Arrange
            string entry = null;

            //Act
            var result = entry.GetNumerics();
        }


        #region SubstituteSpecialChars


        [Fact]
        public void TestSusbstituteSpecialCharsWithNullString()
        {
            
        }

        [Fact]
        public void TestSusbstituteSpecialCharsWithEmptyString()
        {

        }

        [Fact]
        public void TestSusbstituteSpecialCharsWithWhiteSpacesString()
        {

        }

        [Fact]
        public void TestSusbstituteSpecialCharsWithNormalString()
        {
            // Arrange
            var entry = "São Paulo";
            var expectedResult = "Sao Paulo";

            // Act
            var result = entry.SubstituteSpecialChars();

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void TestSusbstituteSpecialCharsWithNormalString2()
        {
            // Arrange
            var entry = "seção sagüi d'água com açafrão";
            var expectedResult = "secao sagui d agua com acafrao";

            // Act
            var result = entry.SubstituteSpecialChars();

            // Assert
            Assert.Equal(expectedResult, result);
        }


        [Theory]
        [InlineData("Alçafrão", "Alcafrao")]
        [InlineData("São Paulo", "Sao Paulo")]
        public void Teste1(
            string entry,
            string expectedResult)
        {
            // Act
            var result = entry.SubstituteSpecialChars();

            // Assert
            Assert.Equal(expectedResult, result);
        }


        #endregion


    }
}

