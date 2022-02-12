namespace HMS
{
    partial class add_patient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_patient));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.patientTableAdapter1 = new HMS.databaseDataSetTableAdapters.patientTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
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
            this.groupBox1.Location = new System.Drawing.Point(537, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(452, 414);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اضافه کردن بیمار";
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(18, 321);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(237, 39);
            this.txtage.TabIndex = 19;
            this.txtage.MouseHover += new System.EventHandler(this.txtage_MouseHover);
            // 
            // txtcode
            // 
            this.txtcode.Location = new System.Drawing.Point(18, 251);
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(237, 39);
            this.txtcode.TabIndex = 18;
            this.txtcode.MouseHover += new System.EventHandler(this.txtcode_MouseHover);
            // 
            // txtfather
            // 
            this.txtfather.Location = new System.Drawing.Point(18, 184);
            this.txtfather.Name = "txtfather";
            this.txtfather.Size = new System.Drawing.Size(237, 39);
            this.txtfather.TabIndex = 17;
            this.txtfather.MouseHover += new System.EventHandler(this.txtfather_MouseHover);
            // 
            // txtfamily
            // 
            this.txtfamily.Location = new System.Drawing.Point(18, 116);
            this.txtfamily.Name = "txtfamily";
            this.txtfamily.Size = new System.Drawing.Size(237, 39);
            this.txtfamily.TabIndex = 16;
            this.txtfamily.TextChanged += new System.EventHandler(this.txtfamily_TextChanged);
            this.txtfamily.MouseHover += new System.EventHandler(this.txtfamily_MouseHover);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(18, 52);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(237, 39);
            this.txtname.TabIndex = 15;
            this.txtname.MouseHover += new System.EventHandler(this.txtname_MouseHover);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(405, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 31);
            this.label5.TabIndex = 5;
            this.label5.Text = "سن";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(381, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "کد ملی";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(386, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "نام پدر";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(349, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "نام خانوادگی";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(413, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "نام";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button4.Font = new System.Drawing.Font("0 Nazanin", 15.75F);
            this.button4.Location = new System.Drawing.Point(355, 323);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(170, 49);
            this.button4.TabIndex = 24;
            this.button4.Text = "راهنما";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Goldenrod;
            this.button3.Font = new System.Drawing.Font("0 Nazanin", 15.75F);
            this.button3.Location = new System.Drawing.Point(355, 250);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(170, 49);
            this.button3.TabIndex = 23;
            this.button3.Text = "پاک کردن";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.IndianRed;
            this.button2.Font = new System.Drawing.Font("0 Nazanin", 15.75F);
            this.button2.Location = new System.Drawing.Point(355, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 49);
            this.button2.TabIndex = 22;
            this.button2.Text = "انصراف";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.Font = new System.Drawing.Font("0 Nazanin", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.Location = new System.Drawing.Point(355, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 49);
            this.button1.TabIndex = 21;
            this.button1.Text = "ذخیره";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(324, 415);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // patientTableAdapter1
            // 
            this.patientTableAdapter1.ClearBeforeFill = true;
            // 
            // add_patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(992, 442);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "add_patient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "افزودن بیمار";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.TextBox txtcode;
        private System.Windows.Forms.TextBox txtfather;
        private System.Windows.Forms.TextBox txtfamily;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private databaseDataSetTableAdapters.patientTableAdapter patientTableAdapter1;
    }
}