using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelperToolRenovado
{
    class Navigation
    {
        private Panel Contenedor;
        private Dictionary<string, IVista> Vistas = new Dictionary<string, IVista>();

        public Navigation(Panel contenedor)
        {
            Contenedor = contenedor;
        }

        public void AgregarVista(string nombre, IVista vista)
        {
            if (vista is UserControl) Vistas.Add(nombre, vista);
        }

        public void Navegar(string nombre)
        {
            if (Vistas.ContainsKey(nombre))
            {
                Contenedor.Controls.Clear();
                Contenedor.Controls.Add((UserControl)Vistas[nombre]);
            }
        }
        public IVista GetVista(string nombre)
        {
            return Vistas.ContainsKey(nombre) ? Vistas[nombre] : null;
        }
    }

}
