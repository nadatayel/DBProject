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
    public partial class InsDept : Form
    {
        public InsDept()
        {
            InitializeComponent();
        }
        Dictionary<int, string> dic = new Dictionary<int, string>();
        int deptID;
        private void DelDept_Load(object sender, EventArgs e)
        {
            ExamDB.Open();
            SqlCommand std = new SqlCommand("getdept", ExamDB);
            std.CommandType = CommandType.StoredProcedure;
            SqlDataReader Std = std.ExecuteReader();
            while (Std.Read())
            {
                dic.Add(int.Parse(Std["Dept_id"].ToString()), Std["Dname"].ToString());
                stdName.Items.Add(Std["Dname"]).ToString();
            }
            Std.Close();
            ExamDB.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            ExamDB.Open();
            SqlCommand std = new SqlCommand("getcourInInstr", ExamDB);
            std.CommandType = CommandType.StoredProcedure;
            DataTable dTable = new DataTable();
            std.Parameters.AddWithValue("@id", SqlDbType.VarChar).Value = deptID;
            dTable.Load(std.ExecuteReader());
            dataGridView1.DataSource = dTable;
            ExamDB.Close();

        }

        private void stdName_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in dic)
            {
                if (stdName.SelectedItem.ToString() == item.Value)
                {
                    deptID = item.Key;
                    break;
                }
            }
        }
    }
}
