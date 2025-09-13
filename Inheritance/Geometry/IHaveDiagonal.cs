﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geometry
{
	interface IHaveDiagonal
	{
		double GetDiagonal();
		void DrawDiagonal(PaintEventArgs e);
	}
}
