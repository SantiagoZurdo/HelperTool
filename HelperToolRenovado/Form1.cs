using System;
using System.Collections.Generic;
using System.Management;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelperToolRenovado
{
    public partial class Form1 : Form
    {
        Navigation Navigate;
        Dictionary<string, string> diccionarioKeys;
        public Form1()
        {
            InitializeComponent();
            PersonalizeDesing();
            Navigate = new Navigation(panel1);
            Navigate.AgregarVista("VistaInicio", new VistaInicio());
            Navigate.AgregarVista("VistaCarga", new VistaCarga());
            Navigate.AgregarVista("VistaAdvancedControls", new VistaAdvancedControls());
            Navigate.AgregarVista("VistaOptimization", new VistaOptimization());
            Navigate.Navegar("VistaInicio");

            diccionarioKeys = new Dictionary<string, string>()
            {
                {"Microsoft Windows 10 Pro", "insert valid key of windows here :D"},
                {"Microsoft Windows 10 Home", "insert valid key of windows here :D"},
                {"Microsoft Windows 10 Enterprise", "insert valid key of windows here :D"},
                {"Microsoft Windows 10 Education", "insert valid key of windows here :D"},
                {"Microsoft Windows 11 Pro", "insert valid key of windows here :D"},
                {"Microsoft Windows 11 Home", "insert valid key of windows here :D"},
                {"Microsoft Windows 11 Education", "insert valid key of windows here :D"}
            };
        }
        private void PersonalizeDesing()
        {
            panelSubmenuActivation.Visible = false;
            panelOptimizeSettings.Visible = false;
        }

        private void hideSubmenu()
        {
            if (panelSubmenuActivation.Visible== true)
            {
                panelSubmenuActivation.Visible = false;
            }
            if (panelOptimizeSettings.Visible == true)
            {
                panelOptimizeSettings.Visible = false;
            }
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubmenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        
        private async Task ActivateWindowsComand(string key)
        {
            await CommandsCMD.RunSlmgr("-ipk " + key);
            await CommandsCMD.RunSlmgr("-skms kms.digiboy.ir");
            await CommandsCMD.RunSlmgr("-ato");
        }
        enum RecycleFlags : uint
        {
            SHRB_NOCONFIRMATION = 0x00000001,   // No solicita la confirmacion para eliminar
            SHRB_NOPROGRESSUI = 0x00000002,     // No muestra dialogo de windows
            SHRB_NOSOUND = 0x00000004           // No produce ningun sonido al relaizar operacion
        }
        [DllImport("Shell32.dll", CharSet = CharSet.Unicode)]
        static extern uint SHEmptyRecycleBin(IntPtr hwnd, string pszRootPath, RecycleFlags dwFlags);
        private async void  btnActivateW_Click(object sender, EventArgs e)
        {
            Navigate.Navegar("VistaInicio");
            hideSubmenu();
            string windowsVersion = "";
            using (ManagementObjectSearcher buscador = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem"))
            {
                ManagementObjectCollection information = buscador.Get();
                if (information != null)
                {
                    foreach (ManagementObject obj in information)
                    {
                        windowsVersion = obj["Caption"].ToString();
                    }
                }
                DialogResult mensajeActivacion;
                mensajeActivacion = MessageBox.Show("Are you sure you want to activate " + "(" + (windowsVersion) + ")", "HelperTool Message.", MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
                if (mensajeActivacion == System.Windows.Forms.DialogResult.Yes)
                {
                    Navigate.Navegar("VistaCarga");
                    if (diccionarioKeys.ContainsKey(windowsVersion))
                    {
                        string WindowsKey = diccionarioKeys[windowsVersion];
                        await ActivateWindowsComand(WindowsKey);
                        Navigate.Navegar("VistaInicio");
                        MessageBox.Show("Your operating system :"+(windowsVersion)+ "has been successfully activated", "HelperTool message.",MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Your windows version has not been found!!!!!"
                       + "\n\n"
                       + "Remember that this program only supports licenses of:"
                       + "\n"
                       + "Windows 10 Pro & Windows 11 Pro."
                       + "\n"
                       + "Windows 10 Home & Windows 11 Home."
                       + "\n"
                       + "Windows 10 Enterprise & Windows 11 Enterprise"
                       + "\n"
                       + "Windows 10 Education & Windows 11 Education.", "HelperTool Error!.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void btnDeactivateW_Click(object sender, EventArgs e)
        {
            Navigate.Navegar("VistaInicio");
            hideSubmenu();
            DialogResult result2;
            result2 = MessageBox.Show("Are you sure you want to deactivate windows?", "HelperTool Message.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result2 == System.Windows.Forms.DialogResult.Yes)
            {
                CommandsCMD.RunSlmgr("-upk");
            }
        }
        private void btnShowWversion_Click(object sender, EventArgs e)
        {
            Navigate.Navegar("VistaInicio");
            hideSubmenu();
            CommandsCMD.RunCommand("start ms-settings:activation");
        }
        private void btnOptimizeW_Click(object sender, EventArgs e)
        {
            Navigate.Navegar("VistaOptimization");
            hideSubmenu();
        }
        private void btnAdvancedOptionsW_Click(object sender, EventArgs e)
        {
            Navigate.Navegar("VistaAdvancedControls");
            hideSubmenu();
        }

        private void btnActivationSettings_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubmenuActivation);
        }

        private void btnOptimizeSettings_Click(object sender, EventArgs e)
        {
            showSubMenu(panelOptimizeSettings);
        }
    }
}