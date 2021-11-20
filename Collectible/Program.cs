using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collectible
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCollectible collectible = new MyCollectible();
            collectible.Add("a", 1);
            collectible.Add("b", 2);
            collectible.Add("c", 3);
           
            
            foreach(Pair pair in collectible)
            {
                Console.WriteLine($"{pair.Key}; {pair.Value}");
            }

        }
    }
}
