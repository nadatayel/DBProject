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
    public partial class NewCrs : Form
    {
        public NewCrs()
        {
            InitializeComponent();
        }

        private void NewCrs_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            ExamDB.Open();
            SqlCommand cmd = new SqlCommand("addCourse", ExamDB);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", SqlDbType.VarChar).Value = crsName.Text.ToString().Trim();
            cmd.Parameters.AddWithValue("@dur", SqlDbType.Int).Value = dur.Text.ToString().Trim();            
            cmd.ExecuteNonQuery();
            MessageBox.Show("^_^ You Added New Student ^_^");
            ExamDB.Close();
            crsName.Text = dur.Text  = String.Empty;

        }
    }
}
