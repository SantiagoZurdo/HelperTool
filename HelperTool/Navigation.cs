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
        private Dictionary<string,UserControl> Vistas = new Dictionary<string, UserControl>();
        public Navigation(Panel contenedor)
        {
            Contenedor = contenedor;
        }
        public void AgregarVista(string nombre,UserControl vista)
        {
            Vistas.Add(nombre,vista);

        }
        public void Navegar(string nombre)
        {
            if (Vistas.ContainsKey(nombre))
            {
                Contenedor.Controls.Clear();
                Contenedor.Controls.Add(Vistas[nombre]);
            }
        }

    }
}
