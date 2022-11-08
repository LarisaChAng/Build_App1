using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Build_App1
{
    class Program
    {        
        static void Main(string[] args)
        {
            Building building = new Building("Иркутск", 56, 12, 6);
            Console.WriteLine(building.Print());
            MultiBuilding multiBuilding = new MultiBuilding("Иркутск-2", 68, 18, 8, 3);
            Console.WriteLine(multiBuilding.Print());           

            Console.ReadKey();
        }
    }
}
