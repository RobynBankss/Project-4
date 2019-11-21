using System;
using System.Globalization;

/////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Project 4 - Simulation with Queues
//	File Name:	Registrant.cs
//	Description:	Creates the times for the Registrants and when the leave
//	Course:		CSCI 2210-001 - Data Structures
//	Author:		Zachary Lykins, lykinsz@etsu.edu, East Tennessee State University
//	Created:		November 14, 2019
//	Copyright:	Zachary Lykins, 2019
////////////////////////////////////////////////////////////////////////////////////////////////////////////

namespace Project_4
{
	class Registrant
	{
		Events events = new Events();
		Random rnd;
		int OpenHour = -1;
		int CloseHour = -1;

		/// <summary>
		/// Gets or sets the time it takes for the registrant to complete registration
		/// </summary>
		public DateTime RegistrationTime { get; set; }

		/// <summary>
		/// The default constructor that sets the arrival time and the length of their registration 
		/// </summary>
		public Registrant()
		{
			rnd = new Random();
			TimeOpen();
			TimeClose();

			TimeSpan Start = TimeSpan.FromHours(OpenHour);
			TimeSpan End = TimeSpan.FromHours(CloseHour + 12);

			int maxMinutes = (int)((End - Start).TotalMinutes);

			int Minutes = rnd.Next(maxMinutes);

			TimeSpan TimeMinutes = Start.Add(TimeSpan.FromMinutes(Minutes));

			string RndTime = (rnd.Next(OpenHour, CloseHour + 12)).ToString();

			events.ArrivalTime = DateTime.Parse(RndTime);
			RegistrationTime = NegativeExponential();
		}

		/// <summary>
		/// Gets a number from the negative exponential graph
		/// </summary>
		/// <returns>returns a negative exponential for the time</returns>
		public DateTime NegativeExponential()
		{
			rnd = new Random();
			string temp; // temporarily holds the read line
			int TimeMin = -1;
			int TimeSec = -1;

			do
			{
				try
				{
					Console.WriteLine("What is the average time that it takes to register? (Ex. 1:30");
					temp = Console.ReadLine();
					if (temp.Length == 4)
					{
						TimeMin = int.Parse(temp.Substring(0, 1));
						TimeSec = int.Parse(temp.Substring(2, 2));	
					}
					else if (temp.Length == 5)
					{
						TimeMin = int.Parse(temp.Substring(0, 2));
						TimeSec = int.Parse(temp.Substring(3, 2));
					}


				}
				catch (Exception ex)
				{
					Console.WriteLine("Enter a valid registration time");
				}

			} while (TimeMin != -1 && TimeSec != -1);

			double RegTime = (-TimeMin * Math.Log(rnd.NextDouble(), Math.E));

			string StrRegTime = RegTime.ToString();

			TimeMin = int.Parse(StrRegTime.Substring(0, 1));
			TimeSec = int.Parse(StrRegTime.Substring(2, 2));

			StrRegTime = TimeMin.ToString() + TimeSec.ToString();

			int TempTime = int.Parse(StrRegTime);

			DateTime time = new DateTime(TempTime);

			return time;
		}

		/// <summary>
		/// Gets the time that registration will open
		/// </summary>
		/// <returns>The time that registration opens</returns>
		private DateTime TimeOpen()
		{
			DateTime OpenTime = default;
			string temp; // temporarily holds the line read
			while (OpenTime == default(DateTime))
			{
				try
				{
					Console.WriteLine("What time does registration open? (Ex. 8:30)");
					temp = Console.ReadLine();

					OpenTime = DateTime.Parse(temp);
					if(temp.Length > 4)
						OpenHour = int.Parse(temp.Substring(0, 2));
					else
						OpenHour = int.Parse(temp.Substring(0, 1));
				}

				catch (Exception ex)
				{
					Console.WriteLine("Input a valid time (Ex.8:30)");
				}
			}

			return OpenTime;
		}

		/// <summary>
		/// gets the time that registration ends
		/// </summary>
		/// <returns>the time that registration ends</returns>
		private DateTime TimeClose()
		{
			DateTime CloseTime = default;
			string temp; // temporarily holds the line read
			while (CloseTime == default(DateTime))
			{
				try
				{
					Console.WriteLine("What time does registration close? (Ex. 8:30)");
					temp = Console.ReadLine();

					CloseTime = DateTime.Parse(temp);

					if (temp.Length > 4)
						CloseHour = int.Parse(temp.Substring(0, 2));
					else
						CloseHour = int.Parse(temp.Substring(0, 1));
				}

				catch (Exception ex)
				{
					Console.WriteLine("Input a valid time (Ex.8:30)");
				}
			}

			return CloseTime;
		}
	}
}
