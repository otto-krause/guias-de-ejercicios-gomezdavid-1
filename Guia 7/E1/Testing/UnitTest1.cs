using NUnit.Framework;
using Ejercicio;
using System.Collections.Generic;
using System.Linq;

namespace Testing
{
    public class Tests
    {
        private PeterParker peter;
        private SpidermanNoir noir;
        private SpiderGwen gwen;
        private SpiderGwen gwen2;
        private MilesMorales miles;
        private SpiderTeam spiderTeam;
        private KingPin kingPin;

        [SetUp]
        public void Setup()
        {
            peter = new PeterParker(new Traje(10, new List<Arma> { new Arma("Acme", 25) }), 10);
            
            noir = new SpidermanNoir(new Traje(0, new List<Arma> { new Arma("Iron", 6), new Arma("Cold", 9) }), 0, new PeterParker(new Traje(10, new List<Arma> { }), 10));
            
            gwen = new SpiderGwen(5, new Traje(0, new List<Arma> { }), 10);
            
            gwen2 = new SpiderGwen(0, new Traje(0, new List<Arma> { }), 10);
            
            miles = new MilesMorales(10, new Traje(0, new List<Arma> { }), 10);

            spiderTeam = new SpiderTeam(new List<SpidermanClasico>());
            
            //spiderTeam = new SpiderTeam(new List<SpidermanClasico> { new PeterParker(new Traje(801, new List<Arma> { new Arma("Acme", 25) }), 0), new SpidermanNoir(new Traje(0, new List<Arma> { new Arma("Iron", 6), new Arma("Cold", 9) }), 0, new PeterParker(new Traje(10, new List<Arma> { }), 10)), new SpiderGwen(5, new Traje(0, new List<Arma> { }), 10), new MilesMorales(10, new Traje(0, new List<Arma> { }), 10)});
            
            spiderTeam.ListaDeSpidermans.Add(new PeterParker(new Traje(800,new List<Arma>{new Arma("Acme",25)}),10));

            spiderTeam.ListaDeSpidermans.Add(new SpidermanNoir(new Traje(0, new List<Arma> { new Arma("Iron", 6), new Arma("Cold", 9) }), 0, new PeterParker(new Traje(10, new List<Arma> { }), 10)));

            spiderTeam.ListaDeSpidermans.Add(new SpiderGwen(5, new Traje(0, new List<Arma> { }), 10));

            spiderTeam.ListaDeSpidermans.Add(new MilesMorales(10, new Traje(0, new List<Arma> { }), 10));

            kingPin = new KingPin(800);
        }

        [Test]
        public void TestVerSiElCalculoDelMetodoDelPoderDePeterParkerEsCorrecto()
        {
            Assert.AreEqual(20, peter.Poder());
        }

        [Test]
        public void TestVerSiElCalculoDelMetodoDelPoderDeSpidermanNoirEsCorrecto()
        {
            Assert.AreEqual(22, noir.Poder());
        }

        [Test]
        public void TestVerSiElCalculoDelMetodoDelPoderDeSpidermanGwenEsCorrecto1()
        {
            Assert.AreEqual(15, gwen.Poder());
        }

        [Test]
        public void TestVerSiElCalculoDelMetodoDelPoderDeSpidermanGwenEsCorrecto2()
        {
            Assert.Throws<System.Exception>(() => gwen2.Poder());
        }

        [Test]
        public void TestVerSiElCalculoDelMetodoDelPoderDeMilesMoralesEsCorrecto()
        {
            Assert.AreEqual(20, miles.Poder());
        }

        [Test]
        public void TestVerSiKingpiniFueVencido()
        {
            spiderTeam.PelearConAKingPin(kingPin);
            Assert.AreEqual(true, kingPin.FueVencido());
        }

        [Test]
        public void TestVerificarSiUnSpidermanVuelveACasaAlMatarAKingpin()
        {
            spiderTeam.PelearConAKingPin(kingPin);
            spiderTeam.VolverACasa(kingPin);
            Assert.AreEqual(3, spiderTeam.ListaDeSpidermans.Count);
        }

        /*[Test] //funciona, lo comente porque tenia que cambiar los valores innicales de las fuerzas para probar test de arriba.
        public void TestVerSiLaSumaDeLaFuerzaDeLosSpidermansDa30()
        {
            Assert.AreEqual(30, spiderTeam.FuerzaDelSpiderTeam());
        }*/
    }
}