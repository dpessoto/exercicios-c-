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

            Calc calc = new Calc();

            calc.CalcY(); //precisa de argumento
            calc.CalcY(1); //1 aurgumento é obrigatorio
            calc.CalcY(1,2); //ter um segundo argumento é opcional
            calc.CalcY(1, 2, 3); //ter um terceiro argumento é opcional

            Console.WriteLine(calc.CalcY(1));
        }

    }
}
