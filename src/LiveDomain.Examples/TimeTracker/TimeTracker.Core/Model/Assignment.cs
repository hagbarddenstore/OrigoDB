﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TimeTracker.Core
{
	[Serializable]
	public class Assignment
	{
		public User User { get; set; }
		public Role Role { get; set; }
		public decimal HourlyRate { get;set; }

		public Assignment(User user, Role role)
		{
			if (user == null || role == null)
				throw new ArgumentNullException();

			User = user;
			Role = role;
		}
	}
}