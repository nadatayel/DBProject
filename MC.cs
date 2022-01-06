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
    public partial class MC : Form
    {
        public MC()
        {
            InitializeComponent();
        }
        Dictionary<int, string> dic = new Dictionary<int, string>();
        int crsId;
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void MC_Load(object sender, EventArgs e)
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

        private void save_Click(object sender, EventArgs e)
        {
            if (crsName.Text == null || crsName.Text == "" || deg.Text == null || deg.Text == "" || qubox.Text == null || qubox.Text == "" || answer.Text == null || answer.Text == "")
            { MessageBox.Show(" ^_^ please Enter a valid Data ^_^"); }
            else
            {
                ExamDB.Open();
                SqlCommand cmd = new SqlCommand("addNewMcQuestion", ExamDB);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@question", SqlDbType.NVarChar).Value = qubox.Text.ToString().Trim();
                //cmd.Parameters.AddWithValue("@type", SqlDbType.NVarChar).Value = "mc";
                cmd.Parameters.AddWithValue("@grade", SqlDbType.Int).Value = deg.Text.Trim().ToString();
                cmd.Parameters.AddWithValue("@ansid", SqlDbType.Int).Value = answer.Text.ToString().Trim();
                cmd.Parameters.AddWithValue("@ch1", SqlDbType.Int).Value = a.Text.ToString().Trim();
                cmd.Parameters.AddWithValue("@ch2", SqlDbType.Int).Value = b.Text.ToString().Trim();
                cmd.Parameters.AddWithValue("@ch3", SqlDbType.Int).Value = c.Text.ToString().Trim();
                cmd.Parameters.AddWithValue("@ch4", SqlDbType.Int).Value = d.Text.ToString().Trim();
                cmd.Parameters.AddWithValue("@crs_id", SqlDbType.Int).Value = crsId;
                cmd.ExecuteNonQuery();
                MessageBox.Show("^_^ You Added New Question ^_^");
                ExamDB.Close();
                qubox.Text = crsName.Text = deg.Text = answer.Text = String.Empty;
            }
            
        }

        private void crsName_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in dic)
            {
                if (crsName.SelectedItem.ToString() == item.Value)
                {
                    crsId = item.Key;
                    break;
                }
            }
        }
    }
}
