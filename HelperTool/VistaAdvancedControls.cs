using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace HelperToolRenovado
{
    public partial class VistaAdvancedControls : UserControl, IVista
    {
        List<CheckBox> listacheckAdvanced;
        public VistaAdvancedControls()
        {
            InitializeComponent();
            listacheckAdvanced = new List<CheckBox> { checkBoxDelMusic, checkBoxDelImage, checkBoxDelVideo, checkBoxDelObjects, checkBoxDelFastAccs,checkBoxUnistallOneDrive,checkBoxDisableFirewall,checkBoxDisableRunasAdmin, checkBoxDisableNotifications,checkBoxDisableDefender,checkBoxDisableWindowsAnimations };

        }
        private bool ComprobarCheckboxs(List<CheckBox> listaAdvanced)
        {
            for (int i = 0; i < listaAdvanced.Count; i++)
            {
                if (listaAdvanced[i].Checked == true)
                {
                    return true;
                }
            }
            return false;
        }
        private void Checkear(object sender, EventArgs e)
        {
            bool checkbox = ComprobarCheckboxs(listacheckAdvanced);
            btnGoAdvancedOptions.Enabled = checkbox;
            if (checkbox)
            {
                btnGoAdvancedOptions.BackColor = ColorTranslator.FromHtml("#005FB8");
            }
            else
            {
                btnGoAdvancedOptions.BackColor = ColorTranslator.FromHtml("#808080");
            }
        }
        private void Visibles(bool visibles, List<CheckBox> listaAdvanced)
        {
            foreach (var cheackeadas in listaAdvanced)
            {
                cheackeadas.Checked = visibles;
            }
        }
        private void btnUnCheckAll_Advanced_Click(object sender, EventArgs e)
        {
            Visibles(false, listacheckAdvanced);
        }
        private void btnGoAdvancedOptions_Click(object sender, EventArgs e)
        {
            try
            {
                //delete music
                if (checkBoxDelMusic.Checked)
                {
                    RegistryKey eliminarMusica = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\MyComputer\NameSpace", true);
                    eliminarMusica.DeleteSubKeyTree("{3dfdf296-dbec-4fb4-81d1-6a3438bcf4de}");
                }
                //delete images
                if (checkBoxDelImage.Checked)
                {
                    RegistryKey eliminarIamagenes = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\MyComputer\NameSpace", true);
                    eliminarIamagenes.DeleteSubKeyTree("{24ad3ad4-a569-4530-98e1-ab02f9417aa8}");
                }
                // delete video
                if (checkBoxDelVideo.Checked)
                {
                    RegistryKey eliminarVideos = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\MyComputer\NameSpace", true);
                    eliminarVideos.DeleteSubKeyTree("{f86fa3ab-70d2-4fc7-9c99-fcbf05467f3a}");
                }
                //delete objects 3d
                if (checkBoxDelObjects.Checked)
                {
                    RegistryKey eliminarObjetos3D = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\MyComputer\NameSpace", true);
                    eliminarObjetos3D.DeleteSubKeyTree("{0DB7E03F-FC29-4DC6-9020-FF41B59E513A}");
                }
                //delete fast acces win 10
                if (checkBoxDelFastAccs.Checked)
                {
                    using (RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer", true))
                    {
                        key?.SetValue("HubMode", 1);
                    }
                    using (RegistryKey key1 = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer", true))
                    {
                        key1?.SetValue("HubMode", 1);
                    }
                }
                //unistall one drive
                if (checkBoxUnistallOneDrive.Checked)
                {
                    CommandsCMD.RunCommand("taskkill / f / im OneDrive.exe");
                    CommandsCMD.RunCommand(@"%SystemRoot%\SysWOW64\OneDriveSetup.exe /uninstall");
                }
                //disable firewall
                if (checkBoxDisableFirewall.Checked)
                {
                    CommandsCMD.RunCommand("netsh advfirewall set allprofiles state off");
                }
                if (checkBoxDisableRunasAdmin.Checked)
                {
                    RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System", true);
                    key.SetValue("EnableLUA", "0");
                }
                if (checkBoxDisableNotifications.Checked)
                {
                    RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\PushNotifications", true);
                    key.SetValue("ToastEnabled","0");
                }
                if (checkBoxDisableDefender.Checked)
                {
                    RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Policies\Microsoft\Windows Defender", true);
                    key.SetValue("DisableAntiSpyware", "1");                 
                }
                if (checkBoxDisableWindowsAnimations.Checked)
                {
                    //incompleto
                    //RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", true);

                }
            }
            catch (Exception){}
            DialogResult mensajeCambiosAplicadosReiniciar = MessageBox.Show(Res.mensajeCambiosAplicadosReiniciar,"HelperTool Message.", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (mensajeCambiosAplicadosReiniciar == System.Windows.Forms.DialogResult.Yes)
            {
                Process.Start("shutdown", "/r /t 0");
            }
        }
        private void rjToggleButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (SwitchChecked.Checked == true)
            {
                Visibles(true, listacheckAdvanced);
                lblCheckAll2.Visible = false;
                lblUncheckAll2.Visible = true;
            }
            else
            {
                Visibles(false, listacheckAdvanced);
                lblUncheckAll2.Visible = false;
                lblCheckAll2.Visible = true;
            }
        }

        public void Traducir() 
        {
            checkBoxDelMusic.Text = Res.checkBoxDelMusic;
            checkBoxDelImage.Text = Res.checkBoxDelImage;
            checkBoxDelVideo.Text = Res.checkBoxDelVideo;
            checkBoxDelObjects.Text = Res.checkBoxDelObjects;
            checkBoxDelFastAccs.Text = Res.checkBoxDelFastAccs;
            checkBoxUnistallOneDrive.Text = Res.checkBoxUnistallOneDrive;
            checkBoxDisableFirewall.Text = Res.checkBoxDisableFirewall;
            checkBoxDisableRunasAdmin.Text = Res.checkBoxDisableRunasAdmin;
            checkBoxDisableNotifications.Text = Res.checkBoxDisableNotifications;
            checkBoxDisableDefender.Text = Res.checkBoxDisableDefender;
            label2.Text = Res.label2;
            lblCheckAll2.Text = Res.lblCheckAll2;
            lblUncheckAll2.Text = Res.lblUncheckAll2;
            btnGoAdvancedOptions.Text = Res.btnGoAdvancedOptions;
            checkBoxDisableWindowsAnimations.Text = Res.checkBoxDisableWindowsAnimations;

        }
    }
}