using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandEx1
{
    class turnOnRadio:IradioCommand
    {
        private radioControl rc;
        public turnOnRadio(radioControl rcc)
        {
            this.rc = rcc;
        }
        public string execute()
        {
         return  this.rc.turnOn();
      }

    }
}
