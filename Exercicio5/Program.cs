using System;

namespace Exercicio5 {
    public delegate void Chamar();
    class C1 {
        public void M1() {
            Console.WriteLine("XPTO");
        }
        public void M2() {
            Console.WriteLine("OTPX");
        }
    }
    class Program {
        static void Main(string[] args) {
            Chamar p;
            C1 O = new C1();
            p = O.M2;
            p();
            p = O.M1;
            p();
        }
    }
}
