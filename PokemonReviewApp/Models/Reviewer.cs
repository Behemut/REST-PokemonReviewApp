using System.ComponentModel.DataAnnotations;
namespace PokemonReviewApp.Models
{
    public class Reviewer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public  string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        public ICollection<Review> Reviews { get; set; }
    }
}
