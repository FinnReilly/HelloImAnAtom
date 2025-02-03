using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloImAnAtom
{
    public class Orbital
    {
        public OrbitalType Type { get; }

        public int CurrentElectronCount { get; private set; }

        public bool Full => CurrentElectronCount == 2;
        public bool Empty => CurrentElectronCount == 0;

        private Orbital(OrbitalType type)
        {
            Type = type;
        }

        public bool TryAddElectron()
        {
            if (Full)
            {
                return false;
            }

            CurrentElectronCount++;
            return true;
        }

        public bool TryStealElectron()
        {
            if (Empty)
            {
                return false;
            }

            CurrentElectronCount--;
            return true;
        }

        public static Orbital OfType(OrbitalType type) => new Orbital(type);
    }
}
