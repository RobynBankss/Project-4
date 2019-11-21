using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Project 4 - Simulation with Queues
//	File Name:	Events.cs
//	Description:	Sets the arrival and departure time
//	Course:		CSCI 2210-001 - Data Structures
//	Author:		Zachary Lykins, lykinsz@etsu.edu, East Tennessee State University
//	Created:		November 14, 2019
//	Copyright:	Zachary Lykins, 2019
////////////////////////////////////////////////////////////////////////////////////////////////////////////

namespace Project_4
{
	class Events
	{
		/// <summary>
		/// Gets or sets the arrival time of the registrant
		/// </summary>
		public DateTime ArrivalTime { get; set; }

		/// <summary>
		/// Gets or sets the departure time of the registrant
		/// </summary>
		public string DepartureTime { get; set; }

		/// <summary>
		/// The default constructor
		/// </summary>
		public Events()
		{

		}
	}
}
