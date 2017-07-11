using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat ("Samon", "Chordata", AnimalSize.Small, "white",5,4,true, "Maine coon",FurSize.Short);
            cat1.DisplayInfo();
        }
    }
}
