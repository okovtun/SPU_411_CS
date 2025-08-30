//#define ARRAYS_1
//#define ARRAYS_2
#define JAGGED_ARRAYS

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
	class Program
	{
		static void Main(string[] args)
		{

#if ARRAYS_1
			Console.WriteLine("Arrays");
			Console.Write("Введите размер массива: ");
			int n = 5; //Convert.ToInt32(Console.ReadLine());
			int[] arr = new int[n];
			Console.WriteLine($"Размер массива: {arr.Length}");
			Console.WriteLine($"Количество измерений: {arr.Rank}");
			Console.WriteLine($"Размер массива: {arr.GetLength(0)}");

			Random rand = new Random(0); //Для того чтобы генерировать случайные числа,
										 //нужно создать объект класса 'Random'
										 //По умолчанию 'Random' генерирует всегда разные числа,
										 //для того, чтобы числа были одни и те же,
										 //при создании объекта класса 'Random' нужно указать значение 'seed'.
										 //seed - это самое обычное целое число

			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = rand.Next(100);
			}

			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write(arr[i] + "\t");
			}
			Console.WriteLine();
			foreach (int i in arr)
			{
				Console.Write(i + "\t");
			}
			Console.WriteLine();
			Console.WriteLine($"Сумма элементов массива: {arr.Sum()}");
			Console.WriteLine($"Среднее-арифметическое элементов массива: {arr.Average()}");
			Console.WriteLine($"Минимальное значение в массиве: {arr.Min()}");
			Console.WriteLine($"Максимальное значение в массиве: {arr.Max()}"); 
#endif

#if ARRAYS_2
			Console.Write("Введите количество строк: ");
			int rows = Convert.ToInt32(Console.ReadLine());

			Console.Write("Введите количество элементов строки: ");
			int cols = Convert.ToInt32(Console.ReadLine());

			int[,] i_arr_2 = new int[rows, cols];

			Random rand = new Random(0);
			Console.WriteLine($"Размер массива: {i_arr_2.Length}");
			for (int i = 0; i < i_arr_2.GetLength(0); i++)
			{
				for (int j = 0; j < i_arr_2.GetLength(1); j++)
				{
					i_arr_2[i, j] = rand.Next(10);
				}
			}
			for (int i = 0; i < i_arr_2.GetLength(0); i++)
			{
				for (int j = 0; j < i_arr_2.GetLength(1); j++)
				{
					Console.Write(i_arr_2[i, j] + "\t");
				}
				Console.WriteLine();
			}
			Console.WriteLine($"Сумма элементов массива: {i_arr_2.Cast<int>().Sum()}");
			Console.WriteLine($"Среднее-арифметическое элементов массива: {i_arr_2.Cast<int>().Average()}");
			Console.WriteLine($"Минимальное значение в массиве: {i_arr_2.Cast<int>().Min()}");
			Console.WriteLine($"Максимальное значение в массиве: {i_arr_2.Cast<int>().Max()}"); 
#endif

#if JAGGED_ARRAYS
			int[][] arr = new int[][]
				{
					new int[]{ 3, 5, 8 },
					new int[]{ 13, 21},
					new int[]{ 34, 55, 89},
					new int[]{ 144, 233}
				};

			Console.WriteLine($"Jagged length: {arr.Length}");
			for (int i = 0; i < arr.Length; i++)
			{
				for (int j = 0; j<arr[i].Length; j++)
				{
					Console.Write(arr[i][j] + "\t");
				}
				Console.WriteLine();
			}
#endif
		}
	}
}
