namespace HelloImAnAtom
{
    public class OrbitalSet
    {
        public OrbitalType Type { get; }
        public int MaxOrbitals { get; }
        public int MaxElectronCount { get; }
        public int CurrentElectronCount { get; private set; }

        public Orbital[] Orbitals { get; }

        public bool Full => CurrentElectronCount == MaxElectronCount;
        public bool Empty => CurrentElectronCount == 0;
        public bool Stable => CurrentElectronCount == MaxElectronCount || CurrentElectronCount == MaxOrbitals || CurrentElectronCount == 0;
        public int ElectronsToStabilise => CurrentElectronCount > MaxOrbitals ?
            MaxElectronCount - CurrentElectronCount
            : MaxOrbitals - CurrentElectronCount;

        private OrbitalSet(OrbitalType type)
        {
            Type = type;
            MaxOrbitals = ((int)type * 2) + 1; 
            Orbitals = Enumerable.Range(0, MaxOrbitals)
                .Select(i => Orbital.OfType(type))
                .ToArray();
            MaxElectronCount = MaxOrbitals * 2;
        }

        public bool TryAddAllElectrons(int electronsToAdd, out int remainder)
        {
            remainder = electronsToAdd;
            while (!Full && remainder > 0)
            {
                foreach (var orbital in Orbitals)
                {
                    if (remainder == 0)
                    {
                        break;
                    }

                    if (orbital.TryAddElectron())
                    {
                        CurrentElectronCount++;
                        remainder--;
                    }
                }
            }

            return remainder == 0;
        }

        public bool TryStealAllElectrons(int electronsToSteal, out int remainder)
        {
            remainder = electronsToSteal;
            if (electronsToSteal > CurrentElectronCount)
            {
                return false;
            }

            while (!Empty && remainder > 0)
            {
                foreach (var orbital in Orbitals.Reverse())
                {
                    if (remainder == 0)
                    {
                        break;
                    }
                    if (orbital.TryStealElectron())
                    {
                        CurrentElectronCount--;
                        remainder--;
                    }
                }
            }
            return remainder == 0;
        }

        public static OrbitalSet OfType(OrbitalType type) => new OrbitalSet(type);
    }
}
