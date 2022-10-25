using Ardalis.GuardClauses;

namespace TestingRefactoring
{
    public static class ConversorServicio
    {
        public static decimal ConvertirMoneda(decimal? valor, string tipoMoneda)
        {
            Guard.Against.Null(valor, nameof(valor), "El valor no puede ser cero");
            Guard.Against.NullOrEmpty(tipoMoneda, nameof(tipoMoneda));
            
            //validate if valor is null
            //_ = valor ?? throw new ArgumentException("El valor no puede ser cero", nameof(valor));

            decimal valorNotNull = Convert.ToDecimal(valor);

            //validar los tipos de moneda
            if (tipoMoneda == "USD")
            {
                return valorNotNull / 1500M;
            }
            else
            {
                if (tipoMoneda == "EUR")
                {
                    return valorNotNull / 1250M;
                }
                else if (tipoMoneda == "CAD")
                {
                    return valorNotNull / 1000M;
                }
                return 0;
            }
        }

        public static decimal ConvertirMonedaVersion2(ClaseConversion _request) =>
           _request switch
           {
               { valor: 0 } => throw new ArgumentException("El valor no puede ser cero"),
               { tipoMoneda: null } => throw new ArgumentNullException(nameof(_request.tipoMoneda)),
               { tipoMoneda: "USD" } => _request.valor / 1500M,
               { tipoMoneda: "EUR" } => _request.valor / 1250M,
               { tipoMoneda: "CAD" } => _request.valor / 1000M,
           };
    }
}