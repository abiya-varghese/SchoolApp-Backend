using System.ComponentModel.DataAnnotations;

namespace Assignment9.Models
{
    public class Movie
    {
        [Required(ErrorMessage = "Enter Movie ID")]
        public int MovieId { get; set; }
        [Required(ErrorMessage ="Enter Movie Name")]
        public string MovieName { get; set;}
        [Required(ErrorMessage ="Enter Language ")]
        public string Lang {  get; set;}
        [Required(ErrorMessage = "Enter Release year ")]
        [RegularExpression("[0-9]{4}",ErrorMessage ="Must Contain 4 digit")]
        [Range(1988,2023,ErrorMessage ="Year should in between 1988 to 2023")]
        public string ReleaseYear {  get; set;}
        [Required(ErrorMessage = "Enter Actor")]

        public string Actor {  get; set;}
        [Required(ErrorMessage = "Enter Director ")]

        public string Director { get; set;} 
    }
}
