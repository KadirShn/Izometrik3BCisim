
namespace WinFormsApp2
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OTX = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.OTY = new System.Windows.Forms.TextBox();
            this.OTZ = new System.Windows.Forms.TextBox();
            this.OLZ = new System.Windows.Forms.TextBox();
            this.OLY = new System.Windows.Forms.TextBox();
            this.OLX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 62);
            this.button1.TabIndex = 0;
            this.button1.Text = "Eksenleri çiz (XYZ)";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(12, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 60);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cismin izometrik izdüşümü al";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Silver;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(11, 322);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(197, 119);
            this.button3.TabIndex = 3;
            this.button3.Text = "ÖLÇEKLE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Silver;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(11, 183);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(197, 119);
            this.button4.TabIndex = 2;
            this.button4.Text = "ÖTELE";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Silver;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(11, 465);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(197, 58);
            this.button5.TabIndex = 4;
            this.button5.Text = "Formu temizle";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(229, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(229, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Y";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(229, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Z";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // OTX
            // 
            this.OTX.BackColor = System.Drawing.Color.Gainsboro;
            this.OTX.Location = new System.Drawing.Point(253, 198);
            this.OTX.Name = "OTX";
            this.OTX.Size = new System.Drawing.Size(156, 27);
            this.OTX.TabIndex = 8;
            this.OTX.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(8654, 6281);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(16935, 27);
            this.textBox2.TabIndex = 9;
            // 
            // OTY
            // 
            this.OTY.BackColor = System.Drawing.Color.Gainsboro;
            this.OTY.Location = new System.Drawing.Point(253, 231);
            this.OTY.Name = "OTY";
            this.OTY.Size = new System.Drawing.Size(156, 27);
            this.OTY.TabIndex = 10;
            this.OTY.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // OTZ
            // 
            this.OTZ.BackColor = System.Drawing.Color.Gainsboro;
            this.OTZ.Location = new System.Drawing.Point(253, 264);
            this.OTZ.Name = "OTZ";
            this.OTZ.Size = new System.Drawing.Size(156, 27);
            this.OTZ.TabIndex = 11;
            this.OTZ.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // OLZ
            // 
            this.OLZ.BackColor = System.Drawing.Color.Gainsboro;
            this.OLZ.Location = new System.Drawing.Point(253, 401);
            this.OLZ.Name = "OLZ";
            this.OLZ.Size = new System.Drawing.Size(156, 27);
            this.OLZ.TabIndex = 17;
            this.OLZ.TextChanged += new System.EventHandler(this.OLZ_TextChanged);
            // 
            // OLY
            // 
            this.OLY.BackColor = System.Drawing.Color.Gainsboro;
            this.OLY.Location = new System.Drawing.Point(253, 368);
            this.OLY.Name = "OLY";
            this.OLY.Size = new System.Drawing.Size(156, 27);
            this.OLY.TabIndex = 16;
            this.OLY.TextChanged += new System.EventHandler(this.OLY_TextChanged);
            // 
            // OLX
            // 
            this.OLX.BackColor = System.Drawing.Color.Gainsboro;
            this.OLX.Location = new System.Drawing.Point(253, 335);
            this.OLX.Name = "OLX";
            this.OLX.Size = new System.Drawing.Size(156, 27);
            this.OLX.TabIndex = 15;
            this.OLX.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(229, 408);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Z";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(229, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Y";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(229, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1255, 602);
            this.Controls.Add(this.OLZ);
            this.Controls.Add(this.OLY);
            this.Controls.Add(this.OLX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.OTZ);
            this.Controls.Add(this.OTY);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.OTX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Kadir_Sahin";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox OTX;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox OTY;
        private System.Windows.Forms.TextBox OTZ;
        private System.Windows.Forms.TextBox OLZ;
        private System.Windows.Forms.TextBox OLY;
        private System.Windows.Forms.TextBox OLX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

