
namespace AutoMapper
{
    public class Game
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public Owner owner { get; set; }

    }
}
