using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * name: MANSI MEHINDRU
* student number: 301108725
* Date last Modified: JULY 23, 2020
* Program description: Abstract Planets Program class
*/

namespace COMP123_AbstractPlanets_Assignment3
{
    /// <summary>
    /// This is the driver class which will create the new objects
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_ Planets +_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_");
            Console.WriteLine("\n\t----------------------------- GIANT PLANET -----------------------------------");
            GiantPlanet giantplanet = new GiantPlanet("\nJupiter", 139822, 1.898 * Math.Pow(10, 27), "Gas");
            Console.WriteLine(giantplanet.ToString());

            //Extra Work: to test the HasMoons, HasRings and Habitable methods
            giantplanet.MoonCount = 1;                                                                      // Assigned 1 moon to giantplanet object for testing
            Console.WriteLine("\nDoes {0} have any moons? {1}", giantplanet.Name, giantplanet.HasMoons());
            Console.WriteLine("Does {0} have any rings? {1}", giantplanet.Name, giantplanet.HasRings());         // Did not assign any rings to giant planet

            Console.WriteLine("\n\n\t----------------------------- TERRESTRIAL PLANET -----------------------------------");
            TerrestrialPlanet terrestrialplanet = new TerrestrialPlanet("\nEarth", 12742, 5.972 * Math.Pow(10, 24), true);
            Console.WriteLine(terrestrialplanet.ToString());

                                                       
            Console.WriteLine("\nDoes {0} have any moons? {1}", terrestrialplanet.Name, terrestrialplanet.HasMoons());        // Did not assign any moons to terrestrial planet
            Console.WriteLine("Is {0} habitable (does it have oxygen?) {1}", terrestrialplanet.Name, terrestrialplanet.Habitable());

            
        }

       
    }
}
