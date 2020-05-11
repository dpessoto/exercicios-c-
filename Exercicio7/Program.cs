using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7 {
    class Program {
        static void Main(string[] args) {

            Registro registro = new Registro();

            int n1 = 1;
            int n2;

            Console.WriteLine(registro.Ref01(2, 4));

            Console.WriteLine(registro.Ref02(ref n1, out n2)); //qnd passdo por ref, 
            //precisa inicializar a variavel, atribuindo algum valor, qnd passado por out, n precisa atribuir valor a variavel

            Console.WriteLine(registro.Ref03(2, out n2));
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
