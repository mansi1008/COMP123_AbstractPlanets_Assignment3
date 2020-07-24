using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * name: MANSI MEHINDRU
* student number: 301108725
* Date last Modified: JULY 23, 2020
* Program description: TerrestrialPlanet subclass 
*/

namespace COMP123_AbstractPlanets_Assignment3
{
    /// <summary>
    /// This is the TerrestrialPlanet class
    /// </summary>
    public class TerrestrialPlanet : Planet, IHasMoons, IHabitable
    {
        // private instance variables (fields)
        private bool _oxygen;

        // public properties

        /// <summary>
        /// This is the constructor which takes the parameters of the planet base class and adds an oxygen bool variable
        /// </summary>
        /// 
        /// <mm name="name"></mm>
        /// <mm name="diameter"></mm>
        /// <mm name="mass"></mm>
        /// <mm name="oxygen"></mm>
        // constructors +_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+
        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen) : base(name, diameter, mass)
        {
            this._oxygen = oxygen;
        }

        // private methods


        // public methods

        /// <summary>
        /// These public methods will return if satisfied
        /// </summary>
        /// 
        public bool HasMoons()
        {
            return MoonCount > 0;
        }

        public bool Habitable()
        {
            return _oxygen = true;
        }

        /// <summary>
        ///  This is the ToString method specific for TerrestrialPlanet Class
        /// </summary>
        /// 
        /// <returns></returns>
        public override string ToString()
        {
            string output = this.Name + " | " + " Diameter = " + this.Diameter + " km | Mass = " + this.Mass + " kg | Oxygen? = " + this._oxygen;
            return output;
        }

    }
}
