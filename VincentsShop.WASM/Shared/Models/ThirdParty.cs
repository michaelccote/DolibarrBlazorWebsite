using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace VincentsShop.WASM.Shared.Models
{
    public class ThirdParty
    {

        [JsonPropertyName("entity")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string entity { get; set; }

        [JsonPropertyName("name")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string name { get; set; }

        [JsonPropertyName("name_alias")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string name_alias { get; set; }

        [JsonPropertyName("address")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string address { get; set; }

        [JsonPropertyName("zip")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string zip { get; set; }

        [JsonPropertyName("town")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string town { get; set; }

        [JsonPropertyName("status")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string status { get; set; }

        [JsonPropertyName("state_id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string state_id { get; set; }

        [JsonPropertyName("state_code")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string state_code { get; set; }

        [JsonPropertyName("state")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string state { get; set; }

        [JsonPropertyName("phone")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string phone { get; set; }

        [JsonPropertyName("fax")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object fax { get; set; }

        [JsonPropertyName("email")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string email { get; set; }

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

        [JsonPropertyName("url")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string url { get; set; }

        [JsonPropertyName("barcode")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object barcode { get; set; }

        [JsonPropertyName("idprof1")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string idprof1 { get; set; }

        [JsonPropertyName("idprof2")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string idprof2 { get; set; }

        [JsonPropertyName("idprof3")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string idprof3 { get; set; }

        [JsonPropertyName("idprof4")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string idprof4 { get; set; }

        [JsonPropertyName("idprof5")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string idprof5 { get; set; }

        [JsonPropertyName("idprof6")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string idprof6 { get; set; }

        [JsonPropertyName("tva_assuj")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string tva_assuj { get; set; }

        [JsonPropertyName("tva_intra")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string tva_intra { get; set; }

        [JsonPropertyName("localtax1_assuj")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string localtax1_assuj { get; set; }

        [JsonPropertyName("localtax1_value")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string localtax1_value { get; set; }

        [JsonPropertyName("localtax2_assuj")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object localtax2_assuj { get; set; }

        [JsonPropertyName("localtax2_value")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string localtax2_value { get; set; }

        [JsonPropertyName("managers")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object managers { get; set; }

        [JsonPropertyName("capital")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object capital { get; set; }

        [JsonPropertyName("typent_id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string typent_id { get; set; }

        [JsonPropertyName("typent_code")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string typent_code { get; set; }

        [JsonPropertyName("effectif")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string effectif { get; set; }

        [JsonPropertyName("effectif_id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object effectif_id { get; set; }

        [JsonPropertyName("forme_juridique_code")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object forme_juridique_code { get; set; }

        [JsonPropertyName("forme_juridique")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string forme_juridique { get; set; }

        [JsonPropertyName("remise_percent")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string remise_percent { get; set; }

        [JsonPropertyName("remise_supplier_percent")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string remise_supplier_percent { get; set; }

        [JsonPropertyName("mode_reglement_supplier_id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object mode_reglement_supplier_id { get; set; }

        [JsonPropertyName("cond_reglement_supplier_id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object cond_reglement_supplier_id { get; set; }

        [JsonPropertyName("fk_prospectlevel")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string fk_prospectlevel { get; set; }

        [JsonPropertyName("date_modification")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string date_modification { get; set; }

        [JsonPropertyName("user_modification")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string user_modification { get; set; }

        [JsonPropertyName("date_creation")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int date_creation { get; set; }

        [JsonPropertyName("user_creation")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string user_creation { get; set; }

        [JsonPropertyName("specimen")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object specimen { get; set; }

        [JsonPropertyName("client")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string client { get; set; }

        [JsonPropertyName("prospect")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int prospect { get; set; }

        [JsonPropertyName("fournisseur")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string fournisseur { get; set; }

        [JsonPropertyName("code_client")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string code_client { get; set; }

        [JsonPropertyName("code_fournisseur")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object code_fournisseur { get; set; }

        [JsonPropertyName("code_compta")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object code_compta { get; set; }

        [JsonPropertyName("code_compta_client")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object code_compta_client { get; set; }

        [JsonPropertyName("code_compta_fournisseur")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object code_compta_fournisseur { get; set; }

        [JsonPropertyName("note_private")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object note_private { get; set; }

        [JsonPropertyName("note_public")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object note_public { get; set; }

        [JsonPropertyName("stcomm_id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string stcomm_id { get; set; }

        [JsonPropertyName("status_prospect_label")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string status_prospect_label { get; set; }

        [JsonPropertyName("price_level")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object price_level { get; set; }

        [JsonPropertyName("outstanding_limit")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object outstanding_limit { get; set; }

        [JsonPropertyName("order_min_amount")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object order_min_amount { get; set; }

        [JsonPropertyName("supplier_order_min_amount")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object supplier_order_min_amount { get; set; }

        [JsonPropertyName("parent")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object parent { get; set; }

        [JsonPropertyName("default_lang")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string default_lang { get; set; }

        [JsonPropertyName("ref")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string @ref { get; set; }

        [JsonPropertyName("ref_ext")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object ref_ext { get; set; }

        [JsonPropertyName("import_key")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string import_key { get; set; }

        [JsonPropertyName("webservices_url")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object webservices_url { get; set; }

        [JsonPropertyName("webservices_key")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object webservices_key { get; set; }

        [JsonPropertyName("logo")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object logo { get; set; }

        [JsonPropertyName("logo_small")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object logo_small { get; set; }

        [JsonPropertyName("logo_mini")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object logo_mini { get; set; }

        [JsonPropertyName("logo_squarred")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object logo_squarred { get; set; }

        [JsonPropertyName("logo_squarred_small")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object logo_squarred_small { get; set; }

        [JsonPropertyName("logo_squarred_mini")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object logo_squarred_mini { get; set; }

        [JsonPropertyName("fk_incoterms")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string fk_incoterms { get; set; }

        [JsonPropertyName("location_incoterms")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object location_incoterms { get; set; }

        [JsonPropertyName("label_incoterms")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object label_incoterms { get; set; }

        [JsonPropertyName("fk_multicurrency")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string fk_multicurrency { get; set; }

        [JsonPropertyName("multicurrency_code")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string multicurrency_code { get; set; }

        [JsonPropertyName("bank_account")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object bank_account { get; set; }

        [JsonPropertyName("id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string id { get; set; }

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

        [JsonPropertyName("statut")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object statut { get; set; }

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
        public string fk_account { get; set; }

        [JsonPropertyName("lastname")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object lastname { get; set; }

        [JsonPropertyName("firstname")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object firstname { get; set; }

        [JsonPropertyName("civility_id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object civility_id { get; set; }

        [JsonPropertyName("date_validation")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public object date_validation { get; set; }

        /// <summary>
        /// La commande est brouillon si on ne met pas le statut à 3 (traité)
        /// </summary>
        public void FinalizeCreation()
        {
            name_alias = name;
        }
    }
}
