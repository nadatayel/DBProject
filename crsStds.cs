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
    public partial class crsStds : Form
    {
        public crsStds()
        {
            InitializeComponent();
        }
        Dictionary<int, string> dic = new Dictionary<int, string>();
        private void crsStds_Load(object sender, EventArgs e)
        {
            ExamDB.Open();
            SqlCommand crs = new SqlCommand("getcours", ExamDB);
            crs.CommandType = CommandType.StoredProcedure;
            SqlDataReader Crs = crs.ExecuteReader();
            while (Crs.Read())
            {
                dic.Add(int.Parse(Crs["Crs_id"].ToString()), Crs["Crs_name"].ToString());
                crsName.Items.Add(Crs["Crs_name"]).ToString();
            }
            Crs.Close();
            ExamDB.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExamDB.Open();
            SqlCommand std = new SqlCommand("getAllStdinCrs", ExamDB);
            std.CommandType = CommandType.StoredProcedure;
            DataTable dTable = new DataTable();
            std.Parameters.AddWithValue("@name", SqlDbType.VarChar).Value = crsName.Text.Trim().ToString();
            dTable.Load(std.ExecuteReader());
            dataGridView1.DataSource = dTable;
            ExamDB.Close();
        }

        private void crsName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
