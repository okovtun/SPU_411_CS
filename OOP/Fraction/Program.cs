﻿//#define CONSTRUCTORS_CHECK
//#define ARITHMETICAL_OPERATORS
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
	class Program
	{
		const string delimiter = "\n---------------------------------\n";
		static void Main(string[] args)
		{
#if CONSTRUCTORS_CHECK
			Fraction A = new Fraction();
			Console.WriteLine(A);
			Console.WriteLine(A.GetType());
			//object
			A.Print();

			Fraction B = new Fraction(5);
			Console.WriteLine(B);
			B.Print();

			Fraction C = new Fraction(1, 2);
			Console.WriteLine(C);
			C.Print();

			Fraction D = new Fraction(2, 3, 4);
			Console.WriteLine(D);
			D.Print();

			Console.WriteLine("\n----------------------------------------\n");

			Fraction E = new Fraction(D);   //CopyConstrcutor
			Console.WriteLine(E);
			E.Print(); 
#endif

#if ARITHMETICAL_OPERATORS
			Fraction A = new Fraction(2, 3, 4);
			Fraction B = new Fraction(3, 4, 5);
			Console.WriteLine(A);
			Console.WriteLine(B);
			/////////////////////////////////////////////
			Console.WriteLine(delimiter);
			Fraction C = A * B;
			Console.WriteLine(delimiter);
			Console.WriteLine(C);
			Console.WriteLine(A);
			Console.WriteLine(B);
			/////////////////////////////////////////////
			Console.WriteLine(delimiter);
			C = A / B;
			Console.WriteLine(delimiter);
			Console.WriteLine(C);
			Console.WriteLine(A);
			Console.WriteLine(B); 
#endif

			Fraction A = new Fraction(2, 3, 4);
			Fraction B = new Fraction(3, 4, 5);
			Console.WriteLine(A);
			Console.WriteLine(B);

			A *= B;
			Console.WriteLine(A);
			A /= B;
			Console.WriteLine(A);
		}
	}
}
//#error version
