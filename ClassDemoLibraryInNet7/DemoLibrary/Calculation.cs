﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace DemoLibrary.Models
{
	public static class Calculation
	{
		public static double Add(double x, double y)
		{
			return x + y;
		}
	}
}
