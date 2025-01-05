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

            var electronShell = new ElectronShell();
            electronShell.TryAddAllElectrons(ElectronCount, out var remainder);
            Shells = (electronShell.AllShells);
        }

        public int AtomicNumber { get; }
        public int AtomicMass { get; }
        public int ProtonCount { get; }
        public int NeutronCount { get; }
        public int ElectronCount { get; }
        public IList<ElectronShell> Shells { get; } = new List<ElectronShell>();
    }
}
