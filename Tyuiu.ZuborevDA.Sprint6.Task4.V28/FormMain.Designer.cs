
namespace Tyuiu.ZuborevDA.Sprint6.Task4.V28
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panelUp_ZDA = new System.Windows.Forms.Panel();
            this.panelLeft_ZDA = new System.Windows.Forms.Panel();
            this.panelCenter_ZDA = new System.Windows.Forms.Panel();
            this.splitterBtw_ZDA = new System.Windows.Forms.Splitter();
            this.groupBoxTask_ZDA = new System.Windows.Forms.GroupBox();
            this.groupBoxDataIn_ZDA = new System.Windows.Forms.GroupBox();
            this.groupBoxDataOut_ZDA = new System.Windows.Forms.GroupBox();
            this.textBoxResult_ZDA = new System.Windows.Forms.TextBox();
            this.textBoxTask_ZDA = new System.Windows.Forms.TextBox();
            this.textBoxStart_ZDA = new System.Windows.Forms.TextBox();
            this.textBoxStop_ZDA = new System.Windows.Forms.TextBox();
            this.chartFunction_ZDA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelStart_ZDA = new System.Windows.Forms.Label();
            this.labelStop_ZDA = new System.Windows.Forms.Label();
            this.buttonPushMe_ZDA = new System.Windows.Forms.Button();
            this.buttonSave_ZDA = new System.Windows.Forms.Button();
            this.buttonInform_ZDA = new System.Windows.Forms.Button();
            this.panelUp_ZDA.SuspendLayout();
            this.panelLeft_ZDA.SuspendLayout();
            this.panelCenter_ZDA.SuspendLayout();
            this.groupBoxTask_ZDA.SuspendLayout();
            this.groupBoxDataIn_ZDA.SuspendLayout();
            this.groupBoxDataOut_ZDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_ZDA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUp_ZDA
            // 
            this.panelUp_ZDA.Controls.Add(this.buttonInform_ZDA);
            this.panelUp_ZDA.Controls.Add(this.buttonSave_ZDA);
            this.panelUp_ZDA.Controls.Add(this.buttonPushMe_ZDA);
            this.panelUp_ZDA.Controls.Add(this.groupBoxDataIn_ZDA);
            this.panelUp_ZDA.Controls.Add(this.groupBoxTask_ZDA);
            this.panelUp_ZDA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUp_ZDA.Location = new System.Drawing.Point(0, 0);
            this.panelUp_ZDA.Name = "panelUp_ZDA";
            this.panelUp_ZDA.Size = new System.Drawing.Size(979, 77);
            this.panelUp_ZDA.TabIndex = 0;
            // 
            // panelLeft_ZDA
            // 
            this.panelLeft_ZDA.Controls.Add(this.groupBoxDataOut_ZDA);
            this.panelLeft_ZDA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_ZDA.Location = new System.Drawing.Point(0, 77);
            this.panelLeft_ZDA.Name = "panelLeft_ZDA";
            this.panelLeft_ZDA.Size = new System.Drawing.Size(200, 374);
            this.panelLeft_ZDA.TabIndex = 0;
            // 
            // panelCenter_ZDA
            // 
            this.panelCenter_ZDA.Controls.Add(this.chartFunction_ZDA);
            this.panelCenter_ZDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter_ZDA.Location = new System.Drawing.Point(200, 77);
            this.panelCenter_ZDA.Name = "panelCenter_ZDA";
            this.panelCenter_ZDA.Size = new System.Drawing.Size(779, 374);
            this.panelCenter_ZDA.TabIndex = 0;
            // 
            // splitterBtw_ZDA
            // 
            this.splitterBtw_ZDA.Location = new System.Drawing.Point(200, 77);
            this.splitterBtw_ZDA.Name = "splitterBtw_ZDA";
            this.splitterBtw_ZDA.Size = new System.Drawing.Size(3, 374);
            this.splitterBtw_ZDA.TabIndex = 1;
            this.splitterBtw_ZDA.TabStop = false;
            // 
            // groupBoxTask_ZDA
            // 
            this.groupBoxTask_ZDA.Controls.Add(this.textBoxTask_ZDA);
            this.groupBoxTask_ZDA.Location = new System.Drawing.Point(3, 3);
            this.groupBoxTask_ZDA.Name = "groupBoxTask_ZDA";
            this.groupBoxTask_ZDA.Size = new System.Drawing.Size(422, 67);
            this.groupBoxTask_ZDA.TabIndex = 0;
            this.groupBoxTask_ZDA.TabStop = false;
            this.groupBoxTask_ZDA.Text = "Условие";
            // 
            // groupBoxDataIn_ZDA
            // 
            this.groupBoxDataIn_ZDA.Controls.Add(this.labelStop_ZDA);
            this.groupBoxDataIn_ZDA.Controls.Add(this.labelStart_ZDA);
            this.groupBoxDataIn_ZDA.Controls.Add(this.textBoxStop_ZDA);
            this.groupBoxDataIn_ZDA.Controls.Add(this.textBoxStart_ZDA);
            this.groupBoxDataIn_ZDA.Location = new System.Drawing.Point(431, 3);
            this.groupBoxDataIn_ZDA.Name = "groupBoxDataIn_ZDA";
            this.groupBoxDataIn_ZDA.Size = new System.Drawing.Size(218, 67);
            this.groupBoxDataIn_ZDA.TabIndex = 1;
            this.groupBoxDataIn_ZDA.TabStop = false;
            this.groupBoxDataIn_ZDA.Text = "Ввод данных";
            // 
            // groupBoxDataOut_ZDA
            // 
            this.groupBoxDataOut_ZDA.Controls.Add(this.textBoxResult_ZDA);
            this.groupBoxDataOut_ZDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDataOut_ZDA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxDataOut_ZDA.Name = "groupBoxDataOut_ZDA";
            this.groupBoxDataOut_ZDA.Size = new System.Drawing.Size(200, 374);
            this.groupBoxDataOut_ZDA.TabIndex = 0;
            this.groupBoxDataOut_ZDA.TabStop = false;
            this.groupBoxDataOut_ZDA.Text = "Вывод данных:";
            // 
            // textBoxResult_ZDA
            // 
            this.textBoxResult_ZDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResult_ZDA.Location = new System.Drawing.Point(3, 16);
            this.textBoxResult_ZDA.Multiline = true;
            this.textBoxResult_ZDA.Name = "textBoxResult_ZDA";
            this.textBoxResult_ZDA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_ZDA.Size = new System.Drawing.Size(194, 355);
            this.textBoxResult_ZDA.TabIndex = 0;
            this.textBoxResult_ZDA.TabStop = false;
            // 
            // textBoxTask_ZDA
            // 
            this.textBoxTask_ZDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask_ZDA.Location = new System.Drawing.Point(3, 16);
            this.textBoxTask_ZDA.Multiline = true;
            this.textBoxTask_ZDA.Name = "textBoxTask_ZDA";
            this.textBoxTask_ZDA.ReadOnly = true;
            this.textBoxTask_ZDA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxTask_ZDA.Size = new System.Drawing.Size(416, 48);
            this.textBoxTask_ZDA.TabIndex = 0;
            this.textBoxTask_ZDA.TabStop = false;
            this.textBoxTask_ZDA.Text = resources.GetString("textBoxTask_ZDA.Text");
            // 
            // textBoxStart_ZDA
            // 
            this.textBoxStart_ZDA.Location = new System.Drawing.Point(6, 32);
            this.textBoxStart_ZDA.Name = "textBoxStart_ZDA";
            this.textBoxStart_ZDA.Size = new System.Drawing.Size(100, 20);
            this.textBoxStart_ZDA.TabIndex = 1;
            // 
            // textBoxStop_ZDA
            // 
            this.textBoxStop_ZDA.Location = new System.Drawing.Point(112, 32);
            this.textBoxStop_ZDA.Name = "textBoxStop_ZDA";
            this.textBoxStop_ZDA.Size = new System.Drawing.Size(100, 20);
            this.textBoxStop_ZDA.TabIndex = 2;
            // 
            // chartFunction_ZDA
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_ZDA.ChartAreas.Add(chartArea1);
            this.chartFunction_ZDA.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chartFunction_ZDA.Legends.Add(legend1);
            this.chartFunction_ZDA.Location = new System.Drawing.Point(0, 0);
            this.chartFunction_ZDA.Name = "chartFunction_ZDA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_ZDA.Series.Add(series1);
            this.chartFunction_ZDA.Size = new System.Drawing.Size(779, 374);
            this.chartFunction_ZDA.TabIndex = 0;
            this.chartFunction_ZDA.TabStop = false;
            this.chartFunction_ZDA.Text = "chart1";
            title1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.ForeColor = System.Drawing.Color.Blue;
            title1.Name = "TitleFunction";
            title1.Text = "График функции cos(2x) + ((sin(x))/(x+2,5))  + 2x";
            this.chartFunction_ZDA.Titles.Add(title1);
            // 
            // labelStart_ZDA
            // 
            this.labelStart_ZDA.AutoSize = true;
            this.labelStart_ZDA.Location = new System.Drawing.Point(3, 16);
            this.labelStart_ZDA.Name = "labelStart_ZDA";
            this.labelStart_ZDA.Size = new System.Drawing.Size(64, 13);
            this.labelStart_ZDA.TabIndex = 2;
            this.labelStart_ZDA.Text = "Старт шага";
            // 
            // labelStop_ZDA
            // 
            this.labelStop_ZDA.AutoSize = true;
            this.labelStop_ZDA.Location = new System.Drawing.Point(109, 16);
            this.labelStop_ZDA.Name = "labelStop_ZDA";
            this.labelStop_ZDA.Size = new System.Drawing.Size(66, 13);
            this.labelStop_ZDA.TabIndex = 3;
            this.labelStop_ZDA.Text = "Конец шага";
            // 
            // buttonPushMe_ZDA
            // 
            this.buttonPushMe_ZDA.BackColor = System.Drawing.Color.Green;
            this.buttonPushMe_ZDA.Location = new System.Drawing.Point(655, 11);
            this.buttonPushMe_ZDA.Name = "buttonPushMe_ZDA";
            this.buttonPushMe_ZDA.Size = new System.Drawing.Size(75, 55);
            this.buttonPushMe_ZDA.TabIndex = 3;
            this.buttonPushMe_ZDA.Text = "Выполнить";
            this.buttonPushMe_ZDA.UseVisualStyleBackColor = false;
            this.buttonPushMe_ZDA.Click += new System.EventHandler(this.buttonPushMe_ZDA_Click);
            this.buttonPushMe_ZDA.MouseEnter += new System.EventHandler(this.buttonPushMe_ZDA_MouseEnter);
            // 
            // buttonSave_ZDA
            // 
            this.buttonSave_ZDA.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonSave_ZDA.Location = new System.Drawing.Point(736, 11);
            this.buttonSave_ZDA.Name = "buttonSave_ZDA";
            this.buttonSave_ZDA.Size = new System.Drawing.Size(75, 55);
            this.buttonSave_ZDA.TabIndex = 4;
            this.buttonSave_ZDA.Text = "Сохранить";
            this.buttonSave_ZDA.UseVisualStyleBackColor = false;
            this.buttonSave_ZDA.Click += new System.EventHandler(this.buttonSave_ZDA_Click);
            this.buttonSave_ZDA.MouseEnter += new System.EventHandler(this.buttonSave_ZDA_MouseEnter);
            // 
            // buttonInform_ZDA
            // 
            this.buttonInform_ZDA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInform_ZDA.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonInform_ZDA.Location = new System.Drawing.Point(901, 11);
            this.buttonInform_ZDA.Name = "buttonInform_ZDA";
            this.buttonInform_ZDA.Size = new System.Drawing.Size(75, 55);
            this.buttonInform_ZDA.TabIndex = 5;
            this.buttonInform_ZDA.Text = "Справка";
            this.buttonInform_ZDA.UseVisualStyleBackColor = false;
            this.buttonInform_ZDA.Click += new System.EventHandler(this.buttonInform_ZDA_Click);
            this.buttonInform_ZDA.MouseEnter += new System.EventHandler(this.buttonInform_ZDA_MouseEnter);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 451);
            this.Controls.Add(this.splitterBtw_ZDA);
            this.Controls.Add(this.panelCenter_ZDA);
            this.Controls.Add(this.panelLeft_ZDA);
            this.Controls.Add(this.panelUp_ZDA);
            this.MinimumSize = new System.Drawing.Size(909, 377);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 4 | Вариант 28 | ЗуборевД. А.";
            this.panelUp_ZDA.ResumeLayout(false);
            this.panelLeft_ZDA.ResumeLayout(false);
            this.panelCenter_ZDA.ResumeLayout(false);
            this.groupBoxTask_ZDA.ResumeLayout(false);
            this.groupBoxTask_ZDA.PerformLayout();
            this.groupBoxDataIn_ZDA.ResumeLayout(false);
            this.groupBoxDataIn_ZDA.PerformLayout();
            this.groupBoxDataOut_ZDA.ResumeLayout(false);
            this.groupBoxDataOut_ZDA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_ZDA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUp_ZDA;
        private System.Windows.Forms.Panel panelLeft_ZDA;
        private System.Windows.Forms.Panel panelCenter_ZDA;
        private System.Windows.Forms.GroupBox groupBoxDataIn_ZDA;
        private System.Windows.Forms.TextBox textBoxStop_ZDA;
        private System.Windows.Forms.TextBox textBoxStart_ZDA;
        private System.Windows.Forms.GroupBox groupBoxTask_ZDA;
        private System.Windows.Forms.TextBox textBoxTask_ZDA;
        private System.Windows.Forms.GroupBox groupBoxDataOut_ZDA;
        private System.Windows.Forms.TextBox textBoxResult_ZDA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_ZDA;
        private System.Windows.Forms.Splitter splitterBtw_ZDA;
        private System.Windows.Forms.Label labelStop_ZDA;
        private System.Windows.Forms.Label labelStart_ZDA;
        private System.Windows.Forms.Button buttonInform_ZDA;
        private System.Windows.Forms.Button buttonSave_ZDA;
        private System.Windows.Forms.Button buttonPushMe_ZDA;
    }
}

