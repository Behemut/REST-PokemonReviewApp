using System.ComponentModel.DataAnnotations;

namespace PokemonReviewApp.Models
{
    public class Pokemon
    {
        [Key]
        public int Id{ get; set; }
        [Required]
        public string Name{ get; set; }
        [Required]
        public DateTime Birthdate { get; set; }

        //ONE TO MANY RELATIONSHIP
        public ICollection<Review> Reviews { get; set; }

        //MANY TO MANY RELATIONSHIP
        public ICollection<PokemonOwner> PokemonOwners { get; set; }
        public ICollection<PokemonCategory>  PokemonCategories { get; set; }

    }
}
