using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS
{
    public partial class doctor_list : Form
    {
        string mdfFile = @"database.mdb";
        public doctor_list()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = Int16.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            using (OleDbConnection connection = new OleDbConnection(string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0}", mdfFile)))
            {
                using (OleDbCommand deleteCommand = new OleDbCommand("DELETE FROM doctor WHERE [ID] = ?", connection))
                {
                    connection.Open();

                    deleteCommand.Parameters.AddWithValue("@ID", id);

                    deleteCommand.ExecuteNonQuery();

                    connection.Close();

                    load_doctor_grid_view();

                    dataGridView1.Refresh();
                }
            }
        }

        private void load_doctor_grid_view()
        {

            using (OleDbConnection connection = new OleDbConnection(string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0}", mdfFile)))
            {
                using (OleDbCommand selectCommand = new OleDbCommand("SELECT * FROM doctor", connection))
                {
                    connection.Open();

                    DataTable table = new DataTable();
                    OleDbDataAdapter adapter = new OleDbDataAdapter();
                    adapter.SelectCommand = selectCommand;
                    adapter.Fill(table);

                    dataGridView1.DataSource = table;


                }
            }
        }

        private void doctor_list_Load(object sender, EventArgs e)
        { 
            load_doctor_grid_view();     
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("شما میتوانید در این قسمت اقدام به حذف یا ویرایش پزشک کنید", "راهنما", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK) this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (OleDbConnection connection = new OleDbConnection(string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0}", mdfFile)))
            {
                using (OleDbCommand updateCommand = new OleDbCommand("UPDATE doctor SET [username] = ?, [userfamily] = ? ,[fathername] = ?, [nationalcode] = ?,[userage] = ?,[title]=? WHERE [ID] = ?", connection))
                {
                    connection.Open();
                    int id = Int16.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    string name = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    string family = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    string father = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    string nationalcode = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    int age = Int16.Parse(dataGridView1.CurrentRow.Cells[5].Value.ToString());
                    string title = dataGridView1.CurrentRow.Cells[6].Value.ToString();


                    updateCommand.Parameters.AddWithValue("@username", name);
                    updateCommand.Parameters.AddWithValue("@userfamily", family);
                    updateCommand.Parameters.AddWithValue("@fathername", father);
                    updateCommand.Parameters.AddWithValue("@nationalcode", nationalcode);
                    updateCommand.Parameters.AddWithValue("@userage", age);
                    updateCommand.Parameters.AddWithValue("@title", title);
                    updateCommand.Parameters.AddWithValue("@ID", id);
                    updateCommand.ExecuteNonQuery();
                    connection.Close();
                    load_doctor_grid_view();
                    dataGridView1.Refresh();
                }
            }
        }
    }
}
