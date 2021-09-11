using Examen_T1_Calidad;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokerTest
{
    class PokerUtilitiesTest
    {
        private Jugador jugador;
        [Test]
        public void PokerCaso01()
        {
            var jugador = new List<Jugador>();
            jugador.Add(new Jugador() { Nombre = "Roberto" });
            var test = new ExceptionTestClass();
            Assert.Throws(typeof(Exception), () => test.CantidadJugadores(jugador.Count()));
        }
        [Test]
        public void PokerCaso02()
        {
            var jugador = new List<Jugador>();
            jugador.Add(new Jugador() { Nombre = "Roberto" });
            jugador.Add(new Jugador() { Nombre = "Juan" });
            jugador.Add(new Jugador() { Nombre = "Luis" });
            jugador.Add(new Jugador() { Nombre = "Enrique" });
            jugador.Add(new Jugador() { Nombre = "Juan" });
            jugador.Add(new Jugador() { Nombre = "Pablo" });
            var test = new ExceptionTestClass();
            Assert.Throws(typeof(Exception), () => test.CantidadJugadores(jugador.Count()));
        }
        [Test]
        public void PokerCaso03()
        {
            var jugador = new Jugador ();
            jugador.Nombre = "Juan";
            jugador.TipoCarta = "1 espadas";
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "1 espadas";
            var t = new ExceptionTestClass();
            Assert.Throws(typeof(Exception), () => t.ComprobarCartasIguales(jugador.Nombre, jugador.TipoCarta));
        }
        [Test]
        public void PokerCaso04()
        {
            var juego = new Juego(new List<Jugador>());
            jugador.Nombre = "Juan";
            jugador.TipoCarta = "10 espadas";
            jugador.Nombre = "Juan";
            jugador.TipoCarta = "J espadas";
            jugador.Nombre = "Juan";
            jugador.TipoCarta = "Q espadas";
            jugador.Nombre = "Juan"; 
            jugador.TipoCarta = "K espadas";
            jugador.Nombre = "Juan";
            jugador.TipoCarta = "A espadas";
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "J espadas";
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "Q espadas";
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "A espadas";
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "9 espadas";
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "7 espadas";

            var result = juego.ValidarEscaleraReal(jugador.Nombre,jugador.TipoCarta);
            Assert.AreEqual("Gana Juan", result);
        }
        [Test]
        public void PokerCaso05()
        {
            var juego = new Juego(new List<Jugador>());
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "8 espadas";
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "8 corazones";
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "8 diamantes";
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "8 trebol";
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "JOKER";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "J espadas";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "Q espadas";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "A espadas";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "9 espadas";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "7 espadas";

            var result = juego.ValidarRePoker(jugador.Nombre, jugador.TipoCarta);
            Assert.AreEqual("Gana Roberto", result);
        }
        [Test]
        public void PokerCaso06()
        {
            var juego = new Juego(new List<Jugador>());
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "4 espadas";
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "8 corazones";
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "1 diamantes";
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "2 trebol";
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "JOKER";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "7 espadas";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "8 espadas";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "9 espadas";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "10 espadas";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "11 espadas";

            var result = juego.ValidarEscaleraColor(jugador.Nombre, jugador.TipoCarta);
            Assert.AreEqual("Gana Raúl", result);
        }
        [Test]
        public void PokerCaso07()
        {
            var juego = new Juego(new List<Jugador>());
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "4 espadas";
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "8 corazones";
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "1 diamantes";
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "2 trebol";
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "A corazones";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "3 espadas";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "9 carazones";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "9 diamante";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "9 trebol";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "9 espadas";

            var result = juego.ValidarPoker(jugador.Nombre, jugador.TipoCarta);
            Assert.AreEqual("Gana Raúl", result);
        }
        [Test]
        public void PokerCaso08()
        {
            var juego = new Juego(new List<Jugador>());
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "6 espadas";
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "6 corazones";
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "6 diamantes";
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "3 trebol";
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "3 diamantes";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "3 espadas";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "8 carazones";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "9 diamante";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "A trebol";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "K espadas";

            var result = juego.ValidarFull(jugador.Nombre, jugador.TipoCarta);
            Assert.AreEqual("Gana Roberto", result);
        }
        [Test]
        public void PokerCaso09()
        {
            var juego = new Juego(new List<Jugador>());
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "1 espadas";
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "2 corazones";
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "3 diamantes";
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "4 trebol";
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "5 diamantes";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "3 espadas";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "8 carazones";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "9 diamante";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "A trebol";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "K espadas";

            var result = juego.ValidarEscalera(jugador.Nombre, jugador.TipoCarta);
            Assert.AreEqual("Gana Roberto", result);
        }
        [Test]
        public void PokerCaso10()
        {
            var juego = new Juego(new List<Jugador>());
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "A espadas";
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "A corazones";
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "A diamantes";
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "4 trebol";
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "5 diamantes";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "3 espadas";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "8 carazones";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "9 diamante";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "A trebol";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "K espadas";

            var result = juego.ValidarTrio(jugador.Nombre, jugador.TipoCarta);
            Assert.AreEqual("Gana Roberto", result);
        }
        [Test]
        public void PokerCaso11()
        {
            var juego = new Juego(new List<Jugador>());
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "A espadas";
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "A corazones";
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "4 diamantes";
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "4 trebol";
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "5 diamantes";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "3 espadas";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "8 carazones";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "9 diamante";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "A trebol";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "K espadas";

            var result = juego.ValidarDoblePareja(jugador.Nombre, jugador.TipoCarta);
            Assert.AreEqual("Gana Roberto", result);
        }
        [Test]
        public void PokerCaso12()
        {
            var juego = new Juego(new List<Jugador>());
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "K espadas";
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "K corazones";
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "2 diamantes";
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "4 trebol";
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "5 diamantes";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "3 espadas";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "8 carazones";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "9 diamante";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "A trebol";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "K espadas";

            var result = juego.ValidarPareja(jugador.Nombre, jugador.TipoCarta);
            Assert.AreEqual("Gana Roberto", result);
        }
        [Test]
        public void PokerCaso13()
        {
            var juego = new Juego(new List<Jugador>());
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "K espadas";
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "K corazones";
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "2 diamantes";
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "4 trebol";
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "5 diamantes";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "3 espadas";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "8 carazones";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "9 diamante";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "A trebol";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "K espadas";

            var result = juego.ValidarCartaMasAlta(jugador.Nombre, jugador.TipoCarta);
            Assert.AreEqual("Gana Roberto", result);
        }
    }
}
