namespace C__Weather_Application
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.locationInput = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labType = new System.Windows.Forms.Label();
            this.labDetails = new System.Windows.Forms.Label();
            this.labTemp = new System.Windows.Forms.Label();
            this.labFL = new System.Windows.Forms.Label();
            this.labSunrise = new System.Windows.Forms.Label();
            this.labSunset = new System.Windows.Forms.Label();
            this.labWS = new System.Windows.Forms.Label();
            this.labPressure = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // locationInput
            // 
            this.locationInput.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.locationInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.locationInput.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationInput.Location = new System.Drawing.Point(50, 50);
            this.locationInput.Multiline = true;
            this.locationInput.Name = "locationInput";
            this.locationInput.Size = new System.Drawing.Size(600, 60);
            this.locationInput.TabIndex = 0;
            this.locationInput.Text = "\r\n Search for Location (Toronto, New York, etc.)";
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.Transparent;
            this.searchBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchBtn.BackgroundImage")));
            this.searchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchBtn.Location = new System.Drawing.Point(589, 50);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(60, 59);
            this.searchBtn.TabIndex = 1;
            this.searchBtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Type:";
            this.label1.Click += new System.EventHandler(this.lab1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "Details:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 39);
            this.label4.TabIndex = 4;
            this.label4.Text = "Feels Like:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 39);
            this.label3.TabIndex = 5;
            this.label3.Text = "Temp:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(450, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 39);
            this.label5.TabIndex = 6;
            this.label5.Text = "Sunrise:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(450, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 39);
            this.label6.TabIndex = 7;
            this.label6.Text = "Sunset:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(450, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(235, 39);
            this.label7.TabIndex = 8;
            this.label7.Text = "Wind Speed:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Lucida Sans", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(450, 350);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 39);
            this.label8.TabIndex = 9;
            this.label8.Text = "Pressure:";
            // 
            // labType
            // 
            this.labType.AutoSize = true;
            this.labType.BackColor = System.Drawing.Color.Transparent;
            this.labType.Font = new System.Drawing.Font("Lucida Sans", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labType.Location = new System.Drawing.Point(171, 150);
            this.labType.Name = "labType";
            this.labType.Size = new System.Drawing.Size(89, 39);
            this.labType.TabIndex = 10;
            this.labType.Text = "N/A";
            // 
            // labDetails
            // 
            this.labDetails.AutoSize = true;
            this.labDetails.BackColor = System.Drawing.Color.Transparent;
            this.labDetails.Font = new System.Drawing.Font("Lucida Sans", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDetails.Location = new System.Drawing.Point(209, 200);
            this.labDetails.Name = "labDetails";
            this.labDetails.Size = new System.Drawing.Size(89, 39);
            this.labDetails.TabIndex = 11;
            this.labDetails.Text = "N/A";
            // 
            // labTemp
            // 
            this.labTemp.AutoSize = true;
            this.labTemp.BackColor = System.Drawing.Color.Transparent;
            this.labTemp.Font = new System.Drawing.Font("Lucida Sans", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTemp.Location = new System.Drawing.Point(183, 300);
            this.labTemp.Name = "labTemp";
            this.labTemp.Size = new System.Drawing.Size(89, 39);
            this.labTemp.TabIndex = 12;
            this.labTemp.Text = "N/A";
            // 
            // labFL
            // 
            this.labFL.AutoSize = true;
            this.labFL.BackColor = System.Drawing.Color.Transparent;
            this.labFL.Font = new System.Drawing.Font("Lucida Sans", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFL.Location = new System.Drawing.Point(260, 350);
            this.labFL.Name = "labFL";
            this.labFL.Size = new System.Drawing.Size(89, 39);
            this.labFL.TabIndex = 13;
            this.labFL.Text = "N/A";
            // 
            // labSunrise
            // 
            this.labSunrise.AutoSize = true;
            this.labSunrise.BackColor = System.Drawing.Color.Transparent;
            this.labSunrise.Font = new System.Drawing.Font("Lucida Sans", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSunrise.Location = new System.Drawing.Point(617, 150);
            this.labSunrise.Name = "labSunrise";
            this.labSunrise.Size = new System.Drawing.Size(89, 39);
            this.labSunrise.TabIndex = 14;
            this.labSunrise.Text = "N/A";
            // 
            // labSunset
            // 
            this.labSunset.AutoSize = true;
            this.labSunset.BackColor = System.Drawing.Color.Transparent;
            this.labSunset.Font = new System.Drawing.Font("Lucida Sans", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSunset.Location = new System.Drawing.Point(605, 200);
            this.labSunset.Name = "labSunset";
            this.labSunset.Size = new System.Drawing.Size(89, 39);
            this.labSunset.TabIndex = 15;
            this.labSunset.Text = "N/A";
            // 
            // labWS
            // 
            this.labWS.AutoSize = true;
            this.labWS.BackColor = System.Drawing.Color.Transparent;
            this.labWS.Font = new System.Drawing.Font("Lucida Sans", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labWS.Location = new System.Drawing.Point(691, 300);
            this.labWS.Name = "labWS";
            this.labWS.Size = new System.Drawing.Size(89, 39);
            this.labWS.TabIndex = 16;
            this.labWS.Text = "N/A";
            // 
            // labPressure
            // 
            this.labPressure.AutoSize = true;
            this.labPressure.BackColor = System.Drawing.Color.Transparent;
            this.labPressure.Font = new System.Drawing.Font("Lucida Sans", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPressure.Location = new System.Drawing.Point(640, 350);
            this.labPressure.Name = "labPressure";
            this.labPressure.Size = new System.Drawing.Size(89, 39);
            this.labPressure.TabIndex = 17;
            this.labPressure.Text = "N/A";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(816, 537);
            this.Controls.Add(this.labPressure);
            this.Controls.Add(this.labWS);
            this.Controls.Add(this.labSunset);
            this.Controls.Add(this.labSunrise);
            this.Controls.Add(this.labFL);
            this.Controls.Add(this.labTemp);
            this.Controls.Add(this.labDetails);
            this.Controls.Add(this.labType);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.locationInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox locationInput;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labType;
        private System.Windows.Forms.Label labDetails;
        private System.Windows.Forms.Label labTemp;
        private System.Windows.Forms.Label labFL;
        private System.Windows.Forms.Label labSunrise;
        private System.Windows.Forms.Label labSunset;
        private System.Windows.Forms.Label labWS;
        private System.Windows.Forms.Label labPressure;
    }
}

