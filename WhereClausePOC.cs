using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPractice
{
   public class WhereClausePOC
    {
        public static void Main()
        {
          List<string> fruits = new List<string> { "apple", "passionfruit", "banana", "mango","orange", "blueberry", "grape", "strawberry" };

            IEnumerable<string> query = fruits.Where(fruit => fruit.Length < 6);

            foreach (string fruit in query)
            {
                Console.WriteLine(fruit);
            }
        }
    }
}
