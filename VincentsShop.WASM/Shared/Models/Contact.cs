using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace VincentsShop.WASM.Shared.Models
{
    public class Contact
    {

        [JsonPropertyName("civility_id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object civility_id { get; set; }

        [JsonPropertyName("civility_code")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string civility_code { get; set; }

        [JsonPropertyName("civility")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string civility { get; set; }

        [JsonPropertyName("address")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string address { get; set; }

        [JsonPropertyName("zip")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string zip { get; set; }

        [JsonPropertyName("town")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string town { get; set; }

        [JsonPropertyName("state_id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string state_id { get; set; }

        [JsonPropertyName("state_code")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string state_code { get; set; }

        [JsonPropertyName("state")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string state { get; set; }

        [JsonPropertyName("poste")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string poste { get; set; }

        [JsonPropertyName("socid")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string socid { get; set; }

        [JsonPropertyName("statut")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string statut { get; set; }

        [JsonPropertyName("code")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object code { get; set; }

        [JsonPropertyName("email")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string email { get; set; }

        [JsonPropertyName("no_email")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object no_email { get; set; }

        [JsonPropertyName("socialnetworks")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public List<object> socialnetworks { get; set; }

        [JsonPropertyName("skype")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object skype { get; set; }

        [JsonPropertyName("twitter")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object twitter { get; set; }

        [JsonPropertyName("facebook")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object facebook { get; set; }

        [JsonPropertyName("linkedin")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object linkedin { get; set; }

        [JsonPropertyName("jabberid")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object jabberid { get; set; }

        [JsonPropertyName("photo")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string photo { get; set; }

        [JsonPropertyName("phone_pro")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string phone_pro { get; set; }

        [JsonPropertyName("phone_perso")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string phone_perso { get; set; }

        [JsonPropertyName("phone_mobile")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string phone_mobile { get; set; }

        [JsonPropertyName("fax")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string fax { get; set; }

        [JsonPropertyName("priv")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string priv { get; set; }

        [JsonPropertyName("birthday")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int? birthday { get; set; }

        [JsonPropertyName("default_lang")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object default_lang { get; set; }

        [JsonPropertyName("ref_facturation")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object ref_facturation { get; set; }

        [JsonPropertyName("ref_contrat")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object ref_contrat { get; set; }

        [JsonPropertyName("ref_commande")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object ref_commande { get; set; }

        [JsonPropertyName("ref_propal")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object ref_propal { get; set; }

        [JsonPropertyName("user_id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object user_id { get; set; }

        [JsonPropertyName("user_login")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object user_login { get; set; }

        [JsonPropertyName("roles")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public List<object> roles { get; set; }

        [JsonPropertyName("id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string id { get; set; }

        [JsonPropertyName("import_key")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object import_key { get; set; }

        [JsonPropertyName("array_options")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public List<object> array_options { get; set; }

        [JsonPropertyName("array_languages")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object array_languages { get; set; }

        [JsonPropertyName("linkedObjectsIds")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object linkedObjectsIds { get; set; }

        [JsonPropertyName("canvas")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object canvas { get; set; }

        [JsonPropertyName("fk_project")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object fk_project { get; set; }

        [JsonPropertyName("contact")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object contact { get; set; }

        [JsonPropertyName("contact_id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object contact_id { get; set; }

        [JsonPropertyName("user")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object user { get; set; }

        [JsonPropertyName("origin")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object origin { get; set; }

        [JsonPropertyName("origin_id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object origin_id { get; set; }

        [JsonPropertyName("ref")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string @ref { get; set; }

        [JsonPropertyName("ref_ext")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string ref_ext { get; set; }

        [JsonPropertyName("country")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string country { get; set; }

        [JsonPropertyName("country_id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string country_id { get; set; }

        [JsonPropertyName("country_code")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string country_code { get; set; }

        [JsonPropertyName("barcode_type")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object barcode_type { get; set; }

        [JsonPropertyName("barcode_type_code")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object barcode_type_code { get; set; }

        [JsonPropertyName("barcode_type_label")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object barcode_type_label { get; set; }

        [JsonPropertyName("barcode_type_coder")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object barcode_type_coder { get; set; }

        [JsonPropertyName("mode_reglement_id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object mode_reglement_id { get; set; }

        [JsonPropertyName("cond_reglement_id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object cond_reglement_id { get; set; }

        [JsonPropertyName("cond_reglement")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object cond_reglement { get; set; }

        [JsonPropertyName("shipping_method_id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object shipping_method_id { get; set; }

        [JsonPropertyName("modelpdf")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object modelpdf { get; set; }

        [JsonPropertyName("last_main_doc")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object last_main_doc { get; set; }

        [JsonPropertyName("fk_account")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object fk_account { get; set; }

        [JsonPropertyName("note_public")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string note_public { get; set; }

        [JsonPropertyName("note_private")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string note_private { get; set; }

        [JsonPropertyName("fk_incoterms")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object fk_incoterms { get; set; }

        [JsonPropertyName("label_incoterms")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object label_incoterms { get; set; }

        [JsonPropertyName("location_incoterms")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object location_incoterms { get; set; }

        [JsonPropertyName("name")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object name { get; set; }

        [JsonPropertyName("lastname")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string lastname { get; set; }

        [JsonPropertyName("firstname")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string firstname { get; set; }

        [JsonPropertyName("date_creation")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int date_creation { get; set; }

        [JsonPropertyName("date_validation")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object date_validation { get; set; }

        [JsonPropertyName("date_modification")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string date_modification { get; set; }

        [JsonPropertyName("entity")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string entity { get; set; }

        [JsonPropertyName("socname")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string socname { get; set; }

        [JsonPropertyName("mail")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string mail { get; set; }

        [JsonPropertyName("gender")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string gender { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public void FinalizeCreation()
        {
            // Créer contact avant de créer user?
            statut = "1";
            entity = "1";
        }
    }
}
