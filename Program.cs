using AutoMapper;

class Program
{
    static void Main(string[] args)
    {
        var games = new List<Game>()
        {
            new Game(){
                        Description = "Description game",
                        Name = "Call of dot",
                        Id = Guid.NewGuid(),
                        Price = 200,
                        Genre = "War",
                        owner = new Owner()
                        {
                            Name = "Studio 7",
                            Idade = 140,
                            Salario = 2500
                        }
            },
            new Game(){
                        Description = "Description2 game",
                        Name = "ManiCreft",
                        Id = Guid.NewGuid(),
                        Price = 250,
                        Genre = "Strategy",
                        owner = new Owner()
                        {
                            Name = "Microsoft",
                            Idade = 140,
                            Salario = 2500
                        }
            }

        };

        var game1 = new Game()
        {
            Description = "Description2 game",
            Name = "ManiCreft",
            Id = Guid.NewGuid(),
            Price = 250,
            Genre = "Strategy",
            owner = new Owner()
            {
                Name = "Microsoft",
                Idade = 140,
                Salario = 2500
            }
        };

        var game1Dto = game1.ToDto();

        var gamesDto = games.ToDto();

        foreach (var g in gamesDto)
        {
            Console.WriteLine($"Name: {g.Name}, Owner: {g.NameOwner}, Genre: {g.Genre}");
        }

        Console.ReadLine();
    }

}