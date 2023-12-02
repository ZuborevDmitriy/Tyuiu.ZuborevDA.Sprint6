
namespace Tyuiu.ZuborevDA.Sprint6.Task0.V6
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
            this.groupBoxUslovie_ZDA = new System.Windows.Forms.GroupBox();
            this.textBoxUslText_ZDA = new System.Windows.Forms.TextBox();
            this.pictureBoxFormula_ZDA = new System.Windows.Forms.PictureBox();
            this.groupBoxData_ZDA = new System.Windows.Forms.GroupBox();
            this.labelTextX_ZDA = new System.Windows.Forms.Label();
            this.textBoxVarX_ZDA = new System.Windows.Forms.TextBox();
            this.groupBoxOut_ZDA = new System.Windows.Forms.GroupBox();
            this.labelTextResult_ZDA = new System.Windows.Forms.Label();
            this.textBoxResult_ZDA = new System.Windows.Forms.TextBox();
            this.buttonPushMe_ZDA = new System.Windows.Forms.Button();
            this.buttonQuestion = new System.Windows.Forms.Button();
            this.groupBoxUslovie_ZDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_ZDA)).BeginInit();
            this.groupBoxData_ZDA.SuspendLayout();
            this.groupBoxOut_ZDA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxUslovie_ZDA
            // 
            this.groupBoxUslovie_ZDA.Controls.Add(this.textBoxUslText_ZDA);
            this.groupBoxUslovie_ZDA.Controls.Add(this.pictureBoxFormula_ZDA);
            this.groupBoxUslovie_ZDA.Location = new System.Drawing.Point(11, 19);
            this.groupBoxUslovie_ZDA.Name = "groupBoxUslovie_ZDA";
            this.groupBoxUslovie_ZDA.Size = new System.Drawing.Size(406, 127);
            this.groupBoxUslovie_ZDA.TabIndex = 0;
            this.groupBoxUslovie_ZDA.TabStop = false;
            this.groupBoxUslovie_ZDA.Text = "Условие";
            // 
            // textBoxUslText_ZDA
            // 
            this.textBoxUslText_ZDA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUslText_ZDA.Location = new System.Drawing.Point(11, 19);
            this.textBoxUslText_ZDA.Multiline = true;
            this.textBoxUslText_ZDA.Name = "textBoxUslText_ZDA";
            this.textBoxUslText_ZDA.ReadOnly = true;
            this.textBoxUslText_ZDA.Size = new System.Drawing.Size(251, 102);
            this.textBoxUslText_ZDA.TabIndex = 1;
            this.textBoxUslText_ZDA.TabStop = false;
            this.textBoxUslText_ZDA.Text = "Вычислить выражение по формуле";
            // 
            // pictureBoxFormula_ZDA
            // 
            this.pictureBoxFormula_ZDA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_ZDA.Image")));
            this.pictureBoxFormula_ZDA.Location = new System.Drawing.Point(268, 19);
            this.pictureBoxFormula_ZDA.Name = "pictureBoxFormula_ZDA";
            this.pictureBoxFormula_ZDA.Size = new System.Drawing.Size(132, 57);
            this.pictureBoxFormula_ZDA.TabIndex = 0;
            this.pictureBoxFormula_ZDA.TabStop = false;
            // 
            // groupBoxData_ZDA
            // 
            this.groupBoxData_ZDA.Controls.Add(this.labelTextX_ZDA);
            this.groupBoxData_ZDA.Controls.Add(this.textBoxVarX_ZDA);
            this.groupBoxData_ZDA.Location = new System.Drawing.Point(11, 152);
            this.groupBoxData_ZDA.Name = "groupBoxData_ZDA";
            this.groupBoxData_ZDA.Size = new System.Drawing.Size(200, 75);
            this.groupBoxData_ZDA.TabIndex = 1;
            this.groupBoxData_ZDA.TabStop = false;
            this.groupBoxData_ZDA.Text = "Ввод данных";
            // 
            // labelTextX_ZDA
            // 
            this.labelTextX_ZDA.AutoSize = true;
            this.labelTextX_ZDA.Location = new System.Drawing.Point(13, 25);
            this.labelTextX_ZDA.Name = "labelTextX_ZDA";
            this.labelTextX_ZDA.Size = new System.Drawing.Size(84, 13);
            this.labelTextX_ZDA.TabIndex = 2;
            this.labelTextX_ZDA.Text = "Переменная X:";
            // 
            // textBoxVarX_ZDA
            // 
            this.textBoxVarX_ZDA.Location = new System.Drawing.Point(16, 44);
            this.textBoxVarX_ZDA.Name = "textBoxVarX_ZDA";
            this.textBoxVarX_ZDA.Size = new System.Drawing.Size(81, 20);
            this.textBoxVarX_ZDA.TabIndex = 1;
            this.textBoxVarX_ZDA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarX_ZDA_KeyPress);
            // 
            // groupBoxOut_ZDA
            // 
            this.groupBoxOut_ZDA.Controls.Add(this.labelTextResult_ZDA);
            this.groupBoxOut_ZDA.Controls.Add(this.textBoxResult_ZDA);
            this.groupBoxOut_ZDA.Location = new System.Drawing.Point(217, 152);
            this.groupBoxOut_ZDA.Name = "groupBoxOut_ZDA";
            this.groupBoxOut_ZDA.Size = new System.Drawing.Size(200, 75);
            this.groupBoxOut_ZDA.TabIndex = 2;
            this.groupBoxOut_ZDA.TabStop = false;
            this.groupBoxOut_ZDA.Text = "Вывод данных";
            // 
            // labelTextResult_ZDA
            // 
            this.labelTextResult_ZDA.AutoSize = true;
            this.labelTextResult_ZDA.Location = new System.Drawing.Point(7, 25);
            this.labelTextResult_ZDA.Name = "labelTextResult_ZDA";
            this.labelTextResult_ZDA.Size = new System.Drawing.Size(59, 13);
            this.labelTextResult_ZDA.TabIndex = 1;
            this.labelTextResult_ZDA.Text = "Результат";
            // 
            // textBoxResult_ZDA
            // 
            this.textBoxResult_ZDA.Location = new System.Drawing.Point(7, 44);
            this.textBoxResult_ZDA.Name = "textBoxResult_ZDA";
            this.textBoxResult_ZDA.ReadOnly = true;
            this.textBoxResult_ZDA.Size = new System.Drawing.Size(187, 20);
            this.textBoxResult_ZDA.TabIndex = 4;
            this.textBoxResult_ZDA.TabStop = false;
            // 
            // buttonPushMe_ZDA
            // 
            this.buttonPushMe_ZDA.Location = new System.Drawing.Point(306, 280);
            this.buttonPushMe_ZDA.Name = "buttonPushMe_ZDA";
            this.buttonPushMe_ZDA.Size = new System.Drawing.Size(112, 32);
            this.buttonPushMe_ZDA.TabIndex = 2;
            this.buttonPushMe_ZDA.Text = "Выполнить";
            this.buttonPushMe_ZDA.UseVisualStyleBackColor = true;
            this.buttonPushMe_ZDA.Click += new System.EventHandler(this.buttonPushMe_ZDA_Click);
            // 
            // buttonQuestion
            // 
            this.buttonQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuestion.Location = new System.Drawing.Point(268, 280);
            this.buttonQuestion.Name = "buttonQuestion";
            this.buttonQuestion.Size = new System.Drawing.Size(32, 32);
            this.buttonQuestion.TabIndex = 3;
            this.buttonQuestion.Text = "?";
            this.buttonQuestion.UseVisualStyleBackColor = true;
            this.buttonQuestion.Click += new System.EventHandler(this.buttonQuestion_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 324);
            this.Controls.Add(this.buttonQuestion);
            this.Controls.Add(this.buttonPushMe_ZDA);
            this.Controls.Add(this.groupBoxOut_ZDA);
            this.Controls.Add(this.groupBoxData_ZDA);
            this.Controls.Add(this.groupBoxUslovie_ZDA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 6 |Зуборев Д. А.";
            this.groupBoxUslovie_ZDA.ResumeLayout(false);
            this.groupBoxUslovie_ZDA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_ZDA)).EndInit();
            this.groupBoxData_ZDA.ResumeLayout(false);
            this.groupBoxData_ZDA.PerformLayout();
            this.groupBoxOut_ZDA.ResumeLayout(false);
            this.groupBoxOut_ZDA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUslovie_ZDA;
        private System.Windows.Forms.TextBox textBoxUslText_ZDA;
        private System.Windows.Forms.PictureBox pictureBoxFormula_ZDA;
        private System.Windows.Forms.GroupBox groupBoxData_ZDA;
        private System.Windows.Forms.Label labelTextX_ZDA;
        private System.Windows.Forms.TextBox textBoxVarX_ZDA;
        private System.Windows.Forms.GroupBox groupBoxOut_ZDA;
        private System.Windows.Forms.Label labelTextResult_ZDA;
        private System.Windows.Forms.TextBox textBoxResult_ZDA;
        private System.Windows.Forms.Button buttonPushMe_ZDA;
        private System.Windows.Forms.Button buttonQuestion;
    }
}

