using System;

namespace Exercicio1 {

    public class Calc {
        public int CalcY(int p1, int p2 = 3, int p3 = 4) {
            int ret;//= int.MinValue;
            ret = p2 - p1 + p3;
            return ret;
        }
    }

    class Program {
        static void Main(string[] args) {

            Calc obj1 = new Calc();

            obj1.CalcY(44); //Correta
            obj1.CalcY(44, 12); //Correta
            obj1.CalcY(44, , 34); //Incorreta, arugmento ausente

            Console.WriteLine(obj1.CalcY(1));
        }

    }
}
