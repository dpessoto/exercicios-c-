using System;

namespace Exercicio6 {
    enum Frutas {
        Laranja,
        Abacaxi, Pera
    }
    class Program {
        static void Main(string[] args) {
            Frutas Melancia = Frutas.Laranja;
            switch (Melancia) {
                case Frutas.Abacaxi:
                    Console.WriteLine("Pitanga"); //n imprime
                    break;
                case Frutas.Pera:
                    Console.WriteLine("Maça"); //n imprime
                    break;
                case Frutas.Laranja:
                    Console.WriteLine("Jaca"); //imprime
                    break;
            }
        }
    }
}
