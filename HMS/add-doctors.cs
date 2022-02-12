using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace HMS
{
    public partial class add_doctors : Form
    {
        string mdfFile = @"database.mdb";

        private OleDbConnection con;
        public add_doctors()
        {
            InitializeComponent();


        }

        private void add_doctors_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtname.Text = "";
            txtfamily.Text = "";
            txtfather.Text = "";
            txtcode.Text = "";
            txtage.Text = "";

        }
       
        private void button4_Click(object sender, EventArgs e)
        {

           if( MessageBox.Show("کاربر گرامی لطفا در نوشتن مشخصات مربوط به پزشک دقت فرمایید","راهنما",MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK) this.Close();
        }


        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void button1_Click(object sender, EventArgs e)
            
        {

            string name = txtname.Text.Trim();
            string family = txtfamily.Text.Trim();
            string father = txtfather.Text.Trim();
            string code = txtcode.Text.Trim();
            int age = 0;
            string title = txtcode.Text.Trim();

            try
            {
                age = Int16.Parse(txtage.Text);


                if (name != "" && family != "" && father != "" && code != "" && age > 0 && title !="")

                {
                    // int result = patientTableAdapter1.Insert(name, family, father, code, age);


                    using (OleDbConnection connection = new OleDbConnection(string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0}", mdfFile)))
                    {
                        using (OleDbCommand insertCommand = new OleDbCommand("INSERT INTO doctor ([username],[userfamily],[fathername],[nationalcode],[userage],[title]) VALUES (?,?,?,?,?,?)", connection))
                        {
                            connection.Open();

                            insertCommand.Parameters.AddWithValue("@username", name);
                            insertCommand.Parameters.AddWithValue("@userfamily", family);
                            insertCommand.Parameters.AddWithValue("@fathername", father);
                            insertCommand.Parameters.AddWithValue("@nationalcode", code);
                            insertCommand.Parameters.AddWithValue("@userage", age);
                            insertCommand.Parameters.AddWithValue("@title",title);


                            insertCommand.ExecuteNonQuery();

                            MessageBox.Show("عملیات با موفقیت انجام شد شما میتوانید بیمار جدید را در لیست بیماران مشاهده کنید", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtname.Text = "";
                            txtfamily.Text = "";
                            txtfather.Text = "";
                            txtcode.Text = "";
                            txtage.Text = "";
                            txttitle.Text = "";
                        }
                    }
                }

                else
                {
                    MessageBox.Show("مقادیر ورودی صحیح نمی باشد");
                }
            }
            catch
            {
                MessageBox.Show("سن وارد شده صحیح نمی باشد");
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void update_Click(object sender, EventArgs e)
        {

        }

        private void txtname_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(txtname, "از نوشتن اعداد در این قسمت خودداری کنید  ");
        }

        private void txtfamily_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(txtfamily, "از نوشتن اعداد در این قسمت خودداری کنید ");
        }

        private void txtfather_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(txtfather, "از نوشتن اعداد در این قسمت خودداری کنید ");
        }

        private void txtcode_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(txtcode, "از نوشتن حروف در این قسمت خودداری کنید ");
        }

        private void txtage_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(txtage, "از نوشتن حروف در این قسمت خودداری کنید ");
        }

        private void txttitle_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(txttitle, "از وارد کردن اعداد در این قسمت خودداری کنید ");
        }
    }
}
