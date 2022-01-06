
namespace DBProject
{
    partial class NewDept
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewDept));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ExamDB = new System.Data.SqlClient.SqlConnection();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.cnl = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.mgr = new System.Windows.Forms.ComboBox();
            this.deptName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(796, 445);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ExamDB
            // 
            this.ExamDB.ConnectionString = "Data Source=.;Initial Catalog=ExamDB;Integrated Security=True";
            this.ExamDB.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommand1.Connection = this.ExamDB;
            // 
            // cnl
            // 
            this.cnl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cnl.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cnl.ForeColor = System.Drawing.Color.Navy;
            this.cnl.Location = new System.Drawing.Point(423, 318);
            this.cnl.Name = "cnl";
            this.cnl.Size = new System.Drawing.Size(75, 23);
            this.cnl.TabIndex = 26;
            this.cnl.Text = "Cancel";
            this.cnl.UseVisualStyleBackColor = false;
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.save.ForeColor = System.Drawing.Color.Navy;
            this.save.Location = new System.Drawing.Point(294, 318);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 25;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // mgr
            // 
            this.mgr.BackColor = System.Drawing.SystemColors.HighlightText;
            this.mgr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mgr.FormattingEnabled = true;
            this.mgr.Location = new System.Drawing.Point(381, 227);
            this.mgr.Name = "mgr";
            this.mgr.Size = new System.Drawing.Size(193, 24);
            this.mgr.TabIndex = 24;
            this.mgr.SelectedIndexChanged += new System.EventHandler(this.mgr_SelectedIndexChanged);
            // 
            // deptName
            // 
            this.deptName.Location = new System.Drawing.Point(381, 157);
            this.deptName.Name = "deptName";
            this.deptName.Size = new System.Drawing.Size(193, 22);
            this.deptName.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(273, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(286, 39);
            this.label6.TabIndex = 19;
            this.label6.Text = "New Department";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(238, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Manger Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(238, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Dept Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // NewDept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cnl);
            this.Controls.Add(this.save);
            this.Controls.Add(this.mgr);
            this.Controls.Add(this.deptName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "NewDept";
            this.Text = "NewDept";
            this.Load += new System.EventHandler(this.NewDept_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Data.SqlClient.SqlConnection ExamDB;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.Button cnl;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.ComboBox mgr;
        private System.Windows.Forms.TextBox deptName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}