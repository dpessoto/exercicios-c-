using System;

namespace Exercicio13 {
    class Program {
        static void Main(string[] args) {
            int D = 4;
            string Dia = "";

            if (D == 1)
                Dia = "Domingo";

            else if (D == 2)
                Dia = "Segunda";

            if (D == 3)
                Dia = "Terca";

            else if (D == 4)
                Dia = "Quarta";

            if (D == 5)
                Dia = "Quinta";

            else
                Dia = "Domingo";

            if (D == 6)
                Dia = "Sexta";
            Console.WriteLine
            ("Hoje e {0}", Dia);
        }
    }
}
