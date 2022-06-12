namespace PokemonReviewApp.Models
{
    public class PokemonOwner
    {

        public int PokemonId { get; set; }
        public int OwnerId { get; set; }


        //MANY TO MANY RELATIONSHIPS
        public Pokemon Pokemon { get; set; }
        public Owner Owner { get; set; }
    }
}
