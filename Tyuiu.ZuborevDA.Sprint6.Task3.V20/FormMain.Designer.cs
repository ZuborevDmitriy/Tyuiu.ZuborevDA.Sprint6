
namespace Tyuiu.ZuborevDA.Sprint6.Task3.V20
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxTask_ZDA = new System.Windows.Forms.GroupBox();
            this.groupBoxOut_ZDA = new System.Windows.Forms.GroupBox();
            this.dataGridViewMatrix_ZDA = new System.Windows.Forms.DataGridView();
            this.buttonPushMe_ZDA = new System.Windows.Forms.Button();
            this.buttonInform_ZDA = new System.Windows.Forms.Button();
            this.textBoxUslovie_ZDA = new System.Windows.Forms.TextBox();
            this.labelResult_ZDA = new System.Windows.Forms.Label();
            this.textBoxResult_ZDA = new System.Windows.Forms.TextBox();
            this.groupBoxTask_ZDA.SuspendLayout();
            this.groupBoxOut_ZDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_ZDA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_ZDA
            // 
            this.groupBoxTask_ZDA.Controls.Add(this.textBoxUslovie_ZDA);
            this.groupBoxTask_ZDA.Controls.Add(this.dataGridViewMatrix_ZDA);
            this.groupBoxTask_ZDA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_ZDA.Name = "groupBoxTask_ZDA";
            this.groupBoxTask_ZDA.Size = new System.Drawing.Size(453, 209);
            this.groupBoxTask_ZDA.TabIndex = 0;
            this.groupBoxTask_ZDA.TabStop = false;
            this.groupBoxTask_ZDA.Text = "Условие";
            // 
            // groupBoxOut_ZDA
            // 
            this.groupBoxOut_ZDA.Controls.Add(this.labelResult_ZDA);
            this.groupBoxOut_ZDA.Controls.Add(this.textBoxResult_ZDA);
            this.groupBoxOut_ZDA.Location = new System.Drawing.Point(471, 12);
            this.groupBoxOut_ZDA.Name = "groupBoxOut_ZDA";
            this.groupBoxOut_ZDA.Size = new System.Drawing.Size(129, 122);
            this.groupBoxOut_ZDA.TabIndex = 1;
            this.groupBoxOut_ZDA.TabStop = false;
            this.groupBoxOut_ZDA.Text = "Вывод данных";
            // 
            // dataGridViewMatrix_ZDA
            // 
            this.dataGridViewMatrix_ZDA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_ZDA.ColumnHeadersVisible = false;
            this.dataGridViewMatrix_ZDA.Location = new System.Drawing.Point(254, 16);
            this.dataGridViewMatrix_ZDA.Name = "dataGridViewMatrix_ZDA";
            this.dataGridViewMatrix_ZDA.ReadOnly = true;
            this.dataGridViewMatrix_ZDA.RowHeadersVisible = false;
            this.dataGridViewMatrix_ZDA.Size = new System.Drawing.Size(193, 184);
            this.dataGridViewMatrix_ZDA.TabIndex = 0;
            this.dataGridViewMatrix_ZDA.TabStop = false;
            // 
            // buttonPushMe_ZDA
            // 
            this.buttonPushMe_ZDA.Location = new System.Drawing.Point(520, 174);
            this.buttonPushMe_ZDA.Name = "buttonPushMe_ZDA";
            this.buttonPushMe_ZDA.Size = new System.Drawing.Size(80, 47);
            this.buttonPushMe_ZDA.TabIndex = 1;
            this.buttonPushMe_ZDA.Text = "Выполнить";
            this.buttonPushMe_ZDA.UseVisualStyleBackColor = true;
            this.buttonPushMe_ZDA.Click += new System.EventHandler(this.buttonPushMe_ZDA_Click);
            // 
            // buttonInform_ZDA
            // 
            this.buttonInform_ZDA.Location = new System.Drawing.Point(480, 180);
            this.buttonInform_ZDA.Name = "buttonInform_ZDA";
            this.buttonInform_ZDA.Size = new System.Drawing.Size(32, 35);
            this.buttonInform_ZDA.TabIndex = 2;
            this.buttonInform_ZDA.Text = "?";
            this.buttonInform_ZDA.UseVisualStyleBackColor = true;
            this.buttonInform_ZDA.Click += new System.EventHandler(this.buttonInform_ZDA_Click);
            // 
            // textBoxUslovie_ZDA
            // 
            this.textBoxUslovie_ZDA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUslovie_ZDA.Location = new System.Drawing.Point(6, 16);
            this.textBoxUslovie_ZDA.Multiline = true;
            this.textBoxUslovie_ZDA.Name = "textBoxUslovie_ZDA";
            this.textBoxUslovie_ZDA.ReadOnly = true;
            this.textBoxUslovie_ZDA.Size = new System.Drawing.Size(242, 184);
            this.textBoxUslovie_ZDA.TabIndex = 0;
            this.textBoxUslovie_ZDA.TabStop = false;
            this.textBoxUslovie_ZDA.Text = resources.GetString("textBoxUslovie_ZDA.Text");
            // 
            // labelResult_ZDA
            // 
            this.labelResult_ZDA.AutoSize = true;
            this.labelResult_ZDA.Location = new System.Drawing.Point(6, 16);
            this.labelResult_ZDA.Name = "labelResult_ZDA";
            this.labelResult_ZDA.Size = new System.Drawing.Size(62, 13);
            this.labelResult_ZDA.TabIndex = 1;
            this.labelResult_ZDA.Text = "Результат:";
            // 
            // textBoxResult_ZDA
            // 
            this.textBoxResult_ZDA.Location = new System.Drawing.Point(9, 32);
            this.textBoxResult_ZDA.Multiline = true;
            this.textBoxResult_ZDA.Name = "textBoxResult_ZDA";
            this.textBoxResult_ZDA.ReadOnly = true;
            this.textBoxResult_ZDA.Size = new System.Drawing.Size(109, 78);
            this.textBoxResult_ZDA.TabIndex = 0;
            this.textBoxResult_ZDA.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 233);
            this.Controls.Add(this.buttonInform_ZDA);
            this.Controls.Add(this.buttonPushMe_ZDA);
            this.Controls.Add(this.groupBoxOut_ZDA);
            this.Controls.Add(this.groupBoxTask_ZDA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 20 | ЗуборевД. А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_ZDA.ResumeLayout(false);
            this.groupBoxTask_ZDA.PerformLayout();
            this.groupBoxOut_ZDA.ResumeLayout(false);
            this.groupBoxOut_ZDA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_ZDA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_ZDA;
        private System.Windows.Forms.TextBox textBoxUslovie_ZDA;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_ZDA;
        private System.Windows.Forms.GroupBox groupBoxOut_ZDA;
        private System.Windows.Forms.Label labelResult_ZDA;
        private System.Windows.Forms.Button buttonPushMe_ZDA;
        private System.Windows.Forms.Button buttonInform_ZDA;
        private System.Windows.Forms.TextBox textBoxResult_ZDA;
    }
}

