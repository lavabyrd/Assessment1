//using System;

//namespace Problem_1
//{
//	class Program
//	{
//		public static void Main(string[] args)
//		{
//			// Declare empty variable for username values
//			string fullUsername;
//			string domain;
//			string username;

//			// Print the welcome message
//			Console.WriteLine("##################################");
//			Console.WriteLine("WELCOME TO THE DBS CONSOLE");
//			Console.WriteLine("##################################");
//			// Print Query to user
//			Console.WriteLine("Please enter your username:");

//			// Accept the input and check its in the correct format
//			// Otherwise return wrong format
//			// doesn't check for multiple occurences of \ and this may cause an issue

//			fullUsername = Console.ReadLine().ToUpper();
//			if (fullUsername.StartsWith("DBS\\"))
//			{
//				String[] substrings = fullUsername.Split('\\');
//				domain = substrings[0];
//				username = substrings[1];
//				Console.WriteLine("Domain : " + domain);
//				Console.WriteLine("Username : " + username);

//			}
//			else
//			{
//				Console.WriteLine("Incorrect format: Expected format: DBS/12345");
//			}

//		}
//	}
//}