namespace TestingRefactoring.UnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void ConvertirPesosDolares_Test1()
        {
            decimal result = decimal.Round(ConversorServicio.ConvertirMoneda(100000, "USD"), 2);
            Assert.Equal(66.67M, result);
        }
        
        [Fact]
        public void ConvertirPesosDolares_Test2()
        {
            decimal result = decimal.Round(ConversorServicio.ConvertirMoneda(200000, "USD"), 2);
            Assert.Equal(133.33M, result);
        }

        [Fact]
        public void ConvertirPesosDolares_Test3()
        {
            //Arrange
            decimal valor = 100000;
            string tipoMoneda = "USD";
            decimal expected = 66.67M;

            //Act
            decimal result = decimal.Round(ConversorServicio.ConvertirMoneda(valor, tipoMoneda), 2);

            //Assert
            Assert.Equal(expected, result);
        }
        
        [Theory]
        [InlineData(100000, "USD", 66.67)]
        [InlineData(100000, "EUR", 80)]
        [InlineData(100000, "CAD", 100)]
        public void ConvertirPesosDolares_Test4(decimal valor, string tipoMoneda, decimal expected)
        {
            //Act
            decimal result = decimal.Round(ConversorServicio.ConvertirMoneda(valor, tipoMoneda), 2);

            //Assert
            Assert.Equal(expected, result);
        }
    }
}