using System;

namespace review_app
{
	class Problem_1
	{
		public static void Prob1()
		{

			// Print the welcome message
			review_app.MainFile.Header();


			string fullUsername;
			string domain;
			string username;
			// Print Query to user
			Console.WriteLine("\nPlease enter your username or enter Exit to return to the Main Menu:");

			// Accept the input and check its in the correct format
			// Otherwise return wrong format
			// doesn't check for multiple occurences of \ and this may cause an issue
			fullUsername = Console.ReadLine().ToUpper();

			if (fullUsername.StartsWith("DBS\\"))
			{
				String[] substrings = fullUsername.Split('\\');
				domain = substrings[0];
				username = substrings[1];
				Console.WriteLine("\nDomain : " + domain);
				Console.WriteLine("Username : " + username);
				Console.WriteLine("Press any key to Continue...");
				Console.ReadKey();

			}
			else if (fullUsername == "EXIT")
			{
				Console.WriteLine("\nReturning to the Main Menu...\n");
				review_app.MainFile.Header();
			}

			else {
				Console.WriteLine("##################################");
				Console.WriteLine("INVALID ENTRY");
				Console.WriteLine("##################################");
				Console.WriteLine("\nReturning to the Main Menu...\n");
				review_app.MainFile.Header();
			}

		}
	}
}