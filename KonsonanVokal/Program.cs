using System;
using System.Collections.Generic;
using System.Linq;

namespace KonsonanVokal
{
    class Program
    {
		public static string procVowel(string param)
		{
			string vowels = "aeiou";
			param = param.Replace(" ", string.Empty).ToLower();
			string result = new string(param.Where(c => vowels.Contains(c)).ToArray());

			Dictionary<char, int> valuePairs = new Dictionary<char, int>();

			foreach (var item in result)
            {
				if (!valuePairs.ContainsKey(item))
                {
					valuePairs.Add(item, 1);
                }
				else
                {
					valuePairs[item] = valuePairs[item] + 1;

				}
            }

			List<char> lstUrut = new List<char>();

			foreach (KeyValuePair<char, int> entry in valuePairs)
			{
				// do something with entry.Value or entry.Key
				int total = entry.Value;
				for (int i = 0; i < total; i++)
					lstUrut.Add(entry.Key);
			}
			
			return new string(lstUrut.ToArray());
		}

		public static string procConsonant(string param)
		{
			string vowels = "aeiou";
			param = param.Replace(" ", string.Empty).ToLower();
			string result = new string(param.Where(c => !vowels.Contains(c)).ToArray());

			Dictionary<char, int> valuePairs = new Dictionary<char, int>();

			foreach (var item in result)
			{
				if (!valuePairs.ContainsKey(item))
				{
					valuePairs.Add(item, 1);
				}
				else
				{
					valuePairs[item] = valuePairs[item] + 1;

				}
			}

			List<char> lstUrut = new List<char>();

			foreach (KeyValuePair<char, int> entry in valuePairs)
			{
				// do something with entry.Value or entry.Key
				int total = entry.Value;
				for (int i = 0; i < total; i++)
					lstUrut.Add(entry.Key);
			}

			return new string(lstUrut.ToArray());
		}

		public static void Main()
		{
			Console.Write("Input one line of words (S) : ");
			string input = Console.ReadLine();

			string charVowel = procVowel(input);
			string charConsonant = procConsonant(input);

			Console.WriteLine("Vowel Characters : ");
			Console.WriteLine(charVowel);
			Console.WriteLine("Consonant Characters : ");
			Console.WriteLine(charConsonant);
			Console.Write("Press any key to continue...");
			Console.ReadKey();
		}
	}
}
