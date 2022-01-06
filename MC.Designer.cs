
namespace DBProject
{
    partial class MC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MC));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.l1 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.l3 = new System.Windows.Forms.Label();
            this.l4 = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.TextBox();
            this.b = new System.Windows.Forms.TextBox();
            this.c = new System.Windows.Forms.TextBox();
            this.d = new System.Windows.Forms.TextBox();
            this.answer = new System.Windows.Forms.ComboBox();
            this.deg = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.crsName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.qubox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ExamDB = new System.Data.SqlClient.SqlConnection();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(976, 460);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.ForeColor = System.Drawing.Color.Navy;
            this.button3.Location = new System.Drawing.Point(550, 374);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 44);
            this.button3.TabIndex = 16;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.OldLace;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(480, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = " Answer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.OldLace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(297, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 39);
            this.label1.TabIndex = 17;
            this.label1.Text = "Multi Choice Question";
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.AntiqueWhite;
            this.save.ForeColor = System.Drawing.Color.Navy;
            this.save.Location = new System.Drawing.Point(319, 374);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(117, 44);
            this.save.TabIndex = 19;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.l1.Location = new System.Drawing.Point(547, 115);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(16, 17);
            this.l1.TabIndex = 20;
            this.l1.Text = "1";
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.l2.Location = new System.Drawing.Point(547, 161);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(16, 17);
            this.l2.TabIndex = 21;
            this.l2.Text = "2";
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.BackColor = System.Drawing.Color.AntiqueWhite;
            this.l3.Location = new System.Drawing.Point(547, 207);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(16, 17);
            this.l3.TabIndex = 22;
            this.l3.Text = "3";
            // 
            // l4
            // 
            this.l4.AutoSize = true;
            this.l4.BackColor = System.Drawing.Color.AntiqueWhite;
            this.l4.Location = new System.Drawing.Point(547, 262);
            this.l4.Name = "l4";
            this.l4.Size = new System.Drawing.Size(16, 17);
            this.l4.TabIndex = 23;
            this.l4.Text = "4";
            // 
            // a
            // 
            this.a.BackColor = System.Drawing.Color.AntiqueWhite;
            this.a.Location = new System.Drawing.Point(585, 115);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(281, 22);
            this.a.TabIndex = 24;
            // 
            // b
            // 
            this.b.BackColor = System.Drawing.Color.AntiqueWhite;
            this.b.Location = new System.Drawing.Point(585, 161);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(281, 22);
            this.b.TabIndex = 25;
            // 
            // c
            // 
            this.c.BackColor = System.Drawing.Color.AntiqueWhite;
            this.c.Location = new System.Drawing.Point(585, 207);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(281, 22);
            this.c.TabIndex = 26;
            // 
            // d
            // 
            this.d.BackColor = System.Drawing.Color.AntiqueWhite;
            this.d.Location = new System.Drawing.Point(585, 262);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(281, 22);
            this.d.TabIndex = 27;
            // 
            // answer
            // 
            this.answer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.answer.FormattingEnabled = true;
            this.answer.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.answer.Location = new System.Drawing.Point(585, 68);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(281, 24);
            this.answer.TabIndex = 28;
            // 
            // deg
            // 
            this.deg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deg.FormattingEnabled = true;
            this.deg.Items.AddRange(new object[] {
            "1",
            "2"});
            this.deg.Location = new System.Drawing.Point(155, 233);
            this.deg.Name = "deg";
            this.deg.Size = new System.Drawing.Size(281, 24);
            this.deg.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.OldLace;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 29);
            this.label2.TabIndex = 33;
            this.label2.Text = "Degree";
            // 
            // crsName
            // 
            this.crsName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.crsName.FormattingEnabled = true;
            this.crsName.Location = new System.Drawing.Point(155, 67);
            this.crsName.Name = "crsName";
            this.crsName.Size = new System.Drawing.Size(281, 24);
            this.crsName.TabIndex = 32;
            this.crsName.SelectedIndexChanged += new System.EventHandler(this.crsName_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.OldLace;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(13, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 29);
            this.label3.TabIndex = 31;
            this.label3.Text = "Course";
            // 
            // qubox
            // 
            this.qubox.BackColor = System.Drawing.Color.AntiqueWhite;
            this.qubox.Location = new System.Drawing.Point(155, 158);
            this.qubox.Name = "qubox";
            this.qubox.Size = new System.Drawing.Size(281, 22);
            this.qubox.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.OldLace;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 29);
            this.label5.TabIndex = 29;
            this.label5.Text = "Question";
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
            // MC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 459);
            this.Controls.Add(this.deg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.crsName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.qubox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.d);
            this.Controls.Add(this.c);
            this.Controls.Add(this.b);
            this.Controls.Add(this.a);
            this.Controls.Add(this.l4);
            this.Controls.Add(this.l3);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MC";
            this.Text = "MC";
            this.Load += new System.EventHandler(this.MC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.Label l4;
        private System.Windows.Forms.TextBox a;
        private System.Windows.Forms.TextBox b;
        private System.Windows.Forms.TextBox c;
        private System.Windows.Forms.TextBox d;
        private System.Windows.Forms.ComboBox answer;
        private System.Windows.Forms.ComboBox deg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox crsName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox qubox;
        private System.Windows.Forms.Label label5;
        private System.Data.SqlClient.SqlConnection ExamDB;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
    }
}