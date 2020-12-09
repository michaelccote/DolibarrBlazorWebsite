using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
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
    public class Usager
    {
        [JsonPropertyName("id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public uint id { get; set; }
        
        [JsonPropertyName("statut")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public uint statut { get; set; }
        
        [JsonPropertyName("employee")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string employee { get; set; }
        
        [JsonPropertyName("gender")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string gender { get; set; }
        
        [JsonPropertyName("birth")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public int? birth { get; set; }
        
        [JsonPropertyName("email")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string email { get; set; }
        
        [JsonPropertyName("personal_email")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string personal_email { get; set; }
        
        [JsonPropertyName("socialnetworks")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public List<object> socialnetworks { get; set; }
        
        [JsonPropertyName("job")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string job { get; set; }
        
        [JsonPropertyName("signature")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string signature { get; set; }
        
        [JsonPropertyName("address")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string address { get; set; }
        
        [JsonPropertyName("zip")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string zip { get; set; }
        
        [JsonPropertyName("town")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string town { get; set; }
        
        [JsonPropertyName("state_id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string state_id { get; set; }
        
        [JsonPropertyName("state_code")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string state_code { get; set; }
        
        [JsonPropertyName("state")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string state { get; set; }
        
        [JsonPropertyName("office_phone")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string office_phone { get; set; }
        
        [JsonPropertyName("office_fax")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string office_fax { get; set; }
        
        [JsonPropertyName("user_mobile")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string user_mobile { get; set; }
        
        [JsonPropertyName("personal_mobile")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string personal_mobile { get; set; }
        
        [JsonPropertyName("admin")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public uint admin { get; set; }
        
        [JsonPropertyName("login")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string login { get; set; }
        
        [JsonPropertyName("password")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [DataType(DataType.Password)]

        /// <summary>
        /// Ajouté localement pour gestion login
        /// </summary>
        public string password { get; set; }

        [JsonPropertyName("reset")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        /// <summary>
        /// Ajouté localement pour gestion login
        /// </summary>
        public bool reset { get; set; }
        
        [JsonPropertyName("entity")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string entity { get; set; }
        
        [JsonPropertyName("datec")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public int? datec { get; set; }
        
        [JsonPropertyName("datem")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string datem { get; set; }
        
        [JsonPropertyName("societe_id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string societe_id { get; set; }
        
        [JsonPropertyName("contact_id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string contact_id { get; set; }
        
        [JsonPropertyName("socid")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string socid { get; set; }
        
        [JsonPropertyName("contactid")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string contactid { get; set; }
        
        [JsonPropertyName("fk_member")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string fk_member { get; set; }
        
        [JsonPropertyName("fk_user")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string fk_user { get; set; }
        
        [JsonPropertyName("fk_user_expense_validator")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string fk_user_expense_validator { get; set; }
        
        [JsonPropertyName("fk_user_holiday_validator")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string fk_user_holiday_validator { get; set; }
        
        [JsonPropertyName("clicktodial_url")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string clicktodial_url { get; set; }
        
        [JsonPropertyName("clicktodial_login")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string clicktodial_login { get; set; }
        
        [JsonPropertyName("clicktodial_poste")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string clicktodial_poste { get; set; }
        
        [JsonPropertyName("datelastlogin")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string datelastlogin { get; set; }
        
        [JsonPropertyName("datepreviouslogin")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string datepreviouslogin { get; set; }
        
        [JsonPropertyName("photo")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string photo { get; set; }
       
        [JsonPropertyName("lang")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string lang { get; set; }

        [JsonPropertyName("rights")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Rights rights { get; set; }

        [JsonPropertyName("conf")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public Conf conf { get; set; }
        
        [JsonPropertyName("users")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public List<object> users { get; set; }
        
        [JsonPropertyName("parentof")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string parentof { get; set; }
        
        [JsonPropertyName("reaccountancy_codeset")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string accountancy_code { get; set; }
        
        [JsonPropertyName("weeklyhours")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string weeklyhours { get; set; }
        
        [JsonPropertyName("dateemployment")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string dateemployment { get; set; }
       
        [JsonPropertyName("dateemploymentend")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string dateemploymentend { get; set; }
        
        [JsonPropertyName("default_c_exp_tax_cat")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string default_c_exp_tax_cat { get; set; }
        
        [JsonPropertyName("default_range")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string default_range { get; set; }
        
        [JsonPropertyName("fk_warehouse")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string fk_warehouse { get; set; }
        
        [JsonPropertyName("import_key")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string import_key { get; set; }
        
        [JsonPropertyName("array_options")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public List<object> array_options { get; set; }
        
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
        
        [JsonPropertyName("thirdparty")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string thirdparty { get; set; }
        
        [JsonPropertyName("user")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string user { get; set; }
        
        [JsonPropertyName("origin")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string origin { get; set; }
        
        [JsonPropertyName("origin_id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string origin_id { get; set; }
        
        [JsonPropertyName("ref_ext")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string ref_ext { get; set; }
        
        [JsonPropertyName("country")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
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
        
        [JsonPropertyName("last_main_doc")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string last_main_doc { get; set; }
        
        [JsonPropertyName("fk_account")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string fk_account { get; set; }
        
        [JsonPropertyName("note_public")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string note_public { get; set; }
        
        [JsonPropertyName("note_private")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string note_private { get; set; }
        
        [JsonPropertyName("note")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string note { get; set; }
        
        [JsonPropertyName("name")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string name { get; set; }
        
        [JsonPropertyName("lastname")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string lastname { get; set; }
        
        [JsonPropertyName("firstname")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string firstname { get; set; }
        
        [JsonPropertyName("civility_id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string civility_id { get; set; }
        
        [JsonPropertyName("date_creation")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string date_creation { get; set; }
        
        [JsonPropertyName("date_validation")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string date_validation { get; set; }
        
        [JsonPropertyName("date_modification")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string date_modification { get; set; }
        
        [JsonPropertyName("liste_limit")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public int liste_limit { get; set; }

        public class Conf
        {
        }

        public class Rights
        {
            public User user { get; set; }

            public class User
            {
                public User2 user { get; set; }
                public Self self { get; set; }
                public class User2
                {
                }

                public class Self
                {
                    public int creer { get; set; }
                }
            }
        }


        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        //[Compare(nameof(password), ErrorMessage = "Les mots de passes sont différents")]
        public string confirmPassword { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public void FinalizeCreation()
        {
            // Créer contact avant de créer user?
            statut = 1;
            employee = societe_id == "" ? "1" : "0";
            entity = "1";
        }

        /// <summary>
        /// Important afin que l'usager puisse se connecter, il doit avoir accès à modifier sa clé API
        /// Finalement j'ai activer ce droit par défaut à la création d'un usager
        /// </summary>
        public void SetSelfRights()
        {
            
            rights = new Rights();
            rights.user = new Rights.User();
            rights.user.user = new Rights.User.User2();
            rights.user.self = new Rights.User.Self();
            rights.user.self.creer = 1;
        }
    }
}
