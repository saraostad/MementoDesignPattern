using MementoDesignPattern_SalesProspect;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestMementoDesignPattern
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            SalesProspect s = new SalesProspect();
            s.Name = "Noel van Halen";
            s.Phone = "(412) 256-0990";
            s.Budget = 25000.0;

            //act
            ProspectMemory m = new ProspectMemory();
            m.Memento = s.SaveMemento();
            // Continue changing originator
            s.Name = "Leo Welch";
            s.Phone = "(310) 209-7111";
            s.Budget = 1000000.0;

            // Restore saved state
            s.RestoreMemento(m.Memento);

            //expect
            Assert.AreEqual(s.Budget, 25000.0);
        }
    }
}
