using System.ComponentModel.DataAnnotations;

namespace PokemonReviewApp.Models
{
    public class Owner
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Gym { get; set; }

        public Country Country { get; set; }

        public ICollection<PokemonOwner> PokemonOwners { get; set; }


    }
}
