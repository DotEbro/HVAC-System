
namespace HVAC_Program
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.OutTemp_box = new System.Windows.Forms.TextBox();
            this.InTemp_box = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Conditioned_box = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Nextbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Castellar", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(168, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(880, 104);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Heat Ventilation \r\nand Cooling System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(205, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(840, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "This system will be able to calculate the heat of the Residential House";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 186);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(389, 444);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(447, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "Please Select Your City";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(447, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(384, 33);
            this.label5.TabIndex = 5;
            this.label5.Text = "Design Indoor Temperature °C";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(447, 457);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(403, 33);
            this.label6.TabIndex = 6;
            this.label6.Text = "Conditioned Room Temperature";
            // 
            // OutTemp_box
            // 
            this.OutTemp_box.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OutTemp_box.Location = new System.Drawing.Point(903, 329);
            this.OutTemp_box.Multiline = true;
            this.OutTemp_box.Name = "OutTemp_box";
            this.OutTemp_box.ReadOnly = true;
            this.OutTemp_box.Size = new System.Drawing.Size(221, 35);
            this.OutTemp_box.TabIndex = 7;
            // 
            // InTemp_box
            // 
            this.InTemp_box.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InTemp_box.Location = new System.Drawing.Point(903, 393);
            this.InTemp_box.Multiline = true;
            this.InTemp_box.Name = "InTemp_box";
            this.InTemp_box.ReadOnly = true;
            this.InTemp_box.Size = new System.Drawing.Size(221, 35);
            this.InTemp_box.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Lahore",
            "Hyderabad",
            "Peshawar",
            "Islambad",
            "Khaniwal",
            "Jamshoro"});
            this.comboBox1.Location = new System.Drawing.Point(903, 263);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(221, 35);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Conditioned_box
            // 
            this.Conditioned_box.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Conditioned_box.Location = new System.Drawing.Point(903, 457);
            this.Conditioned_box.Multiline = true;
            this.Conditioned_box.Name = "Conditioned_box";
            this.Conditioned_box.ReadOnly = true;
            this.Conditioned_box.Size = new System.Drawing.Size(221, 35);
            this.Conditioned_box.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(447, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(401, 33);
            this.label7.TabIndex = 9;
            this.label7.Text = "Design Outdoor Temperature °C";
            // 
            // Nextbtn
            // 
            this.Nextbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(124)))), ((int)(((byte)(163)))));
            this.Nextbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Nextbtn.ForeColor = System.Drawing.Color.Yellow;
            this.Nextbtn.Location = new System.Drawing.Point(971, 616);
            this.Nextbtn.Margin = new System.Windows.Forms.Padding(0);
            this.Nextbtn.Name = "Nextbtn";
            this.Nextbtn.Size = new System.Drawing.Size(99, 35);
            this.Nextbtn.TabIndex = 11;
            this.Nextbtn.Text = "Next";
            this.Nextbtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Nextbtn.UseVisualStyleBackColor = false;
            this.Nextbtn.Click += new System.EventHandler(this.Nextbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1170, 714);
            this.Controls.Add(this.Nextbtn);
            this.Controls.Add(this.Conditioned_box);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.InTemp_box);
            this.Controls.Add(this.OutTemp_box);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox OutTemp_box;
        private System.Windows.Forms.TextBox InTemp_box;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox Conditioned_box;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Nextbtn;
    }
}

