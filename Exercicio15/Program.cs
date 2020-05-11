using System;

namespace Exercicio15 {
    class Program {
        static void Main(string[] args) {
        }

    }

    class Clock {
        static Clock relogio;
        Clock() { }
        public static Clock Instance() {
            if (relogio == null) {
                relogio = new Clock();
            }
            return relogio;
        }
    }
}
