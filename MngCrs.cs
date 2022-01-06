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
    public partial class MngCrs : Form
    {
        public MngCrs()
        {
            InitializeComponent();
        }

        private void MngCrs_Load(object sender, EventArgs e)
        {
            ExamDB.Open();
            SqlCommand std = new SqlCommand("getAllcours", ExamDB);
            std.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            dt.Load(std.ExecuteReader());
            dataGridView1.DataSource = dt;

            ExamDB.Close();
            
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            NewCrs frm = new NewCrs();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            totStdCrs frm = new totStdCrs();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            crsStds frm = new crsStds();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewQue frm = new NewQue();
            frm.ShowDialog();
        }
    }
}
