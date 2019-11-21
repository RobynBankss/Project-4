using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Project 4 - Simulation with Queues
//	File Name:	RegistrationWindows.cs
//	Description:	Handles adding Registrants to the queues and removing them once that are finished
//	Course:		CSCI 2210-001 - Data Structures
//	Author:		Zachary Lykins, lykinsz@etsu.edu, East Tennessee State University
//	Created:		November 14, 2019
//	Copyright:	Zachary Lykins, 2019
////////////////////////////////////////////////////////////////////////////////////////////////////////////

namespace Project_4
{
	class RegistrationWindow
	{
		private Queue<Registrant> Window = new Queue<Registrant>();

		/// <summary>
		/// Adds the Registrant to the queue
		/// </summary>
		/// <param name="Person">The person being added</param>
		public RegistrationWindow(Registrant Person)
		{
			Window.Enqueue(Person);
		}

		/// <summary>
		/// Returns the queue for the window
		/// </summary>
		/// <returns>Window - the queue for the window</returns>
		public Queue<Registrant> ReturnQueue()
		{
			return Window;
		}
	}
}
