﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	class Human
	{
		public string LastName { get; set; }
		public string FirstName { get; set; }
		public int Age { get; set; }
		//				Constructors:
		public Human(string lastName, string firstName, int age)
		{
			LastName = lastName;
			FirstName = firstName;
			Age = age;
			Console.WriteLine($"HConstrcuctor:\t{GetHashCode().ToString("X")}");
		}
		~Human()
		{
			Console.WriteLine($"HDestrcuctor:\t{GetHashCode().ToString("X")}");
		}

		public override string ToString()
		{
			return base.ToString() + $"{LastName} {FirstName} {Age}";
		}
	}
}
