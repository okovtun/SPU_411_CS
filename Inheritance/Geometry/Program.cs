﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Geometry
{
	class Program
	{
		static void Main(string[] args)
		{
			IntPtr hwnd = GetConsoleWindow();
			Graphics graphics = Graphics.FromHwnd(hwnd);
			System.Drawing.Rectangle window_rect = new System.Drawing.Rectangle
				(
					Console.WindowLeft, Console.WindowTop,
					Console.WindowWidth, Console.WindowHeight
				);
			PaintEventArgs e = new PaintEventArgs(graphics, window_rect);
			e.Graphics.DrawLine(new Pen(Color.AliceBlue, 10), 100, 100, 500, 500);

			//Shape shape = new Shape(0, 0, 0, System.Drawing.Color.Aquamarine);
			Rectangle rectangle = new Rectangle(150, 100, 500, 10, 1, Color.Aquamarine);
			rectangle.Info(e);

			Square square = new Square(80, 800, 10, 3, Color.Red);
			square.Info(e);
			GetDiagonal(square);
		}
		static void GetDiagonal(IHaveDiagonal d)
		{
			Console.WriteLine(d.GetDiagonal());
		}
		[DllImport("kernel32.dll")]
		public static extern IntPtr GetConsoleWindow();
		//[DllImport("kernel32.dll")]
		//public static extern IntPtr GetDC(IntPtr hwnd);
	}
}

/*
------------------------------------
I...able
IMovable - я умею перемещаться;
IFlyable - я умею летать;
IDriveable - я умею ездить;
------------------------------------
 */
