using System.ComponentModel.DataAnnotations;


namespace VincentsShop.WASM.Shared.Models
{
    public class LoginModel
    {
        [Required]
        public string User { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        //[Required]
        //[DataType(DataType.Password)]
        //[Compare ()]
        //public string ConfirmPassword { get; set; }

        public string ApiKey { get; set; }

    }
}
