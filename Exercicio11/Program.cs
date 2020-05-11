using System;

namespace Exercicio11 {
    class Program {
        static void Main(string[] args) {
        }
    }

    class Alvo {
        public virtual void Requisitar() {
            Console.WriteLine("Alvo");
        }
    }
    class Ajustar : Alvo {
        Ajustado _adaptee = new Ajustado();
        public override void Requisitar() {
            _adaptee.SpecificRequest();
        }
    }
    class Ajustado {
        public void SpecificRequest() {
            Console.WriteLine("Requititado()");
        }
    }
}
