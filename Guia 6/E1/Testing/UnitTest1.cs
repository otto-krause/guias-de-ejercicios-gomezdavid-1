using NUnit.Framework;
using Ejercicio;
using System.Collections.Generic;

namespace Testing
{
    public class Tests
    {
        private Arma bastonDeMetal;
        private Arma bombasDeHumo;
        private Robin robin;
        private Raven raven;

        private ChicoBestia chicoBestia;

        [SetUp]
        public void Setup()
        {
            bastonDeMetal = new Arma(15, 10);
            bombasDeHumo = new Arma(14, 89);
            robin = new Robin(new List<Arma> { bastonDeMetal, bombasDeHumo }, 10);
            raven = new Raven(new List<string>(), 2, 4, 0);
            raven.Pensamientos.Add("Extraño a mi Papi");
            raven.Pensamientos.Add("Me quede sin MANTECA");
            raven.Pensamientos.Add("Perdi a Pipo");
            raven.Pensamientos.Add("Voy a comprar pilas para Robocop");
            raven.Pensamientos.Add("¿Donde Esta Pipo?");
            chicoBestia = new ChicoBestia("verde", 2);
        }

        [Test]
        public void TestConocerElPoderDelBastonDeMetal()
        {
            Assert.AreEqual(620, bastonDeMetal.Fuerza());
        }

        [Test]
        public void TestRobinLloraPorRobocop2VecesYSuPoderEs598()
        {
            robin.LlorarPorRobocop();
            robin.LlorarPorRobocop();
            Assert.AreEqual(598, robin.Poder());
        }

        [Test]
        public void TestRavenCome4PorcionesDePizzaYVerSiEstaTriste()
        {
            raven.ComerPizza();
            Assert.AreEqual(true, raven.EstaTriste());
        }

        [Test]
        public void TestHacerQueChicoBestiaComaPizzaYConocerSuPoder()
        {
            chicoBestia.ComerPizza();
            Assert.AreEqual(871, chicoBestia.Poder());
        }

        [Test]
        public void TestHacerQueChicoBestiaComaPizzaYVerSiElPoderDeRavenEsMayorAlDeLosDemasTitanes()
        {
            chicoBestia.ComerPizza();
            Assert.AreEqual(false, raven.Poder() > chicoBestia.Poder() && raven.Poder() > robin.Poder());
        }

        [Test]
        public void TestHacerQueChicoBestiaLlorePorRobocopYVerSuNivelDeTristeza()
        {
            chicoBestia.LlorarPorRobocop();
            Assert.AreEqual(0, chicoBestia.MetodoQueDevuelveLaTristezaDeChicoBesita());
        }

        [Test]
        public void TestHacerQueRavenLlorePorRobocopYLuegoTestearSiEstaTriste()
        {
            raven.LlorarPorRobocop();
            Assert.AreEqual(false, raven.EstaTriste());
        }
    }
}