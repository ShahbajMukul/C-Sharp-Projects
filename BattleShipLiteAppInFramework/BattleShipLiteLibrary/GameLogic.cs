using BattleShipLiteLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShipLiteLibrary
{
	public static class GameLogic
	{
		public static int GetShotCount(PlayerInfoModel player)
		{
			int shotCount = 0;

			foreach (var spot in player.ShotGrid)
			{
				if (spot.Status != GridSpotStatus.Empty) //or ship?
				{
					shotCount++;
				}
			}
			return shotCount;
		}

		public static void InitializeGrid(PlayerInfoModel player)
		{
			List<string> letters = new List<string>
			{
				"A",
				"B",
				"C",
				"D",
				"E"
			};

			List<int> numbers = new List<int> 
			{ 
				1,
				2,
				3,
				4,
				5 
			};

			foreach (var letter in letters) 
			{
				foreach (var number in numbers)
				{
					AddGridSpot(player, letter, number);
				}
			}
		}
	

		public static bool ValidateShot(PlayerInfoModel player, string row, int column)
		{
			bool isValidShot = false;

			foreach (var spot in player.ShotGrid)
			{
				if (spot.SpotLetter == row.ToUpper() && spot.SpotNumber == column)
				{
					if (spot.Status == GridSpotStatus.Empty) //what if status is that there is a ship?
					{
						isValidShot = true;
					}
				}
			}
			return isValidShot;
		}

		public static (bool isSpotValid, bool isSpotOpen) PlaceShip(PlayerInfoModel player, string shipLocation)
		{
			
			(string row, int column) = SplitShotIntoRowAndColumn(shipLocation);

			bool isSpotValid = ValidateGridLocation(player, row, column);
			bool isSpotOpen = false;

			if (isSpotValid == true)
			{
				isSpotOpen = ValidateShipLocation(player, row, column);
			}

			if (isSpotValid && isSpotOpen)
			{
				player.ShipLocation.Add(new GridSpotModel
				{
					SpotLetter = row.ToUpper(),
					SpotNumber = column,
					Status = GridSpotStatus.Ship
				});
				
			}

			return (isSpotValid, isSpotOpen);

		}

		private static bool ValidateShipLocation(PlayerInfoModel player, string row, int column)
		{
			bool isValidLocation = true;

			foreach (var ship in player.ShipLocation)
			{
				if (ship.SpotLetter == row.ToUpper() && ship.SpotNumber == column)
				{
					isValidLocation = false;
				}
			}
			return isValidLocation;
		}

		private static bool ValidateGridLocation(PlayerInfoModel player, string row, int column)
		{
			bool isValidGridLocation = false;
			

			foreach (var spot in player.ShotGrid)
			{
				if (spot.SpotLetter == row.ToUpper() && spot.SpotNumber == column)
				{
					isValidGridLocation = true;
				}
			}
			return isValidGridLocation;
		}

		public static bool PlayerStillActive(PlayerInfoModel player)
		{
			bool isActive = false;

			foreach (var ship in player.ShipLocation)
			{
				if (ship.Status != GridSpotStatus.Sunk)
				{
					isActive = true;
				}
			}
			return isActive;
		}

		public static (string row, int column) SplitShotIntoRowAndColumn(string shotSpot)
		{
			string row = "";
			int column = 0;

			if (string.IsNullOrEmpty(shotSpot) || shotSpot.Length != 2)
			{
				throw new ArgumentException($"{shotSpot} is an invalid shot type.\n\n");
			}
			char[] individualChars = shotSpot.ToArray();
			row = individualChars[0].ToString();
			column = int.Parse(individualChars[1].ToString());

			return (row, column);
		}

		private static void AddGridSpot(PlayerInfoModel player, string letter, int number)
		{
			GridSpotModel spot = new GridSpotModel
			{
				SpotLetter = letter,
				SpotNumber = number,
				Status = GridSpotStatus.Empty
			};
			player.ShotGrid.Add(spot);
		}

		public static bool IdentifyShotResult(PlayerInfoModel player, string row, int column)
		{
			bool isAHit = false;

			foreach (var spot in player.ShipLocation)
			{
				if (spot.SpotLetter == row.ToUpper() && spot.SpotNumber == column)
				{
					spot.Status = GridSpotStatus.Sunk;
					isAHit = true;					
				}
			}
			return isAHit;
		}

		public static void MarkShotResult(PlayerInfoModel player, string row, int column, bool isAHit)
		{
			foreach (var spot in player.ShotGrid)
			{
				if (spot.SpotLetter == row.ToUpper() && spot.SpotNumber == column)
				{
					if (isAHit)
					{
						spot.Status = GridSpotStatus.Hit;
					}
					else
					{
						spot.Status = GridSpotStatus.Miss;
					}
				}

			}
			
		}
	}
}
