namespace Elgato_Keylight_External_Configurator
{
    partial class ElgatoKeylightConfigurator
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElgatoKeylightConfigurator));
            this.ConnectButton = new System.Windows.Forms.Button();
            this.IpAddress = new System.Windows.Forms.TextBox();
            this.BrightnessTrackbar = new System.Windows.Forms.TrackBar();
            this.TemperatureTrackbar = new System.Windows.Forms.TrackBar();
            this.DisplayNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BrightnessTrackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TemperatureTrackbar)).BeginInit();
            this.SuspendLayout();
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(295, 12);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(75, 20);
            this.ConnectButton.TabIndex = 0;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // IpAddress
            // 
            this.IpAddress.Location = new System.Drawing.Point(13, 12);
            this.IpAddress.Name = "IpAddress";
            this.IpAddress.Size = new System.Drawing.Size(276, 20);
            this.IpAddress.TabIndex = 1;
            this.IpAddress.Text = "192.168.1.1";
            // 
            // BrightnessTrackbar
            // 
            this.BrightnessTrackbar.Enabled = false;
            this.BrightnessTrackbar.Location = new System.Drawing.Point(12, 86);
            this.BrightnessTrackbar.Maximum = 100;
            this.BrightnessTrackbar.Name = "BrightnessTrackbar";
            this.BrightnessTrackbar.Size = new System.Drawing.Size(357, 45);
            this.BrightnessTrackbar.TabIndex = 2;
            this.BrightnessTrackbar.TickFrequency = 10;
            this.BrightnessTrackbar.Scroll += new System.EventHandler(this.BrightnessTrackbar_Scroll);
            // 
            // TemperatureTrackbar
            // 
            this.TemperatureTrackbar.Enabled = false;
            this.TemperatureTrackbar.Location = new System.Drawing.Point(12, 146);
            this.TemperatureTrackbar.Maximum = 344;
            this.TemperatureTrackbar.Minimum = 143;
            this.TemperatureTrackbar.Name = "TemperatureTrackbar";
            this.TemperatureTrackbar.Size = new System.Drawing.Size(357, 45);
            this.TemperatureTrackbar.TabIndex = 3;
            this.TemperatureTrackbar.Value = 143;
            this.TemperatureTrackbar.Scroll += new System.EventHandler(this.TemperatureTrackbar_Scroll);
            // 
            // DisplayNameLabel
            // 
            this.DisplayNameLabel.AutoSize = true;
            this.DisplayNameLabel.Location = new System.Drawing.Point(12, 39);
            this.DisplayNameLabel.Name = "DisplayNameLabel";
            this.DisplayNameLabel.Size = new System.Drawing.Size(78, 13);
            this.DisplayNameLabel.TabIndex = 4;
            this.DisplayNameLabel.Text = "Not connected";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Brightness";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Color Temperature";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Made by maduranma to solve Alexelcapo\'s problem";
            // 
            // ElgatoKeylightConfigurator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 215);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DisplayNameLabel);
            this.Controls.Add(this.TemperatureTrackbar);
            this.Controls.Add(this.BrightnessTrackbar);
            this.Controls.Add(this.IpAddress);
            this.Controls.Add(this.ConnectButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ElgatoKeylightConfigurator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elgato Keylight External Configurator";
            this.Load += new System.EventHandler(this.ElgatoKeylightConfigurator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BrightnessTrackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TemperatureTrackbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.TextBox IpAddress;
        private System.Windows.Forms.TrackBar BrightnessTrackbar;
        private System.Windows.Forms.TrackBar TemperatureTrackbar;
        private System.Windows.Forms.Label DisplayNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

