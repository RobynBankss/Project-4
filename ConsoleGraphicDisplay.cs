using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Project 4 - Simulation with Queues
//	File Name:	ConsoleGraphicDisplay.cs
//	Description:	Displays the simulation of the queues in the console window
//	Course:		CSCI 2210-001 - Data Structures
//	Author:		Zachary Lykins, lykinsz@etsu.edu, East Tennessee State University
//	Created:		November 14, 2019
//	Copyright:	Zachary Lykins, 2019
////////////////////////////////////////////////////////////////////////////////////////////////////////////

namespace Project_4
{
	class ConsoleGraphicDisplay
	{
		List<Queue<int>> r = new List<Queue<int>>();

		public ConsoleGraphicDisplay(int NumWindows)
		{
			Registrant s;
			Queue<int> t;

			for (int i = 0; i < NumWindows; i++)
				r.Add(t = new Queue<int>());

			for (int i = 0; i < 16; i++)
			{
				for(int k = 0; k < r.Count; k++)
				{
					if (r[k].Count < 5)
					{
						r[k].Enqueue(i * 2);
						break;
					}
				}

				Console.Clear();

				for (int m = 0; m < NumWindows; m++)
					Console.Write("X	");

				Console.Write("\n");

				RewriteDisplay();

				Console.ReadLine();
			}
		}

		private void RewriteDisplay()
		{
			int[] y;

			for (int j = 0; j < r.Count; j++)
			{
				for (int i = 0; i < r.Count; i++)
				{
					y = r[i].ToArray();
					Console.Write(y[j]);
					Console.Write("\n");
				}
				Console.Write("\n");
			}
		}
	}
}
