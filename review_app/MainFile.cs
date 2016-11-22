using System;



namespace review_app
{
	class MainFile
	{
		public static void Header()
		{
			// Print the welcome message
			Console.WriteLine("##################################");
			Console.WriteLine("WELCOME TO THE DBS CONSOLE");
			Console.WriteLine("##################################");

		}
		static void Main(string[] args)
		{

			//Print a menu
			Header();

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

				//get a selection from the user
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
					Console.WriteLine("Please entry a valid selection");
				}

			} 
			while (entry.ToLower() != "e");





		} 
	}
}
