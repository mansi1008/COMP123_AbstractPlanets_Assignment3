using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * name: MANSI MEHINDRU
* student number: 301108725
* Date last Modified: JULY 23, 2020
* Program description: GiantPlanet subclass 
*/

namespace COMP123_AbstractPlanets_Assignment3
{
    /// <summary>
    /// This is the GiantPlanet subclass
    /// </summary>
    public class GiantPlanet : Planet, IHasMoons, IHasRings
    {
        // private instance variables (fields)
        private string _type;

        // public properties

        /// <summary>
        /// This is the constructor for GiantPlanet subclass which will take 3 parameters inherited from the planet class with the addition of a type variable
        /// </summary>
        /// <mm name="name"></mm>
        /// <mm name="diameter"></mm>
        /// <mm name="mass"></mm>
        /// <mm name="type"></mm>
        // constructors +_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+
        public GiantPlanet(string name, double diameter, double mass, string type) : base(name, diameter, mass)
        {
            if (type == "Gas")
            {
                this._type = type;
            }
            else if (type == "Ice")
            {
                this._type = type;
            }
            else
            {
                type = "Not a valid type, must be either Gas or Ice";
                this._type = type;
            }
        }


        // private methods

        /// <summary>
        /// Extra: These public bool methods will return true if the condition is satisfied
        /// </summary>
        /// 
        /// <returns></returns>
        // public methods
        public bool HasMoons()
        {
            return MoonCount > 0;
        }
        public bool HasRings()
        {
            return RingCount > 0;
        }

        /// <summary>
        /// This ToString overrides the Planet ToString method for more specifics which include planet type for GiantPlanet class
        /// </summary>
        /// 
        /// <returns></returns>
        public override string ToString()
        {
            string output = this.Name + " | " + " Diameter = " + this.Diameter + " km | Mass = " + this.Mass + " kg | Type = " + this._type;
            return output;
        }
    }
}
