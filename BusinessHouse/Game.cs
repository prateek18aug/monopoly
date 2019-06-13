using System;
using System.Collections.Generic;
using System.Linq;
using BusinessHouse.Models;
using BusinessHouse.Services;

namespace BusinessHouse
{
    public class Game
    {
        GameBoard gameBoard;
        List<Player> players;
        List<string> diceInput;
        IPlayerManager playerManager;
        int gameBoardSize;
        IGameHelper gameHelper;
        public Game(GameBoard gameBoard, List<Player> players, List<string> diceInput)
        {
            this.gameBoard = gameBoard;
            this.players = players;
            this.diceInput = diceInput;
            this.playerManager = new PlayerManager();
            gameBoardSize = gameBoard.GameSpaces.ToList().Count();
            this.gameHelper = new GameHelper();
        }

        public void Play()
        {
            int turn = 0;
            foreach (var diceInput in diceInput)
            {
                int dc = Convert.ToInt32(diceInput);
                var currentPlayer = playerManager.GetPlayer(players, turn);
                currentPlayer.Position = this.gameHelper.AdvancePlayer(currentPlayer, dc, gameBoardSize);
                var gameSpace = gameBoard.GetGameSpace(currentPlayer.Position) as IGameSpace;
                currentPlayer = gameSpace.PerformAction(currentPlayer);
                UpdatePlayerProperties(players, currentPlayer, turn);
                turn++;
            }
            DisplayGameOutput();
        }

        private void DisplayGameOutput()
        {
            foreach (var player in players)
            {
                Console.WriteLine($"Player{player.ID} balance:{player.Balance}");
                Console.WriteLine($"Player{player.ID} asset Val:{player.AssetValue}");
            }
            Console.WriteLine($"Bank balance{Banker.Balance}");
            Console.ReadLine();
        }

        private void UpdatePlayerProperties(List<Player> players, Player currentPlayer, int turn)
        {
            if (turn >= players.Count())
            {
                turn = 0;
            }
            players[turn].Position = currentPlayer.Position;
            players[turn].Balance = currentPlayer.Balance;
            players[turn].AssetValue = currentPlayer.AssetValue;
        }
    }
}
