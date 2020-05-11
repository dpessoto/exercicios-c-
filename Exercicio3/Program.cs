using System;

namespace Exercicio3 {
    class Program {
        static void Main(string[] args) {
            Vericador v1 = new Vericador();
            if (v1.v0(p2: 4, p1: 3))
                Console.Write("FALSO");

            else Console.Write("VERDADE");
        }
    }

    public class Vericador {
        public bool v0(int p1, int p2) {
            bool ret = false;
            ret = (p1 > p2) ? false : true; //operador ternário
            return ret;
        }
    }
}