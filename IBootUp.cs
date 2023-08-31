using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_Morgan_Daniel
{
    internal interface IBootUp
    {
        // Boolean property call IsOn with an automatic getter and setter
        public bool IsOn { get; set; }
        // Method call PowerOnOff
        public void PowerOnOff();

    }
}
