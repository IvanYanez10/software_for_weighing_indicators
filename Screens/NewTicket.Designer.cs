namespace weighting_soft.Screens
{
    partial class NewTicket
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
            this.pnlElements = new System.Windows.Forms.Panel();
            this.pnlTicketPreview = new System.Windows.Forms.Panel();
            this.pnlElementProperties = new System.Windows.Forms.Panel();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.pnlElements.SuspendLayout();
            this.pnlElementProperties.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlElements
            // 
            this.pnlElements.Controls.Add(this.label2);
            this.pnlElements.Location = new System.Drawing.Point(12, 53);
            this.pnlElements.Name = "pnlElements";
            this.pnlElements.Size = new System.Drawing.Size(162, 422);
            this.pnlElements.TabIndex = 0;
            // 
            // pnlTicketPreview
            // 
            this.pnlTicketPreview.Location = new System.Drawing.Point(180, 53);
            this.pnlTicketPreview.Name = "pnlTicketPreview";
            this.pnlTicketPreview.Size = new System.Drawing.Size(386, 422);
            this.pnlTicketPreview.TabIndex = 1;
            // 
            // pnlElementProperties
            // 
            this.pnlElementProperties.Controls.Add(this.label1);
            this.pnlElementProperties.Location = new System.Drawing.Point(572, 53);
            this.pnlElementProperties.Name = "pnlElementProperties";
            this.pnlElementProperties.Size = new System.Drawing.Size(200, 422);
            this.pnlElementProperties.TabIndex = 2;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.button2);
            this.pnlButtons.Controls.Add(this.button1);
            this.pnlButtons.Location = new System.Drawing.Point(12, 481);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(760, 54);
            this.pnlButtons.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(454, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "Imprimir prueba";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(631, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Element name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Elementos disponibles";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 35);
            this.panel1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nuevo ticket";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(723, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(20, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // NewTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 550);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlElementProperties);
            this.Controls.Add(this.pnlTicketPreview);
            this.Controls.Add(this.pnlElements);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewTicket";
            this.Text = "Nuevo ticket";
            this.pnlElements.ResumeLayout(false);
            this.pnlElements.PerformLayout();
            this.pnlElementProperties.ResumeLayout(false);
            this.pnlElementProperties.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlElements;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlTicketPreview;
        private System.Windows.Forms.Panel pnlElementProperties;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
    }
}