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
    public partial class NewQue : Form
    {
        public NewQue()
        {
            InitializeComponent();
        }
        Dictionary<int, string> dic = new Dictionary<int, string>();
        private void tf_Click(object sender, EventArgs e)
        {
                ExamDB.Close();
                TF frm = new TF();
                frm.ShowDialog();
   
        }

        private void mc_Click(object sender, EventArgs e)
        {
            
                MC frm = new MC();
                frm.ShowDialog();
            

        }

        private void crs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NewQue_Load(object sender, EventArgs e)
        {
           
        }
    }
}
