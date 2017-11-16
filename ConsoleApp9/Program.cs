using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un numero de 9 cifras");
            string n = Console.ReadLine();
            string[] cad = new string[9];
            for (int i = 0; i < cad.Length; i++)
                cad[i] = n[i]+"";
            foreach(string item in cad)
            {
                Console.Write(item+" ");
            }
            Console.ReadKey();
        }
    }
}
