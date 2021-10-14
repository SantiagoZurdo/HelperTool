
namespace HelperToolRenovado
{
    partial class VistaAdvancedControls
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
            this.btnCheckAll_Advanced = new System.Windows.Forms.Button();
            this.btnGoAdvancedOptions = new System.Windows.Forms.Button();
            this.checkBoxDelFastAccs = new System.Windows.Forms.CheckBox();
            this.checkBoxDelObjects = new System.Windows.Forms.CheckBox();
            this.checkBoxDelVideo = new System.Windows.Forms.CheckBox();
            this.checkBoxDelImage = new System.Windows.Forms.CheckBox();
            this.checkBoxDelMusic = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUnCheckAll_Advanced = new System.Windows.Forms.Button();
            this.checkBoxUnistallOneDrive = new System.Windows.Forms.CheckBox();
            this.checkBoxDisableFirewall = new System.Windows.Forms.CheckBox();
            this.checkBoxDisableRunasAdmin = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnCheckAll_Advanced
            // 
            this.btnCheckAll_Advanced.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCheckAll_Advanced.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckAll_Advanced.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckAll_Advanced.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckAll_Advanced.ForeColor = System.Drawing.Color.White;
            this.btnCheckAll_Advanced.Location = new System.Drawing.Point(382, 502);
            this.btnCheckAll_Advanced.Name = "btnCheckAll_Advanced";
            this.btnCheckAll_Advanced.Size = new System.Drawing.Size(126, 37);
            this.btnCheckAll_Advanced.TabIndex = 44;
            this.btnCheckAll_Advanced.TabStop = false;
            this.btnCheckAll_Advanced.Text = "Check All";
            this.btnCheckAll_Advanced.UseVisualStyleBackColor = true;
            this.btnCheckAll_Advanced.Click += new System.EventHandler(this.btnCheckAll_Advanced_Click);
            // 
            // btnGoAdvancedOptions
            // 
            this.btnGoAdvancedOptions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGoAdvancedOptions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoAdvancedOptions.Enabled = false;
            this.btnGoAdvancedOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoAdvancedOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoAdvancedOptions.ForeColor = System.Drawing.Color.White;
            this.btnGoAdvancedOptions.Location = new System.Drawing.Point(22, 566);
            this.btnGoAdvancedOptions.Name = "btnGoAdvancedOptions";
            this.btnGoAdvancedOptions.Size = new System.Drawing.Size(859, 59);
            this.btnGoAdvancedOptions.TabIndex = 43;
            this.btnGoAdvancedOptions.TabStop = false;
            this.btnGoAdvancedOptions.Text = "GO!";
            this.btnGoAdvancedOptions.UseVisualStyleBackColor = true;
            this.btnGoAdvancedOptions.Click += new System.EventHandler(this.btnGoAdvancedOptions_Click);
            // 
            // checkBoxDelFastAccs
            // 
            this.checkBoxDelFastAccs.AutoSize = true;
            this.checkBoxDelFastAccs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDelFastAccs.ForeColor = System.Drawing.Color.White;
            this.checkBoxDelFastAccs.Location = new System.Drawing.Point(22, 201);
            this.checkBoxDelFastAccs.Name = "checkBoxDelFastAccs";
            this.checkBoxDelFastAccs.Size = new System.Drawing.Size(247, 24);
            this.checkBoxDelFastAccs.TabIndex = 42;
            this.checkBoxDelFastAccs.TabStop = false;
            this.checkBoxDelFastAccs.Text = "- Delete fast acces folder";
            this.checkBoxDelFastAccs.UseVisualStyleBackColor = true;
            this.checkBoxDelFastAccs.CheckStateChanged += new System.EventHandler(this.Checkear);
            // 
            // checkBoxDelObjects
            // 
            this.checkBoxDelObjects.AutoSize = true;
            this.checkBoxDelObjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDelObjects.ForeColor = System.Drawing.Color.White;
            this.checkBoxDelObjects.Location = new System.Drawing.Point(22, 171);
            this.checkBoxDelObjects.Name = "checkBoxDelObjects";
            this.checkBoxDelObjects.Size = new System.Drawing.Size(244, 24);
            this.checkBoxDelObjects.TabIndex = 41;
            this.checkBoxDelObjects.TabStop = false;
            this.checkBoxDelObjects.Text = "- Delete objects3D folder";
            this.checkBoxDelObjects.UseVisualStyleBackColor = true;
            this.checkBoxDelObjects.CheckStateChanged += new System.EventHandler(this.Checkear);
            // 
            // checkBoxDelVideo
            // 
            this.checkBoxDelVideo.AutoSize = true;
            this.checkBoxDelVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDelVideo.ForeColor = System.Drawing.Color.White;
            this.checkBoxDelVideo.Location = new System.Drawing.Point(22, 141);
            this.checkBoxDelVideo.Name = "checkBoxDelVideo";
            this.checkBoxDelVideo.Size = new System.Drawing.Size(203, 24);
            this.checkBoxDelVideo.TabIndex = 40;
            this.checkBoxDelVideo.TabStop = false;
            this.checkBoxDelVideo.Text = "- Delete video folder";
            this.checkBoxDelVideo.UseVisualStyleBackColor = true;
            this.checkBoxDelVideo.CheckStateChanged += new System.EventHandler(this.Checkear);
            // 
            // checkBoxDelImage
            // 
            this.checkBoxDelImage.AutoSize = true;
            this.checkBoxDelImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDelImage.ForeColor = System.Drawing.Color.White;
            this.checkBoxDelImage.Location = new System.Drawing.Point(22, 111);
            this.checkBoxDelImage.Name = "checkBoxDelImage";
            this.checkBoxDelImage.Size = new System.Drawing.Size(209, 24);
            this.checkBoxDelImage.TabIndex = 39;
            this.checkBoxDelImage.TabStop = false;
            this.checkBoxDelImage.Text = "- Delete image folder";
            this.checkBoxDelImage.UseVisualStyleBackColor = true;
            this.checkBoxDelImage.CheckStateChanged += new System.EventHandler(this.Checkear);
            // 
            // checkBoxDelMusic
            // 
            this.checkBoxDelMusic.AutoSize = true;
            this.checkBoxDelMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDelMusic.ForeColor = System.Drawing.Color.White;
            this.checkBoxDelMusic.Location = new System.Drawing.Point(22, 81);
            this.checkBoxDelMusic.Name = "checkBoxDelMusic";
            this.checkBoxDelMusic.Size = new System.Drawing.Size(209, 24);
            this.checkBoxDelMusic.TabIndex = 38;
            this.checkBoxDelMusic.TabStop = false;
            this.checkBoxDelMusic.Text = "- Delete music folder";
            this.checkBoxDelMusic.UseVisualStyleBackColor = true;
            this.checkBoxDelMusic.CheckStateChanged += new System.EventHandler(this.Checkear);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(372, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 33);
            this.label2.TabIndex = 37;
            this.label2.Text = "Advanced Options";
            // 
            // btnUnCheckAll_Advanced
            // 
            this.btnUnCheckAll_Advanced.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUnCheckAll_Advanced.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUnCheckAll_Advanced.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnCheckAll_Advanced.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnCheckAll_Advanced.ForeColor = System.Drawing.Color.White;
            this.btnUnCheckAll_Advanced.Location = new System.Drawing.Point(382, 502);
            this.btnUnCheckAll_Advanced.Name = "btnUnCheckAll_Advanced";
            this.btnUnCheckAll_Advanced.Size = new System.Drawing.Size(126, 37);
            this.btnUnCheckAll_Advanced.TabIndex = 45;
            this.btnUnCheckAll_Advanced.TabStop = false;
            this.btnUnCheckAll_Advanced.Text = "Uncheck All";
            this.btnUnCheckAll_Advanced.UseVisualStyleBackColor = true;
            this.btnUnCheckAll_Advanced.Click += new System.EventHandler(this.btnUnCheckAll_Advanced_Click);
            // 
            // checkBoxUnistallOneDrive
            // 
            this.checkBoxUnistallOneDrive.AutoSize = true;
            this.checkBoxUnistallOneDrive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxUnistallOneDrive.ForeColor = System.Drawing.Color.White;
            this.checkBoxUnistallOneDrive.Location = new System.Drawing.Point(22, 231);
            this.checkBoxUnistallOneDrive.Name = "checkBoxUnistallOneDrive";
            this.checkBoxUnistallOneDrive.Size = new System.Drawing.Size(193, 24);
            this.checkBoxUnistallOneDrive.TabIndex = 46;
            this.checkBoxUnistallOneDrive.TabStop = false;
            this.checkBoxUnistallOneDrive.Text = "- Unistall OneDrive";
            this.checkBoxUnistallOneDrive.UseVisualStyleBackColor = true;
            this.checkBoxUnistallOneDrive.CheckStateChanged += new System.EventHandler(this.Checkear);
            // 
            // checkBoxDisableFirewall
            // 
            this.checkBoxDisableFirewall.AutoSize = true;
            this.checkBoxDisableFirewall.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDisableFirewall.ForeColor = System.Drawing.Color.White;
            this.checkBoxDisableFirewall.Location = new System.Drawing.Point(22, 261);
            this.checkBoxDisableFirewall.Name = "checkBoxDisableFirewall";
            this.checkBoxDisableFirewall.Size = new System.Drawing.Size(180, 24);
            this.checkBoxDisableFirewall.TabIndex = 47;
            this.checkBoxDisableFirewall.TabStop = false;
            this.checkBoxDisableFirewall.Text = "- Disable Firewall";
            this.checkBoxDisableFirewall.UseVisualStyleBackColor = true;
            this.checkBoxDisableFirewall.CheckStateChanged += new System.EventHandler(this.Checkear);
            // 
            // checkBoxDisableRunasAdmin
            // 
            this.checkBoxDisableRunasAdmin.AutoSize = true;
            this.checkBoxDisableRunasAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDisableRunasAdmin.ForeColor = System.Drawing.Color.White;
            this.checkBoxDisableRunasAdmin.Location = new System.Drawing.Point(22, 291);
            this.checkBoxDisableRunasAdmin.Name = "checkBoxDisableRunasAdmin";
            this.checkBoxDisableRunasAdmin.Size = new System.Drawing.Size(375, 24);
            this.checkBoxDisableRunasAdmin.TabIndex = 48;
            this.checkBoxDisableRunasAdmin.TabStop = false;
            this.checkBoxDisableRunasAdmin.Text = "- Disable run as administrator messages";
            this.checkBoxDisableRunasAdmin.UseVisualStyleBackColor = true;
            this.checkBoxDisableRunasAdmin.CheckStateChanged += new System.EventHandler(this.Checkear);
            // 
            // VistaAdvancedControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(49)))));
            this.Controls.Add(this.checkBoxDisableRunasAdmin);
            this.Controls.Add(this.checkBoxDisableFirewall);
            this.Controls.Add(this.checkBoxUnistallOneDrive);
            this.Controls.Add(this.btnCheckAll_Advanced);
            this.Controls.Add(this.btnGoAdvancedOptions);
            this.Controls.Add(this.checkBoxDelFastAccs);
            this.Controls.Add(this.checkBoxDelObjects);
            this.Controls.Add(this.checkBoxDelVideo);
            this.Controls.Add(this.checkBoxDelImage);
            this.Controls.Add(this.checkBoxDelMusic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUnCheckAll_Advanced);
            this.Name = "VistaAdvancedControls";
            this.Size = new System.Drawing.Size(904, 648);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheckAll_Advanced;
        private System.Windows.Forms.Button btnGoAdvancedOptions;
        private System.Windows.Forms.CheckBox checkBoxDelFastAccs;
        private System.Windows.Forms.CheckBox checkBoxDelObjects;
        private System.Windows.Forms.CheckBox checkBoxDelVideo;
        private System.Windows.Forms.CheckBox checkBoxDelImage;
        private System.Windows.Forms.CheckBox checkBoxDelMusic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUnCheckAll_Advanced;
        private System.Windows.Forms.CheckBox checkBoxUnistallOneDrive;
        private System.Windows.Forms.CheckBox checkBoxDisableFirewall;
        private System.Windows.Forms.CheckBox checkBoxDisableRunasAdmin;
    }
}
