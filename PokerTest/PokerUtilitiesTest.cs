using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokerTest
{
    class PokerUtilitiesTest
    {
        [Test]
        public void VerGanadorCaso01()
        {
            var ganador = new Ganador(new List<Jugador>());
            jugador.Eleccion = "Tijera";
            jugador2.Eleccion = "Papel";
            var result = ganador.VerGanador(jugador, jugador2);
            Assert.AreEqual("gana jugador 1", result);
        }
    }
}
