﻿using System;
using System.Text.RegularExpressions;

namespace EmployeeDirectory
{
	public class Employee
	{
		public Employee ()
		{
		}

		public string FullName { get; set; }
		public string Email {get; set; }
		public string Phone { get; set;}
		public string Twitter { get; set; }
		public string City { get; set; }
		public string Title { get; set; }
		public GeoLocation GeoLocation { get; set; }

		public string Initials {
			get { 
				Regex initials = new Regex (@"(\b[a-zA-Z])[a-zA-Z]* ?");
				string init = initials.Replace (FullName, "$1");
				return init;
			}
		}

//		public Employee (string name, string email, string phone, string city, string twitter, string title)
//		{
//			FullName = name;
//			Email = email;
//			Phone = phone;
//			Twitter = twitter;
//			Title = title;
//			City = city;
//		}
	}
}

