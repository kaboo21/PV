using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_15
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("What time is it (in minutes)?");
                int timeRead = Int32.Parse(Console.ReadLine());
                Time currentTime = Time.ConvertFromIntToTime(timeRead);
                Console.WriteLine($"It's {currentTime}");
            }
            catch (InvalidTimeFormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (SystemException e)
            {
                Console.Error.WriteLine (e.Message);
            }
            finally
            {
                Console.WriteLine("\nGoodbye!");
            }



            Console.ReadKey();

        }
    }
}
