using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hazi3
{
    class Program
    {
        static string convert_to_infix(string s)
        {
            string result = "";
            string muvelet = "+-*/^%";
            Stack<string> v = new Stack<string>();

            foreach (char c in s)
            {
                if (muvelet.Contains(c))
                {
                    string t1 = v.Pop();
                    result = $"({v.Pop()}{c}{t1})";
                    v.Push(result);
                }
                else if ("0123456789".Contains(c))
                    v.Push(c.ToString());

            }

            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(convert_to_infix("23-"));
            Console.WriteLine(convert_to_infix("59*"));
            Console.WriteLine(convert_to_infix("14/"));
            Console.WriteLine(convert_to_infix("69^"));
            Console.WriteLine(convert_to_infix("11-"));
            Console.WriteLine(convert_to_infix("34*"));

        }
    }
}
