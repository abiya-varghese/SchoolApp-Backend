using System.ComponentModel.DataAnnotations;
namespace HandsOnAPIUsingModelValidation.Model
{
    public class Login
    {
        [Required(ErrorMessage ="pls enter password")]
        public string? UserName {  get; set; }
        [Required(ErrorMessage ="Pls enter password")]
        public string? Password { get; set; }
    }
}
