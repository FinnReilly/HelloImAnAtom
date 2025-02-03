using HelloImAnAtom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestFixture]
    public class TransitionMetalsTests
    {
        [Test]
        public void TestCopper()
        {
            // Arrange / Act
            var copper = new Atom(29, 65);

            // Assert
            Assert.That(copper.AtomicMass, Is.EqualTo(65));
            Assert.That(copper.AtomicNumber, Is.EqualTo(29));
            Assert.That(copper.ProtonCount, Is.EqualTo(29));
            Assert.That(copper.NeutronCount, Is.EqualTo(36));
            Assert.That(copper.Shells.Count, Is.EqualTo(4));
            Assert.That(copper.Shells[0].OrbitalSets[(int)OrbitalType.S]?.CurrentElectronCount, Is.EqualTo(2));
            Assert.That(copper.Shells[1].OrbitalSets[(int)OrbitalType.S]?.CurrentElectronCount, Is.EqualTo(2));
            Assert.That(copper.Shells[1].OrbitalSets[(int)OrbitalType.P]?.CurrentElectronCount, Is.EqualTo(6));
            Assert.That(copper.Shells[2].OrbitalSets[(int)OrbitalType.S]?.CurrentElectronCount, Is.EqualTo(2));
            Assert.That(copper.Shells[2].OrbitalSets[(int)OrbitalType.P]?.CurrentElectronCount, Is.EqualTo(6));
            Assert.That(copper.Shells[2].OrbitalSets[(int)OrbitalType.D]?.CurrentElectronCount, Is.EqualTo(10));
            Assert.That(copper.Shells[3].OrbitalSets[(int)OrbitalType.S]?.CurrentElectronCount, Is.EqualTo(1));
        }
    }
}
