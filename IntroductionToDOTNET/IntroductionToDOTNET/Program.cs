//#define STING_OPERATIONS
#define DATA_TYPES
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToDOTNET
{
	class Program
	{
		static void Main(string[] args)
		{
#if STING_OPERATIONS
			//Console.WriteLine("\t\t\t\tHello .NET");
			//Console.WriteLine("Привет");

			Console.Write("Введите Ваше имя: ");
			string first_name = Console.ReadLine();

			Console.Write("Введите Вашу фамилию: ");
			string last_name = Console.ReadLine();

			Console.Write("Введите Ваш возраст: ");
			int age = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine(first_name + " " + last_name + " " + age); //Конкатенация строк
			Console.WriteLine(String.Format("{0} {1} {2}", first_name, last_name, age));    //Форматирование строк
			Console.WriteLine($"{first_name} {last_name} {age}");   //Интерполяция строк  
#endif

#if DATA_TYPES
			Console.WriteLine(sizeof(bool));
			//Console.WriteLine(Boolean.);
			bool var1;
			Boolean var2;

			Console.WriteLine(sizeof(char));
			/*
			-----------------------
			sbyte	byte	SByte	Byte
			short	ushort	Int16	UInt16
			int		uint	Int32	UInt32
			long	ulong	Int64	UInt64
			-----------------------
			 */
			short var = 0;
			Console.WriteLine
				(
		$"{var.GetType()} занимает {sizeof(short)} Байт памяти, и принимает значения в диапазоне:{short.MinValue} ... {short.MaxValue}"
				);

			//float		Single;
			//double	Double;
			//decimal	Decimal;

			decimal f=1;
			Console.WriteLine(f.GetType());

			Console.
#endif

		}
	}
}