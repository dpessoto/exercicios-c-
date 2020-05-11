using System;

namespace Exercicio8 {
    class Program {
        static void Main(string[] args) {

            Registro registro = new Registro();

            int n1 = 9;
            int n2;

            Console.WriteLine(registro.Ref01(2, 4));
            Console.WriteLine(registro.Ref02(ref n1, out n2)); 
            Console.WriteLine(registro.Ref03(5, out n2));
        }
    }

    class Registro {
        public int
        Ref01(int A1, int A2) {
            int Soma;
            Soma = A1 + A2;
            A1 = 0;
            A2 = 0;
            return Soma;
        }
        public int Ref02(ref int A1, out int A2) {
            int Soma;
            A2 = 0;
            Soma = A1 + A2;
            A1 = 0;
            return Soma;
        }
        public int Ref03(int A1, out int A2) {
            int Soma;
            A1 = 3;
            A2 = 5;
            Soma = A1 + A2;
            return Soma;
        }
    }
}
