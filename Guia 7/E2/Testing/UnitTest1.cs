using NUnit.Framework;
using Ejercicio;
using System.Collections.Generic;
using System.Linq;

namespace Testing
{
    public class Tests
    {

        private Niño elniño;
        private Traje traje;
        private AdultoComun adultoComun;
        private Anciano anciano;

        [SetUp]
        public void Setup()
        {
            elniño = new Niño(0,10,0,new Tierno(0),new List<Maquillaje>());
            elniño.ListaDeMaquillajes.Add(new Maquillaje("pintura blanca"));
            adultoComun = new AdultoComun(1);
            anciano = new Anciano();
        }

        [Test]
        public void TestVerificarMetodoCapacidadDeSustoDelNiÑO()
        {
            Assert.AreEqual(50,elniño.capacidadDeSustoDelNiño());
        }

        [Test]
        public void TestHacerQueUnNiñoAsusteAUnAdultoComunYObtenerCaramelos()
        {
            elniño.AsustarAdultoComun(adultoComun);
            Assert.AreEqual(5,elniño.Caramelos);
        }

        [Test]
        public void TestHacerQueUnNiñoAsusteAUnAncianoYObtenerCaramelos()
        {
            elniño.AsustarAnciano(anciano,adultoComun);
            Assert.AreEqual(2.5,elniño.Caramelos);
        }



    }
}