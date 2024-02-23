using System.ComponentModel.DataAnnotations;
namespace Mission06_Imerlishvili.Models
{
    public class Application
    {
        [Key]
        [Required]
        public int ApplicationId { get; set; }

        [Required(ErrorMessage = "Category is required.")]
        public string Category { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Year is required.")]
        
        public int Year { get; set; }

        [Required(ErrorMessage = "Director is required.")]
        public string Director { get; set; }

        [Required(ErrorMessage = "Rating is required.")]
        public string Rating { get; set; }

        public bool Edited { get; set; }

        // "Lent" is not explicitly marked as required, making it optional
        public string Lent { get; set; }
        [Required(ErrorMessage = "Rating is required.")]
        public bool Plex { get; set; }

        [MaxLength(25, ErrorMessage = "Notes should be limited to 25 characters.")]
 
        public string Note { get; set; }

    }
}
