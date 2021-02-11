using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operazioni;

namespace OperazioniTests
{
    [TestClass]
    public class GestioneTest
    {
        [TestMethod]
        public void TestCalcoloMisterioso()
        {
            int n = 5;
            long valore_aspettato = 240;
            long resp = Gestione.CalcoloMisterioso(n);
            Assert.AreEqual(valore_aspettato, resp);
        }

        [TestMethod]
        public void TestCalcoloMisterioso2Di1()
        {
            int n = 3;
            long valore_aspettato = 12;
            long resp = Gestione.CalcoloMisterioso(n);
            Assert.AreEqual(valore_aspettato, resp);
        }

        [TestMethod]
        public void TestCalcoloMisterioso3Di1()
        {
            int n = 6;
            long valore_aspettato = 1440;
            long resp = Gestione.CalcoloMisterioso(n);
            Assert.AreEqual(valore_aspettato, resp);
        }

        [TestMethod]
        public void TestCalcoloMisterioso2()
        {
            int n = -100;
            long valore_aspettato = -3;
            long resp = Gestione.CalcoloMisterioso2(n);
            Assert.AreEqual(valore_aspettato, resp);
        }

        [TestMethod]
        public void TestCalcoloMisterioso2Di2()
        {
            int n = -78;
            long valore_aspettato = -3;
            long resp = Gestione.CalcoloMisterioso2(n);
            Assert.AreEqual(valore_aspettato, resp);
        }

        [TestMethod]
        public void TestCalcoloMisterioso2Di3()
        {
            int n = -50;
            long valore_aspettato = -3;
            long resp = Gestione.CalcoloMisterioso2(n);
            Assert.AreEqual(valore_aspettato, resp);
        }

        [TestMethod]
        public void TestMisurazioneMisteriosa()
        {
            double[] valori = new double[4] { 4, 6, 7, -9.1 };
            double valore_aspettato = 3;
            double min = Gestione.MisurazioneMisteriosa(valori);
            Assert.AreEqual(valore_aspettato, min);
        }

        [TestMethod]
        public void TestMisurazioneMisteriosa2()
        {
            double[] valori = new double[4] { -4, 6, 7, 9.1 };
            double valore_aspettato = 0;
            double min = Gestione.MisurazioneMisteriosa(valori);
            Assert.AreEqual(valore_aspettato, min);
        }

        [TestMethod]
        public void TestMisurazioneMisteriosa3()
        {
            double[] valori = new double[4] { 4, 6, -7, +9.1 };
            double valore_aspettato = 2;
            double min = Gestione.MisurazioneMisteriosa(valori);
            Assert.AreEqual(valore_aspettato, min);
        }
    }
}
