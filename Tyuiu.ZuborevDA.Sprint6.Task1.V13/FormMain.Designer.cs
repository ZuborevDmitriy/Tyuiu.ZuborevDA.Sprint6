
namespace Tyuiu.ZuborevDA.Sprint6.Task1.V13
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
            this.textBoxUslovie_ZDA = new System.Windows.Forms.TextBox();
            this.groupBoxIn_ZDA = new System.Windows.Forms.GroupBox();
            this.labelStop_ZDA = new System.Windows.Forms.Label();
            this.labelStart_ZDA = new System.Windows.Forms.Label();
            this.textBoxStopV_ZDA = new System.Windows.Forms.TextBox();
            this.textBoxStartV_ZDA = new System.Windows.Forms.TextBox();
            this.groupBoxOut_ZDA = new System.Windows.Forms.GroupBox();
            this.labelResult_ZDA = new System.Windows.Forms.Label();
            this.textBoxResult_ZDA = new System.Windows.Forms.TextBox();
            this.buttonPushMe_ZDA = new System.Windows.Forms.Button();
            this.buttonInform_ZDA = new System.Windows.Forms.Button();
            this.groupBoxTask_ZDA.SuspendLayout();
            this.groupBoxIn_ZDA.SuspendLayout();
            this.groupBoxOut_ZDA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_ZDA
            // 
            this.groupBoxTask_ZDA.Controls.Add(this.textBoxUslovie_ZDA);
            this.groupBoxTask_ZDA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_ZDA.Name = "groupBoxTask_ZDA";
            this.groupBoxTask_ZDA.Size = new System.Drawing.Size(455, 227);
            this.groupBoxTask_ZDA.TabIndex = 7;
            this.groupBoxTask_ZDA.TabStop = false;
            this.groupBoxTask_ZDA.Text = "Условие";
            // 
            // textBoxUslovie_ZDA
            // 
            this.textBoxUslovie_ZDA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUslovie_ZDA.Location = new System.Drawing.Point(8, 20);
            this.textBoxUslovie_ZDA.Multiline = true;
            this.textBoxUslovie_ZDA.Name = "textBoxUslovie_ZDA";
            this.textBoxUslovie_ZDA.ReadOnly = true;
            this.textBoxUslovie_ZDA.Size = new System.Drawing.Size(441, 201);
            this.textBoxUslovie_ZDA.TabIndex = 1;
            this.textBoxUslovie_ZDA.TabStop = false;
            this.textBoxUslovie_ZDA.Text = resources.GetString("textBoxUslovie_ZDA.Text");
            // 
            // groupBoxIn_ZDA
            // 
            this.groupBoxIn_ZDA.Controls.Add(this.labelStop_ZDA);
            this.groupBoxIn_ZDA.Controls.Add(this.labelStart_ZDA);
            this.groupBoxIn_ZDA.Controls.Add(this.textBoxStopV_ZDA);
            this.groupBoxIn_ZDA.Controls.Add(this.textBoxStartV_ZDA);
            this.groupBoxIn_ZDA.Location = new System.Drawing.Point(13, 246);
            this.groupBoxIn_ZDA.Name = "groupBoxIn_ZDA";
            this.groupBoxIn_ZDA.Size = new System.Drawing.Size(240, 58);
            this.groupBoxIn_ZDA.TabIndex = 8;
            this.groupBoxIn_ZDA.TabStop = false;
            this.groupBoxIn_ZDA.Text = "Ввод данных";
            // 
            // labelStop_ZDA
            // 
            this.labelStop_ZDA.AutoSize = true;
            this.labelStop_ZDA.Location = new System.Drawing.Point(123, 13);
            this.labelStop_ZDA.Name = "labelStop_ZDA";
            this.labelStop_ZDA.Size = new System.Drawing.Size(69, 13);
            this.labelStop_ZDA.TabIndex = 3;
            this.labelStop_ZDA.Text = "Конец шага:";
            // 
            // labelStart_ZDA
            // 
            this.labelStart_ZDA.AutoSize = true;
            this.labelStart_ZDA.Location = new System.Drawing.Point(7, 13);
            this.labelStart_ZDA.Name = "labelStart_ZDA";
            this.labelStart_ZDA.Size = new System.Drawing.Size(67, 13);
            this.labelStart_ZDA.TabIndex = 2;
            this.labelStart_ZDA.Text = "Старт шага:";
            // 
            // textBoxStopV_ZDA
            // 
            this.textBoxStopV_ZDA.Location = new System.Drawing.Point(123, 32);
            this.textBoxStopV_ZDA.Name = "textBoxStopV_ZDA";
            this.textBoxStopV_ZDA.Size = new System.Drawing.Size(110, 20);
            this.textBoxStopV_ZDA.TabIndex = 1;
            // 
            // textBoxStartV_ZDA
            // 
            this.textBoxStartV_ZDA.Location = new System.Drawing.Point(7, 32);
            this.textBoxStartV_ZDA.Name = "textBoxStartV_ZDA";
            this.textBoxStartV_ZDA.Size = new System.Drawing.Size(110, 20);
            this.textBoxStartV_ZDA.TabIndex = 0;
            // 
            // groupBoxOut_ZDA
            // 
            this.groupBoxOut_ZDA.Controls.Add(this.labelResult_ZDA);
            this.groupBoxOut_ZDA.Controls.Add(this.textBoxResult_ZDA);
            this.groupBoxOut_ZDA.Location = new System.Drawing.Point(474, 13);
            this.groupBoxOut_ZDA.Name = "groupBoxOut_ZDA";
            this.groupBoxOut_ZDA.Size = new System.Drawing.Size(234, 291);
            this.groupBoxOut_ZDA.TabIndex = 9;
            this.groupBoxOut_ZDA.TabStop = false;
            this.groupBoxOut_ZDA.Text = "Вывод данных";
            // 
            // labelResult_ZDA
            // 
            this.labelResult_ZDA.AutoSize = true;
            this.labelResult_ZDA.Location = new System.Drawing.Point(7, 19);
            this.labelResult_ZDA.Name = "labelResult_ZDA";
            this.labelResult_ZDA.Size = new System.Drawing.Size(59, 13);
            this.labelResult_ZDA.TabIndex = 4;
            this.labelResult_ZDA.Text = "Результат";
            // 
            // textBoxResult_ZDA
            // 
            this.textBoxResult_ZDA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxResult_ZDA.Font = new System.Drawing.Font("Consolas", 10F);
            this.textBoxResult_ZDA.Location = new System.Drawing.Point(6, 38);
            this.textBoxResult_ZDA.Multiline = true;
            this.textBoxResult_ZDA.Name = "textBoxResult_ZDA";
            this.textBoxResult_ZDA.ReadOnly = true;
            this.textBoxResult_ZDA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_ZDA.Size = new System.Drawing.Size(224, 249);
            this.textBoxResult_ZDA.TabIndex = 3;
            // 
            // buttonPushMe_ZDA
            // 
            this.buttonPushMe_ZDA.BackColor = System.Drawing.Color.Green;
            this.buttonPushMe_ZDA.Location = new System.Drawing.Point(340, 250);
            this.buttonPushMe_ZDA.Name = "buttonPushMe_ZDA";
            this.buttonPushMe_ZDA.Size = new System.Drawing.Size(127, 54);
            this.buttonPushMe_ZDA.TabIndex = 10;
            this.buttonPushMe_ZDA.Text = "Выполнить";
            this.buttonPushMe_ZDA.UseVisualStyleBackColor = false;
            this.buttonPushMe_ZDA.Click += new System.EventHandler(this.buttonPushMe_ZDA_Click);
            // 
            // buttonInform_ZDA
            // 
            this.buttonInform_ZDA.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonInform_ZDA.Location = new System.Drawing.Point(259, 250);
            this.buttonInform_ZDA.Name = "buttonInform_ZDA";
            this.buttonInform_ZDA.Size = new System.Drawing.Size(75, 54);
            this.buttonInform_ZDA.TabIndex = 11;
            this.buttonInform_ZDA.Text = "Справка";
            this.buttonInform_ZDA.UseVisualStyleBackColor = false;
            this.buttonInform_ZDA.Click += new System.EventHandler(this.buttonInform_ZDA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 316);
            this.Controls.Add(this.buttonInform_ZDA);
            this.Controls.Add(this.buttonPushMe_ZDA);
            this.Controls.Add(this.groupBoxOut_ZDA);
            this.Controls.Add(this.groupBoxIn_ZDA);
            this.Controls.Add(this.groupBoxTask_ZDA);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 1 | Вариант 13 | ЗуборевД. А.";
            this.groupBoxTask_ZDA.ResumeLayout(false);
            this.groupBoxTask_ZDA.PerformLayout();
            this.groupBoxIn_ZDA.ResumeLayout(false);
            this.groupBoxIn_ZDA.PerformLayout();
            this.groupBoxOut_ZDA.ResumeLayout(false);
            this.groupBoxOut_ZDA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_ZDA;
        private System.Windows.Forms.TextBox textBoxUslovie_ZDA;
        private System.Windows.Forms.GroupBox groupBoxIn_ZDA;
        private System.Windows.Forms.Label labelStop_ZDA;
        private System.Windows.Forms.Label labelStart_ZDA;
        private System.Windows.Forms.TextBox textBoxStopV_ZDA;
        private System.Windows.Forms.TextBox textBoxStartV_ZDA;
        private System.Windows.Forms.GroupBox groupBoxOut_ZDA;
        private System.Windows.Forms.Label labelResult_ZDA;
        private System.Windows.Forms.TextBox textBoxResult_ZDA;
        private System.Windows.Forms.Button buttonPushMe_ZDA;
        private System.Windows.Forms.Button buttonInform_ZDA;
    }
}

