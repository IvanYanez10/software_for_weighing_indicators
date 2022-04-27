namespace weighting_soft
{
    partial class InitialConfigurationScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTryconnection = new System.Windows.Forms.Button();
            this.linkHelp = new System.Windows.Forms.LinkLabel();
            this.cBPort = new System.Windows.Forms.ComboBox();
            this.cBBaud = new System.Windows.Forms.ComboBox();
            this.lblErr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Configuracion inicial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Puerto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Baud";
            // 
            // btnTryconnection
            // 
            this.btnTryconnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTryconnection.Location = new System.Drawing.Point(23, 125);
            this.btnTryconnection.Name = "btnTryconnection";
            this.btnTryconnection.Size = new System.Drawing.Size(260, 40);
            this.btnTryconnection.TabIndex = 4;
            this.btnTryconnection.Text = "Probar conexion";
            this.btnTryconnection.UseVisualStyleBackColor = true;
            this.btnTryconnection.Click += new System.EventHandler(this.btnTryconnection_Click);
            // 
            // linkHelp
            // 
            this.linkHelp.AutoSize = true;
            this.linkHelp.Location = new System.Drawing.Point(135, 179);
            this.linkHelp.Name = "linkHelp";
            this.linkHelp.Size = new System.Drawing.Size(37, 13);
            this.linkHelp.TabIndex = 5;
            this.linkHelp.TabStop = true;
            this.linkHelp.Text = "Ayuda";
            this.linkHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkHelp_LinkClicked);
            // 
            // cBPort
            // 
            this.cBPort.FormattingEnabled = true;
            this.cBPort.Location = new System.Drawing.Point(126, 50);
            this.cBPort.Name = "cBPort";
            this.cBPort.Size = new System.Drawing.Size(135, 21);
            this.cBPort.TabIndex = 6;
            // 
            // cBBaud
            // 
            this.cBBaud.FormattingEnabled = true;
            this.cBBaud.Items.AddRange(new object[] {
            "2400",
            "9600",
            "57600"});
            this.cBBaud.Location = new System.Drawing.Point(126, 89);
            this.cBBaud.Name = "cBBaud";
            this.cBBaud.Size = new System.Drawing.Size(135, 21);
            this.cBBaud.TabIndex = 7;
            // 
            // lblErr
            // 
            this.lblErr.AutoSize = true;
            this.lblErr.Location = new System.Drawing.Point(135, 214);
            this.lblErr.Name = "lblErr";
            this.lblErr.Size = new System.Drawing.Size(35, 13);
            this.lblErr.TabIndex = 8;
            this.lblErr.Text = "label4";
            // 
            // InitialConfigurationScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 236);
            this.Controls.Add(this.lblErr);
            this.Controls.Add(this.cBBaud);
            this.Controls.Add(this.cBPort);
            this.Controls.Add(this.linkHelp);
            this.Controls.Add(this.btnTryconnection);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InitialConfigurationScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuracion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTryconnection;
        private System.Windows.Forms.LinkLabel linkHelp;
        private System.Windows.Forms.ComboBox cBPort;
        private System.Windows.Forms.ComboBox cBBaud;
        private System.Windows.Forms.Label lblErr;
    }
}