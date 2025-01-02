namespace HelloImAnAtom
{
    public class Atom
    {
        public Atom(int atomicNumber, int atomicMass) 
        {
            AtomicNumber = atomicNumber;
            AtomicMass = atomicMass;
            ProtonCount = atomicNumber;
            NeutronCount = atomicMass - atomicNumber;
            ElectronCount = atomicNumber;
        }

        public int AtomicNumber { get; }
        public int AtomicMass { get; }
        public int ProtonCount { get; }
        public int NeutronCount { get; }
        public int ElectronCount { get; }
    }
}
