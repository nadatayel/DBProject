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
    public partial class NewStd : Form
    {
        public NewStd()
        {
            InitializeComponent();
        }

        Dictionary<int, string> dic = new Dictionary<int, string>();
        int deptId;
        private void NewStd_Load(object sender, EventArgs e)
        {
            ExamDB.Open();
            SqlCommand std = new SqlCommand("getdept", ExamDB);
            std.CommandType = CommandType.StoredProcedure;
            SqlDataReader Std = std.ExecuteReader();
            while (Std.Read())
            {
                dic.Add(int.Parse(Std["Dept_id"].ToString()), Std["Dname"].ToString());
                dept.Items.Add(Std["Dname"]).ToString();
            }
            Std.Close();
            ExamDB.Close();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            if (fname.Text == null || fname.Text == "" || lname.Text == null || lname.Text == "" || ads.Text == null || ads.Text == "" || bod.Text == null || bod.Text == "" || dept.Text == null || dept.Text == "" ) { MessageBox.Show(" ^_^ please Enter a valid ID ^_^"); }
            else
            {
                ExamDB.Open();
                SqlCommand cmd = new SqlCommand("addStudent", ExamDB);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fname", SqlDbType.NVarChar).Value = fname.Text.ToString().Trim();
                cmd.Parameters.AddWithValue("@lname", SqlDbType.NVarChar).Value = lname.Text.ToString().Trim();
                cmd.Parameters.AddWithValue("@address", SqlDbType.NVarChar).Value = ads.Text.Trim().ToString();
                cmd.Parameters.AddWithValue("@bod", SqlDbType.DateTime).Value = bod.Text.ToString().Trim();
                cmd.Parameters.AddWithValue("@dept", SqlDbType.Int).Value = deptId;
                cmd.ExecuteNonQuery();
                MessageBox.Show("^_^ You Added New Student ^_^");
                ExamDB.Close();
                fname.Text = lname.Text = ads.Text = bod.Text = dept.Text = String.Empty;
            }         
        }
        
        private void dept_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in dic)
            {
                if (dept.SelectedItem.ToString() == item.Value)
                {
                    deptId = item.Key;
                    break;
                }
            }
           
        }
    }
}
