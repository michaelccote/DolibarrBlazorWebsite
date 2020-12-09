using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace VincentsShop.WASM.Shared.Models
{
    public class Company
    {
        [JsonPropertyName("entity")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string entity { get; set; }

        [JsonPropertyName("nom")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string nom { get; set; }

        [JsonPropertyName("name")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string name { get; set; }

        [JsonPropertyName("name_alias")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string name_alias { get; set; }

        [JsonPropertyName("particulier")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string particulier { get; set; }

        [JsonPropertyName("address")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string address { get; set; }

        [JsonPropertyName("zip")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string zip { get; set; }

        [JsonPropertyName("town")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string town { get; set; }

        [JsonPropertyName("status")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string status { get; set; }

        [JsonPropertyName("state_id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string state_id { get; set; }

        [JsonPropertyName("state_code")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string state_code { get; set; }

        [JsonPropertyName("state")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string state { get; set; }

        [JsonPropertyName("departement_code")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string departement_code { get; set; }

        [JsonPropertyName("departement")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string departement { get; set; }

        [JsonPropertyName("pays")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string pays { get; set; }
        
        [JsonPropertyName("phone")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string phone { get; set; }
        
        [JsonPropertyName("fax")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string fax { get; set; }
        
        [JsonPropertyName("email")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string email { get; set; }
        
        [JsonPropertyName("socialnetworks")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string[] socialnetworks { get; set; }
        
        [JsonPropertyName("skype")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string skype { get; set; }
        
        [JsonPropertyName("twitter")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string twitter { get; set; }

        [JsonPropertyName("facebook")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string facebook { get; set; }

        [JsonPropertyName("linkedin")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string linkedin { get; set; }

        [JsonPropertyName("url")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string url { get; set; }

        [JsonPropertyName("barcode")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string barcode { get; set; }

        [JsonPropertyName("twiidprof1tter")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string idprof1 { get; set; }

        [JsonPropertyName("idprof2")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string idprof2 { get; set; }

        [JsonPropertyName("idprof3")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string idprof3 { get; set; }

        [JsonPropertyName("idprof4")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string idprof4 { get; set; }

        [JsonPropertyName("idprof5")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string idprof5 { get; set; }

        [JsonPropertyName("idprof6")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string idprof6 { get; set; }

        [JsonPropertyName("prefix_comm")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string prefix_comm { get; set; }

        [JsonPropertyName("tva_assuj")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string tva_assuj { get; set; }

        [JsonPropertyName("tva_intra")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string tva_intra { get; set; }

        [JsonPropertyName("localtax1_assuj")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string localtax1_assuj { get; set; }

        [JsonPropertyName("localtax1_value")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string localtax1_value { get; set; }

        [JsonPropertyName("localtax2_assuj")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string localtax2_assuj { get; set; }

        [JsonPropertyName("localtax2_value")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string localtax2_value { get; set; }

        [JsonPropertyName("managers")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string managers { get; set; }

        [JsonPropertyName("capital")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string capital { get; set; }

        [JsonPropertyName("typent_id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string typent_id { get; set; }

        [JsonPropertyName("typent_code")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string typent_code { get; set; }

        [JsonPropertyName("effectif")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string effectif { get; set; }

        [JsonPropertyName("effectif_id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string effectif_id { get; set; }

        [JsonPropertyName("forme_juridique_code")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string forme_juridique_code { get; set; }

        [JsonPropertyName("forme_juridique")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string forme_juridique { get; set; }

        [JsonPropertyName("remise_percent")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string remise_percent { get; set; }

        [JsonPropertyName("remise_supplier_percent")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string remise_supplier_percent { get; set; }

        [JsonPropertyName("mode_reglement_supplier_id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string mode_reglement_supplier_id { get; set; }

        [JsonPropertyName("cond_reglement_supplier_id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string cond_reglement_supplier_id { get; set; }

        [JsonPropertyName("fk_prospectlevel")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string fk_prospectlevel { get; set; }

        [JsonPropertyName("name_bis")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string name_bis { get; set; }

        [JsonPropertyName("date_modification")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string date_modification { get; set; }

        [JsonPropertyName("user_modification")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string user_modification { get; set; }

        [JsonPropertyName("date_creation")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string date_creation { get; set; }

        [JsonPropertyName("user_creation")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string user_creation { get; set; }

        [JsonPropertyName("specimen")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string specimen { get; set; }

        [JsonPropertyName("client")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string client { get; set; }

        [JsonPropertyName("prospect")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string prospect { get; set; }

        [JsonPropertyName("fournisseur")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string fournisseur { get; set; }

        [JsonPropertyName("code_client")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string code_client { get; set; }

        [JsonPropertyName("code_fournisseur")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string code_fournisseur { get; set; }

        [JsonPropertyName("code_compta")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string code_compta { get; set; }

        [JsonPropertyName("code_compta_client")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string code_compta_client { get; set; }

        [JsonPropertyName("code_compta_fournisseur")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string code_compta_fournisseur { get; set; }

        [JsonPropertyName("note")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string note { get; set; }

        [JsonPropertyName("note_private")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string note_private { get; set; }

        [JsonPropertyName("note_public")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string note_public { get; set; }

        [JsonPropertyName("stcomm_id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string stcomm_id { get; set; }

        [JsonPropertyName("remise_supplier_percent")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string status_prospect_label { get; set; }

        [JsonPropertyName("price_level")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string price_level { get; set; }

        [JsonPropertyName("outstanding_limit")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string outstanding_limit { get; set; }

        [JsonPropertyName("order_min_amount")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string order_min_amount { get; set; }

        [JsonPropertyName("supplier_order_min_amount")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string supplier_order_min_amount { get; set; }

        [JsonPropertyName("commercial_id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string commercial_id { get; set; }

        [JsonPropertyName("parent")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string parent { get; set; }

        [JsonPropertyName("default_lang")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string default_lang { get; set; }

        [JsonPropertyName("ref")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string reference { get; set; }

        [JsonPropertyName("ref_ext")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string ref_ext { get; set; }

        [JsonPropertyName("import_key")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string import_key { get; set; }

        [JsonPropertyName("webservices_url")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string webservices_url { get; set; }

        [JsonPropertyName("webservices_key")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string webservices_key { get; set; }

        [JsonPropertyName("logo")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string logo { get; set; }

        [JsonPropertyName("logo_small")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string logo_small { get; set; }

        [JsonPropertyName("logo_mini")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string logo_mini { get; set; }

        [JsonPropertyName("logo_squarred")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string logo_squarred { get; set; }

        [JsonPropertyName("logo_squarred_small")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string logo_squarred_small { get; set; }

        [JsonPropertyName("logo_squarred_mini")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string logo_squarred_mini { get; set; }

        [JsonPropertyName("fk_incoterms")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string fk_incoterms { get; set; }

        [JsonPropertyName("location_incoterms")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string location_incoterms { get; set; }

        [JsonPropertyName("label_incoterms")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string label_incoterms { get; set; }

        [JsonPropertyName("fk_multicurrency")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string fk_multicurrency { get; set; }

        [JsonPropertyName("multicurrency_code")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string multicurrency_code { get; set; }

        [JsonPropertyName("bank_account")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string bank_account { get; set; }

        [JsonPropertyName("id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string id { get; set; }

        [JsonPropertyName("array_options")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string[] array_options { get; set; }

        [JsonPropertyName("array_languages")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string array_languages { get; set; }

        [JsonPropertyName("linkedObjectsIds")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string linkedObjectsIds { get; set; }

        [JsonPropertyName("canvas")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string canvas { get; set; }

        [JsonPropertyName("fk_project")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string fk_project { get; set; }

        [JsonPropertyName("contact")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string contact { get; set; }

        [JsonPropertyName("contact_id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string contact_id { get; set; }

        [JsonPropertyName("thirdparty")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string thirdparty { get; set; }

        [JsonPropertyName("user")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string user { get; set; }

        [JsonPropertyName("origin")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string origin { get; set; }

        [JsonPropertyName("origin_id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string origin_id { get; set; }

        [JsonPropertyName("statut")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string statut { get; set; }

        [JsonPropertyName("country")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string country { get; set; }

        [JsonPropertyName("country_id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string country_id { get; set; }

        [JsonPropertyName("country_code")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string country_code { get; set; }

        [JsonPropertyName("barcode_type")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string barcode_type { get; set; }

        [JsonPropertyName("barcode_type_code")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string barcode_type_code { get; set; }

        [JsonPropertyName("barcode_type_label")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string barcode_type_label { get; set; }

        [JsonPropertyName("barcode_type_coder")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string barcode_type_coder { get; set; }

        [JsonPropertyName("mode_reglement_id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string mode_reglement_id { get; set; }

        [JsonPropertyName("cond_reglement_id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string cond_reglement_id { get; set; }

        [JsonPropertyName("cond_reglement")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string cond_reglement { get; set; }

        [JsonPropertyName("shipping_method_id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string shipping_method_id { get; set; }

        [JsonPropertyName("modelpdf")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string modelpdf { get; set; }

        [JsonPropertyName("last_main_doc")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string last_main_doc { get; set; }

        [JsonPropertyName("fk_account")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string fk_account { get; set; }

        [JsonPropertyName("total_ht")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string total_ht { get; set; }

        [JsonPropertyName("total_tva")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string total_tva { get; set; }

        [JsonPropertyName("total_localtax1")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string total_localtax1 { get; set; }

        [JsonPropertyName("total_localtax2")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string total_localtax2 { get; set; }

        [JsonPropertyName("total_ttc")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string total_ttc { get; set; }

        [JsonPropertyName("lines")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string lines { get; set; }

        [JsonPropertyName("lastname")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string lastname { get; set; }

        [JsonPropertyName("firstname")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string firstname { get; set; }

        [JsonPropertyName("civility_id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string civility_id { get; set; }

        [JsonPropertyName("date_validation")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string date_validation { get; set; }

        [JsonPropertyName("object")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string objet { get; set; }

        [JsonPropertyName("facebook_url")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string facebook_url { get; set; }

        [JsonPropertyName("twitter_url")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string twitter_url { get; set; }

        [JsonPropertyName("linkedin_url")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string linkedin_url { get; set; }

        [JsonPropertyName("instagram_url")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string instagram_url { get; set; }

        [JsonPropertyName("youtube_url")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string youtube_url { get; set; }

        [JsonPropertyName("github_url")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string github_url { get; set; }

    }
}
