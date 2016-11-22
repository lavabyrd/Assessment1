using System;

namespace review_app
{
	class Problem_2
	{
		public static void Prob2()
		{

			// Print the welcome message
			review_app.MainFile.Header();


			// Declare empty variables
			int value1 = 0;
			int value2 = 0;
			int total;

			// Print query for value 1 and if not an int, return 0
			Console.WriteLine("\nPlease enter value 1 :");
			int.TryParse(Console.ReadLine(), out value1);

			// Print query for value 2 and if not an int, return 0
			Console.WriteLine("\nPlease enter value 2 :");
			int.TryParse(Console.ReadLine(), out value2);

			// Calculate total by combining both values and print to the console
			total = value1 + value2;

			Console.WriteLine("TOTAL : " + total);
			Console.WriteLine("\nReturning to the Main Menu...\n");


		}
	}
}
