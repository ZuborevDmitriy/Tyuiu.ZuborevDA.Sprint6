
namespace Tyuiu.ZuborevDA.Sprint6.Task2.V7
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxTask_ZDA = new System.Windows.Forms.GroupBox();
            this.groupBoxOut_ZDA = new System.Windows.Forms.GroupBox();
            this.groupBoxIn_ZDA = new System.Windows.Forms.GroupBox();
            this.dataGridViewFunction_ZDA = new System.Windows.Forms.DataGridView();
            this.textBoxStartV_ZDA = new System.Windows.Forms.TextBox();
            this.textBoxStopV_ZDA = new System.Windows.Forms.TextBox();
            this.chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonPushMe_ZDA = new System.Windows.Forms.Button();
            this.buttonInform_ZDA = new System.Windows.Forms.Button();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelStart_ZDA = new System.Windows.Forms.Label();
            this.labelStop_ZDA = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBoxTask_ZDA.SuspendLayout();
            this.groupBoxOut_ZDA.SuspendLayout();
            this.groupBoxIn_ZDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_ZDA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_ZDA
            // 
            this.groupBoxTask_ZDA.Controls.Add(this.textBox1);
            this.groupBoxTask_ZDA.Location = new System.Drawing.Point(13, 13);
            this.groupBoxTask_ZDA.Name = "groupBoxTask_ZDA";
            this.groupBoxTask_ZDA.Size = new System.Drawing.Size(429, 221);
            this.groupBoxTask_ZDA.TabIndex = 0;
            this.groupBoxTask_ZDA.TabStop = false;
            this.groupBoxTask_ZDA.Text = "Условие";
            // 
            // groupBoxOut_ZDA
            // 
            this.groupBoxOut_ZDA.Controls.Add(this.chartFunction);
            this.groupBoxOut_ZDA.Controls.Add(this.dataGridViewFunction_ZDA);
            this.groupBoxOut_ZDA.Location = new System.Drawing.Point(448, 13);
            this.groupBoxOut_ZDA.Name = "groupBoxOut_ZDA";
            this.groupBoxOut_ZDA.Size = new System.Drawing.Size(569, 290);
            this.groupBoxOut_ZDA.TabIndex = 1;
            this.groupBoxOut_ZDA.TabStop = false;
            this.groupBoxOut_ZDA.Text = "Вывод данных";
            // 
            // groupBoxIn_ZDA
            // 
            this.groupBoxIn_ZDA.Controls.Add(this.labelStop_ZDA);
            this.groupBoxIn_ZDA.Controls.Add(this.labelStart_ZDA);
            this.groupBoxIn_ZDA.Controls.Add(this.textBoxStopV_ZDA);
            this.groupBoxIn_ZDA.Controls.Add(this.textBoxStartV_ZDA);
            this.groupBoxIn_ZDA.Location = new System.Drawing.Point(12, 240);
            this.groupBoxIn_ZDA.Name = "groupBoxIn_ZDA";
            this.groupBoxIn_ZDA.Size = new System.Drawing.Size(233, 63);
            this.groupBoxIn_ZDA.TabIndex = 2;
            this.groupBoxIn_ZDA.TabStop = false;
            this.groupBoxIn_ZDA.Text = "Ввод данных";
            // 
            // dataGridViewFunction_ZDA
            // 
            this.dataGridViewFunction_ZDA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_ZDA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.dataGridViewFunction_ZDA.Location = new System.Drawing.Point(10, 37);
            this.dataGridViewFunction_ZDA.Name = "dataGridViewFunction_ZDA";
            this.dataGridViewFunction_ZDA.RowHeadersVisible = false;
            this.dataGridViewFunction_ZDA.Size = new System.Drawing.Size(125, 247);
            this.dataGridViewFunction_ZDA.TabIndex = 0;
            this.dataGridViewFunction_ZDA.TabStop = false;
            // 
            // textBoxStartV_ZDA
            // 
            this.textBoxStartV_ZDA.Location = new System.Drawing.Point(6, 32);
            this.textBoxStartV_ZDA.Name = "textBoxStartV_ZDA";
            this.textBoxStartV_ZDA.Size = new System.Drawing.Size(108, 20);
            this.textBoxStartV_ZDA.TabIndex = 1;
            // 
            // textBoxStopV_ZDA
            // 
            this.textBoxStopV_ZDA.Location = new System.Drawing.Point(120, 32);
            this.textBoxStopV_ZDA.Name = "textBoxStopV_ZDA";
            this.textBoxStopV_ZDA.Size = new System.Drawing.Size(108, 20);
            this.textBoxStopV_ZDA.TabIndex = 2;
            // 
            // chartFunction
            // 
            chartArea2.Name = "ChartArea1";
            this.chartFunction.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartFunction.Legends.Add(legend2);
            this.chartFunction.Location = new System.Drawing.Point(141, 37);
            this.chartFunction.Name = "chartFunction";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartFunction.Series.Add(series2);
            this.chartFunction.Size = new System.Drawing.Size(418, 247);
            this.chartFunction.TabIndex = 1;
            this.chartFunction.TabStop = false;
            this.chartFunction.Text = "chart1";
            // 
            // buttonPushMe_ZDA
            // 
            this.buttonPushMe_ZDA.BackColor = System.Drawing.Color.Green;
            this.buttonPushMe_ZDA.Location = new System.Drawing.Point(332, 240);
            this.buttonPushMe_ZDA.Name = "buttonPushMe_ZDA";
            this.buttonPushMe_ZDA.Size = new System.Drawing.Size(110, 62);
            this.buttonPushMe_ZDA.TabIndex = 3;
            this.buttonPushMe_ZDA.Text = "Выполнить";
            this.buttonPushMe_ZDA.UseVisualStyleBackColor = false;
            this.buttonPushMe_ZDA.Click += new System.EventHandler(this.buttonPushMe_ZDA_Click);
            this.buttonPushMe_ZDA.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonPushMe_ZDA_MouseDown);
            this.buttonPushMe_ZDA.MouseEnter += new System.EventHandler(this.buttonPushMe_ZDA_MouseEnter);
            this.buttonPushMe_ZDA.MouseLeave += new System.EventHandler(this.buttonPushMe_ZDA_MouseLeave);
            // 
            // buttonInform_ZDA
            // 
            this.buttonInform_ZDA.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonInform_ZDA.Location = new System.Drawing.Point(251, 240);
            this.buttonInform_ZDA.Name = "buttonInform_ZDA";
            this.buttonInform_ZDA.Size = new System.Drawing.Size(75, 63);
            this.buttonInform_ZDA.TabIndex = 4;
            this.buttonInform_ZDA.Text = "Справка";
            this.buttonInform_ZDA.UseVisualStyleBackColor = false;
            this.buttonInform_ZDA.Click += new System.EventHandler(this.buttonInform_ZDA_Click);
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.Width = 50;
            // 
            // Y
            // 
            this.Y.HeaderText = "F(X)";
            this.Y.Name = "Y";
            this.Y.Width = 50;
            // 
            // labelStart_ZDA
            // 
            this.labelStart_ZDA.AutoSize = true;
            this.labelStart_ZDA.Location = new System.Drawing.Point(6, 16);
            this.labelStart_ZDA.Name = "labelStart_ZDA";
            this.labelStart_ZDA.Size = new System.Drawing.Size(67, 13);
            this.labelStart_ZDA.TabIndex = 2;
            this.labelStart_ZDA.Text = "Старт шага:";
            // 
            // labelStop_ZDA
            // 
            this.labelStop_ZDA.AutoSize = true;
            this.labelStop_ZDA.Location = new System.Drawing.Point(117, 16);
            this.labelStop_ZDA.Name = "labelStop_ZDA";
            this.labelStop_ZDA.Size = new System.Drawing.Size(69, 13);
            this.labelStop_ZDA.TabIndex = 3;
            this.labelStop_ZDA.Text = "Конец шага:";
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "Написать программу, которая выводит таблицу значений функции:",
            "F(x) = 3x + 2 - ((2x-x)/(cos(x)+1))",
            "(произвести табулирование) f(x) на заданном диапазоне [-5; 5] с шагом 1. Произвес" +
                "ти проверку деления на ноль.",
            "При делении на ноль вернуть значение 0.",
            "Значения занести в DataGridView",
            "Значения округлить до двух знаков после запятой.",
            "Графический интерфейс оформить по шаблону из лекции."});
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(8, 20);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(415, 195);
            this.textBox1.TabIndex = 0;
            this.textBox1.TabStop = false;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 314);
            this.Controls.Add(this.buttonInform_ZDA);
            this.Controls.Add(this.buttonPushMe_ZDA);
            this.Controls.Add(this.groupBoxIn_ZDA);
            this.Controls.Add(this.groupBoxOut_ZDA);
            this.Controls.Add(this.groupBoxTask_ZDA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 7 | ЗуборевД. А.";
            this.groupBoxTask_ZDA.ResumeLayout(false);
            this.groupBoxTask_ZDA.PerformLayout();
            this.groupBoxOut_ZDA.ResumeLayout(false);
            this.groupBoxIn_ZDA.ResumeLayout(false);
            this.groupBoxIn_ZDA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_ZDA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_ZDA;
        private System.Windows.Forms.GroupBox groupBoxOut_ZDA;
        private System.Windows.Forms.GroupBox groupBoxIn_ZDA;
        private System.Windows.Forms.DataGridView dataGridViewFunction_ZDA;
        private System.Windows.Forms.TextBox textBoxStopV_ZDA;
        private System.Windows.Forms.TextBox textBoxStartV_ZDA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
        private System.Windows.Forms.Button buttonPushMe_ZDA;
        private System.Windows.Forms.Button buttonInform_ZDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelStop_ZDA;
        private System.Windows.Forms.Label labelStart_ZDA;
    }
}

