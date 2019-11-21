using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Project 4 - Simulation with Queues
//	File Name:	All RegistrationWindows.cs
//	Description:	Handles all the registration window queues
//	Course:		CSCI 2210-001 - Data Structures
//	Author:		Zachary Lykins, lykinsz@etsu.edu, East Tennessee State University
//	Created:		November 14, 2019
//	Copyright:	Zachary Lykins, 2019
////////////////////////////////////////////////////////////////////////////////////////////////////////////

namespace Project_4
{
	class AllRegistrationWindows
	{
		private List<Queue<Registrant>> AllWindows = new List<Queue<Registrant>>();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="TotalIndividuals">The total individuals expected</param>
		/// <param name="TotalWindows">The total windows that are expected to keep up</param>
		public AllRegistrationWindows(int TotalIndividuals, int TotalWindows)
		{
			Queue<Registrant> Window;

			for (int i = 0; i < TotalWindows; i++)
			{
				Window = new Queue<Registrant>();
				AllWindows.Add(Window);
			}

			Registrant Person;

			for(int i = 0; i < TotalIndividuals; i++)
			{
				Person = new Registrant();
				for(int j = 0; j < AllWindows.Count; j++)
				{
					if (AllWindows[j].Count < 5)
						AllWindows[j].Enqueue(Person);
				}

				for (int j = 0; j < TotalWindows; j++)
					Console.WriteLine(AllWindows[j].Count);
			}

		}
	}
}
