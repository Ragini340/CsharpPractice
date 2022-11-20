using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPractice
{
    public class VarPOC
    {
        static void Main(string[] args)
        {
            var a= "Ragini";
            var roll = 340;
            Console.WriteLine("Type of 'a' is : {0}", a.GetType());
            Console.WriteLine("Type of 'b' is : {0} ", roll.GetType());

            var xs = new List <string>();
            xs.Add("Ragini");
            xs.Add("Ragini Ragini");
            xs.Add("Ragini Singh");
            xs.Add("R Singh");
            foreach (var s in xs)
            {
                Console.WriteLine(s);
            }

        }
    }
}
