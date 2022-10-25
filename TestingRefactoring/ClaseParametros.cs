namespace TestingRefactoring
{
    public  class ClaseParametros
    {
        public string Url { get; set; }
        public string ApiKey { get; set; }
        public int Version { get; set; }
        public bool IsValid { get; set; }
        
        public ClaseParametros(string url, string apiKey, int version, bool isValid)
        {
            Url = url;
            ApiKey = apiKey;
            Version = version;
            IsValid = isValid;
        }
    }
    public class ClaseConversion
    {
        public decimal valor { get; set; }
        public string tipoMoneda { get; set; }

        public ClaseConversion(decimal valor, string tipoMoneda)
        {
            this.valor = valor;
            this.tipoMoneda = tipoMoneda;
        }

    }
}