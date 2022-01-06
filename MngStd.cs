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
    public partial class MngStd : Form
    {
        public MngStd()
        {
            InitializeComponent();
        }

        private void MngStd_Load(object sender, EventArgs e)
        {
            ExanDB.Open();
            SqlCommand  std = new SqlCommand("getAllStd",ExanDB);
            std.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            dt.Load(std.ExecuteReader());
            dataGridView1.DataSource = dt;         
            
            ExanDB.Close();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            NewStd frm = new NewStd();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrsGrade frm = new CrsGrade();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            totStdGrade frm = new totStdGrade();
            frm.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
