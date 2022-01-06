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
    public partial class MngDept : Form
    {
        public MngDept()
        {
            InitializeComponent();
        }

        private void MngDept_Load(object sender, EventArgs e)
        {
            ExamDB.Open();
            SqlCommand std = new SqlCommand("getdept", ExamDB);
            std.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            dt.Load(std.ExecuteReader());
            dataGridView1.DataSource = dt;
            ExamDB.Close();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            NewDept frm = new NewDept();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsDept frm = new InsDept();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Std_sDept frm = new Std_sDept();
            frm.ShowDialog();
        }
    }
}
