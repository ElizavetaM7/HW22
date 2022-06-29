using System;
using HRLibrary;
using NUnit.Framework;


namespace HRLibrary.UnitTests
{
    [TestFixture]
    public class PerfomanceUnitTests
    {
        [Test]
        public void ConstructorTest()
        {

            var viy = CreateTestPerfomance();

            Assert.AreEqual("Viy", viy.Title);
            Assert.AreEqual("The mystical story of N. V. Gogol, first published in his collection Mirgorod.", viy.Description);
            Assert.AreEqual("15.09.2022 19:00", viy.Start);
            Assert.AreEqual("15.29.2022 21:30", viy.Finish);
            Assert.AreEqual("{Finish}-{Start}", viy.Duration);
            Assert.AreEqual(TypePerfomance.Premiere, viy.Type);
            Assert.AreEqual("-30%", viy.Discount);
        }
        [Test]
        public void ToString_Perfomance_Title()
        {
            //var viy = CreateTestPerfomance();
            Assert.AreEqual("Viy", viy.ToString());
        }
        public Perfomance CreateTestPerfomance()
        {
            return new Perfomance("Viy", "The mystical story of N. V. Gogol, first published in his collection Mirgorod.");
        }

    }
}
