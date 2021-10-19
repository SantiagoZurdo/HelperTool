﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace HelperToolRenovado
{
    public partial class VistaAdvancedControls : Vista
    {
        List<CheckBox> listacheckAdvanced;
        
        public VistaAdvancedControls()
        {
            InitializeComponent();
            listacheckAdvanced = new List<CheckBox> { checkBoxDelMusic, checkBoxDelImage, checkBoxDelVideo, checkBoxDelObjects, checkBoxDelFastAccs,checkBoxUnistallOneDrive,checkBoxDisableFirewall,checkBoxDisableRunasAdmin, checkBoxDisableNotifications,checkBoxDisableDefender};
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
                btnGoAdvancedOptions.BackColor = ColorTranslator.FromHtml("#0078d7");
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
                    using (RegistryKey key2 = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer", true))
                    {
                        key2?.SetValue("HubMode", 1);
                    }
                }
                if (checkBoxUnistallOneDrive.Checked)
                {
                    CommandsCMD.RunCommand("taskkill / f / im OneDrive.exe");
                    CommandsCMD.RunCommand(@"%SystemRoot%\SysWOW64\OneDriveSetup.exe /uninstall");
                }
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
            }
            catch (Exception){}
            DialogResult resultado;
            resultado = MessageBox.Show("To see the applied changes you need to restart the system. Do you want to do it now?", "Helper Tool Message.", MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
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
    }
}