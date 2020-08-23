using NUnit.Framework;
using Ejercicio;
using System.Collections.Generic;

namespace Testing
{
    public class Tests
    {
        
        private Mago HarryPostre;
        private Receta receta;
        //private Ingrediente ingrediente;

        [SetUp]
        public void Setup()
        {
            HarryPostre = new Mago(new VaritaDeCarpe(0),new List<Receta>());
            receta = new Receta(new List<Ingrediente>(),new List<int>());
            HarryPostre.ListaDeRecetas.Add(new Receta(new List<Ingrediente>{new Ingrediente(4000,"Ingrediente 1"),new Ingrediente(400,"Ingrediente 2"),new Ingrediente(400,"Ingrediente 3")},new List<int>{3}));
            HarryPostre.ListaDeRecetas.Add(new Receta(new List<Ingrediente>{new Ingrediente(400,"Ingrediente 1"),new Ingrediente(400,"Ingrediente 2"),new Ingrediente(400,"Ingrediente 3")},new List<int>{3}));
        }

        [Test]
        public void TestParaSaberSiTodasLasRecetasSonDeGordo()
        {
            Assert.AreEqual(true,receta.EsDeGordo());
        }
    }
}