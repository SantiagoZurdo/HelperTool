
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
            this.btnCheckAll = new System.Windows.Forms.Button();
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
            this.btnOptmizeNow = new System.Windows.Forms.Button();
            this.btnRollback = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUncheckAll = new System.Windows.Forms.Button();
            this.checkClearRecyclebin = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnCheckAll
            // 
            this.btnCheckAll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCheckAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckAll.ForeColor = System.Drawing.Color.White;
            this.btnCheckAll.Location = new System.Drawing.Point(381, 517);
            this.btnCheckAll.Name = "btnCheckAll";
            this.btnCheckAll.Size = new System.Drawing.Size(126, 35);
            this.btnCheckAll.TabIndex = 42;
            this.btnCheckAll.TabStop = false;
            this.btnCheckAll.Text = "Check All";
            this.btnCheckAll.UseVisualStyleBackColor = true;
            this.btnCheckAll.Click += new System.EventHandler(this.btnCheckAll_Click);
            // 
            // checkDisableSearch
            // 
            this.checkDisableSearch.AutoSize = true;
            this.checkDisableSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkDisableSearch.ForeColor = System.Drawing.Color.White;
            this.checkDisableSearch.Location = new System.Drawing.Point(22, 376);
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
            this.checkDisableSysM.Location = new System.Drawing.Point(22, 316);
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
            this.checkDisablePushN.Location = new System.Drawing.Point(22, 286);
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
            this.checkDisableGameModeWin.Location = new System.Drawing.Point(22, 256);
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
            this.checkDisableUpdates.Location = new System.Drawing.Point(22, 346);
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
            this.checkEnergyPlan.Location = new System.Drawing.Point(22, 226);
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
            this.checkDisableServices.Location = new System.Drawing.Point(22, 406);
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
            // btnOptmizeNow
            // 
            this.btnOptmizeNow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOptmizeNow.Enabled = false;
            this.btnOptmizeNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptmizeNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptmizeNow.ForeColor = System.Drawing.Color.White;
            this.btnOptmizeNow.Location = new System.Drawing.Point(13, 571);
            this.btnOptmizeNow.Name = "btnOptmizeNow";
            this.btnOptmizeNow.Size = new System.Drawing.Size(873, 59);
            this.btnOptmizeNow.TabIndex = 41;
            this.btnOptmizeNow.TabStop = false;
            this.btnOptmizeNow.Text = "Optimize Now";
            this.btnOptmizeNow.UseVisualStyleBackColor = true;
            this.btnOptmizeNow.Click += new System.EventHandler(this.btnOptmizeNow_Click);
            // 
            // btnRollback
            // 
            this.btnRollback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRollback.Enabled = false;
            this.btnRollback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRollback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRollback.ForeColor = System.Drawing.Color.LightCoral;
            this.btnRollback.Location = new System.Drawing.Point(16, 529);
            this.btnRollback.Name = "btnRollback";
            this.btnRollback.Size = new System.Drawing.Size(112, 36);
            this.btnRollback.TabIndex = 40;
            this.btnRollback.TabStop = false;
            this.btnRollback.Text = "Rollback";
            this.btnRollback.UseVisualStyleBackColor = true;
            this.btnRollback.Click += new System.EventHandler(this.btnRollback_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(375, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 33);
            this.label1.TabIndex = 39;
            this.label1.Text = "Optimize Options";
            // 
            // btnUncheckAll
            // 
            this.btnUncheckAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUncheckAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUncheckAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUncheckAll.ForeColor = System.Drawing.Color.White;
            this.btnUncheckAll.Location = new System.Drawing.Point(381, 517);
            this.btnUncheckAll.Name = "btnUncheckAll";
            this.btnUncheckAll.Size = new System.Drawing.Size(126, 35);
            this.btnUncheckAll.TabIndex = 43;
            this.btnUncheckAll.TabStop = false;
            this.btnUncheckAll.Text = "Uncheck All";
            this.btnUncheckAll.UseVisualStyleBackColor = true;
            this.btnUncheckAll.Click += new System.EventHandler(this.btnUncheckAll_Click);
            // 
            // checkClearRecyclebin
            // 
            this.checkClearRecyclebin.AutoSize = true;
            this.checkClearRecyclebin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkClearRecyclebin.ForeColor = System.Drawing.Color.White;
            this.checkClearRecyclebin.Location = new System.Drawing.Point(22, 436);
            this.checkClearRecyclebin.Name = "checkClearRecyclebin";
            this.checkClearRecyclebin.Size = new System.Drawing.Size(193, 24);
            this.checkClearRecyclebin.TabIndex = 56;
            this.checkClearRecyclebin.TabStop = false;
            this.checkClearRecyclebin.Text = "- Clear Recycle bin";
            this.checkClearRecyclebin.UseVisualStyleBackColor = true;
            this.checkClearRecyclebin.CheckStateChanged += new System.EventHandler(this.Checkear);
            // 
            // VistaOptimization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(49)))));
            this.Controls.Add(this.checkClearRecyclebin);
            this.Controls.Add(this.btnCheckAll);
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
            this.Controls.Add(this.btnOptmizeNow);
            this.Controls.Add(this.btnRollback);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUncheckAll);
            this.Name = "VistaOptimization";
            this.Size = new System.Drawing.Size(904, 648);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheckAll;
        private System.Windows.Forms.Button btnRollback;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUncheckAll;
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
        private System.Windows.Forms.Button btnOptmizeNow;
        public System.Windows.Forms.CheckBox checkClearRecyclebin;
    }
}
