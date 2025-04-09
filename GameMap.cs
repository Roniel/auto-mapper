namespace AutoMapper
{
    public static class GameMap
    {
        public static GameDTO ToDto(this Game game)
        {
            return new GameDTO(
                game.Id,
                game.Name,
                game.Genre,
                game.Price,
                game.owner
            );
        }

        public static List<GameDTO> ToDto(this List<Game> game)
        {
            var games = new List<GameDTO>();
            foreach (var item in game) {
                games.Add(ToDto(item));
            }

            return games;
        }
    }
}
