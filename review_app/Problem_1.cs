using System;

namespace review_app
{
	// create a class for this problem
	class Problem_1
	{
		public static void Prob1()
		{

			// Print the welcome message
			review_app.MainFile.Header();

			// create variables for the items we'll capture and use
			string fullUsername;
			string domain;
			string username;

			// Print Query to user
			Console.WriteLine("\nPlease enter your username or enter Exit to return to the Main Menu:");

			// Accept the input and check its in the correct format
			// Otherwise return wrong format

			fullUsername = Console.ReadLine().ToUpper();
			// If it starts with "DBS\" we're good to go!
			if (fullUsername.StartsWith("DBS\\"))
			{
				// if the user enters two or more \\ then we have a problem
				if (fullUsername.StartsWith("DBS\\\\"))
				{
					
					Console.WriteLine("\nINVALID ENTRY");
					Console.WriteLine("The expected format is DBS\\12345");
					Console.WriteLine("\nReturning to the Main Menu...\n");
					review_app.MainFile.Header();
				}
				else {
					// take the entered value, split on the \ and then assign each to an array.
					String[] substrings = fullUsername.Split('\\');
					domain = substrings[0];
					username = substrings[1];
					Console.WriteLine("\nDomain : " + domain);
					Console.WriteLine("Username : " + username);
					Console.WriteLine("Press any key to Continue...");
					Console.ReadKey();
				}

			}
			else if (fullUsername == "EXIT")
			{
				Console.WriteLine("\nReturning to the Main Menu...\n");
				review_app.MainFile.Header();
			}

			else {
				Console.WriteLine("INVALID ENTRY");
				Console.WriteLine("The expected format is DBS\\12345");
				Console.WriteLine("##################################");
				Console.WriteLine("\nReturning to the Main Menu...\n");
				review_app.MainFile.Header();
			}

		}
	}
}