using System;


// main file namespace
namespace review_app
{
	// create a class that will be ran when we start this script
	class MainFile
	{
		// Create the standard header that will run at the start and also on each problem selection
		public static void Header()
		{
			// Print the welcome message
			Console.WriteLine("##################################");
			Console.WriteLine("WELCOME TO THE DBS CONSOLE");
			Console.WriteLine("##################################");

		}
		static void Main(string[] args)
		{

			// Print a menu for the user with the header
			Header();

			// create an empty string for the user entry
			string entry;
			do
			{
				//Ask the user to select their entry

				Console.WriteLine("\nPlease enter the problem number you're looking for\n");

				Console.WriteLine("1 - Problem 1");

				Console.WriteLine("2 - Problem 2");

				Console.WriteLine("3 - Problem 3");

				Console.WriteLine("E - Exit\n");

				Console.Write("Please select (1,2,3 or E): ");

				// take the user selection and run an additional class based on it
				entry = Console.ReadLine();

				if (entry.ToString() == "1")
				{
					Console.WriteLine();
					review_app.Problem_1.Prob1();
				}
				else if (entry.ToString() == "2")
				{
					Console.WriteLine();
					review_app.Problem_2.Prob2();
				}
				else if (entry.ToString() == "3")
				{
					Console.WriteLine();
					review_app.Problem_3.Prob3();
				}
				else 
				{
					// if the user does not select a valid selection, return this message
					Console.WriteLine("Please entry a valid selection");
				}

			} 

			// if the entry is E or e, exit the loop
			while (entry.ToLower() != "e");


		} 
	}
}
