using System;

namespace Exercicio12 {
    class Program {
        static void Main(string[] args) {
            int[] lista;
            lista = new int[]
            { 1, 2, 3, 4, 5, 6 };
            int k14 = 10;
            foreach (int num in lista) {
                k14 -= num;
                if (k14 % 2 == 0)
                    break;
            }
            Console.WriteLine("K14={0}", ++k14);
        }
    }
}
