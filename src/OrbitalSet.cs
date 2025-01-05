namespace HelloImAnAtom
{
    public class OrbitalSet
    {
        public OrbitalType Type { get; }
        public int MaxOrbitals { get; }
        public int MaxElectronCount { get; }
        public int CurrentElectronCount { get; private set; }
        public bool Full => CurrentElectronCount == MaxElectronCount;

        private OrbitalSet(OrbitalType type)
        {
            Type = type;
            MaxOrbitals = ((int)type * 2) + 1; 
            MaxElectronCount = MaxOrbitals * 2;
        }

        public bool TryAddAllElectrons(int electronsToAdd, out int remainder)
        {
            remainder = electronsToAdd;
            while (!Full)
            {
                CurrentElectronCount++;
                remainder--;
            }

            return remainder == 0;
        }

        public static OrbitalSet OfType(OrbitalType type)
        {
            return new OrbitalSet(type);
        }
    }
}
