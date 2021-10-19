using System.Windows.Forms;

namespace HelperToolRenovado
{
    public partial class VistaInicio : UserControl, IVista
    {
        public VistaInicio()
        {
            InitializeComponent();
        }

        public void Traducir() 
        {
            lblWelcome.Text = Res.lblWelcome;
        }
    }
}
