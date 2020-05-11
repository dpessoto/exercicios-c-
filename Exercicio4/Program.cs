using System;

namespace Exercicio3 {
    class Program {
        static void Main(string[] args) {
            //Vericador v1 = new Vericador();
            if (Verificador.v0(p2: 4, p1: 3))
                Console.Write("FALSO");

            else Console.Write("VERDADE");
        }
    }

    public static class Verificador {
        public static bool v0(int p1, int p2) {
            bool ret = false;
            ret = (p1 > p2) ? false : true; //operador ternário
            return ret;
        }
    }
}