using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBProject
{
    public partial class totStdGrade : Form
    {
        public totStdGrade()
        {
            InitializeComponent();
        }
        Dictionary<int, string> dic1 = new Dictionary<int, string>();
        private void totStdGrade_Load(object sender, EventArgs e)
        {
            ExanDB.Open();
            SqlCommand std = new SqlCommand("getAllStdName ", ExanDB);
            std.CommandType = CommandType.StoredProcedure;
            SqlDataReader Std = std.ExecuteReader();
            while (Std.Read())
            {
                dic1.Add(int.Parse(Std["St_id"].ToString()), Std["FullName"].ToString());
                stdName.Items.Add(Std["FullName"]).ToString();
            }
            Std.Close();
            ExanDB.Close();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExanDB.Open();
            SqlCommand std = new SqlCommand("getStdGradebyName", ExanDB);
            std.CommandType = CommandType.StoredProcedure;
            DataTable dTable = new DataTable();
            std.Parameters.AddWithValue("@stdname", SqlDbType.VarChar).Value = stdName.Text.Trim().ToString();
            dTable.Load(std.ExecuteReader());
            dataGridView1.DataSource = dTable;
            ExanDB.Close();


        }

        private void stdName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
