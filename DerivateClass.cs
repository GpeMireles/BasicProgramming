using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming {
    internal sealed class DerivateClass : AbstractClass {
        public DerivateClass(int attribute1, int attribute2) {
            Attribute1 = attribute1;
            Attribute2 = attribute2;
        }

        public override void Suma() {
            Console.WriteLine(Attribute1 + Attribute2);
        }

        public override void Resta() {
            Console.WriteLine(Attribute1 - Attribute2);
        }
    }
}
