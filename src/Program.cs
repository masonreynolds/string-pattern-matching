﻿using System;
using string_pattern_matching.Algorithms;

namespace string_pattern_matching
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(BMH.Run("Hello World!", "!"));

			Console.WriteLine("\nPress enter to exit...");
			Console.ReadLine();
		}
	}
}