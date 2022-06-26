using System;
using System.Collections.Generic;
using System.Linq;

namespace PSBB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the number of family: ");
            int jumlah = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the number of members in the family (separated by space): ");
            string members = Console.ReadLine();
            List<int> lstMember = members.Split(' ').Select(a=> Convert.ToInt32(a)).ToList();

            if (jumlah != lstMember.Count())
            {
                Console.WriteLine("Input must be equal with the count of family");
            }
            else
            {
                int totalorang = lstMember.Sum(a => a);
                double minbus = totalorang / (double)4;
                Console.WriteLine("Minimum bus required is " + Math.Ceiling(minbus));
            }

            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
