
namespace AutoMapper
{
    public class GameDTO
    {

        public GameDTO(Guid id, string name, string genre, int price, Owner nameOwner)
        {
            Id = id;
            Name = name;
            Genre = genre;
            Price = price;
            NameOwner = nameOwner.Name;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public int Price { get; set; }
        public string NameOwner { get; set; }
    }

}
