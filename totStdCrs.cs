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
    public partial class totStdCrs : Form
    {
        public totStdCrs()
        {
            InitializeComponent();
        }
        Dictionary<int, string> dic = new Dictionary<int, string>();
        private void totStdCrs_Load(object sender, EventArgs e)
        {
            ExamDB.Open();
            SqlCommand std = new SqlCommand("getCrsTopic", ExamDB);
            std.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            dt.Load(std.ExecuteReader());
            dataGridView1.DataSource = dt;
            ExamDB.Close();
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

        private void crsName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {

        }
    }
}
