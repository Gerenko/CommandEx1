using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandEx1
{
    class tuneUpRadio : IradioCommand
    {
        private radioControl rc;
        public tuneUpRadio(radioControl rcc)
        {
            this.rc = rcc;
        }
        public string execute()
        {
            return this.rc.tuneUp();
        }
    }
}
