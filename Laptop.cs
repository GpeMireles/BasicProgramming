using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming {
    /// <summary>
    /// Clase derivada de Computer que contiene sus 2 atributos e implementa los 2 metodos
    /// </summary>
    internal sealed class Laptop : Computer {
        public Laptop(bool power, bool connected) {
            Power = power;
            ConnectedToInternet = connected;
        }

        /// <summary>
        /// Try to Connect the laptop to internet, this is possible if the device is power on
        /// </summary>
        public override void Connect() {
            if(Power) {
                ConnectedToInternet = true;
                Console.WriteLine("You have acces to internet via Wifi");
            }
            else {
                ConnectedToInternet = false;
                Console.WriteLine("The device is Power Off");
            }
        }
        /// <summary>
        /// Toggle the state of the machine
        /// </summary>
        public override void OnOff() {
            Power = !Power;
        }
    }
}
