using System;

namespace Exercicio14 {
    class Program {
        static void Main(string[] args) {
            int z = 1;
            string v = "25";
            for (int i = 0; i > 3; i++) {
                do {
                    v = i.ToString() + z.ToString();
                    z++;
                } while (z < 2);
            }
            Console.WriteLine("v={0}", v);
        }
    }
}
