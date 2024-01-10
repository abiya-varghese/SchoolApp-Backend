using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace HandsOnAPIUsingModelValidation.Model
{
    public class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Enter Name ")]

        public string Name { get; set; }
        [Range(18,50,ErrorMessage ="age should between 18 to 50")]
        public int age {  get; set; }

        [Required(ErrorMessage ="Enter email")]
        [EmailAddress(ErrorMessage ="Invalid email id")]
        public string Email { get; set; }
        [RegularExpression(@"[6-9]\d{9}",ErrorMessage ="Number should have 10 digit")]
        public string Mobile { get; set; }
        [Required(ErrorMessage ="Enter username")]
        public string UserName {  get; set; }
        [Required(ErrorMessage ="enter password")]
        [RegularExpression("[a-zA-Z0-9]{6,8}", ErrorMessage="should have range between 6 to 8")]

        public string Password { get; set; }

    }
}
