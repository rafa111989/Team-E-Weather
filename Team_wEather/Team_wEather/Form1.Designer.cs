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
            this.lbl_city = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblTemp_output = new System.Windows.Forms.Label();
            this.lbl_tempFaren_Output = new System.Windows.Forms.Label();
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
            // lbl_city
            // 
            this.lbl_city.AutoSize = true;
            this.lbl_city.Location = new System.Drawing.Point(12, 16);
            this.lbl_city.Name = "lbl_city";
            this.lbl_city.Size = new System.Drawing.Size(55, 13);
            this.lbl_city.TabIndex = 2;
            this.lbl_city.Text = "City Name";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Location = new System.Drawing.Point(15, 55);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(67, 13);
            this.lblTemp.TabIndex = 3;
            this.lblTemp.Text = "Temperature";
            // 
            // lblTemp_output
            // 
            this.lblTemp_output.AutoSize = true;
            this.lblTemp_output.Location = new System.Drawing.Point(89, 55);
            this.lblTemp_output.Name = "lblTemp_output";
            this.lblTemp_output.Size = new System.Drawing.Size(0, 13);
            this.lblTemp_output.TabIndex = 4;
            // 
            // lbl_tempFaren_Output
            // 
            this.lbl_tempFaren_Output.AutoSize = true;
            this.lbl_tempFaren_Output.Location = new System.Drawing.Point(82, 72);
            this.lbl_tempFaren_Output.Name = "lbl_tempFaren_Output";
            this.lbl_tempFaren_Output.Size = new System.Drawing.Size(0, 13);
            this.lbl_tempFaren_Output.TabIndex = 5;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 285);
            this.Controls.Add(this.lbl_tempFaren_Output);
            this.Controls.Add(this.lblTemp_output);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.lbl_city);
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
        private System.Windows.Forms.Label lbl_city;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblTemp_output;
        private System.Windows.Forms.Label lbl_tempFaren_Output;
    }
}

