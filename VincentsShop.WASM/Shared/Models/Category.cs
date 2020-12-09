using System.Text.Json.Serialization;

namespace VincentsShop.WASM.Shared.Models
{
    /// <summary>
    /// L'avantage de spécifier l'attribut JsonPropertyName ici est de pouvoir utiliser un nom de membre différents de ce que Dolibarr nous donne
    /// L'avantage de spécifier l'attribut JsonIgnore ici est de pouvoir réduire le traitement de sérialization en omettant les valeurs nulls. 
    /// On pourrait également ne pas sérialiser ce qui n'est pas encore implanté dans l'interface Web en utilisant JsonIgnoreCondition.Always
    /// https://docs.microsoft.com/en-us/dotnet/standard/serialization/system-text-json-how-to?pivots=dotnet-5-0#exclude-individual-properties
    /// </summary>
    public class Category
    {

        [JsonPropertyName("id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public uint id { get; set; }

        [JsonPropertyName("fk_parent")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public uint fk_parent { get; set; }

        [JsonPropertyName("label")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string label { get; set; }

        [JsonPropertyName("description")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string description { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public Product[] produits { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string imageUrl { get; set; }

        public string getUrl()
        { 
            //return "/categories/" + label.Replace(' ', '_').ToLower();
            return "/categories/" + id; 
        }

        public string getImageUrl()
        {
            return "/img/samples/" + label.Replace(' ', '_').ToLower() + ".jpg";
        }
    }
}
