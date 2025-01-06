using HelloImAnAtom;
using NuGet.Frameworks;

namespace Tests
{
    [TestFixture]
    public class NobleGasesTests
    {
        [Test]
        public void TestHelium()
        {
            // Arrange / Act
            var helium = new Atom(2, 4);

            // Assert
            Assert.That(helium.ProtonCount, Is.EqualTo(2));
            Assert.That(helium.NeutronCount, Is.EqualTo(2));
            Assert.That(helium.ElectronCount, Is.EqualTo(2));
            Assert.That(helium.Shells.Count, Is.EqualTo(1));
            Assert.That(helium.Shells[0]!.ShellIndex, Is.EqualTo(0));
            Assert.That(helium.Shells[0]!.IsValence, Is.True);
            Assert.That(helium.Shells[0]!.OrbitalSets[(int)OrbitalType.S]!.Full, Is.True);
        }

        [Test]
        public void TestNeon()
        {
            // Arrange / Act
            var neon = new Atom(10, 20);

            // Assert
            Assert.That(neon.ProtonCount, Is.EqualTo(10));
            Assert.That(neon.NeutronCount, Is.EqualTo(10));
            Assert.That(neon.ElectronCount, Is.EqualTo(10));
            Assert.That(neon.Shells.Count, Is.EqualTo(2));
            Assert.That(neon.Shells[0]!.ShellIndex, Is.EqualTo(0));
            Assert.That(neon.Shells[0]!.IsValence, Is.False);
            Assert.That(neon.Shells[0]!.OrbitalSets[(int)OrbitalType.S]!.Full, Is.True);
            Assert.That(neon.Shells[0]!.OrbitalSets[(int)OrbitalType.P], Is.Null);
            Assert.That(neon.Shells[1]!.ShellIndex, Is.EqualTo(1));
            Assert.That(neon.Shells[1]!.IsValence, Is.True);
            Assert.That(neon.Shells[1]!.OrbitalSets[(int)OrbitalType.S]!.Full, Is.True);
            Assert.That(neon.Shells[1]!.OrbitalSets[(int)OrbitalType.P]!.Full, Is.True);
        }

        [Test]
        public void TestArgon()
        {
            // Arrange / Act
            var argon = new Atom(18, 40);

            // Assert
            Assert.That(argon.ProtonCount, Is.EqualTo(18));
            Assert.That(argon.NeutronCount, Is.EqualTo(22));
            Assert.That(argon.ElectronCount, Is.EqualTo(18));
            Assert.That(argon.Shells.Count, Is.EqualTo(3));
            Assert.That(argon.Shells[0]!.ShellIndex, Is.EqualTo(0));
            Assert.That(argon.Shells[0]!.IsValence, Is.False);
            Assert.That(argon.Shells[0]!.OrbitalSets[(int)OrbitalType.S]!.Full, Is.True);
            Assert.That(argon.Shells[0]!.OrbitalSets[(int)OrbitalType.P], Is.Null);
            Assert.That(argon.Shells[1]!.ShellIndex, Is.EqualTo(1));
            Assert.That(argon.Shells[1]!.IsValence, Is.False);
            Assert.That(argon.Shells[1]!.OrbitalSets[(int)OrbitalType.S]!.Full, Is.True);
            Assert.That(argon.Shells[1]!.OrbitalSets[(int)OrbitalType.P]!.Full, Is.True);
            Assert.That(argon.Shells[1]!.OrbitalSets[(int)OrbitalType.D], Is.Null);
            Assert.That(argon.Shells[2]!.ShellIndex, Is.EqualTo(2));
            Assert.That(argon.Shells[2]!.IsValence, Is.True);
            Assert.That(argon.Shells[2]!.OrbitalSets[(int)OrbitalType.S]!.Full, Is.True);
            Assert.That(argon.Shells[2]!.OrbitalSets[(int)OrbitalType.P]!.Full, Is.True);
        }

        [Test]
        public void TestKrypton()
        {
            // Arrange / Act
            var krypton = new Atom(36, 84);

            // Assert
            Assert.That(krypton.ProtonCount, Is.EqualTo(36));
            Assert.That(krypton.NeutronCount, Is.EqualTo(48));
            Assert.That(krypton.ElectronCount, Is.EqualTo(36));
            Assert.That(krypton.Shells.Count, Is.EqualTo(4));
            Assert.That(krypton.Shells[0]!.ShellIndex, Is.EqualTo(0));
            Assert.That(krypton.Shells[0]!.IsValence, Is.False);
            Assert.That(krypton.Shells[0]!.OrbitalSets[(int)OrbitalType.S]!.Full, Is.True);
            Assert.That(krypton.Shells[0]!.OrbitalSets[(int)OrbitalType.P], Is.Null);
            Assert.That(krypton.Shells[1]!.ShellIndex, Is.EqualTo(1));
            Assert.That(krypton.Shells[1]!.IsValence, Is.False);
            Assert.That(krypton.Shells[1]!.OrbitalSets[(int)OrbitalType.S]!.Full, Is.True);
            Assert.That(krypton.Shells[1]!.OrbitalSets[(int)OrbitalType.P]!.Full, Is.True);
            Assert.That(krypton.Shells[1]!.OrbitalSets[(int)OrbitalType.D], Is.Null);
            Assert.That(krypton.Shells[2]!.ShellIndex, Is.EqualTo(2));
            Assert.That(krypton.Shells[2]!.IsValence, Is.False);
            Assert.That(krypton.Shells[2]!.OrbitalSets[(int)OrbitalType.S]!.Full, Is.True);
            Assert.That(krypton.Shells[2]!.OrbitalSets[(int)OrbitalType.P]!.Full, Is.True);
            Assert.That(krypton.Shells[2]!.OrbitalSets[(int)OrbitalType.D]!.Full, Is.True);
            Assert.That(krypton.Shells[3]!.ShellIndex, Is.EqualTo(3));
            Assert.That(krypton.Shells[3]!.IsValence, Is.True);
            Assert.That(krypton.Shells[3]!.OrbitalSets[(int)OrbitalType.S]!.Full, Is.True);
            Assert.That(krypton.Shells[3]!.OrbitalSets[(int)OrbitalType.P]!.Full, Is.True);
        }

        [Test]
        public void TestXenon()
        {
            // Arrange / Act
            var xenon = new Atom(54, 131);

            // Assert
            Assert.That(xenon.ProtonCount, Is.EqualTo(54));
            Assert.That(xenon.NeutronCount, Is.EqualTo(77));
            Assert.That(xenon.ElectronCount, Is.EqualTo(54));
            Assert.That(xenon.Shells.Count, Is.EqualTo(5));
            Assert.That(xenon.Shells[0]!.ShellIndex, Is.EqualTo(0));
            Assert.That(xenon.Shells[0]!.IsValence, Is.False);
            Assert.That(xenon.Shells[0]!.OrbitalSets[(int)OrbitalType.S]!.Full, Is.True);
            Assert.That(xenon.Shells[0]!.OrbitalSets[(int)OrbitalType.P], Is.Null);
            Assert.That(xenon.Shells[1]!.ShellIndex, Is.EqualTo(1));
            Assert.That(xenon.Shells[1]!.IsValence, Is.False);
            Assert.That(xenon.Shells[1]!.OrbitalSets[(int)OrbitalType.S]!.Full, Is.True);
            Assert.That(xenon.Shells[1]!.OrbitalSets[(int)OrbitalType.P]!.Full, Is.True);
            Assert.That(xenon.Shells[1]!.OrbitalSets[(int)OrbitalType.D], Is.Null);
            Assert.That(xenon.Shells[2]!.ShellIndex, Is.EqualTo(2));
            Assert.That(xenon.Shells[2]!.IsValence, Is.False);
            Assert.That(xenon.Shells[2]!.OrbitalSets[(int)OrbitalType.S]!.Full, Is.True);
            Assert.That(xenon.Shells[2]!.OrbitalSets[(int)OrbitalType.P]!.Full, Is.True);
            Assert.That(xenon.Shells[2]!.OrbitalSets[(int)OrbitalType.D]!.Full, Is.True);
            Assert.That(xenon.Shells[2]!.OrbitalSets[(int)OrbitalType.F], Is.Null);
            Assert.That(xenon.Shells[3]!.ShellIndex, Is.EqualTo(3));
            Assert.That(xenon.Shells[3]!.IsValence, Is.False);
            Assert.That(xenon.Shells[3]!.OrbitalSets[(int)OrbitalType.S]!.Full, Is.True);
            Assert.That(xenon.Shells[3]!.OrbitalSets[(int)OrbitalType.P]!.Full, Is.True);
            Assert.That(xenon.Shells[3]!.OrbitalSets[(int)OrbitalType.D]!.Full, Is.True);
            Assert.That(xenon.Shells[3]!.OrbitalSets[(int)OrbitalType.F]!.CurrentElectronCount, Is.Zero);
            Assert.That(xenon.Shells[4]!.ShellIndex, Is.EqualTo(4));
            Assert.That(xenon.Shells[4]!.IsValence, Is.True);
            Assert.That(xenon.Shells[4]!.OrbitalSets[(int)OrbitalType.S]!.Full, Is.True);
            Assert.That(xenon.Shells[4]!.OrbitalSets[(int)OrbitalType.P]!.Full, Is.True);
            Assert.That(xenon.Shells[4]!.OrbitalSets[(int)OrbitalType.D]!.CurrentElectronCount, Is.Zero);
            Assert.That(xenon.Shells[4]!.OrbitalSets[(int)OrbitalType.D]!.Full, Is.False);
            Assert.That(xenon.Shells[4]!.OrbitalSets[(int)OrbitalType.F]!.CurrentElectronCount, Is.Zero);
            Assert.That(xenon.Shells[4]!.OrbitalSets[(int)OrbitalType.F]!.Full, Is.False);
        }

        [Test]
        public void TestRadon()
        {
            // Arrange / Act
            var radon = new Atom(86, 222);

            // Assert
            Assert.That(radon.ProtonCount, Is.EqualTo(86));
            Assert.That(radon.NeutronCount, Is.EqualTo(136));
            Assert.That(radon.ElectronCount, Is.EqualTo(86));
            Assert.That(radon.Shells.Count, Is.EqualTo(6));
            Assert.That(radon.Shells[0]!.ShellIndex, Is.EqualTo(0));
            Assert.That(radon.Shells[0]!.IsValence, Is.False);
            Assert.That(radon.Shells[0]!.OrbitalSets[(int)OrbitalType.S]!.Full, Is.True);
            Assert.That(radon.Shells[0]!.OrbitalSets[(int)OrbitalType.P], Is.Null);
            Assert.That(radon.Shells[1]!.ShellIndex, Is.EqualTo(1));
            Assert.That(radon.Shells[1]!.IsValence, Is.False);
            Assert.That(radon.Shells[1]!.OrbitalSets[(int)OrbitalType.S]!.Full, Is.True);
            Assert.That(radon.Shells[1]!.OrbitalSets[(int)OrbitalType.P]!.Full, Is.True);
            Assert.That(radon.Shells[1]!.OrbitalSets[(int)OrbitalType.D], Is.Null);
            Assert.That(radon.Shells[2]!.ShellIndex, Is.EqualTo(2));
            Assert.That(radon.Shells[2]!.IsValence, Is.False);
            Assert.That(radon.Shells[2]!.OrbitalSets[(int)OrbitalType.S]!.Full, Is.True);
            Assert.That(radon.Shells[2]!.OrbitalSets[(int)OrbitalType.P]!.Full, Is.True);
            Assert.That(radon.Shells[2]!.OrbitalSets[(int)OrbitalType.D]!.Full, Is.True);
            Assert.That(radon.Shells[2]!.OrbitalSets[(int)OrbitalType.F], Is.Null);
            Assert.That(radon.Shells[3]!.ShellIndex, Is.EqualTo(3));    
            Assert.That(radon.Shells[3]!.IsValence, Is.False);
            Assert.That(radon.Shells[3]!.OrbitalSets[(int)OrbitalType.S]!.Full, Is.True);
            Assert.That(radon.Shells[3]!.OrbitalSets[(int)OrbitalType.P]!.Full, Is.True);
            Assert.That(radon.Shells[3]!.OrbitalSets[(int)OrbitalType.D]!.Full, Is.True);
            Assert.That(radon.Shells[3]!.OrbitalSets[(int)OrbitalType.F]!.Full, Is.True);
            Assert.That(radon.Shells[4]!.ShellIndex, Is.EqualTo(4));
            Assert.That(radon.Shells[4]!.IsValence, Is.False);
            Assert.That(radon.Shells[4]!.OrbitalSets[(int)OrbitalType.S]!.Full, Is.True);
            Assert.That(radon.Shells[4]!.OrbitalSets[(int)OrbitalType.P]!.Full, Is.True);
            Assert.That(radon.Shells[4]!.OrbitalSets[(int)OrbitalType.D]!.Full, Is.True);
            Assert.That(radon.Shells[4]!.OrbitalSets[(int)OrbitalType.F]!.CurrentElectronCount, Is.Zero);
            Assert.That(radon.Shells[4]!.OrbitalSets[(int)OrbitalType.F]!.Full, Is.False);
            Assert.That(radon.Shells[5]!.ShellIndex, Is.EqualTo(5));
            Assert.That(radon.Shells[5]!.IsValence, Is.True);
            Assert.That(radon.Shells[5]!.OrbitalSets[(int)OrbitalType.S]!.Full, Is.True);
            Assert.That(radon.Shells[5]!.OrbitalSets[(int)OrbitalType.P]!.Full, Is.True);
            Assert.That(radon.Shells[5]!.OrbitalSets[(int)OrbitalType.D]!.CurrentElectronCount, Is.Zero);
            Assert.That(radon.Shells[5]!.OrbitalSets[(int)OrbitalType.D]!.Full, Is.False);
            Assert.That(radon.Shells[5]!.OrbitalSets[(int)OrbitalType.F]!.CurrentElectronCount, Is.Zero);
            Assert.That(radon.Shells[5]!.OrbitalSets[(int)OrbitalType.F]!.Full, Is.False);

        }
    }
}