using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	class Program
	{
		static void Main(string[] args)
		{
			Human human = new Human("Schwartzenegger", "Arnold", 78);
			Console.WriteLine(human);

			Student student = new Student("Colombo", "Franco", 91, "HeavyMetal", "LA", 98, 100);
			Console.WriteLine(student);
		}
	}
}
