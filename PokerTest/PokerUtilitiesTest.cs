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
            jugador.TipoCarta = "3 corazones";
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
            Assert.AreEqual("Gana Raúl", result);
        }
        [Test]
        public void PokerCaso14()
        {
            var juego = new Juego(new List<Jugador>());
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "A espadas";
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "3 corazones";
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
            Assert.AreEqual("Empate", result);
        }
        [Test]
        public void PokerCaso15()
        {
            var juego = new Juego(new List<Jugador>());
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "A espadas";
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "3 corazones";
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
            Assert.AreEqual("Empate", result);
        }
        [Test]
        public void PokerCaso16()
        {
            var juego = new Juego(new List<Jugador>());
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "A espadas";
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "3 corazones";
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
            jugador.TipoCarta = "10 trebol";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "K espadas";
            jugador.Nombre = "Pablo";
            jugador.TipoCarta = "A espadas";
            jugador.Nombre = "Pablo";
            jugador.TipoCarta = "A carazones";
            jugador.Nombre = "Pablo";
            jugador.TipoCarta = "A diamante";
            jugador.Nombre = "Pablo";
            jugador.TipoCarta = "A trebol";
            jugador.Nombre = "Pablo";
            jugador.TipoCarta = "K espadas";

            var result = juego.ValidarGanador(jugador.Nombre, jugador.TipoCarta);
            Assert.AreEqual("Gana Pablo", result);
        }
        [Test]
        public void PokerCaso17()
        {
            var juego = new Juego(new List<Jugador>());
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "A espadas";
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "3 corazones";
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
            jugador.TipoCarta = "10 trebol";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "K espadas";
            jugador.Nombre = "Pablo";
            jugador.TipoCarta = "3 espadas";
            jugador.Nombre = "Pablo";
            jugador.TipoCarta = "3 carazones";
            jugador.Nombre = "Pablo";
            jugador.TipoCarta = "3 diamante";
            jugador.Nombre = "Pablo";
            jugador.TipoCarta = "3 trebol";
            jugador.Nombre = "Pablo";
            jugador.TipoCarta = "K espadas";

            var result = juego.ValidarGanador(jugador.Nombre, jugador.TipoCarta);
            Assert.AreEqual("Gana Pablo", result);
        }
        [Test]
        public void PokerCaso18()
        {
            var juego = new Juego(new List<Jugador>());
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "A espadas";
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "3 corazones";
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
            jugador.TipoCarta = "10 trebol";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "K espadas";
            jugador.Nombre = "Pablo";
            jugador.TipoCarta = "A espadas";
            jugador.Nombre = "Pablo";
            jugador.TipoCarta = "A carazones";
            jugador.Nombre = "Pablo";
            jugador.TipoCarta = "A diamante";
            jugador.Nombre = "Pablo";
            jugador.TipoCarta = "A trebol";
            jugador.Nombre = "Pablo";
            jugador.TipoCarta = "K espadas";
            jugador.Nombre = "Júan";
            jugador.TipoCarta = "A espadas";
            jugador.Nombre = "Júan";
            jugador.TipoCarta = "A carazones";
            jugador.Nombre = "Júan";
            jugador.TipoCarta = "A diamante";
            jugador.Nombre = "Júan";
            jugador.TipoCarta = "A trebol";
            jugador.Nombre = "Júan";
            jugador.TipoCarta = "K espadas";

            var result = juego.ValidarGanador(jugador.Nombre, jugador.TipoCarta);
            Assert.AreEqual("Gana Júan", result);
        }
        [Test]
        public void PokerCaso19()
        {
            var juego = new Juego(new List<Jugador>());
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "A espadas";
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "3 corazones";
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
            jugador.TipoCarta = "10 trebol";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "K espadas";
            jugador.Nombre = "Pablo";
            jugador.TipoCarta = "A espadas";
            jugador.Nombre = "Pablo";
            jugador.TipoCarta = "A carazones";
            jugador.Nombre = "Pablo";
            jugador.TipoCarta = "K diamante";
            jugador.Nombre = "Pablo";
            jugador.TipoCarta = "10 trebol";
            jugador.Nombre = "Pablo";
            jugador.TipoCarta = "K espadas";
            jugador.Nombre = "Júan";
            jugador.TipoCarta = "3 espadas";
            jugador.Nombre = "Júan";
            jugador.TipoCarta = "3 carazones";
            jugador.Nombre = "Júan";
            jugador.TipoCarta = "3 diamante";
            jugador.Nombre = "Júan";
            jugador.TipoCarta = "3 trebol";
            jugador.Nombre = "Júan";
            jugador.TipoCarta = "K espadas";

            var result = juego.ValidarGanador(jugador.Nombre, jugador.TipoCarta);
            Assert.AreEqual("Empate", result);
        }
        [Test]
        public void PokerCaso20()
        {
            var juego = new Juego(new List<Jugador>());
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "A espadas";
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "3 corazones";
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
            jugador.TipoCarta = "10 trebol";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "K espadas";
            jugador.Nombre = "Pablo";
            jugador.TipoCarta = "A espadas";
            jugador.Nombre = "Pablo";
            jugador.TipoCarta = "Q carazones";
            jugador.Nombre = "Pablo";
            jugador.TipoCarta = "J diamante";
            jugador.Nombre = "Pablo";
            jugador.TipoCarta = "10 trebol";
            jugador.Nombre = "Pablo";
            jugador.TipoCarta = "K espadas";
            jugador.Nombre = "Júan";
            jugador.TipoCarta = "2 espadas";
            jugador.Nombre = "Júan";
            jugador.TipoCarta = "3 carazones";
            jugador.Nombre = "Júan";
            jugador.TipoCarta = "4 espadas";
            jugador.Nombre = "Júan";
            jugador.TipoCarta = "5 trebol";
            jugador.Nombre = "Júan";
            jugador.TipoCarta = "K espadas";

            var result = juego.ValidarGanador(jugador.Nombre, jugador.TipoCarta);
            Assert.AreEqual("Gana Pablo", result);
        }
        [Test]
        public void PokerCaso21()
        {
            var juego = new Juego(new List<Jugador>());
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "A espadas";
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "3 corazones";
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
            jugador.TipoCarta = "10 trebol";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "K espadas";
            jugador.Nombre = "Pablo";
            jugador.TipoCarta = "8 espadas";
            jugador.Nombre = "Pablo";
            jugador.TipoCarta = "Q carazones";
            jugador.Nombre = "Pablo";
            jugador.TipoCarta = "J diamante";
            jugador.Nombre = "Pablo";
            jugador.TipoCarta = "6 trebol";
            jugador.Nombre = "Pablo";
            jugador.TipoCarta = "K espadas";
            jugador.Nombre = "Júan";
            jugador.TipoCarta = "2 espadas";
            jugador.Nombre = "Júan";
            jugador.TipoCarta = "3 carazones";
            jugador.Nombre = "Júan";
            jugador.TipoCarta = "4 espadas";
            jugador.Nombre = "Júan";
            jugador.TipoCarta = "5 trebol";
            jugador.Nombre = "Júan";
            jugador.TipoCarta = "K espadas";

            var result = juego.ValidarGanador(jugador.Nombre, jugador.TipoCarta);
            Assert.AreEqual("Empate", result);
        }
        [Test]
        public void PokerCaso22()
        {
            var juego = new Juego(new List<Jugador>());
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "A espadas";
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "2 corazones";
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "3 diamantes";
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "5 trebol";
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "6 diamantes";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "10 espadas";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "8 carazones";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "9 diamante";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "A trebol";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "K espadas";
            jugador.Nombre = "Pablo";
            jugador.TipoCarta = "A espadas";
            jugador.Nombre = "Pablo";
            jugador.TipoCarta = "Q carazones";
            jugador.Nombre = "Pablo";
            jugador.TipoCarta = "J diamante";
            jugador.Nombre = "Pablo";
            jugador.TipoCarta = "10 trebol";
            jugador.Nombre = "Pablo";
            jugador.TipoCarta = "K espadas";
            jugador.Nombre = "Júan";
            jugador.TipoCarta = "2 espadas";
            jugador.Nombre = "Júan";
            jugador.TipoCarta = "3 carazones";
            jugador.Nombre = "Júan";
            jugador.TipoCarta = "4 espadas";
            jugador.Nombre = "Júan";
            jugador.TipoCarta = "7 trebol";
            jugador.Nombre = "Júan";
            jugador.TipoCarta = "K espadas";

            var result = juego.ValidarGanador(jugador.Nombre, jugador.TipoCarta);
            Assert.AreEqual("Roberto", result);
        }
        [Test]
        public void PokerCaso23()
        {
            var juego = new Juego(new List<Jugador>());
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "A espadas";
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "2 corazones";
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "3 diamantes";
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "5 trebol";
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "6 diamantes";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "A espadas";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "8 carazones";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "9 diamante";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "A trebol";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "K espadas";
            jugador.Nombre = "Pablo";
            jugador.TipoCarta = "A espadas";
            jugador.Nombre = "Pablo";
            jugador.TipoCarta = "Q carazones";
            jugador.Nombre = "Pablo";
            jugador.TipoCarta = "J diamante";
            jugador.Nombre = "Pablo";
            jugador.TipoCarta = "10 trebol";
            jugador.Nombre = "Pablo";
            jugador.TipoCarta = "K espadas";
            jugador.Nombre = "Júan";
            jugador.TipoCarta = "2 espadas";
            jugador.Nombre = "Júan";
            jugador.TipoCarta = "3 carazones";
            jugador.Nombre = "Júan";
            jugador.TipoCarta = "4 espadas";
            jugador.Nombre = "Júan";
            jugador.TipoCarta = "7 trebol";
            jugador.Nombre = "Júan";
            jugador.TipoCarta = "K espadas";

            var t = new ExceptionTestClass();
            Assert.Throws(typeof(Exception), () => t.ComprobarCartasIguales(jugador.Nombre, jugador.TipoCarta));
        }
        [Test]
        public void PokerCaso24()
        {
            var juego = new Juego(new List<Jugador>());
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "K espadas";
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "2 corazones";
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "3 diamantes";
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "5 trebol";
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "6 diamantes";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "A espadas";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "8 carazones";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "9 diamante";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "A trebol";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "K espadas";
            jugador.Nombre = "Pablo";
            jugador.TipoCarta = "A espadas";
            jugador.Nombre = "Pablo";
            jugador.TipoCarta = "Q carazones";
            jugador.Nombre = "Pablo";
            jugador.TipoCarta = "J diamante";
            jugador.Nombre = "Pablo";
            jugador.TipoCarta = "10 trebol";
            jugador.Nombre = "Pablo";
            jugador.TipoCarta = "K espadas";
            jugador.Nombre = "Júan";
            jugador.TipoCarta = "2 espadas";
            jugador.Nombre = "Júan";
            jugador.TipoCarta = "3 carazones";
            jugador.Nombre = "Júan";
            jugador.TipoCarta = "4 espadas";
            jugador.Nombre = "Júan";
            jugador.TipoCarta = "7 trebol";
            jugador.Nombre = "Júan";
            jugador.TipoCarta = "K espadas";
            jugador.Nombre = "Angel";
            jugador.TipoCarta = "2 espadas";
            jugador.Nombre = "Angel";
            jugador.TipoCarta = "3 carazones";
            jugador.Nombre = "Angel";
            jugador.TipoCarta = "4 espadas";
            jugador.Nombre = "Angel";
            jugador.TipoCarta = "7 trebol";
            jugador.Nombre = "Angel";
            jugador.TipoCarta = "K espadas";

            var t = new ExceptionTestClass();
            Assert.Throws(typeof(Exception), () => t.ComprobarCartasIguales(jugador.Nombre, jugador.TipoCarta));
        }
        [Test]
        public void PokerCaso25()
        {
            var juego = new Juego(new List<Jugador>());
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "K espadas";
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "2 corazones";
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "3 diamantes";
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "5 trebol";
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "6 diamantes";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "A espadas";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "8 carazones";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "9 diamante";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "A trebol";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "K espadas";
            jugador.Nombre = "Pablo";
            jugador.TipoCarta = "A espadas";
            jugador.Nombre = "Pablo";
            jugador.TipoCarta = "Q carazones";
            jugador.Nombre = "Pablo";
            jugador.TipoCarta = "J diamante";
            jugador.Nombre = "Pablo";
            jugador.TipoCarta = "10 trebol";
            jugador.Nombre = "Pablo";
            jugador.TipoCarta = "K espadas";
            jugador.Nombre = "Júan";
            jugador.TipoCarta = "2 espadas";
            jugador.Nombre = "Júan";
            jugador.TipoCarta = "3 carazones";
            jugador.Nombre = "Júan";
            jugador.TipoCarta = "4 espadas";
            jugador.Nombre = "Júan";
            jugador.TipoCarta = "7 trebol";
            jugador.Nombre = "Júan";
            jugador.TipoCarta = "K espadas";
            jugador.Nombre = "Angel";
            jugador.TipoCarta = "2 espadas";
            jugador.Nombre = "Angel";
            jugador.TipoCarta = "3 carazones";
            jugador.Nombre = "Angel";
            jugador.TipoCarta = "4 espadas";
            jugador.Nombre = "Angel";
            jugador.TipoCarta = "7 trebol";
            jugador.Nombre = "Angel";
            jugador.TipoCarta = "K espadas";
            jugador.Nombre = "Luis";
            jugador.TipoCarta = "2 espadas";
            jugador.Nombre = "Luis";
            jugador.TipoCarta = "3 carazones";
            jugador.Nombre = "Luis";
            jugador.TipoCarta = "4 espadas";
            jugador.Nombre = "Luis";
            jugador.TipoCarta = "7 trebol";
            jugador.Nombre = "Luis";
            jugador.TipoCarta = "K espadas";

            var t = new ExceptionTestClass();
            Assert.Throws(typeof(Exception), () => t.ComprobarCartasIguales(jugador.Nombre, jugador.TipoCarta));
            Assert.Throws(typeof(Exception), () => t.CantidadJugadores(jugador.Nombre.Count()));
        }
        [Test]
        public void PokerCaso26()
        {
            var juego = new Juego(new List<Jugador>());
            jugador.Nombre = "Pablo";
            jugador.TipoCarta = "A espadas";
            jugador.Nombre = "Pablo";
            jugador.TipoCarta = "Q carazones";
            jugador.Nombre = "Pablo";
            jugador.TipoCarta = "J diamante";
            jugador.Nombre = "Pablo";
            jugador.TipoCarta = "10 trebol";
            jugador.Nombre = "Pablo";
            jugador.TipoCarta = "K espadas";
            jugador.Nombre = "Júan";
            jugador.TipoCarta = "2 espadas";
            jugador.Nombre = "Júan";
            jugador.TipoCarta = "3 carazones";
            jugador.Nombre = "Júan";
            jugador.TipoCarta = "4 espadas";
            jugador.Nombre = "Júan";
            jugador.TipoCarta = "7 trebol";
            jugador.Nombre = "Júan";
            jugador.TipoCarta = "K espadas";
            jugador.Nombre = "Angel";
            jugador.TipoCarta = "2 espadas";
            jugador.Nombre = "Angel";
            jugador.TipoCarta = "3 carazones";
            jugador.Nombre = "Angel";
            jugador.TipoCarta = "4 espadas";
            jugador.Nombre = "Angel";
            jugador.TipoCarta = "7 trebol";
            jugador.Nombre = "Angel";
            jugador.TipoCarta = "K espadas";
            jugador.Nombre = "Luis";
            jugador.TipoCarta = "2 espadas";
            jugador.Nombre = "Luis";
            jugador.TipoCarta = "3 carazones";
            jugador.Nombre = "Luis";
            jugador.TipoCarta = "4 espadas";
            jugador.Nombre = "Luis";
            jugador.TipoCarta = "7 trebol";
            jugador.Nombre = "Luis";
            jugador.TipoCarta = "K espadas";

            var t = new ExceptionTestClass();
            Assert.Throws(typeof(Exception), () => t.ComprobarCartasIguales(jugador.Nombre, jugador.TipoCarta));
        }
        [Test]
        public void PokerCaso27()
        {
            var juego = new Juego(new List<Jugador>());
            jugador.Nombre = "Pablo";
            jugador.TipoCarta = "A espadas";
            jugador.Nombre = "Pablo";
            jugador.TipoCarta = "2 carazones";
            jugador.Nombre = "Pablo";
            jugador.TipoCarta = "3 diamante";
            jugador.Nombre = "Pablo";
            jugador.TipoCarta = "4 trebol";
            jugador.Nombre = "Pablo";
            jugador.TipoCarta = "5 espadas";
            jugador.Nombre = "Júan";
            jugador.TipoCarta = "6 espadas";
            jugador.Nombre = "Júan";
            jugador.TipoCarta = "7 carazones";
            jugador.Nombre = "Júan";
            jugador.TipoCarta = "8 espadas";
            jugador.Nombre = "Júan";
            jugador.TipoCarta = "9 trebol";
            jugador.Nombre = "Júan";
            jugador.TipoCarta = "10 espadas";
            jugador.Nombre = "Angel";
            jugador.TipoCarta = "J espadas";
            jugador.Nombre = "Angel";
            jugador.TipoCarta = "Q carazones";
            jugador.Nombre = "Angel";
            jugador.TipoCarta = "K diamantes";
            jugador.Nombre = "Angel";
            jugador.TipoCarta = "7 trebol";
            jugador.Nombre = "Angel";
            jugador.TipoCarta = "K espadas";
            jugador.Nombre = "Luis";
            jugador.TipoCarta = "6 espadas";
            jugador.Nombre = "Luis";
            jugador.TipoCarta = "6 carazones";
            jugador.Nombre = "Luis";
            jugador.TipoCarta = "6 diamantes";
            jugador.Nombre = "Luis";
            jugador.TipoCarta = "3 trebol";
            jugador.Nombre = "Luis";
            jugador.TipoCarta = "3 espadas";

            var result = juego.ValidarGanador(jugador.Nombre, jugador.TipoCarta);
            Assert.AreEqual("Gana Luis", result);
        }
        [Test]
        public void PokerCaso28()
        {
            var juego = new Juego(new List<Jugador>());
            jugador.Nombre = "Júan";
            jugador.TipoCarta = "6 espadas";
            jugador.Nombre = "Júan";
            jugador.TipoCarta = "7 carazones";
            jugador.Nombre = "Júan";
            jugador.TipoCarta = "8 espadas";
            jugador.Nombre = "Júan";
            jugador.TipoCarta = "9 trebol";
            jugador.Nombre = "Júan";
            jugador.TipoCarta = "10 espadas";
            jugador.Nombre = "Angel";
            jugador.TipoCarta = "4 trebol";
            jugador.Nombre = "Angel";
            jugador.TipoCarta = "5 trebol";
            jugador.Nombre = "Angel";
            jugador.TipoCarta = "6 treblo";
            jugador.Nombre = "Angel";
            jugador.TipoCarta = "7 trebol";
            jugador.Nombre = "Angel";
            jugador.TipoCarta = "8 trebol";

            var result = juego.ValidarGanador(jugador.Nombre, jugador.TipoCarta);
            Assert.AreEqual("Gana Angel", result);
        }
        [Test]
        public void PokerCaso29()
        {
            var juego = new Juego(new List<Jugador>());
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "A trebol";
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "2 trebol";
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "4 trebol";
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "5 trebol";
            jugador.Nombre = "Roberto";
            jugador.TipoCarta = "J trebol";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "Q trebol";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "3 trebol";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "6 trebol";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "7 trebol";
            jugador.Nombre = "Raúl";
            jugador.TipoCarta = "10 trebol";
            jugador.Nombre = "Angel";
            jugador.TipoCarta = "8 trebol";
            jugador.Nombre = "Angel";
            jugador.TipoCarta = "9 trebol";
            jugador.Nombre = "Angel";
            jugador.TipoCarta = "K trebol";
            jugador.Nombre = "Angel";
            jugador.TipoCarta = "J corazones";
            jugador.Nombre = "Angel";
            jugador.TipoCarta = "10 Corazones";
            jugador.Nombre = "Paul";
            jugador.TipoCarta = "A Corazones";
            jugador.Nombre = "Paul";
            jugador.TipoCarta = "4 Corazones";
            jugador.Nombre = "Paul";
            jugador.TipoCarta = "K Corazones";
            jugador.Nombre = "Paul";
            jugador.TipoCarta = "J corazones";
            jugador.Nombre = "Paul";
            jugador.TipoCarta = "7 corazones";
            jugador.Nombre = "Paco";
            jugador.TipoCarta = "A espadas";
            jugador.Nombre = "Paco";
            jugador.TipoCarta = "4 espadas";
            jugador.Nombre = "Paco";
            jugador.TipoCarta = "K espadas";
            jugador.Nombre = "Paco";
            jugador.TipoCarta = "J espadas";
            jugador.Nombre = "Paco";
            jugador.TipoCarta = "7 espadas";
            jugador.Nombre = "Alfredo";
            jugador.TipoCarta = "A diamantes";
            jugador.Nombre = "Alfredo";
            jugador.TipoCarta = "4 diamantes";
            jugador.Nombre = "Alfredo";
            jugador.TipoCarta = "K diamantes";
            jugador.Nombre = "Alfredo";
            jugador.TipoCarta = "J diamantes";
            jugador.Nombre = "Alfredo";
            jugador.TipoCarta = "7 diamantes";

            var test = new ExceptionTestClass();
            Assert.Throws(typeof(Exception), () => test.CantidadJugadores(jugador.Nombre.Count()));
        }
        [Test]
        public void PokerCaso30()
        {
            var jugador = new List<Jugador>();
            var test = new ExceptionTestClass();
            Assert.Throws(typeof(Exception), () => test.CantidadJugadores(jugador.Count()));
        }
    }
}
