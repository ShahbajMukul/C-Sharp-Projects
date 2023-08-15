using System;

namespace HelloWorld
{
	class Program
	{
		        public static string Mul( int inp){
					int answer, mul, total = 0;
					int i = 1;
					string ans;

					do
					{
						mul = inp * i;
						Console.WriteLine(mul);
						total += mul;
						i++;

					} while (i<10);
					ans = total.ToString();
					return ans;
				}
		

		/*         public static string test(int range)
				{
					int firstVal= 0;
					int secondVal = 1;
					int newVal = 0, result = 0;
					string ans = firstVal.ToString() + " " + secondVal.ToString();

					for(int i = 3; i<=range; i++)
					{
						newVal = firstVal + secondVal;
						ans += " " + newVal.ToString();
						firstVal = secondVal;
						secondVal = newVal;

					}
					return ans;
				}
		 */


		     
		public static void ARowLines(int rows)
				{
					if(rows ==0){} else{ rows++;}

					for(int currentRow =1; currentRow < rows; currentRow++)
					{
						int printedAs =0;
						while ( printedAs < currentRow)
						{
							Console.Write("a");
							printedAs++;
							if (printedAs < currentRow) {Console.Write(" "); }
						} 
							Console.WriteLine("");
					}
				} 


		 public static void PascalTriangle(int row)
		{
				int column  = row;
				int[,] pascalArray = new int[row,column];



			for(int currentRow = 0; currentRow < row; currentRow++)
			{
				for(int currentColumn = 0; currentColumn <= column; currentColumn++ )
				{
					if( currentColumn== 0 || currentColumn == column)
					{
						pascalArray[currentRow,currentColumn] = 1;
						break;
					}
					else
					{

						int valueAboveLeft = (currentColumn - 1 >= 0) ? pascalArray[currentRow - 1, currentColumn - 1] : 1;
						int valueAboveRight = pascalArray[currentRow - 1, currentColumn];
						pascalArray[currentRow, currentColumn] = valueAboveLeft + valueAboveRight;            
					}
					Console.Write(pascalArray[currentRow, currentColumn] + " ");
							Console.WriteLine("");
				}

						Console.WriteLine("");

			}

		 } 

	
			public static void PascalTriangleTest(int row)
			{
					int column = row;
					int[,] pascalArray = new int[row, column];
					float spaces = row / 2;



					for (int currentRow = 0; currentRow < row; currentRow++)
					{
						for (int currentColumn = 0; currentColumn <= column; currentColumn++)
						{

							if (currentColumn == 0)
							{
								for (int i = 0; i < spaces; i++)
								{
									Console.Write(" ");
								}
								if (currentRow == 0)
								{
									Console.WriteLine("1");
									break;
								}

								Console.Write("1");
							}
							else if (currentColumn == column )
							{
								Console.WriteLine("1'");
							}
							else
							{
								Console.Write("1");

							}

							if ( currentRow == currentColumn)
							{
								Console.WriteLine("");
								break;
							}

						}
						spaces -= 0.5f;

					}

				}
		



		static public void MMatrix(int n)
		{
			int row = n, column = n; 
			int[,] twoDArray = new int[row,column];
			

			for(int curRow= 0; curRow < row; curRow++)
			{
				for (int curColumn = 0; curColumn<column; curColumn++)
				{
					if(row == curRow&& column == curColumn)
					{
						twoDArray[curRow, curColumn] = 0;
					}
					else if (curRow < curColumn)
					{
						twoDArray[curRow, curColumn] = 1;
					}
					else if(curRow> curColumn)
					{
						twoDArray[curRow, curColumn] = -1;
					}
				}
			}

			//print 
			for (int curRow= 0;curRow < row; curRow++)
			{
				for ( int curColumn = 0;curColumn < column; curColumn++)
				{
					Console.Write(twoDArray[curRow, curColumn] + " ");
				}
				Console.WriteLine();
			}

		}


		static void Main(string[] args)
		{
			int mat = 5;
			MMatrix(mat);

			int numRows = 10;
			Console.WriteLine("Printing Pascal's Triangle of " + numRows + " rows:");
			PascalTriangleTest(numRows);

			Console.WriteLine("Printing rows of letters:");
			ARowLines(5);

			int num = 5;
			string ans = Mul(num);
			Console.WriteLine("The sum of the first 10 multiples of " + num + " is " + ans);

		}
	}
}