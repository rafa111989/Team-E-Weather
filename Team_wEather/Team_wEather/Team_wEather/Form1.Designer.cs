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
            this.lbl_city = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblTemp_output = new System.Windows.Forms.Label();
            this.lbl_tempFaren_Output = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_getWx
            // 
            this.btn_getWx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_getWx.Location = new System.Drawing.Point(9, 157);
            this.btn_getWx.Name = "btn_getWx";
            this.btn_getWx.Size = new System.Drawing.Size(289, 38);
            this.btn_getWx.TabIndex = 0;
            this.btn_getWx.Text = "Get Weather";
            this.btn_getWx.UseVisualStyleBackColor = true;
            this.btn_getWx.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_city
            // 
            this.lbl_city.AutoSize = true;
            this.lbl_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_city.Location = new System.Drawing.Point(12, 16);
            this.lbl_city.Name = "lbl_city";
            this.lbl_city.Size = new System.Drawing.Size(95, 15);
            this.lbl_city.TabIndex = 2;
            this.lbl_city.Text = "US City Name";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.Location = new System.Drawing.Point(12, 58);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(92, 18);
            this.lblTemp.TabIndex = 3;
            this.lblTemp.Text = "Temperature";
            // 
            // lblTemp_output
            // 
            this.lblTemp_output.AutoSize = true;
            this.lblTemp_output.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp_output.Location = new System.Drawing.Point(13, 80);
            this.lblTemp_output.Name = "lblTemp_output";
            this.lblTemp_output.Size = new System.Drawing.Size(0, 17);
            this.lblTemp_output.TabIndex = 4;
            // 
            // lbl_tempFaren_Output
            // 
            this.lbl_tempFaren_Output.AutoSize = true;
            this.lbl_tempFaren_Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tempFaren_Output.Location = new System.Drawing.Point(13, 101);
            this.lbl_tempFaren_Output.Name = "lbl_tempFaren_Output";
            this.lbl_tempFaren_Output.Size = new System.Drawing.Size(0, 17);
            this.lbl_tempFaren_Output.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Albuquerque ",
            "Anaheim ",
            "Anchorage ",
            "Arlington ",
            "Atlanta ",
            "Aurora ",
            "Austin",
            "Bakersfield ",
            "Baltimore ",
            "Boston ",
            "Bronx",
            "Brooklyn",
            "Buffalo ",
            "Central Contra Costa ",
            "Charlotte",
            "Chicago",
            "Chula Vista ",
            "Cincinnati ",
            "Cleveland ",
            "Colorado Springs ",
            "Columbus",
            "Corpus Christi",
            "Dallas",
            "Denver",
            "Detroit",
            "East San Gabriel Valley",
            "East Seattle ",
            "El Paso",
            "Ewa ",
            "Fayette ",
            "Fort Wayne",
            "Fort Worth",
            "Fresno ",
            "Greensboro ",
            "Henderson ",
            "Honolulu ",
            "Houston",
            "Indianapolis",
            "Jacksonville",
            "Jersey City",
            "Kansas City ",
            "Kendale Lakes-Lindgren Acres ",
            "Las Vegas ",
            "Lexington-Fayette",
            "Lincoln ",
            "Long Beach ",
            "Los Angeles",
            "Louisville ",
            "Manhattan",
            "Memphis ",
            "Mesa ",
            "Metropolitan Government ",
            "Miami ",
            "Milwaukee ",
            "Minneapolis ",
            "Nashville-Davidson ",
            "New Orleans ",
            "Newark ",
            "New York",
            "North Coast ",
            "Northeast Jefferson ",
            "Northeast Tarrant ",
            "Northwest Harris ",
            "Oakland ",
            "Oklahoma City ",
            "Omaha ",
            "Orlando",
            "Philadelphia",
            "Phoenix",
            "Pittsburgh",
            "Plano ",
            "Portland ",
            "Queens",
            "Raleigh ",
            "Riverside",
            "Sacramento ",
            "San Antonio",
            "San Diego",
            "San Francisco",
            "San Jose",
            "Santa Ana ",
            "Seattle",
            "South Aurora ",
            "South Coast ",
            "Southeast Montgomery",
            "Southwest San Gabriel Valley",
            "St. Louis",
            "St. Paul ",
            "Staten Island ",
            "Stockton",
            "Tampa ",
            "Toledo ",
            "Tucson ",
            "Tulsa ",
            "Upper San Gabriel Valley ",
            "Urban Honolulu ",
            "Virginia Beach ",
            "Washington ",
            "West Adams",
            "Wichita "});
            this.comboBox1.Location = new System.Drawing.Point(121, 14);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(179, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 210);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbl_tempFaren_Output);
            this.Controls.Add(this.lblTemp_output);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.lbl_city);
            this.Controls.Add(this.btn_getWx);
            this.Name = "main";
            this.Text = "Team_wEather";
           
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_getWx;
        private System.Windows.Forms.Label lbl_city;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblTemp_output;
        private System.Windows.Forms.Label lbl_tempFaren_Output;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

