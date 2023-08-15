using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using BattleShipLiteLibrary;
using BattleShipLiteLibrary.Models;

namespace BattleShipLite
{
	 class Program
	{
		static void Main(string[] args)
		{
			NewGame();

            Console.WriteLine(Environment.NewLine + "Would you like to play the game again? (Y/N)");
			string userResponse = Console.ReadLine();
			

			if (userResponse.ToLower().StartsWith("y"))
			{
				Console.Clear();
				NewGame();
			}

            Console.WriteLine("Thank you for playing!");

        }

		private static void NewGame()
		{
			WelcomeMessage();
			PlayerInfoModel activePlayer = CreatePlayer("Player 1");

			WelcomeMessage();
			PlayerInfoModel opponent = CreatePlayer("Player 2");

			PlayerInfoModel winner = null;

			do
			{
				Console.WriteLine($"{opponent.UserName.ToString()}'s Map: ");
				DisplayShotGrid(activePlayer);

				RecordPlayerShot(activePlayer, opponent);


				bool doesGameContinue = GameLogic.PlayerStillActive(opponent);

				if (doesGameContinue == true)
				{
					//swap positions using tuple
					(activePlayer, opponent) = (opponent, activePlayer);
				}
				else
				{
					winner = activePlayer;
				}

			} while (winner == null);
			IdentifyWinner(winner);
		}

		private static void IdentifyWinner(PlayerInfoModel winner)
		{
            Console.WriteLine($"Congratulations to {winner.UserName} for winning!");
			Console.WriteLine($"{ winner.UserName} took {GameLogic.GetShotCount(winner)} shots to destroy his opponent.");
        }

		private static void RecordPlayerShot(PlayerInfoModel activePlayer, PlayerInfoModel opponent)
		{
			string row = "";
			int column = 0;
			bool isValidShot = false;
            Console.WriteLine(Environment.NewLine + $"Player: {activePlayer.UserName}");
            do
			{
				string shotSpot = AskForShot();

				

				try
				{
					(row, column) = GameLogic.SplitShotIntoRowAndColumn(shotSpot);
					isValidShot = GameLogic.ValidateShot(activePlayer, row, column);
				}
				catch (Exception )
				{              
					isValidShot = false;
                }
				if (isValidShot == false)
				{
					Console.WriteLine($"{shotSpot} was mot a valid entry. Try again!");
				}

			} while (isValidShot == false);

			bool isAHit = GameLogic.IdentifyShotResult(opponent, row, column);
			string shotResult = "";

			if(isAHit) { shotResult = "Hit"; } else { shotResult = "Miss"; }


			GameLogic.MarkShotResult(activePlayer, row, column, isAHit);
			Console.WriteLine("Result: " + shotResult + Environment.NewLine);
			DisplayShotGrid(activePlayer);
			Console.WriteLine("______________________________________________" + Environment.NewLine);

		}

		private static string AskForShot()
		{
            Console.Write("Please enter where you would like to shoot: ");
			string shotSpot = Console.ReadLine();
			return shotSpot;
        }

		private static void DisplayShotGrid(PlayerInfoModel activePlayer)
		{
			string currentRow = activePlayer.ShotGrid[0].SpotLetter.ToString();
			

			foreach (var gridSpot in activePlayer.ShotGrid)
			{
				
				if (gridSpot.SpotLetter != currentRow)
				{
					Console.WriteLine("");					
				}

				if (gridSpot.Status == GridSpotStatus.Empty)
				{
					Console.Write($" {gridSpot.SpotLetter}{gridSpot.SpotNumber} ");
					currentRow = gridSpot.SpotLetter;
				}
				else if (gridSpot.Status == GridSpotStatus.Hit)
				{
					Console.Write("  X ");
				}

				else if (gridSpot.Status == GridSpotStatus.Miss)
				{
					Console.Write("  O ");
				}
				else
				{
					Console.Write(" ? ");
				}

			}
            Console.WriteLine();
        }

		private static void WelcomeMessage() 
		{
            Console.WriteLine("Welcome to the Battleship Lite");
            Console.WriteLine("created by Shahbaj" + Environment.NewLine);
        }
		private static PlayerInfoModel CreatePlayer( string playerTitle)
		{
			PlayerInfoModel player = new PlayerInfoModel();

			//Ask the user for their name
			player.UserName = AskForUsersName(playerTitle);
			

			//Load up the shot grid
			GameLogic.InitializeGrid(player);

			//Ask the user for their 5 ship placements
			PlaceShips(player);

			//Clear Console
			Console.Clear();

			return player;
		}

		private static void PlaceShips(PlayerInfoModel model)
		{
			do
			{
				Console.WriteLine($"Place your ship number {model.ShipLocation.Count + 1}");
				string shipLocation = Console.ReadLine();

				bool isValidLocation = false;
				bool isSpotOpen = false;

				try
				{
					(isValidLocation, isSpotOpen) = GameLogic.PlaceShip(model, shipLocation);
				}
				catch (Exception ex)
				{
					isValidLocation = false;
					isSpotOpen = false;
				}

				if (isValidLocation == false && isSpotOpen == false)
				{
					Console.WriteLine($"{shipLocation} is not a valid location. Try again!");
				}
				else if (isSpotOpen == false)
				{
					Console.WriteLine($"You have already placed another ship at {shipLocation}");
				}
			} while (model.ShipLocation.Count() < 5);
		}

		private static string AskForUsersName(string playerTitle)
		{
			Console.WriteLine("Enter information for " + playerTitle);

			Console.Write("Name of Player : ");
			string playerName = Console.ReadLine();

			return playerName;
		}
	}

}
