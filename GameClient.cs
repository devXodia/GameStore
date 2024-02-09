using GameStore.Client.Models;

namespace GameStore.Client;

public static class GameClient
{
    private static readonly List<Game> games = new(){
        new Game(){
            Id = 1,
            Name = "Tekken 8",
            Genre = "Fighting",
            Price = 89.99M,
            ReleaseDate = new DateTime(2024, 1, 26)
        },

        new Game(){
            Id = 2,
            Name = "Mario Kart 8",
            Genre = "Racing",
            Price = 49.99M,
            ReleaseDate = new DateTime(2014, 5, 19)
        },

        new Game(){
            Id = 3,
            Name = "Hogwarts Legacy",
            Genre = "Roleplaying",
            Price = 69.99M,
            ReleaseDate = new DateTime(2023, 2, 10)
        },

        new Game(){
            Id = 4,
            Name = "Final Fatnasy XIV",
            Genre = "Roleplaying",
            Price = 59.99M,
            ReleaseDate = new DateTime(2010, 9, 30)
        }};

    public static Game[] GetGames()
    {
        return games.ToArray();
    }

    public static void AddGame(Game game)
    {
        game.Id = games.Max(game => game.Id + 1);
        games.Add(game);
    }

    public static Game GetGame(int id)
    {
        return games.Find(game => game.Id == id) ?? throw new Exception("Could not find game!");
    }

    public static void UpdateGame(Game updatedGame)
    {
        Game existingGame = GetGame(updatedGame.Id);
        existingGame.Name = updatedGame.Name;
        existingGame.Genre = updatedGame.Genre;
        existingGame.Price = updatedGame.Price;
        existingGame.ReleaseDate = updatedGame.ReleaseDate;
    }

    public static void DeleteGame(int id)
    {
        Game game = GetGame(id);
        games.Remove(game);
    }

}