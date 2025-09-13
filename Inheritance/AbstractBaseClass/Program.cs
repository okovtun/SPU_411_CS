using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractBaseClass
{
	class Program
	{
		static void Main(string[] args)
		{
			//WaterVehicle vehicle = new WaterVehicle();
			//Console.WriteLine(vehicle);
			Boat boat = new Boat();
			Console.WriteLine(boat);
			boat.Move();
		}
	}
}
