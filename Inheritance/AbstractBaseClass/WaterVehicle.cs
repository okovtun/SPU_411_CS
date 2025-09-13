using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractBaseClass
{
	abstract class WaterVehicle:Vehicle{}
	class Boat : WaterVehicle
	{
		public override void Move()
		{
			Console.WriteLine("Плавает по воде"); ;
		}
	}
}
