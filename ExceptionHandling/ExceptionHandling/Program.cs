using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            START:
            try
            {
                try
                {
                    int eingabe = int.Parse(Console.ReadLine());

                } catch (Exception)
                {
                    throw;

                    // throw;
                } finally
                {
                    Console.WriteLine($"Bitte eine Zahl eingeben");

                }
                goto START;

            } catch (Exception e)
            {

                Console.WriteLine($"{e.Message}");
                Console.WriteLine($"{e.Data}");
                Console.WriteLine($"{e.Source}");
                Console.WriteLine($"{e.StackTrace}");
                Console.WriteLine($"{e.TargetSite}");
                throw e;
            }
            
            // operationen
        }
    }
}
