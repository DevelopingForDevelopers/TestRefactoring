using Microsoft.Extensions.Configuration;
using TestingRefactoring;

//Console.WriteLine("***Convertir Monedas***");

////Convertir 100.000 Pesos a Dolares
//Console.WriteLine($"100.000 Pesos a Dolares: {decimal.Round(ConversorServicio.ConvertirMoneda(100000, "USD"), 2)}");

////Convertir 100000 Pesos a Euros
//Console.WriteLine($"100.000 Pesos a Euros: {decimal.Round(ConversorServicio.ConvertirMoneda(100000, "EUR"))}");

////Convertir 100000 Dolares a dolares canadienses
//Console.WriteLine($"100.000 Dolares a Dolares Canadienses: {decimal.Round(ConversorServicio.ConvertirMoneda(100000, "CAD"))}");

//*************************************************************************************************************************************
//create object for ClaseConversion
//var object1 = new ClaseConversion(100000, "USD");
////refactor
//Console.WriteLine($"100.000 Pesos a Dolares: {decimal.Round(ConversorServicio.ConvertirMonedaVersion2(object1), 2)}");


//*************************************************************************************************************************************
//create var settings
var settings = new Dictionary<string, string>
{
    ["variable1"] = "Hola mundo",
    ["variable2"] = "adios mundo"
};

//var builder = new ConfigurationBuilder()
//    .AddInMemoryCollection(settings)
//    .Build();

//Console.WriteLine(builder["variable1"]);
//Console.WriteLine(builder["variable2"]);

var builderJson = new ConfigurationBuilder()
    .AddInMemoryCollection(settings)
    .AddEnvironmentVariables();

var config = builderJson.Build();

Console.WriteLine(config["variable1"]);
Console.WriteLine(config["variable2"]);