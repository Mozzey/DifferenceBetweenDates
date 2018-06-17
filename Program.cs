using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferenceBetweenDates
{
	class Program
	{
		static void Main(string[] args)
		{
            // Keep the program running until the user decided to exit
			bool isRunning = true;
			while (isRunning)
			{
				// Greet the user and explain the program
				Console.WriteLine("Welcome to the Date difference Program!");
				Console.WriteLine("Please enter a start and end Date and I will calculate the difference.");
				Console.WriteLine("Example: dd/mm/yyyy (optional) hh:mm.");
                Console.WriteLine();
				// Store the two user inputs
				Console.Write("Start Date : ");
				var startDate = Console.ReadLine();
				Console.Write("End Date : ");
				var endDate = Console.ReadLine();
                Console.WriteLine();
                // Run the dateDifference method you get the exact time between two dates
				dateDifference(startDate, endDate);
				
                Console.WriteLine();
				Console.WriteLine("Would you like to run the program again? Y / N");
				string runAgain = Console.ReadLine();
				if (!(runAgain == "Y" || runAgain == "y"))
				{
					isRunning = false;
				}

			}
		}

		private static void dateDifference(string startDate, string endDate) 
		{
            // Convert user input into DateTime
            DateTime startDateConv;
            DateTime endDateConv;
            if (DateTime.TryParse(endDate, out endDateConv) && DateTime.TryParse(startDate, out startDateConv))
	        {
                // Get the time difference
                TimeSpan timeDifference = endDateConv - startDateConv;
                // Store TimeSpan properties to make string formatting more readable				
			    int days = Math.Abs(timeDifference.Days);
			    int hours = Math.Abs(timeDifference.Hours);
			    int minutes = Math.Abs(timeDifference.Minutes);
                // Formatted string to display to the user
			    string timeDiff = String.Format("{0} Days {1} Hours {2} Minutes", days, hours, minutes);
                Console.WriteLine(timeDiff);
	        }
            else
	        {
                Console.WriteLine("Invalid Date Format...Please Try Again!");
	        }
		}
	}
}
