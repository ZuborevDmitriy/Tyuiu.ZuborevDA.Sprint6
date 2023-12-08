
namespace Tyuiu.ZuborevDA.Sprint6.Task5.V25
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
            this.panelUp_ZDA = new System.Windows.Forms.Panel();
            this.groupBoxTask_ZDA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_ZDA = new System.Windows.Forms.TextBox();
            this.buttonInfo_ZDA = new System.Windows.Forms.Button();
            this.buttonOpen_ZDA = new System.Windows.Forms.Button();
            this.buttonPushMe_ZDA = new System.Windows.Forms.Button();
            this.panelLeft_ZDA = new System.Windows.Forms.Panel();
            this.groupBoxOutData_ZDA = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult_ZDA = new System.Windows.Forms.DataGridView();
            this.ColumnX_ZDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnY_ZDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelCenter_ZDA = new System.Windows.Forms.Panel();
            this.chartFunction_ZDA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitterbtw_ZDA = new System.Windows.Forms.Splitter();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelUp_ZDA.SuspendLayout();
            this.groupBoxTask_ZDA.SuspendLayout();
            this.panelLeft_ZDA.SuspendLayout();
            this.groupBoxOutData_ZDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_ZDA)).BeginInit();
            this.panelCenter_ZDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_ZDA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUp_ZDA
            // 
            this.panelUp_ZDA.Controls.Add(this.groupBoxTask_ZDA);
            this.panelUp_ZDA.Controls.Add(this.buttonInfo_ZDA);
            this.panelUp_ZDA.Controls.Add(this.buttonOpen_ZDA);
            this.panelUp_ZDA.Controls.Add(this.buttonPushMe_ZDA);
            this.panelUp_ZDA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUp_ZDA.Location = new System.Drawing.Point(0, 0);
            this.panelUp_ZDA.Name = "panelUp_ZDA";
            this.panelUp_ZDA.Size = new System.Drawing.Size(799, 74);
            this.panelUp_ZDA.TabIndex = 0;
            // 
            // groupBoxTask_ZDA
            // 
            this.groupBoxTask_ZDA.Controls.Add(this.textBoxTask_ZDA);
            this.groupBoxTask_ZDA.Location = new System.Drawing.Point(3, 3);
            this.groupBoxTask_ZDA.Name = "groupBoxTask_ZDA";
            this.groupBoxTask_ZDA.Size = new System.Drawing.Size(542, 65);
            this.groupBoxTask_ZDA.TabIndex = 3;
            this.groupBoxTask_ZDA.TabStop = false;
            this.groupBoxTask_ZDA.Text = "Условие:";
            // 
            // textBoxTask_ZDA
            // 
            this.textBoxTask_ZDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask_ZDA.Location = new System.Drawing.Point(3, 16);
            this.textBoxTask_ZDA.Multiline = true;
            this.textBoxTask_ZDA.Name = "textBoxTask_ZDA";
            this.textBoxTask_ZDA.ReadOnly = true;
            this.textBoxTask_ZDA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxTask_ZDA.Size = new System.Drawing.Size(536, 46);
            this.textBoxTask_ZDA.TabIndex = 0;
            this.textBoxTask_ZDA.TabStop = false;
            this.textBoxTask_ZDA.Text = resources.GetString("textBoxTask_ZDA.Text");
            // 
            // buttonInfo_ZDA
            // 
            this.buttonInfo_ZDA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_ZDA.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonInfo_ZDA.Location = new System.Drawing.Point(713, 12);
            this.buttonInfo_ZDA.Name = "buttonInfo_ZDA";
            this.buttonInfo_ZDA.Size = new System.Drawing.Size(75, 50);
            this.buttonInfo_ZDA.TabIndex = 3;
            this.buttonInfo_ZDA.Text = "Справка";
            this.buttonInfo_ZDA.UseVisualStyleBackColor = false;
            this.buttonInfo_ZDA.Click += new System.EventHandler(this.buttonInfo_ZDA_Click);
            this.buttonInfo_ZDA.MouseEnter += new System.EventHandler(this.buttonInfo_ZDA_MouseEnter);
            // 
            // buttonOpen_ZDA
            // 
            this.buttonOpen_ZDA.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonOpen_ZDA.Location = new System.Drawing.Point(632, 12);
            this.buttonOpen_ZDA.Name = "buttonOpen_ZDA";
            this.buttonOpen_ZDA.Size = new System.Drawing.Size(75, 50);
            this.buttonOpen_ZDA.TabIndex = 2;
            this.buttonOpen_ZDA.Text = "Открыть файл";
            this.buttonOpen_ZDA.UseVisualStyleBackColor = false;
            this.buttonOpen_ZDA.Click += new System.EventHandler(this.buttonOpen_ZDA_Click);
            this.buttonOpen_ZDA.MouseEnter += new System.EventHandler(this.buttonOpen_ZDA_MouseEnter);
            // 
            // buttonPushMe_ZDA
            // 
            this.buttonPushMe_ZDA.BackColor = System.Drawing.Color.Green;
            this.buttonPushMe_ZDA.Location = new System.Drawing.Point(551, 12);
            this.buttonPushMe_ZDA.Name = "buttonPushMe_ZDA";
            this.buttonPushMe_ZDA.Size = new System.Drawing.Size(75, 50);
            this.buttonPushMe_ZDA.TabIndex = 1;
            this.buttonPushMe_ZDA.Text = "Выполнить";
            this.buttonPushMe_ZDA.UseVisualStyleBackColor = false;
            this.buttonPushMe_ZDA.Click += new System.EventHandler(this.buttonPushMe_ZDA_Click);
            this.buttonPushMe_ZDA.MouseEnter += new System.EventHandler(this.buttonPushMe_ZDA_MouseEnter);
            // 
            // panelLeft_ZDA
            // 
            this.panelLeft_ZDA.Controls.Add(this.groupBoxOutData_ZDA);
            this.panelLeft_ZDA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_ZDA.Location = new System.Drawing.Point(0, 74);
            this.panelLeft_ZDA.Name = "panelLeft_ZDA";
            this.panelLeft_ZDA.Size = new System.Drawing.Size(139, 377);
            this.panelLeft_ZDA.TabIndex = 1;
            // 
            // groupBoxOutData_ZDA
            // 
            this.groupBoxOutData_ZDA.Controls.Add(this.dataGridViewResult_ZDA);
            this.groupBoxOutData_ZDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutData_ZDA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutData_ZDA.Name = "groupBoxOutData_ZDA";
            this.groupBoxOutData_ZDA.Size = new System.Drawing.Size(139, 377);
            this.groupBoxOutData_ZDA.TabIndex = 0;
            this.groupBoxOutData_ZDA.TabStop = false;
            this.groupBoxOutData_ZDA.Text = "Вывод данных:";
            // 
            // dataGridViewResult_ZDA
            // 
            this.dataGridViewResult_ZDA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_ZDA.ColumnHeadersVisible = false;
            this.dataGridViewResult_ZDA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnX_ZDA,
            this.ColumnY_ZDA});
            this.dataGridViewResult_ZDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewResult_ZDA.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewResult_ZDA.Name = "dataGridViewResult_ZDA";
            this.dataGridViewResult_ZDA.ReadOnly = true;
            this.dataGridViewResult_ZDA.RowHeadersVisible = false;
            this.dataGridViewResult_ZDA.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewResult_ZDA.Size = new System.Drawing.Size(133, 358);
            this.dataGridViewResult_ZDA.TabIndex = 0;
            this.dataGridViewResult_ZDA.TabStop = false;
            // 
            // ColumnX_ZDA
            // 
            this.ColumnX_ZDA.HeaderText = "X";
            this.ColumnX_ZDA.Name = "ColumnX_ZDA";
            this.ColumnX_ZDA.ReadOnly = true;
            // 
            // ColumnY_ZDA
            // 
            this.ColumnY_ZDA.HeaderText = "Y";
            this.ColumnY_ZDA.Name = "ColumnY_ZDA";
            this.ColumnY_ZDA.ReadOnly = true;
            // 
            // panelCenter_ZDA
            // 
            this.panelCenter_ZDA.Controls.Add(this.chartFunction_ZDA);
            this.panelCenter_ZDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter_ZDA.Location = new System.Drawing.Point(139, 74);
            this.panelCenter_ZDA.Name = "panelCenter_ZDA";
            this.panelCenter_ZDA.Size = new System.Drawing.Size(660, 377);
            this.panelCenter_ZDA.TabIndex = 2;
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
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_ZDA.Series.Add(series1);
            this.chartFunction_ZDA.Size = new System.Drawing.Size(660, 377);
            this.chartFunction_ZDA.TabIndex = 0;
            this.chartFunction_ZDA.TabStop = false;
            this.chartFunction_ZDA.Text = "chartFunction";
            // 
            // splitterbtw_ZDA
            // 
            this.splitterbtw_ZDA.Location = new System.Drawing.Point(139, 74);
            this.splitterbtw_ZDA.Name = "splitterbtw_ZDA";
            this.splitterbtw_ZDA.Size = new System.Drawing.Size(3, 377);
            this.splitterbtw_ZDA.TabIndex = 3;
            this.splitterbtw_ZDA.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 451);
            this.Controls.Add(this.splitterbtw_ZDA);
            this.Controls.Add(this.panelCenter_ZDA);
            this.Controls.Add(this.panelLeft_ZDA);
            this.Controls.Add(this.panelUp_ZDA);
            this.MinimumSize = new System.Drawing.Size(815, 490);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 25 | ЗуборевД. А.";
            this.panelUp_ZDA.ResumeLayout(false);
            this.groupBoxTask_ZDA.ResumeLayout(false);
            this.groupBoxTask_ZDA.PerformLayout();
            this.panelLeft_ZDA.ResumeLayout(false);
            this.groupBoxOutData_ZDA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_ZDA)).EndInit();
            this.panelCenter_ZDA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_ZDA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUp_ZDA;
        private System.Windows.Forms.Panel panelLeft_ZDA;
        private System.Windows.Forms.Panel panelCenter_ZDA;
        private System.Windows.Forms.Splitter splitterbtw_ZDA;
        private System.Windows.Forms.GroupBox groupBoxTask_ZDA;
        private System.Windows.Forms.Button buttonInfo_ZDA;
        private System.Windows.Forms.Button buttonOpen_ZDA;
        private System.Windows.Forms.Button buttonPushMe_ZDA;
        private System.Windows.Forms.GroupBox groupBoxOutData_ZDA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_ZDA;
        private System.Windows.Forms.TextBox textBoxTask_ZDA;
        private System.Windows.Forms.DataGridView dataGridViewResult_ZDA;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnX_ZDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnY_ZDA;
    }
}

