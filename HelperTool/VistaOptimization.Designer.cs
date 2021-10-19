
namespace HelperToolRenovado
{
    partial class VistaOptimization
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkDisableSearch = new System.Windows.Forms.CheckBox();
            this.checkDisableSysM = new System.Windows.Forms.CheckBox();
            this.checkDisablePushN = new System.Windows.Forms.CheckBox();
            this.checkDisableGameModeWin = new System.Windows.Forms.CheckBox();
            this.checkClearEvLog = new System.Windows.Forms.CheckBox();
            this.checkDisableUpdates = new System.Windows.Forms.CheckBox();
            this.checkDelTempFilesUpdate = new System.Windows.Forms.CheckBox();
            this.checkEnergyPlan = new System.Windows.Forms.CheckBox();
            this.checkCacheDNS = new System.Windows.Forms.CheckBox();
            this.checkClearCache = new System.Windows.Forms.CheckBox();
            this.checkDisableServices = new System.Windows.Forms.CheckBox();
            this.checkDeleteTempFiles = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkClearRecyclebin = new System.Windows.Forms.CheckBox();
            this.lblCheckAll = new System.Windows.Forms.Label();
            this.rjToggleButton1 = new HelperToolRenovado.ToggleButton();
            this.lblUncheckAll = new System.Windows.Forms.Label();
            this.btnOptmizeNow = new HelperToolRenovado.FlatButton();
            this.btnRollback2 = new HelperToolRenovado.FlatButton();
            this.SuspendLayout();
            // 
            // checkDisableSearch
            // 
            this.checkDisableSearch.AutoSize = true;
            this.checkDisableSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkDisableSearch.ForeColor = System.Drawing.Color.White;
            this.checkDisableSearch.Location = new System.Drawing.Point(22, 373);
            this.checkDisableSearch.Name = "checkDisableSearch";
            this.checkDisableSearch.Size = new System.Drawing.Size(248, 24);
            this.checkDisableSearch.TabIndex = 55;
            this.checkDisableSearch.TabStop = false;
            this.checkDisableSearch.Text = "- Disable windows search";
            this.checkDisableSearch.UseVisualStyleBackColor = true;
            this.checkDisableSearch.CheckStateChanged += new System.EventHandler(this.Checkear);
            // 
            // checkDisableSysM
            // 
            this.checkDisableSysM.AutoSize = true;
            this.checkDisableSysM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkDisableSysM.ForeColor = System.Drawing.Color.White;
            this.checkDisableSysM.Location = new System.Drawing.Point(22, 313);
            this.checkDisableSysM.Name = "checkDisableSysM";
            this.checkDisableSysM.Size = new System.Drawing.Size(185, 24);
            this.checkDisableSysM.TabIndex = 54;
            this.checkDisableSysM.TabStop = false;
            this.checkDisableSysM.Text = "- Disable Sysmain";
            this.checkDisableSysM.UseVisualStyleBackColor = true;
            this.checkDisableSysM.CheckStateChanged += new System.EventHandler(this.Checkear);
            // 
            // checkDisablePushN
            // 
            this.checkDisablePushN.AutoSize = true;
            this.checkDisablePushN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkDisablePushN.ForeColor = System.Drawing.Color.White;
            this.checkDisablePushN.Location = new System.Drawing.Point(22, 283);
            this.checkDisablePushN.Name = "checkDisablePushN";
            this.checkDisablePushN.Size = new System.Drawing.Size(399, 24);
            this.checkDisablePushN.TabIndex = 53;
            this.checkDisablePushN.TabStop = false;
            this.checkDisablePushN.Text = "- Disable windows Push notification service";
            this.checkDisablePushN.UseVisualStyleBackColor = true;
            this.checkDisablePushN.CheckStateChanged += new System.EventHandler(this.Checkear);
            // 
            // checkDisableGameModeWin
            // 
            this.checkDisableGameModeWin.AutoSize = true;
            this.checkDisableGameModeWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkDisableGameModeWin.ForeColor = System.Drawing.Color.White;
            this.checkDisableGameModeWin.Location = new System.Drawing.Point(22, 253);
            this.checkDisableGameModeWin.Name = "checkDisableGameModeWin";
            this.checkDisableGameModeWin.Size = new System.Drawing.Size(210, 24);
            this.checkDisableGameModeWin.TabIndex = 52;
            this.checkDisableGameModeWin.TabStop = false;
            this.checkDisableGameModeWin.Text = "- Disable game Mode";
            this.checkDisableGameModeWin.UseVisualStyleBackColor = true;
            this.checkDisableGameModeWin.CheckStateChanged += new System.EventHandler(this.Checkear);
            // 
            // checkClearEvLog
            // 
            this.checkClearEvLog.AutoSize = true;
            this.checkClearEvLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkClearEvLog.ForeColor = System.Drawing.Color.White;
            this.checkClearEvLog.Location = new System.Drawing.Point(22, 163);
            this.checkClearEvLog.Name = "checkClearEvLog";
            this.checkClearEvLog.Size = new System.Drawing.Size(171, 24);
            this.checkClearEvLog.TabIndex = 51;
            this.checkClearEvLog.TabStop = false;
            this.checkClearEvLog.Text = "- Clear event log";
            this.checkClearEvLog.UseVisualStyleBackColor = true;
            this.checkClearEvLog.CheckStateChanged += new System.EventHandler(this.Checkear);
            // 
            // checkDisableUpdates
            // 
            this.checkDisableUpdates.AutoSize = true;
            this.checkDisableUpdates.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkDisableUpdates.ForeColor = System.Drawing.Color.White;
            this.checkDisableUpdates.Location = new System.Drawing.Point(22, 343);
            this.checkDisableUpdates.Name = "checkDisableUpdates";
            this.checkDisableUpdates.Size = new System.Drawing.Size(247, 24);
            this.checkDisableUpdates.TabIndex = 50;
            this.checkDisableUpdates.TabStop = false;
            this.checkDisableUpdates.Text = "- Disable windows update";
            this.checkDisableUpdates.UseVisualStyleBackColor = true;
            this.checkDisableUpdates.CheckStateChanged += new System.EventHandler(this.Checkear);
            // 
            // checkDelTempFilesUpdate
            // 
            this.checkDelTempFilesUpdate.AutoSize = true;
            this.checkDelTempFilesUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkDelTempFilesUpdate.ForeColor = System.Drawing.Color.White;
            this.checkDelTempFilesUpdate.Location = new System.Drawing.Point(22, 73);
            this.checkDelTempFilesUpdate.Name = "checkDelTempFilesUpdate";
            this.checkDelTempFilesUpdate.Size = new System.Drawing.Size(424, 24);
            this.checkDelTempFilesUpdate.TabIndex = 49;
            this.checkDelTempFilesUpdate.TabStop = false;
            this.checkDelTempFilesUpdate.Text = "- Delete temporary files from windows updates";
            this.checkDelTempFilesUpdate.UseVisualStyleBackColor = true;
            this.checkDelTempFilesUpdate.CheckStateChanged += new System.EventHandler(this.Checkear);
            // 
            // checkEnergyPlan
            // 
            this.checkEnergyPlan.AutoSize = true;
            this.checkEnergyPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEnergyPlan.ForeColor = System.Drawing.Color.White;
            this.checkEnergyPlan.Location = new System.Drawing.Point(22, 223);
            this.checkEnergyPlan.Name = "checkEnergyPlan";
            this.checkEnergyPlan.Size = new System.Drawing.Size(337, 24);
            this.checkEnergyPlan.TabIndex = 48;
            this.checkEnergyPlan.TabStop = false;
            this.checkEnergyPlan.Text = "- Maximum performance energy plan";
            this.checkEnergyPlan.UseVisualStyleBackColor = true;
            this.checkEnergyPlan.CheckStateChanged += new System.EventHandler(this.Checkear);
            // 
            // checkCacheDNS
            // 
            this.checkCacheDNS.AutoSize = true;
            this.checkCacheDNS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkCacheDNS.ForeColor = System.Drawing.Color.White;
            this.checkCacheDNS.Location = new System.Drawing.Point(22, 133);
            this.checkCacheDNS.Name = "checkCacheDNS";
            this.checkCacheDNS.Size = new System.Drawing.Size(190, 24);
            this.checkCacheDNS.TabIndex = 47;
            this.checkCacheDNS.TabStop = false;
            this.checkCacheDNS.Text = "- Clear DNS cache";
            this.checkCacheDNS.UseVisualStyleBackColor = true;
            this.checkCacheDNS.CheckStateChanged += new System.EventHandler(this.Checkear);
            // 
            // checkClearCache
            // 
            this.checkClearCache.AutoSize = true;
            this.checkClearCache.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkClearCache.ForeColor = System.Drawing.Color.White;
            this.checkClearCache.Location = new System.Drawing.Point(22, 193);
            this.checkClearCache.Name = "checkClearCache";
            this.checkClearCache.Size = new System.Drawing.Size(145, 24);
            this.checkClearCache.TabIndex = 46;
            this.checkClearCache.TabStop = false;
            this.checkClearCache.Text = "- Clear cache";
            this.checkClearCache.UseVisualStyleBackColor = true;
            this.checkClearCache.CheckStateChanged += new System.EventHandler(this.Checkear);
            // 
            // checkDisableServices
            // 
            this.checkDisableServices.AutoSize = true;
            this.checkDisableServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkDisableServices.ForeColor = System.Drawing.Color.White;
            this.checkDisableServices.Location = new System.Drawing.Point(22, 403);
            this.checkDisableServices.Name = "checkDisableServices";
            this.checkDisableServices.Size = new System.Drawing.Size(297, 24);
            this.checkDisableServices.TabIndex = 45;
            this.checkDisableServices.TabStop = false;
            this.checkDisableServices.Text = "- Disable unnecessary services";
            this.checkDisableServices.UseVisualStyleBackColor = true;
            this.checkDisableServices.CheckStateChanged += new System.EventHandler(this.Checkear);
            // 
            // checkDeleteTempFiles
            // 
            this.checkDeleteTempFiles.AutoSize = true;
            this.checkDeleteTempFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkDeleteTempFiles.ForeColor = System.Drawing.Color.White;
            this.checkDeleteTempFiles.Location = new System.Drawing.Point(22, 103);
            this.checkDeleteTempFiles.Name = "checkDeleteTempFiles";
            this.checkDeleteTempFiles.Size = new System.Drawing.Size(231, 24);
            this.checkDeleteTempFiles.TabIndex = 44;
            this.checkDeleteTempFiles.TabStop = false;
            this.checkDeleteTempFiles.Text = "- Delete temporary files";
            this.checkDeleteTempFiles.UseVisualStyleBackColor = true;
            this.checkDeleteTempFiles.CheckStateChanged += new System.EventHandler(this.Checkear);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(320, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 33);
            this.label1.TabIndex = 39;
            this.label1.Text = "Optimize Options";
            // 
            // checkClearRecyclebin
            // 
            this.checkClearRecyclebin.AutoSize = true;
            this.checkClearRecyclebin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkClearRecyclebin.ForeColor = System.Drawing.Color.White;
            this.checkClearRecyclebin.Location = new System.Drawing.Point(22, 433);
            this.checkClearRecyclebin.Name = "checkClearRecyclebin";
            this.checkClearRecyclebin.Size = new System.Drawing.Size(193, 24);
            this.checkClearRecyclebin.TabIndex = 56;
            this.checkClearRecyclebin.TabStop = false;
            this.checkClearRecyclebin.Text = "- Clear Recycle bin";
            this.checkClearRecyclebin.UseVisualStyleBackColor = true;
            this.checkClearRecyclebin.CheckStateChanged += new System.EventHandler(this.Checkear);
            // 
            // lblCheckAll
            // 
            this.lblCheckAll.AutoSize = true;
            this.lblCheckAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckAll.ForeColor = System.Drawing.Color.White;
            this.lblCheckAll.Location = new System.Drawing.Point(18, 509);
            this.lblCheckAll.Name = "lblCheckAll";
            this.lblCheckAll.Size = new System.Drawing.Size(80, 20);
            this.lblCheckAll.TabIndex = 58;
            this.lblCheckAll.Text = "Check All";
            // 
            // rjToggleButton1
            // 
            this.rjToggleButton1.AutoSize = true;
            this.rjToggleButton1.Location = new System.Drawing.Point(133, 507);
            this.rjToggleButton1.MinimumSize = new System.Drawing.Size(45, 22);
            this.rjToggleButton1.Name = "rjToggleButton1";
            this.rjToggleButton1.OffBackColor = System.Drawing.Color.Gray;
            this.rjToggleButton1.OffBackColor1 = System.Drawing.Color.Gray;
            this.rjToggleButton1.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.rjToggleButton1.OffToggleColor1 = System.Drawing.Color.Gainsboro;
            this.rjToggleButton1.OnBackColor = System.Drawing.SystemColors.Highlight;
            this.rjToggleButton1.OnBackColor1 = System.Drawing.SystemColors.Highlight;
            this.rjToggleButton1.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.rjToggleButton1.OnToggleColor1 = System.Drawing.Color.WhiteSmoke;
            this.rjToggleButton1.Size = new System.Drawing.Size(45, 22);
            this.rjToggleButton1.SolidStyle = true;
            this.rjToggleButton1.SolidStyle1 = true;
            this.rjToggleButton1.TabIndex = 57;
            this.rjToggleButton1.UseVisualStyleBackColor = true;
            this.rjToggleButton1.CheckedChanged += new System.EventHandler(this.SwitchChecked_CheckedChanged);
            // 
            // lblUncheckAll
            // 
            this.lblUncheckAll.AutoSize = true;
            this.lblUncheckAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUncheckAll.ForeColor = System.Drawing.Color.White;
            this.lblUncheckAll.Location = new System.Drawing.Point(184, 509);
            this.lblUncheckAll.Name = "lblUncheckAll";
            this.lblUncheckAll.Size = new System.Drawing.Size(101, 20);
            this.lblUncheckAll.TabIndex = 59;
            this.lblUncheckAll.Text = "UnCheck All";
            this.lblUncheckAll.Visible = false;
            // 
            // btnOptmizeNow
            // 
            this.btnOptmizeNow.BackColor = System.Drawing.Color.Gray;
            this.btnOptmizeNow.BackgroundColor = System.Drawing.Color.Gray;
            this.btnOptmizeNow.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnOptmizeNow.BorderRadius = 20;
            this.btnOptmizeNow.BorderSize = 0;
            this.btnOptmizeNow.Enabled = false;
            this.btnOptmizeNow.FlatAppearance.BorderSize = 0;
            this.btnOptmizeNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptmizeNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptmizeNow.ForeColor = System.Drawing.Color.White;
            this.btnOptmizeNow.Location = new System.Drawing.Point(13, 566);
            this.btnOptmizeNow.Name = "btnOptmizeNow";
            this.btnOptmizeNow.Size = new System.Drawing.Size(873, 69);
            this.btnOptmizeNow.TabIndex = 60;
            this.btnOptmizeNow.Text = "Optimize Now";
            this.btnOptmizeNow.TextColor = System.Drawing.Color.White;
            this.btnOptmizeNow.UseVisualStyleBackColor = false;
            this.btnOptmizeNow.Click += new System.EventHandler(this.btnOptmizeNow_Click);
            // 
            // btnRollback2
            // 
            this.btnRollback2.BackColor = System.Drawing.Color.Crimson;
            this.btnRollback2.BackgroundColor = System.Drawing.Color.Crimson;
            this.btnRollback2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRollback2.BorderRadius = 10;
            this.btnRollback2.BorderSize = 0;
            this.btnRollback2.Enabled = false;
            this.btnRollback2.FlatAppearance.BorderSize = 0;
            this.btnRollback2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRollback2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRollback2.ForeColor = System.Drawing.Color.White;
            this.btnRollback2.Location = new System.Drawing.Point(757, 523);
            this.btnRollback2.Name = "btnRollback2";
            this.btnRollback2.Size = new System.Drawing.Size(126, 37);
            this.btnRollback2.TabIndex = 61;
            this.btnRollback2.Text = "Roll Back";
            this.btnRollback2.TextColor = System.Drawing.Color.White;
            this.btnRollback2.UseVisualStyleBackColor = false;
            this.btnRollback2.Click += new System.EventHandler(this.btnRollback2_Click);
            // 
            // VistaOptimization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(49)))));
            this.Controls.Add(this.btnRollback2);
            this.Controls.Add(this.btnOptmizeNow);
            this.Controls.Add(this.lblCheckAll);
            this.Controls.Add(this.rjToggleButton1);
            this.Controls.Add(this.checkClearRecyclebin);
            this.Controls.Add(this.checkDisableSearch);
            this.Controls.Add(this.checkDisableSysM);
            this.Controls.Add(this.checkDisablePushN);
            this.Controls.Add(this.checkDisableGameModeWin);
            this.Controls.Add(this.checkClearEvLog);
            this.Controls.Add(this.checkDisableUpdates);
            this.Controls.Add(this.checkDelTempFilesUpdate);
            this.Controls.Add(this.checkEnergyPlan);
            this.Controls.Add(this.checkCacheDNS);
            this.Controls.Add(this.checkClearCache);
            this.Controls.Add(this.checkDisableServices);
            this.Controls.Add(this.checkDeleteTempFiles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUncheckAll);
            this.Name = "VistaOptimization";
            this.Size = new System.Drawing.Size(904, 648);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.CheckBox checkDisableSearch;
        public System.Windows.Forms.CheckBox checkDisableSysM;
        public System.Windows.Forms.CheckBox checkDisablePushN;
        public System.Windows.Forms.CheckBox checkDisableGameModeWin;
        public System.Windows.Forms.CheckBox checkClearEvLog;
        public System.Windows.Forms.CheckBox checkDisableUpdates;
        public System.Windows.Forms.CheckBox checkDelTempFilesUpdate;
        public System.Windows.Forms.CheckBox checkEnergyPlan;
        public System.Windows.Forms.CheckBox checkCacheDNS;
        public System.Windows.Forms.CheckBox checkClearCache;
        public System.Windows.Forms.CheckBox checkDisableServices;
        public System.Windows.Forms.CheckBox checkDeleteTempFiles;
        public System.Windows.Forms.CheckBox checkClearRecyclebin;
        private ToggleButton rjToggleButton1;
        private System.Windows.Forms.Label lblCheckAll;
        private System.Windows.Forms.Label lblUncheckAll;
        private FlatButton btnOptmizeNow;
        private FlatButton btnRollback2;
    }
}
