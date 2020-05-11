using System;

namespace Exercicio9 {
    class Program {
        static void Main(string[] args) {
        }
    }

    public class Figura {
        public const double PI = Math.PI;
        protected double x, y;
        public Figura() { }
        public Figura(double x, double y) {
            this.x = x; this.y = y;
        }
        public virtual double Area() { return x * y; }
    }

    public class Circulo : Figura {
        public Circulo(double r) : base(r, 0) { }
        public override double Area() { return PI * x * x; }
    }

    class Retangulo : Figura {
        public Retangulo(double l1, double l2) : base(l1, l2) { }
    }

}
