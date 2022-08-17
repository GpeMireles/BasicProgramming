using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming {
    internal sealed class Laptop : Computer {
        public Laptop(bool connected, bool power) {
            ConnectedToInternet = connected;
            Power = power;
        }

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

        public override void OnOff() {
            Power = !Power;
        }
    }
}
