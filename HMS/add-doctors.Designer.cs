namespace HMS
{
    partial class add_doctors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_doctors));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txttitle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.txtfather = new System.Windows.Forms.TextBox();
            this.txtfamily = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.doctorTableAdapter = new HMS.databaseDataSetTableAdapters.doctorTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txttitle);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtage);
            this.groupBox1.Controls.Add(this.txtcode);
            this.groupBox1.Controls.Add(this.txtfather);
            this.groupBox1.Controls.Add(this.txtfamily);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(539, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(452, 452);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اضافه کردن پزشک";
            // 
            // txttitle
            // 
            this.txttitle.Location = new System.Drawing.Point(17, 386);
            this.txttitle.Name = "txttitle";
            this.txttitle.Size = new System.Drawing.Size(237, 39);
            this.txttitle.TabIndex = 22;
            this.txttitle.MouseHover += new System.EventHandler(this.txttitle_MouseHover);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(379, 389);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 31);
            this.label8.TabIndex = 21;
            this.label8.Text = "تخصص";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(17, 324);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(237, 39);
            this.txtage.TabIndex = 19;
            this.txtage.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            this.txtage.MouseHover += new System.EventHandler(this.txtage_MouseHover);
            // 
            // txtcode
            // 
            this.txtcode.Location = new System.Drawing.Point(17, 259);
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(237, 39);
            this.txtcode.TabIndex = 18;
            this.txtcode.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            this.txtcode.MouseHover += new System.EventHandler(this.txtcode_MouseHover);
            // 
            // txtfather
            // 
            this.txtfather.Location = new System.Drawing.Point(17, 190);
            this.txtfather.Name = "txtfather";
            this.txtfather.Size = new System.Drawing.Size(237, 39);
            this.txtfather.TabIndex = 17;
            this.txtfather.MouseHover += new System.EventHandler(this.txtfather_MouseHover);
            // 
            // txtfamily
            // 
            this.txtfamily.Location = new System.Drawing.Point(17, 122);
            this.txtfamily.Name = "txtfamily";
            this.txtfamily.Size = new System.Drawing.Size(237, 39);
            this.txtfamily.TabIndex = 16;
            this.txtfamily.MouseHover += new System.EventHandler(this.txtfamily_MouseHover);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(17, 58);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(237, 39);
            this.txtname.TabIndex = 15;
            this.txtname.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtname.MouseHover += new System.EventHandler(this.txtname_MouseHover);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(404, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 31);
            this.label5.TabIndex = 5;
            this.label5.Text = "سن";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(380, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "کد ملی";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "نام پدر";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "نام خانوادگی";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(412, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "نام";
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.save.Font = new System.Drawing.Font("0 Nazanin", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.save.Location = new System.Drawing.Point(356, 105);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(170, 49);
            this.save.TabIndex = 9;
            this.save.Text = "ذخیره";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.IndianRed;
            this.button2.Font = new System.Drawing.Font("0 Nazanin", 15.75F);
            this.button2.Location = new System.Drawing.Point(356, 179);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 49);
            this.button2.TabIndex = 10;
            this.button2.Text = "انصراف";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Goldenrod;
            this.button3.Font = new System.Drawing.Font("0 Nazanin", 15.75F);
            this.button3.Location = new System.Drawing.Point(356, 258);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(170, 49);
            this.button3.TabIndex = 11;
            this.button3.Text = "پاک کردن";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button4.Font = new System.Drawing.Font("0 Nazanin", 15.75F);
            this.button4.Location = new System.Drawing.Point(356, 331);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(170, 49);
            this.button4.TabIndex = 12;
            this.button4.Text = "راهنما";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(324, 452);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // doctorTableAdapter
            // 
            this.doctorTableAdapter.ClearBeforeFill = true;
            // 
            // add_doctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(992, 459);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.save);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "add_doctors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "افزودن پزشک";
            this.Load += new System.EventHandler(this.add_doctors_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtcode;
        private System.Windows.Forms.TextBox txtfather;
        private System.Windows.Forms.TextBox txtfamily;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txttitle;
        private databaseDataSetTableAdapters.doctorTableAdapter doctorTableAdapter;
    }
}