using System;
using System.Collections.Generic;
using System.Management;
using System.Runtime.InteropServices;
using System.Threading;
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
            GetText();
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
        private string GetWindowsVersion()
        {
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
            }
            return windowsVersion;
        }
        private void PersonalizeDesing()
        {
            panelSubmenuActivation.Visible = false;
            panelOptimizeSettings.Visible = false;
            panelLenguages.Visible = false;
        }
        private void hideSubmenu()
        {
            if (panelSubmenuActivation.Visible == true)
            {
                panelSubmenuActivation.Visible = false;
            }
            if (panelOptimizeSettings.Visible == true)
            {
                panelOptimizeSettings.Visible = false;
            }
            if (panelLenguages.Visible == true)
            {
                panelLenguages.Visible = false;
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
        private async void btnActivateWindows_Click(object sender, EventArgs e)
        {
            Navigate.Navegar("VistaInicio");
            MessageBox.Show(Res.mensajeDemostracion, "HelperTool Message.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            DialogResult mensajeActivacion = MessageBox.Show(Res.mensajeActivacion + "(" + (GetWindowsVersion()) + ")", "HelperTool Message.", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (mensajeActivacion == System.Windows.Forms.DialogResult.Yes)
            {
                Navigate.Navegar("VistaCarga");
                if (diccionarioKeys.ContainsKey(GetWindowsVersion()))
                {
                    string WindowsKey = diccionarioKeys[GetWindowsVersion()];
                    await ActivateWindowsComand(WindowsKey);
                    Navigate.Navegar("VistaInicio");
                    MessageBox.Show(Res.mensajeActivacionCorrecta.Replace("{{windowsVersion}}", GetWindowsVersion()), "HelperTool Message.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else{MessageBox.Show(Res.mensajeErrorVersion, "HelperTool Message.", MessageBoxButtons.OK, MessageBoxIcon.Warning);}
            }
        }
        private void btnDeactivateWindows_Click(object sender, EventArgs e)
        {
            Navigate.Navegar("VistaInicio");
            DialogResult mensajeDesactivacion = MessageBox.Show(Res.mensajeDesactivacion, "HelperTool Message.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (mensajeDesactivacion == System.Windows.Forms.DialogResult.Yes)
            {
                CommandsCMD.RunCommand("slmgr /upk");
            }
        }
        private void btnShowWversion_Click(object sender, EventArgs e)
        {
            Navigate.Navegar("VistaInicio");
            CommandsCMD.RunCommand("start ms-settings:activation");
        }
        private void btnOptimizeMenu_Click(object sender, EventArgs e)
        {
            Navigate.Navegar("VistaOptimization");
        }
        private void btnAdvancedMenuW_Click(object sender, EventArgs e)
        {
            Navigate.Navegar("VistaAdvancedControls");
        }
        private void btnActivationSettings_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubmenuActivation);
            Navigate.Navegar("VistaInicio");
        }
        private void btnOptimizeSettings_Click(object sender, EventArgs e)
        {
            showSubMenu(panelOptimizeSettings);
            Navigate.Navegar("VistaInicio");
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            showSubMenu(panelLenguages);
                
        }
        private void btnSpanish_Click(object sender, EventArgs e)
        {
            showSubMenu(panelLenguages);
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("es");
            GetText();
        }
        private void btnEnglish_Click(object sender, EventArgs e)
        {
            showSubMenu(panelLenguages);
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
            GetText();
        }
        private void GetText()
        {
            //Menu of buttons
            btnActivationSettings.Text = Res.btnActivationSettings;
            btnActivateWindows.Text = Res.btnActivateWindows;
            btnDeactivateWindows.Text = Res.btnDeactivateWindows;
            btnShowWversion.Text = Res.btnShowWversion;
            btnOptimizeSettings.Text = Res.btnOptimizeSettings;
            btnOptimizeMenu.Text = Res.btnOptimizeMenu;
            btnAdvancedMenuW.Text = Res.btnAdvancedMenuW;
            //Translate view
            Navigate.GetVista("VistaCarga").Traducir();
            Navigate.GetVista("VistaInicio").Traducir();
            Navigate.GetVista("VistaOptimization").Traducir();
            Navigate.GetVista("VistaAdvancedControls").Traducir();
        }
    }
}    