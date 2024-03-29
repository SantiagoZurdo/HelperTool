﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Caching;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HelperToolRenovado
{
    public partial class VistaOptimization : UserControl, IVista
    {
        List<CheckBox> listacheckOptimizeOptions;
        
        public VistaOptimization()
        {
            InitializeComponent();
            listacheckOptimizeOptions = new List<CheckBox> {checkDelTempFilesUpdate, checkDeleteTempFiles, checkCacheDNS, checkClearEvLog, checkClearCache, checkEnergyPlan, checkDisableGameModeWin, checkDisablePushN, checkDisableSysM, checkDisableUpdates, checkDisableSearch, checkDisableServices, checkClearRecyclebin };
            btnRollback2.Visible = false;
        }
        enum RecycleFlags : uint {SHRB_NOCONFIRMATION = 0x00000001,SHRB_NOPROGRESSUI = 0x00000002,SHRB_NOSOUND = 0x00000004}
        [DllImport("Shell32.dll", CharSet = CharSet.Unicode)]
        static extern uint SHEmptyRecycleBin(IntPtr hwnd, string pszRootPath, RecycleFlags dwFlags);
        private bool ComprobarCheckboxs(List<CheckBox> listaOptimizacion)
        {
            for (int i = 0; i < listaOptimizacion.Count; i++)
            {
                if (listaOptimizacion[i].Checked == true)
                {
                    return true;
                }
            }
            return false;
        }
        private void Checkear(object sender, EventArgs e)
        {
            bool checkbox = ComprobarCheckboxs(listacheckOptimizeOptions);
            btnOptmizeNow.Enabled = checkbox;
            if (checkbox)
            {
                btnOptmizeNow.BackColor = ColorTranslator.FromHtml("#005FB8");
            }
            else
            {
                btnOptmizeNow.BackColor = ColorTranslator.FromHtml("#808080");
            }
        }
        private void Visibles(bool visibles, List<CheckBox> listaOptimizacion)
        {
            foreach (var cheackeadas in listaOptimizacion)
            {
                cheackeadas.Checked = visibles;
            }
        }
        private void SwitchChecked_CheckedChanged(object sender, EventArgs e)
        {
            if (rjToggleButton1.Checked == true)
            {
                Visibles(true, listacheckOptimizeOptions);
                lblCheckAll.Visible = false;
                lblUncheckAll.Visible = true;
            }
            else
            {
                Visibles(false, listacheckOptimizeOptions);
                lblUncheckAll.Visible = false;
                lblCheckAll.Visible = true;
            }
        }
        private void btnOptmizeNow_Click(object sender, EventArgs e)
        {
            btnRollback2.Visible = true;
            DialogResult mensajeDeseaOptimizar = MessageBox.Show(Res.mensajeDeseaOptimizar, "HelperTool Message.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (mensajeDeseaOptimizar == DialogResult.Yes)
            {
                try
                {
                    if (checkDelTempFilesUpdate.Checked)
                    {
                        RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\wuauserv", true);
                        key.SetValue("Start", 4);
                    }
                    //clear temp files from 3 path's
                    if (checkDeleteTempFiles.Checked)
                    {
                        Directory.Delete(Path.GetTempPath(), true); // %temp% r1
                        Directory.Delete(Environment.GetEnvironmentVariable("TEMP", EnvironmentVariableTarget.Machine), true);// Temp r2
                        Directory.Delete(Environment.GetEnvironmentVariable("PREFETCH", EnvironmentVariableTarget.Machine), true); // temp r3
                    }
                    //clear cache dns
                    if (checkCacheDNS.Checked)
                    {
                        CommandsCMD.RunSlmgr("ipconfig/flushdns");
                    }
                    //clear log event
                    if (checkClearEvLog.Checked)
                    {
                        CommandsCMD.RunSlmgr("wevtutil cl Application");
                        CommandsCMD.RunSlmgr("wevtutil cl Security");
                        CommandsCMD.RunSlmgr("wevtutil cl Setup");
                        CommandsCMD.RunSlmgr("wevtutil cl System");
                        CommandsCMD.RunSlmgr("wevtutil cl ForwardedEvents");
                    }
                    //clear cache (general)
                    if (checkClearCache.Checked)
                    {
                        List<string> cacheKeys = MemoryCache.Default.Select(kvp => kvp.Key).ToList();
                        foreach (string cacheKey in cacheKeys)
                        {
                            MemoryCache.Default.Remove(cacheKey);
                        }
                    }
                    //Maximum performance energy plan
                    if (checkEnergyPlan.Checked)
                    {
                        CommandsCMD.RunCommand("powercfg /setactive 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c");
                    }
                    //Disable game mode from win 10
                    if (checkDisableGameModeWin.Checked)
                    {
                        RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\GameBar", true);
                        key.SetValue("AutoGameModeEnabled", "0");
                    }
                    //disable push notification from windows 10
                    if (checkDisablePushN.Checked)
                    {
                        RegistryKey key10 = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\WpnService", true);
                        key10.SetValue("Start", 4);
                    }
                    //disable sysmain 
                    if (checkDisableSysM.Checked)
                    {
                        RegistryKey key11 = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\SysMain", true);
                        key11.SetValue("Start", 4);
                    }
                    // disable update service
                    if (checkDisableUpdates.Checked)
                    {
                        RegistryKey key2 = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\wuauserv", true);
                        key2.SetValue("Start", 4);
                    }
                    // disable windows search
                    if (checkDisableSearch.Checked)
                    {
                        RegistryKey key12 = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\WSearch", true);
                        key12.SetValue("Start", 4);
                    }
                    if (checkDisableServices.Checked)
                    {
                        RegistryKey key0 = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\SCardSvr", true);
                        key0.SetValue("Start", 4);
                        RegistryKey key1 = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\TapiSrv", true);
                        key1.SetValue("Start", 4);
                        RegistryKey key3 = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\Fax", true);
                        key3.SetValue("Start", 4);
                        RegistryKey key4 = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\WpcMonSvc", true);
                        key4.SetValue("Start", 4);
                        RegistryKey key5 = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\MapsBroker", true);
                        key5.SetValue("Start", 4);
                        RegistryKey key6 = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\SEMgrSvc", true);
                        key6.SetValue("Start", 4);
                        RegistryKey key7 = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\SNMPTRAP", true);
                        key7.SetValue("Start", 4);
                        RegistryKey key8 = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\Netlogon", true);
                        key8.SetValue("Start", 4);
                    }
                    if (checkClearRecyclebin.Checked)
                    {
                        uint IsSuccess = SHEmptyRecycleBin(IntPtr.Zero, null, RecycleFlags.SHRB_NOCONFIRMATION);
                    }
                }
                catch (Exception) { }
            }    
            
            MessageBox.Show(Res.mensajeOptimizadoCorrectamente, "HelperTool Message.", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        private void btnRollback2_Click(object sender, EventArgs e)
        {
            DialogResult mensajeRollBackPregunta = MessageBox.Show(Res.mensajeRollBackPregunta, "HelperTool Message.",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (mensajeRollBackPregunta == DialogResult.Yes)
            {
                try
                {
                    if (checkDisableServices.Checked)
                    {
                        RegistryKey key0 = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\SCardSvr", true);
                        key0.SetValue("Start", 3);
                        RegistryKey key1 = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\TapiSrv", true);
                        key1.SetValue("Start", 3);
                        RegistryKey key3 = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\Fax", true);
                        key3.SetValue("Start", 3);
                        RegistryKey key4 = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\WpcMonSvc", true);
                        key4.SetValue("Start", 3);
                        RegistryKey key5 = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\MapsBroker", true);
                        key5.SetValue("Start", 2);
                        RegistryKey key6 = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\SEMgrSvc", true);
                        key6.SetValue("Start", 3);
                        RegistryKey key7 = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\SNMPTRAP", true);
                        key7.SetValue("Start", 3);
                        RegistryKey key8 = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\Netlogon", true);
                        key8.SetValue("Start", 3);
                    }
                    if (checkDisablePushN.Checked)
                    {
                        RegistryKey key10 = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\WpnService", true);
                        key10.SetValue("Start", 2);
                    }
                    if (checkDisableSysM.Checked)
                    {
                        RegistryKey key11 = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\SysMain", true);
                        key11.SetValue("Start", 2);
                    }
                    if (checkDisableSearch.Checked)
                    {
                        RegistryKey key12 = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\WSearch", true);
                        key12.SetValue("Start", 4);
                    }
                    if (checkDisableGameModeWin.Checked)
                    {
                        RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\GameBar", true);
                        key.SetValue("AutoGameModeEnabled", "1");
                    }
                }
                catch (Exception){}

                MessageBox.Show(Res.mensajeRollbackSuccefull, "HelperTool Message.", MessageBoxButtons.OK,MessageBoxIcon.Information);
                Visibles(false, listacheckOptimizeOptions);
                DialogResult mensajeDeseaReiniciar = MessageBox.Show(Res.mensajeDeseaReiniciar, "HelperTool Message.", MessageBoxButtons.YesNo);
                if (mensajeDeseaReiniciar == System.Windows.Forms.DialogResult.Yes)
                {
                    Process.Start("shutdown", "/r /t 0");
                }
            }
        }
        public void Traducir()
        {
            checkDelTempFilesUpdate.Text = Res.checkDelTempFilesUpdate;
            checkDeleteTempFiles.Text = Res.checkDeleteTempFiles;
            checkCacheDNS.Text = Res.checkCacheDNS;
            checkClearEvLog.Text = Res.checkClearEvLog;
            checkClearCache.Text = Res.checkClearCache;
            checkEnergyPlan.Text = Res.checkEnergyPlan;
            checkDisableGameModeWin.Text = Res.checkDisableGameModeWin;
            checkDisablePushN.Text = Res.checkDisablePushN;
            checkDisableSysM.Text = Res.checkDisableSysM;
            checkDisableUpdates.Text = Res.checkDisableUpdates;
            checkDisableSearch.Text = Res.checkDisableSearch;
            checkDisableServices.Text = Res.checkDisableServices;
            checkClearRecyclebin.Text = Res.checkClearRecyclebin;
            lblCheckAll.Text = Res.lblCheckAll;
            lblUncheckAll.Text = Res.lblUncheckAll;
            btnOptmizeNow.Text = Res.btnOptmizeNow;
            btnRollback2.Text = Res.btnRollback2;
            label1.Text = Res.label1;
        }
    }
}