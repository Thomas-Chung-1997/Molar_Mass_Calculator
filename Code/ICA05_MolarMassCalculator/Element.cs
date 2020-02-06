using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Molar_Mass_Calculator
{
    public class Element
    {
        public string Name { get; private set; }
        public string Symbol { get; private set; }
        public int AtomicNumber { get; private set; }
        public float MolarMass { get; private set; }

        public Element(string sName, string sSymbol,  int sAtomicNumber, float sMolarMass)
        {
            Name = sName;
            Symbol = sSymbol;
            AtomicNumber = sAtomicNumber;
            MolarMass = sMolarMass;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is string other))
                return false;

            return Name.Equals(other);
        }
        public override int GetHashCode()
        {
            return 1;
        }
    }
}
