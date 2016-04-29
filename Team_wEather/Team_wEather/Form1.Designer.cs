namespace Team_wEather
{
    partial class main
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
            this.btn_getWx = new System.Windows.Forms.Button();
            this.txtBx_Zip = new System.Windows.Forms.TextBox();
            this.lbl_Zip = new System.Windows.Forms.Label();
            this.lstBx_DisplayWx = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_getWx
            // 
            this.btn_getWx.Location = new System.Drawing.Point(174, 11);
            this.btn_getWx.Name = "btn_getWx";
            this.btn_getWx.Size = new System.Drawing.Size(111, 23);
            this.btn_getWx.TabIndex = 0;
            this.btn_getWx.Text = "Get Weather";
            this.btn_getWx.UseVisualStyleBackColor = true;
            this.btn_getWx.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBx_Zip
            // 
            this.txtBx_Zip.Location = new System.Drawing.Point(68, 13);
            this.txtBx_Zip.Name = "txtBx_Zip";
            this.txtBx_Zip.Size = new System.Drawing.Size(100, 20);
            this.txtBx_Zip.TabIndex = 1;
            // 
            // lbl_Zip
            // 
            this.lbl_Zip.AutoSize = true;
            this.lbl_Zip.Location = new System.Drawing.Point(12, 16);
            this.lbl_Zip.Name = "lbl_Zip";
            this.lbl_Zip.Size = new System.Drawing.Size(50, 13);
            this.lbl_Zip.TabIndex = 2;
            this.lbl_Zip.Text = "Zip Code";
            // 
            // lstBx_DisplayWx
            // 
            this.lstBx_DisplayWx.FormattingEnabled = true;
            this.lstBx_DisplayWx.Location = new System.Drawing.Point(12, 39);
            this.lstBx_DisplayWx.Name = "lstBx_DisplayWx";
            this.lstBx_DisplayWx.Size = new System.Drawing.Size(273, 225);
            this.lstBx_DisplayWx.TabIndex = 3;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 285);
            this.Controls.Add(this.lstBx_DisplayWx);
            this.Controls.Add(this.lbl_Zip);
            this.Controls.Add(this.txtBx_Zip);
            this.Controls.Add(this.btn_getWx);
            this.Name = "main";
            this.Text = "Team_wEather";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_getWx;
        private System.Windows.Forms.TextBox txtBx_Zip;
        private System.Windows.Forms.Label lbl_Zip;
        private System.Windows.Forms.ListBox lstBx_DisplayWx;
    }
}

