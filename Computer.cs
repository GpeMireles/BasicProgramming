using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming {
    internal abstract class Computer {
        protected bool Power;
        protected bool ConnectedToInternet;


        public abstract void Connect();
        public abstract void OnOff();

    }
}
