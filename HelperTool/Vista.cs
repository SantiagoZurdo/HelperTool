using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperToolRenovado
{
    abstract class Vista : UserControl
    {
        public abstract void Traducir(string lang);
    }
}

