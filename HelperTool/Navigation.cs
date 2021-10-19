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
        private Dictionary<string, Vista> Vistas = new Dictionary<string, Vista>();

        public Navigation(Panel contenedor)
        {
            Contenedor = contenedor;
        }

        public void AgregarVista(string nombre, Vista vista)
        {
            Vistas.Add(nombre, vista);
        }

        public void Navegar(string nombre)
        {
            if (Vistas.ContainsKey(nombre))
            {
                Contenedor.Controls.Clear();
                Contenedor.Controls.Add(Vistas[nombre]);
            }
        }
        public Vista GetVista(string nombre)
        {
            return Vistas.ContainsKey(nombre) ? Vistas[nombre] : null;
        }
    }
    // Para todas las vistas, heredan Vista y se implement el método Traducir
    public partial class VistaCarga : Vista
    {
        public VistaCarga()
        {
            InitializeComponent();
        }
        public void Traducir(string lang)
        {
            //Traducir alsfasfas
        }
    }

}
