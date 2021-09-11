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
            var test = new ExceptionTestClass();
            Assert.Throws(typeof(Exception), () => test.CantidadJugadores(1));
        }
        [Test]
        public void PokerCaso02()
        {
            var test = new ExceptionTestClass();
            Assert.Throws(typeof(Exception), () => test.CantidadJugadores(6));
        }
        [Test]
        public void PokerCaso03()
        {
            var jugador = new List<Jugador>();
            jugador.Add(new Jugador() { Nombre = "Jugador1", TipoCarta = "1 espadas" });
            jugador.Add(new Jugador() { Nombre = "Jugador2", TipoCarta = "1 espadas" });

            var t = new ExceptionTestClass();
            Assert.Throws(typeof(Exception), () => t.ComprobarCartasIguales(jugador));
        }
    }
}
