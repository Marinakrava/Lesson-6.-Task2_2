using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string str2 = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                str2 += str[i];
            }
            if (str == str2)
            {
                System.Console.WriteLine("YES");
            }
            else
            {
                System.Console.WriteLine("NO");
            }
            Console.ReadKey();
        }
    }
}
