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
    public partial class CrsGrade : Form
    {
        Dictionary<int, string> dic = new Dictionary<int, string>();
        Dictionary<int, string> dic1 = new Dictionary<int, string>();
        public CrsGrade()
        {
            InitializeComponent();
        }

        private void CrsGrade_Load(object sender, EventArgs e)
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
            ExamDB.Open();
            SqlCommand std = new SqlCommand("getAllStdName ", ExamDB);
            std.CommandType = CommandType.StoredProcedure;
            SqlDataReader Std = std.ExecuteReader();
            while (Std.Read())
            {
                dic1.Add(int.Parse(Std["St_id"].ToString()), Std["FullName"].ToString());
                stdName.Items.Add(Std["FullName"]).ToString();
            }
            Std.Close();
            ExamDB.Close();
                      

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void shwStd_Click(object sender, EventArgs e)
        {            
            ExamDB.Open();
            SqlCommand std = new SqlCommand("getStdGradesCrs", ExamDB);
            std.CommandType = CommandType.StoredProcedure;
            DataTable dTable = new DataTable();
            std.Parameters.AddWithValue("@stdname", SqlDbType.VarChar).Value = stdName.Text.Trim().ToString();
            std.Parameters.AddWithValue("@crsname", SqlDbType.VarChar).Value = crsName.Text.Trim().ToString();
            dTable.Load(std.ExecuteReader());
            dataGridView1.DataSource = dTable;
            ExamDB.Close();
            
        }
    }
}
