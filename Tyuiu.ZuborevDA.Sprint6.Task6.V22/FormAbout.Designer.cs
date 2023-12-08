
namespace Tyuiu.ZuborevDA.Sprint6.Task6.V22
{
    partial class FormAbout_ZDA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout_ZDA));
            this.pictureBoxAvatar_ZDA = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_ZDA)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAvatar_ZDA
            // 
            this.pictureBoxAvatar_ZDA.Image = global::Tyuiu.ZuborevDA.Sprint6.Task6.V22.Properties.Resources._16883149893820;
            this.pictureBoxAvatar_ZDA.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxAvatar_ZDA.Name = "pictureBoxAvatar_ZDA";
            this.pictureBoxAvatar_ZDA.Size = new System.Drawing.Size(204, 203);
            this.pictureBoxAvatar_ZDA.TabIndex = 0;
            this.pictureBoxAvatar_ZDA.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(223, 13);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(294, 202);
            this.textBox1.TabIndex = 0;
            this.textBox1.TabStop = false;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // FormAbout_ZDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 231);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBoxAvatar_ZDA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout_ZDA";
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_ZDA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAvatar_ZDA;
        private System.Windows.Forms.TextBox textBox1;
    }
}