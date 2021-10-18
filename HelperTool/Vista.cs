using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace HelperToolRenovado
{
    abstract class Vista : UserControl
    {
        public abstract void Traducir(string lang);
    }
}

