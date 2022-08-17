using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming {
    /// <summary>
    /// Clase abstracta Computer de la cual podrian derivar clases como Laptop y PC.
    /// </summary>
    internal abstract class Computer {
        // Dos atributos que solo se podran acceder desde las clases derivadas
        protected bool Power; // "true" if in 'on' and 'false' if is "off"
        protected bool ConnectedToInternet;

        // Dos metodos que, al ser abstractos se deberan de implementar en las clases derivadas
        // y otra clase no los podran acceder desde esta clase porque no se puede instanciar
        public abstract void Connect(); // a Laptop access to internet via wifi and a PC via Etherner
        public abstract void OnOff(); // Turn the computer 'on' or 'off'

    }
}
