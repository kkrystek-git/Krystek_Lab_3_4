﻿using System;
using System.Text.RegularExpressions;

namespace Krystek_Lab_3_4
{
	class Program
	{
		static void Main(string[] args)
		{
			// Name:	Keith Krystek
			// Date:	07.23.2020
			// Class: SD1104-A - Full Stack C# Development - Sona Patel - 7 / 11 / 2020
			//
			// Assignment: Lab 3_4
			// =========================================================================
			//
			//
			//2a.Find all of the occurrences of the letter ‘d’ or ‘e’‘   --  REGEX[d - e]
			//	67 Matches.
			//2b.Find all of the occurrences of the letter ‘d’ or’ e’, followed by another ‘d’ -- REGEX[d - e][*d]
			//	5 Matches.
			//2c.Find all of the occurrences of the letter ‘a’, followed by any letter, then the letter ‘a’ again  --  REGEX[a][a-z][a]
			//	4 Matches.
			//2d.Find all of the words that start with the letter “p”  --  REGEX[ ][p][a - z] *
			//	6 Matches.
			//2e.Find all of the words that end with the letter e  --  REGEX[a - z] *[e][ ]
			//	16 Matches.
			//2f.Find all of the capital letters  --  REGEX[A - Z]
			//	31 Matches.

			// Code generated by Code Generator at https://regex101.com/codegen?language=csharp.
			string pattern = @"[A-Z]";
			string input = @"Episode IV, A NEW HOPE It is a period of civil war. Rebel spaceships, striking from a hidden base, have won their first victory against the evil Galactic Empire. During the battle, Rebel spies managed to steal secret plans to the Empire’s ultimate weapon, the DEATH STAR, an armored space station with enough power to destroy an entire planet. Pursued by the Empire’s sinister agents, Princess Leia races home aboard her starship, custodian of the stolen plans that can save her people and restore freedom to the galaxy….";
			RegexOptions options = RegexOptions.Multiline;

			foreach (Match m in Regex.Matches(input, pattern, options))
			{
				Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
			}

			// Code generated by student.

			Console.WriteLine("\n");

			MatchCollection matches1 = Regex.Matches(input, "[d-e]");
			Console.WriteLine("{0} matches of pattern [d-e].", matches1.Count);
		
			MatchCollection matches2 = Regex.Matches(input, "[d-e][*d]");
			Console.WriteLine("{0} matches of pattern [d-e][*d].", matches2.Count);

			MatchCollection matches3 = Regex.Matches(input, "[a][a-z][a]");
			Console.WriteLine("{0} matches of pattern [a][a-z][a].", matches3.Count);

			MatchCollection matches4 = Regex.Matches(input, "[ ][p][a-z]*");
			Console.WriteLine("{0} matches of pattern [ ][p][a-z]*.", matches4.Count);

			MatchCollection matches5 = Regex.Matches(input, "[a-z]*[e][ ]");
			Console.WriteLine("{0} matches of pattern [a-z]*[e][ ].", matches5.Count);

			MatchCollection matches6 = Regex.Matches(input, "[A-Z]");
			Console.WriteLine("{0} matches of pattern [A-Z].", matches6.Count);

			// End

		}
	}
}
