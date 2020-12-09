using System;
using System.Numerics;
using System.Text.Json.Serialization;

namespace VincentsShop.WASM.Shared.Models
{
    /// <summary>
    /// L'avantage de spécifier l'attribut JsonPropertyName ici est de pouvoir utiliser un nom de membre différents de ce que Dolibarr nous donne
    /// L'avantage de spécifier l'attribut JsonIgnore ici est de pouvoir réduire le traitement de sérialization en omettant les valeurs nulls. 
    /// On pourrait également ne pas sérialiser ce qui n'est pas encore implanté dans l'interface Web en utilisant JsonIgnoreCondition.Always
    /// https://docs.microsoft.com/en-us/dotnet/standard/serialization/system-text-json-how-to?pivots=dotnet-5-0#exclude-individual-properties
    /// </summary>
    public class Product
    {
        [JsonPropertyName("id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)] 
        public uint id { get; set; }
        
        [JsonPropertyName("label")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string label { get; set; }
        
        [JsonPropertyName("description")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string description { get; set; }
        
        [JsonPropertyName("price")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public decimal price { get; set; }
        
        [JsonPropertyName("cost_price")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public decimal cost_price { get; set; }
        
        [JsonPropertyName("accountancy_code_sell")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string accountancy_code_sell { get; set; }
        
        [JsonPropertyName("accountancy_code_buy")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string accountancy_code_buy { get; set; }
        
        [JsonPropertyName("stock_reel")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public uint stock_reel { get; set; }
        
        [JsonPropertyName("category")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string category { get; set; }
        
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public Image image { get; set; }


        public class Image
        {
            [JsonPropertyName("name")]
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string name { get; set; }
            
            [JsonPropertyName("path")]
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string path { get; set; }
            
            [JsonPropertyName("level1name")]
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string level1name { get; set; }
            
            [JsonPropertyName("relativename")]
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string relativename { get; set; }
            
            [JsonPropertyName("fullname")]
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string fullname { get; set; }
            
            [JsonPropertyName("date")]
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public BigInteger date { get; set; }
            
            [JsonPropertyName("size")]
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public uint size { get; set; }
            
            [JsonPropertyName("type")]
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public string type { get; set; }

        }
    }
}
