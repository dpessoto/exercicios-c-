using System;

namespace Exercicio10 {
    class Program {
        static void Main(string[] args) {
            double r = 4.0, h = 2.0;
            Figura c = new Circulo(r);
            Figura q = new Retangulo(r, h);
            Console.WriteLine("Area do Circulo = {0:F2}", c.Area());
            Console.WriteLine("Area do Retangulo = {0:F2}",q.Area());
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