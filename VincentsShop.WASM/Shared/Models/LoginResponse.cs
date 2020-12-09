using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace VincentsShop.WASM.Shared.Models
{
    /// <summary>
    /// L'avantage de spécifier l'attribut JsonPropertyName ici est de pouvoir utiliser un nom de membre différents de ce que Dolibarr nous donne
    /// L'avantage de spécifier l'attribut JsonIgnore ici est de pouvoir réduire le traitement de sérialization en omettant les valeurs nulls. 
    /// On pourrait également ne pas sérialiser ce qui n'est pas encore implanté dans l'interface Web en utilisant JsonIgnoreCondition.Always
    /// https://docs.microsoft.com/en-us/dotnet/standard/serialization/system-text-json-how-to?pivots=dotnet-5-0#exclude-individual-properties
    /// </summary>
    public class LoginResponse
    {
        [JsonPropertyName("success")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
        public Success success { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public bool Successful { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string ErrorMessage { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string JwtToken { get; set; }

        public class Success
        {
            [JsonPropertyName("code")]
            [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
            public int code { get; set; }

            [JsonPropertyName("token")]
            [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
            public string token { get; set; }

            [JsonPropertyName("entity")]
            [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
            public string entity { get; set; }

            [JsonPropertyName("message")]
            [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
            public string message { get; set; }
        }

    }
}
