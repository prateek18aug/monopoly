using BusinessHouse.Services;
using System;
using System.Linq;

namespace BusinessHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cells details");
            var cells = Console.ReadLine();
            var cellsArray = cells.Split(',').ToList();

            IGameBoardInitializer gameBoardInitializer = new GameBoardInitializer();
            var gameBoard = gameBoardInitializer.InitializeGameBoard(cellsArray);

            Console.WriteLine("Enter Dice Input");
            var diceInput = Console.ReadLine().Split(',').ToList();

            Console.WriteLine("Enter number of Players");
            string numberOfPlayersString = Console.ReadLine();
            int numberOfPlayers;
            int.TryParse(numberOfPlayersString, out numberOfPlayers);

            IPlayerManager playerManager = new PlayerManager();
            var players = playerManager.CreatePlayers(numberOfPlayers);

            Game game = new Game(gameBoard, players, diceInput);
            game.Play();
        }
    }
}
