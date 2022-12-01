using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b1tob2_conversie
{
    internal class Program
    {
        private static char[] cifre = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti baza in care va fi dat numarul. Obs! Bazele vor fi >=2 && <=16 ");
            int b1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti numarul. Obs! Cifrele numarului vor fi < baza data");
            string line = Console.ReadLine();
            Console.WriteLine("Introduceti baza in care doriti sa fie convertit numarul");
            int b2 = int.Parse(Console.ReadLine());

            char[] sep = new char[] {'.'};
            string[] val=line.Split(sep, StringSplitOptions.RemoveEmptyEntries);
            //int intreg, fract;
            //intreg = int.Parse(val[0]);
           // fract = int.Parse(val[1]);
            // Console.WriteLine($"{intreg} {fract}");
            Console.WriteLine(baza10toX(b2,bazaXto10(b1, val[0])));
            //Console.WriteLine(FractionaraTo10(b2, val[1]));


            // Console.WriteLine(base10ToBaseK(b2, bazaKto10(b1,line)));
           // Console.WriteLine(bazaKto10(5, "121"));
        }
      
        public static string baza10toX(int b2, int intreg)
        {
            string sol = "";
            Stack<char> stack = new Stack<char>();
            while (intreg > 0)
            {
                stack.Push(cifre[intreg % b2]);
                intreg /= b2;
            }
            foreach (char c in stack)
                sol += c;
            return sol;
        }
        public static int bazaXto10(int b1, string mid)
        {
            int sol = 0;
            for (int i = 0; i < mid.Length; i++)
                sol += (int)Math.Pow(b1, mid.Length - i - 1) * Array.IndexOf(cifre, mid[i]);
            
            return sol;
        }
       
    }
}
