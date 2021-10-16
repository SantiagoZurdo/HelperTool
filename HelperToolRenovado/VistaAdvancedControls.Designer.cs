
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
            this.checkBoxDelFastAccs = new System.Windows.Forms.CheckBox();
            this.checkBoxDelObjects = new System.Windows.Forms.CheckBox();
            this.checkBoxDelVideo = new System.Windows.Forms.CheckBox();
            this.checkBoxDelImage = new System.Windows.Forms.CheckBox();
            this.checkBoxDelMusic = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxUnistallOneDrive = new System.Windows.Forms.CheckBox();
            this.checkBoxDisableFirewall = new System.Windows.Forms.CheckBox();
            this.checkBoxDisableRunasAdmin = new System.Windows.Forms.CheckBox();
            this.checkBoxDisableNotifications = new System.Windows.Forms.CheckBox();
            this.checkBoxDisableDefender = new System.Windows.Forms.CheckBox();
            this.lblCheckAll2 = new System.Windows.Forms.Label();
            this.lblUncheckAll2 = new System.Windows.Forms.Label();
            this.SwitchChecked = new HelperToolRenovado.ToggleButton();
            this.btnGoAdvancedOptions = new HelperToolRenovado.FlatButton();
            this.SuspendLayout();
            // 
            // checkBoxDelFastAccs
            // 
            this.checkBoxDelFastAccs.AutoSize = true;
            this.checkBoxDelFastAccs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDelFastAccs.ForeColor = System.Drawing.Color.White;
            this.checkBoxDelFastAccs.Location = new System.Drawing.Point(22, 193);
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
            this.checkBoxDelObjects.Location = new System.Drawing.Point(22, 163);
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
            this.checkBoxDelVideo.Location = new System.Drawing.Point(22, 133);
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
            this.checkBoxDelImage.Location = new System.Drawing.Point(22, 103);
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
            this.checkBoxDelMusic.Location = new System.Drawing.Point(22, 73);
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
            this.label2.Location = new System.Drawing.Point(320, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 33);
            this.label2.TabIndex = 37;
            this.label2.Text = "Advanced Options";
            // 
            // checkBoxUnistallOneDrive
            // 
            this.checkBoxUnistallOneDrive.AutoSize = true;
            this.checkBoxUnistallOneDrive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxUnistallOneDrive.ForeColor = System.Drawing.Color.White;
            this.checkBoxUnistallOneDrive.Location = new System.Drawing.Point(22, 223);
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
            this.checkBoxDisableFirewall.Location = new System.Drawing.Point(22, 253);
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
            this.checkBoxDisableRunasAdmin.Location = new System.Drawing.Point(22, 283);
            this.checkBoxDisableRunasAdmin.Name = "checkBoxDisableRunasAdmin";
            this.checkBoxDisableRunasAdmin.Size = new System.Drawing.Size(375, 24);
            this.checkBoxDisableRunasAdmin.TabIndex = 48;
            this.checkBoxDisableRunasAdmin.TabStop = false;
            this.checkBoxDisableRunasAdmin.Text = "- Disable run as administrator messages";
            this.checkBoxDisableRunasAdmin.UseVisualStyleBackColor = true;
            this.checkBoxDisableRunasAdmin.CheckStateChanged += new System.EventHandler(this.Checkear);
            // 
            // checkBoxDisableNotifications
            // 
            this.checkBoxDisableNotifications.AutoSize = true;
            this.checkBoxDisableNotifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDisableNotifications.ForeColor = System.Drawing.Color.White;
            this.checkBoxDisableNotifications.Location = new System.Drawing.Point(22, 313);
            this.checkBoxDisableNotifications.Name = "checkBoxDisableNotifications";
            this.checkBoxDisableNotifications.Size = new System.Drawing.Size(324, 24);
            this.checkBoxDisableNotifications.TabIndex = 49;
            this.checkBoxDisableNotifications.TabStop = false;
            this.checkBoxDisableNotifications.Text = "- Disable all Windows notifications";
            this.checkBoxDisableNotifications.UseVisualStyleBackColor = true;
            this.checkBoxDisableNotifications.CheckStateChanged += new System.EventHandler(this.Checkear);
            // 
            // checkBoxDisableDefender
            // 
            this.checkBoxDisableDefender.AutoSize = true;
            this.checkBoxDisableDefender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDisableDefender.ForeColor = System.Drawing.Color.White;
            this.checkBoxDisableDefender.Location = new System.Drawing.Point(22, 343);
            this.checkBoxDisableDefender.Name = "checkBoxDisableDefender";
            this.checkBoxDisableDefender.Size = new System.Drawing.Size(272, 24);
            this.checkBoxDisableDefender.TabIndex = 50;
            this.checkBoxDisableDefender.TabStop = false;
            this.checkBoxDisableDefender.Text = "- Disable Windows Defender";
            this.checkBoxDisableDefender.UseVisualStyleBackColor = true;
            this.checkBoxDisableDefender.CheckStateChanged += new System.EventHandler(this.Checkear);
            // 
            // lblCheckAll2
            // 
            this.lblCheckAll2.AutoSize = true;
            this.lblCheckAll2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckAll2.ForeColor = System.Drawing.Color.White;
            this.lblCheckAll2.Location = new System.Drawing.Point(18, 509);
            this.lblCheckAll2.Name = "lblCheckAll2";
            this.lblCheckAll2.Size = new System.Drawing.Size(80, 20);
            this.lblCheckAll2.TabIndex = 60;
            this.lblCheckAll2.Text = "Check All";
            // 
            // lblUncheckAll2
            // 
            this.lblUncheckAll2.AutoSize = true;
            this.lblUncheckAll2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUncheckAll2.ForeColor = System.Drawing.Color.White;
            this.lblUncheckAll2.Location = new System.Drawing.Point(155, 511);
            this.lblUncheckAll2.Name = "lblUncheckAll2";
            this.lblUncheckAll2.Size = new System.Drawing.Size(101, 20);
            this.lblUncheckAll2.TabIndex = 61;
            this.lblUncheckAll2.Text = "UnCheck All";
            this.lblUncheckAll2.Visible = false;
            // 
            // SwitchChecked
            // 
            this.SwitchChecked.AutoSize = true;
            this.SwitchChecked.Location = new System.Drawing.Point(104, 509);
            this.SwitchChecked.MinimumSize = new System.Drawing.Size(45, 22);
            this.SwitchChecked.Name = "SwitchChecked";
            this.SwitchChecked.OffBackColor = System.Drawing.Color.Gray;
            this.SwitchChecked.OffBackColor1 = System.Drawing.Color.Gray;
            this.SwitchChecked.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.SwitchChecked.OffToggleColor1 = System.Drawing.Color.Gainsboro;
            this.SwitchChecked.OnBackColor = System.Drawing.SystemColors.Highlight;
            this.SwitchChecked.OnBackColor1 = System.Drawing.SystemColors.Highlight;
            this.SwitchChecked.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.SwitchChecked.OnToggleColor1 = System.Drawing.Color.WhiteSmoke;
            this.SwitchChecked.Size = new System.Drawing.Size(45, 22);
            this.SwitchChecked.SolidStyle1 = true;
            this.SwitchChecked.TabIndex = 58;
            this.SwitchChecked.UseVisualStyleBackColor = true;
            this.SwitchChecked.CheckedChanged += new System.EventHandler(this.rjToggleButton1_CheckedChanged);
            // 
            // btnGoAdvancedOptions
            // 
            this.btnGoAdvancedOptions.BackColor = System.Drawing.Color.Gray;
            this.btnGoAdvancedOptions.BackgroundColor = System.Drawing.Color.Gray;
            this.btnGoAdvancedOptions.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGoAdvancedOptions.BorderRadius = 20;
            this.btnGoAdvancedOptions.BorderSize = 0;
            this.btnGoAdvancedOptions.Enabled = false;
            this.btnGoAdvancedOptions.FlatAppearance.BorderSize = 0;
            this.btnGoAdvancedOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoAdvancedOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoAdvancedOptions.ForeColor = System.Drawing.Color.White;
            this.btnGoAdvancedOptions.Location = new System.Drawing.Point(13, 566);
            this.btnGoAdvancedOptions.Name = "btnGoAdvancedOptions";
            this.btnGoAdvancedOptions.Size = new System.Drawing.Size(873, 69);
            this.btnGoAdvancedOptions.TabIndex = 62;
            this.btnGoAdvancedOptions.Text = "Optimize Now";
            this.btnGoAdvancedOptions.TextColor = System.Drawing.Color.White;
            this.btnGoAdvancedOptions.UseVisualStyleBackColor = false;
            this.btnGoAdvancedOptions.Click += new System.EventHandler(this.btnGoAdvancedOptions_Click);
            // 
            // VistaAdvancedControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(49)))));
            this.Controls.Add(this.lblCheckAll2);
            this.Controls.Add(this.btnGoAdvancedOptions);
            this.Controls.Add(this.SwitchChecked);
            this.Controls.Add(this.checkBoxDisableDefender);
            this.Controls.Add(this.checkBoxDisableNotifications);
            this.Controls.Add(this.checkBoxDisableRunasAdmin);
            this.Controls.Add(this.checkBoxDisableFirewall);
            this.Controls.Add(this.checkBoxUnistallOneDrive);
            this.Controls.Add(this.checkBoxDelFastAccs);
            this.Controls.Add(this.checkBoxDelObjects);
            this.Controls.Add(this.checkBoxDelVideo);
            this.Controls.Add(this.checkBoxDelImage);
            this.Controls.Add(this.checkBoxDelMusic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblUncheckAll2);
            this.Name = "VistaAdvancedControls";
            this.Size = new System.Drawing.Size(904, 648);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBoxDelFastAccs;
        private System.Windows.Forms.CheckBox checkBoxDelObjects;
        private System.Windows.Forms.CheckBox checkBoxDelVideo;
        private System.Windows.Forms.CheckBox checkBoxDelImage;
        private System.Windows.Forms.CheckBox checkBoxDelMusic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxUnistallOneDrive;
        private System.Windows.Forms.CheckBox checkBoxDisableFirewall;
        private System.Windows.Forms.CheckBox checkBoxDisableRunasAdmin;
        private System.Windows.Forms.CheckBox checkBoxDisableNotifications;
        private System.Windows.Forms.CheckBox checkBoxDisableDefender;
        private ToggleButton SwitchChecked;
        private System.Windows.Forms.Label lblCheckAll2;
        private System.Windows.Forms.Label lblUncheckAll2;
        private FlatButton btnGoAdvancedOptions;
    }
}
