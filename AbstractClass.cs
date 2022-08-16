using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming {
    internal abstract class AbstractClass {
        protected int Attribute1;
        protected int Attribute2 { get; set; }

        public abstract void Suma();
        public abstract void Resta();

    }
}
