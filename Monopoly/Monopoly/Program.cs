using Monopoly.Infrastructure.Extensions;
using Monopoly.Services;
using System.Collections.Generic;

namespace Monopoly
{
    class Program
    {
        static void Main(string[] args)
        {
            var gameBoardInput = new List<string>() { "H", "E", "E", "J", "L", "H" };
            var diceInputs = new List<int>() { 1, 3, 2, 1, 3 };
            var numberOfPlayers = 2;

            var gameBoardInitializer = new GameBoardInitializer();
            var gameBoard = gameBoardInitializer.Initialize(numberOfPlayers, gameBoardInput);

            foreach (var diceInput in diceInputs)
            {

                var currentPlayer = gameBoard.GetNextPlayer();
                gameBoard.CurrentPlayerId++;
                //Get Cell Position
                //Call Perform of Cell position
            }
        }
    }
}
