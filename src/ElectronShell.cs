namespace HelloImAnAtom
{
    public class ElectronShell
    {
        private static int OrbitalSetsMax = Enum.GetValues<OrbitalType>().Length;

        public int ShellIndex { get; }

        public OrbitalSet?[] OrbitalSets { get; }

        public IList<ElectronShell> AllShells { get; }

        public bool IsValence => AllShells.LastOrDefault()?.ShellIndex == ShellIndex;

        public ElectronShell(ElectronShell? previous = null)
        {
            Prev = previous;
            ShellIndex = Prev == null ? 0 : Prev.ShellIndex + 1;
            OrbitalSets = new OrbitalSet?[OrbitalSetsMax];
            for (var type = 0; type < OrbitalSetsMax; type++)
            {
                if (ShellIndex >= type)
                {
                    OrbitalSets[type] = OrbitalSet.OfType((OrbitalType)type);
                }
            }
            Prev?.AllShells.Add(this);
            AllShells = Prev?.AllShells ?? new List<ElectronShell> { this };
        }

        public bool TryAddAllElectronsToOrbitals(int electronsToAdd, OrbitalType orbitalType, out int remainder)
        {
            remainder = electronsToAdd;
            var targetOrbitals = OrbitalSets[(int)orbitalType];
            
            if (!targetOrbitals.HasValue)
            {
                return false;
            }

            return targetOrbitals.Value.TryAddAllElectrons(electronsToAdd, out remainder);
        }

        public bool TryAddAllElectrons(int electronsToAdd, out int remainder)
        {
            remainder = electronsToAdd;
            for (var orbitalType = 0; orbitalType < OrbitalSetsMax; orbitalType++)
            {
                var orbital = OrbitalSets[orbitalType];

                if (orbital.HasValue)
                {
                    if (orbital.Value.Full)
                    {
                        continue;
                    }

                    if (orbital.Value.TryAddAllElectrons(electronsToAdd, out electronsToAdd))
                    {
                        return true;
                    }
                }

                // electrons remain - decide whether to go to next orbital set or next shell
                if (Prev == null
                    || orbitalType > 0)
                {
                    Next ??= new ElectronShell(this);
                    return Next.TryAddAllElectrons(electronsToAdd, out electronsToAdd);
                }
            }

            return false;
        }

        public ElectronShell? Next { get; private set; }
        public ElectronShell? Prev { get; }
    }
}
