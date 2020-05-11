using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
