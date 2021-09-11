using Examen_T1_Calidad;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokerTest
{
    class PokerUtilitiesTest
    {
        [Test]
        public void PokerCaso01()
        {
            var juego = new Juego();
            juego.cantidadJugadores(1);
            Assert.Throws(typeof(Exception), () => juego.cantidadJugadores(2));
        }
        [Test]
        public void PokerCaso02()
        {
            var juego = new Juego();
            juego.cantidadJugadoresMax();
            Assert.Throws(typeof(Exception), () => juego.numeroDeJugadores(5));
        }
    }
}
