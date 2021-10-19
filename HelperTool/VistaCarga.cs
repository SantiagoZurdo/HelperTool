using System.Windows.Forms;

namespace HelperToolRenovado
{
    public partial class VistaCarga : UserControl, IVista
    {
        public VistaCarga() 
        {
            InitializeComponent();
        }
        public void Traducir() 
        {
            lblPleaseWait.Text = Res.lblPleaseWait;
        }
    }
}
