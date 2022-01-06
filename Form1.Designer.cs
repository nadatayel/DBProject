
namespace DBProject
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnstd = new System.Windows.Forms.Button();
            this.btnins = new System.Windows.Forms.Button();
            this.btnex = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btndept = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 446);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(270, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Exam System";
            // 
            // btnstd
            // 
            this.btnstd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnstd.ForeColor = System.Drawing.Color.Navy;
            this.btnstd.Location = new System.Drawing.Point(52, 366);
            this.btnstd.Name = "btnstd";
            this.btnstd.Size = new System.Drawing.Size(135, 45);
            this.btnstd.TabIndex = 2;
            this.btnstd.Text = "Manage Student";
            this.btnstd.UseVisualStyleBackColor = false;
            this.btnstd.Click += new System.EventHandler(this.btnstd_Click);
            // 
            // btnins
            // 
            this.btnins.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnins.ForeColor = System.Drawing.Color.Navy;
            this.btnins.Location = new System.Drawing.Point(632, 366);
            this.btnins.Name = "btnins";
            this.btnins.Size = new System.Drawing.Size(135, 45);
            this.btnins.TabIndex = 3;
            this.btnins.Text = "Manage Instructor";
            this.btnins.UseVisualStyleBackColor = false;
            // 
            // btnex
            // 
            this.btnex.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnex.ForeColor = System.Drawing.Color.Navy;
            this.btnex.Location = new System.Drawing.Point(491, 366);
            this.btnex.Name = "btnex";
            this.btnex.Size = new System.Drawing.Size(135, 45);
            this.btnex.TabIndex = 4;
            this.btnex.Text = "Manage Exam";
            this.btnex.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.ForeColor = System.Drawing.Color.Navy;
            this.button3.Location = new System.Drawing.Point(350, 366);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 45);
            this.button3.TabIndex = 5;
            this.button3.Text = "Manage Course";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btndept
            // 
            this.btndept.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btndept.ForeColor = System.Drawing.Color.Navy;
            this.btndept.Location = new System.Drawing.Point(193, 366);
            this.btndept.Name = "btndept";
            this.btndept.Size = new System.Drawing.Size(151, 45);
            this.btndept.TabIndex = 6;
            this.btndept.Text = "Manage Department";
            this.btndept.UseVisualStyleBackColor = false;
            this.btndept.Click += new System.EventHandler(this.btndept_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btndept);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnex);
            this.Controls.Add(this.btnins);
            this.Controls.Add(this.btnstd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnstd;
        private System.Windows.Forms.Button btnins;
        private System.Windows.Forms.Button btnex;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btndept;
    }
}

