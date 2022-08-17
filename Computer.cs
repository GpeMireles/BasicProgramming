using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming {
    internal abstract class Computer {
        protected bool ConnectedToInternet;
        protected bool Power;

        public abstract void Connect();
        public abstract void OnOff();

    }
}
