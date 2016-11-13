using System;

namespace Problem_1
{
	class Program
	{
		public static void Main(string[] args)
		{
			// Declare empty variable for username values
			int[] values = new int[10];
			// Declare zero value variable for invalid entries by user
			int invalidvalue = 0;
			//Declare sum and average variables as 0
			int sum = 0;
			int average = 0;

			// Print the welcome message including the line breaks at the end
			Console.WriteLine("##################################");
			Console.WriteLine("WELCOME TO THE DBS CONSOLE");
			Console.WriteLine("##################################\n\n");

			// Print Query to user
			Console.WriteLine("Read 10 numbers and calculate sum and average:");
			Console.WriteLine("----------------------------------------------\n");
			Console.WriteLine("Input the 10 numbers :");

			// Loop over 10 entries requesting input from the user
			// If valid entry, add it to the array, otherwise set as 0
			for (int i = 0; i < 10; i++)
			{
				Console.Write("Number-{0} :", (i + 1));
				int.TryParse(Console.ReadLine(), out invalidvalue);
				values[i] = invalidvalue;
			}

			// Interate over the values, add them to sum and display it
			foreach (var value in values)
			{
				sum += value;
			}
			Console.WriteLine("The sum of 10 no is : {0}", sum);

			// Take the sum, divide by 10 and display the output
			average = sum / 10;
			Console.WriteLine("The Average is : {0}", average);
		}
	}
}