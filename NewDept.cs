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
    public partial class NewDept : Form
    {
        public NewDept()
        {
            InitializeComponent();
        }
        Dictionary<int, string> dic = new Dictionary<int, string>();
        int mgrtId;
        private void NewDept_Load(object sender, EventArgs e)
        {
            ExamDB.Open();
            SqlCommand std = new SqlCommand("getDeptIns", ExamDB);
            std.CommandType = CommandType.StoredProcedure;
            SqlDataReader Std = std.ExecuteReader();
            while (Std.Read())
            {
                dic.Add(int.Parse(Std["Ins_id"].ToString()), Std["Name"].ToString());
                mgr.Items.Add(Std["Name"]).ToString();
            }
            Std.Close();
            ExamDB.Close();


        }

        private void btnnew_Click(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {

            if (deptName.Text == null || deptName.Text == "" || mgr.Text == null || mgr.Text == "") { MessageBox.Show(" ^_^ please Enter a valid ID ^_^"); }
            else
            {
                ExamDB.Open();
                SqlCommand cmd = new SqlCommand("addDepartment", ExamDB);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dname", SqlDbType.NVarChar).Value = deptName.Text.ToString().Trim();
               
                cmd.Parameters.AddWithValue("@mgr_id", SqlDbType.Int).Value = mgrtId;
                cmd.ExecuteNonQuery();
                MessageBox.Show("^_^ You Added New Student ^_^");
                ExamDB.Close();
                deptName.Text = mgr.Text =deptName.Text  = String.Empty;

            }
        }

        private void mgr_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in dic)
            {
                if (mgr.SelectedItem.ToString() == item.Value)
                {
                    mgrtId = item.Key;
                    break;
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
