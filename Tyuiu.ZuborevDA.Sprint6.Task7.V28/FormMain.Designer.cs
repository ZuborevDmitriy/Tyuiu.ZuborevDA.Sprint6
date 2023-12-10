
namespace Tyuiu.ZuborevDA.Sprint6.Task7.V28
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelUp_ZDA = new System.Windows.Forms.Panel();
            this.buttonInfo_ZDA = new System.Windows.Forms.Button();
            this.buttonSave_ZDA = new System.Windows.Forms.Button();
            this.buttonPushMe_ZDA = new System.Windows.Forms.Button();
            this.buttonFile_ZDA = new System.Windows.Forms.Button();
            this.panelDown_ZDA = new System.Windows.Forms.Panel();
            this.groupBoxTask_ZDA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_ZDA = new System.Windows.Forms.TextBox();
            this.panelLeft_ZDA = new System.Windows.Forms.Panel();
            this.groupBoxIn_ZDA = new System.Windows.Forms.GroupBox();
            this.dataGridViewIn_ZDA = new System.Windows.Forms.DataGridView();
            this.panelRight_ZDA = new System.Windows.Forms.Panel();
            this.groupBoxOut_ZDA = new System.Windows.Forms.GroupBox();
            this.dataGridViewOut_ZDA = new System.Windows.Forms.DataGridView();
            this.splitterBtw_ZDA = new System.Windows.Forms.Splitter();
            this.openFileDialogTask_ZDA = new System.Windows.Forms.OpenFileDialog();
            this.toolTipButton_ZDA = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialogMatrix_ZDA = new System.Windows.Forms.SaveFileDialog();
            this.panelUp_ZDA.SuspendLayout();
            this.panelDown_ZDA.SuspendLayout();
            this.groupBoxTask_ZDA.SuspendLayout();
            this.panelLeft_ZDA.SuspendLayout();
            this.groupBoxIn_ZDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_ZDA)).BeginInit();
            this.panelRight_ZDA.SuspendLayout();
            this.groupBoxOut_ZDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_ZDA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUp_ZDA
            // 
            this.panelUp_ZDA.Controls.Add(this.buttonInfo_ZDA);
            this.panelUp_ZDA.Controls.Add(this.buttonSave_ZDA);
            this.panelUp_ZDA.Controls.Add(this.buttonPushMe_ZDA);
            this.panelUp_ZDA.Controls.Add(this.buttonFile_ZDA);
            this.panelUp_ZDA.Controls.Add(this.panelDown_ZDA);
            this.panelUp_ZDA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUp_ZDA.Location = new System.Drawing.Point(0, 0);
            this.panelUp_ZDA.Name = "panelUp_ZDA";
            this.panelUp_ZDA.Size = new System.Drawing.Size(753, 150);
            this.panelUp_ZDA.TabIndex = 0;
            // 
            // buttonInfo_ZDA
            // 
            this.buttonInfo_ZDA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_ZDA.Image = global::Tyuiu.ZuborevDA.Sprint6.Task7.V28.Properties.Resources.help;
            this.buttonInfo_ZDA.Location = new System.Drawing.Point(650, 3);
            this.buttonInfo_ZDA.Name = "buttonInfo_ZDA";
            this.buttonInfo_ZDA.Size = new System.Drawing.Size(100, 70);
            this.buttonInfo_ZDA.TabIndex = 4;
            this.toolTipButton_ZDA.SetToolTip(this.buttonInfo_ZDA, "Информация о приложении");
            this.buttonInfo_ZDA.UseVisualStyleBackColor = true;
            this.buttonInfo_ZDA.Click += new System.EventHandler(this.buttonInfo_ZDA_Click);
            this.buttonInfo_ZDA.MouseEnter += new System.EventHandler(this.buttonInfo_ZDA_MouseEnter);
            // 
            // buttonSave_ZDA
            // 
            this.buttonSave_ZDA.Enabled = false;
            this.buttonSave_ZDA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave_ZDA.Image = global::Tyuiu.ZuborevDA.Sprint6.Task7.V28.Properties.Resources.page_save;
            this.buttonSave_ZDA.Location = new System.Drawing.Point(215, 3);
            this.buttonSave_ZDA.Name = "buttonSave_ZDA";
            this.buttonSave_ZDA.Size = new System.Drawing.Size(100, 70);
            this.buttonSave_ZDA.TabIndex = 3;
            this.toolTipButton_ZDA.SetToolTip(this.buttonSave_ZDA, "Сохранить файл в формате csv");
            this.buttonSave_ZDA.UseVisualStyleBackColor = true;
            this.buttonSave_ZDA.Click += new System.EventHandler(this.buttonSave_ZDA_Click);
            this.buttonSave_ZDA.MouseEnter += new System.EventHandler(this.buttonSave_ZDA_MouseEnter);
            // 
            // buttonPushMe_ZDA
            // 
            this.buttonPushMe_ZDA.Enabled = false;
            this.buttonPushMe_ZDA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPushMe_ZDA.Image = global::Tyuiu.ZuborevDA.Sprint6.Task7.V28.Properties.Resources.page_white_go;
            this.buttonPushMe_ZDA.Location = new System.Drawing.Point(109, 3);
            this.buttonPushMe_ZDA.Name = "buttonPushMe_ZDA";
            this.buttonPushMe_ZDA.Size = new System.Drawing.Size(100, 70);
            this.buttonPushMe_ZDA.TabIndex = 2;
            this.toolTipButton_ZDA.SetToolTip(this.buttonPushMe_ZDA, "Выполнить обработку данных");
            this.buttonPushMe_ZDA.UseVisualStyleBackColor = true;
            this.buttonPushMe_ZDA.Click += new System.EventHandler(this.buttonPushMe_ZDA_Click);
            this.buttonPushMe_ZDA.MouseEnter += new System.EventHandler(this.buttonPushMe_ZDA_MouseEnter);
            // 
            // buttonFile_ZDA
            // 
            this.buttonFile_ZDA.Image = global::Tyuiu.ZuborevDA.Sprint6.Task7.V28.Properties.Resources.folder_page;
            this.buttonFile_ZDA.Location = new System.Drawing.Point(3, 3);
            this.buttonFile_ZDA.Name = "buttonFile_ZDA";
            this.buttonFile_ZDA.Size = new System.Drawing.Size(100, 70);
            this.buttonFile_ZDA.TabIndex = 1;
            this.toolTipButton_ZDA.SetToolTip(this.buttonFile_ZDA, "Открыть файл для обработки в формате csv");
            this.buttonFile_ZDA.UseVisualStyleBackColor = true;
            this.buttonFile_ZDA.Click += new System.EventHandler(this.buttonFile_ZDA_Click);
            this.buttonFile_ZDA.MouseEnter += new System.EventHandler(this.buttonFile_ZDA_MouseEnter);
            // 
            // panelDown_ZDA
            // 
            this.panelDown_ZDA.Controls.Add(this.groupBoxTask_ZDA);
            this.panelDown_ZDA.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDown_ZDA.Location = new System.Drawing.Point(0, 76);
            this.panelDown_ZDA.Name = "panelDown_ZDA";
            this.panelDown_ZDA.Size = new System.Drawing.Size(753, 74);
            this.panelDown_ZDA.TabIndex = 0;
            // 
            // groupBoxTask_ZDA
            // 
            this.groupBoxTask_ZDA.Controls.Add(this.textBoxTask_ZDA);
            this.groupBoxTask_ZDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTask_ZDA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_ZDA.Name = "groupBoxTask_ZDA";
            this.groupBoxTask_ZDA.Size = new System.Drawing.Size(753, 74);
            this.groupBoxTask_ZDA.TabIndex = 0;
            this.groupBoxTask_ZDA.TabStop = false;
            this.groupBoxTask_ZDA.Text = "Условие:";
            // 
            // textBoxTask_ZDA
            // 
            this.textBoxTask_ZDA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_ZDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask_ZDA.Location = new System.Drawing.Point(3, 16);
            this.textBoxTask_ZDA.Multiline = true;
            this.textBoxTask_ZDA.Name = "textBoxTask_ZDA";
            this.textBoxTask_ZDA.ReadOnly = true;
            this.textBoxTask_ZDA.Size = new System.Drawing.Size(747, 55);
            this.textBoxTask_ZDA.TabIndex = 0;
            this.textBoxTask_ZDA.TabStop = false;
            this.textBoxTask_ZDA.Text = resources.GetString("textBoxTask_ZDA.Text");
            // 
            // panelLeft_ZDA
            // 
            this.panelLeft_ZDA.Controls.Add(this.groupBoxIn_ZDA);
            this.panelLeft_ZDA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_ZDA.Location = new System.Drawing.Point(0, 150);
            this.panelLeft_ZDA.Name = "panelLeft_ZDA";
            this.panelLeft_ZDA.Size = new System.Drawing.Size(377, 451);
            this.panelLeft_ZDA.TabIndex = 1;
            // 
            // groupBoxIn_ZDA
            // 
            this.groupBoxIn_ZDA.Controls.Add(this.dataGridViewIn_ZDA);
            this.groupBoxIn_ZDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxIn_ZDA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxIn_ZDA.Name = "groupBoxIn_ZDA";
            this.groupBoxIn_ZDA.Size = new System.Drawing.Size(377, 451);
            this.groupBoxIn_ZDA.TabIndex = 0;
            this.groupBoxIn_ZDA.TabStop = false;
            this.groupBoxIn_ZDA.Text = "Ввод:";
            // 
            // dataGridViewIn_ZDA
            // 
            this.dataGridViewIn_ZDA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIn_ZDA.ColumnHeadersVisible = false;
            this.dataGridViewIn_ZDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewIn_ZDA.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewIn_ZDA.Name = "dataGridViewIn_ZDA";
            this.dataGridViewIn_ZDA.RowHeadersVisible = false;
            this.dataGridViewIn_ZDA.Size = new System.Drawing.Size(371, 432);
            this.dataGridViewIn_ZDA.TabIndex = 0;
            this.dataGridViewIn_ZDA.TabStop = false;
            // 
            // panelRight_ZDA
            // 
            this.panelRight_ZDA.Controls.Add(this.groupBoxOut_ZDA);
            this.panelRight_ZDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight_ZDA.Location = new System.Drawing.Point(377, 150);
            this.panelRight_ZDA.Name = "panelRight_ZDA";
            this.panelRight_ZDA.Size = new System.Drawing.Size(376, 451);
            this.panelRight_ZDA.TabIndex = 2;
            // 
            // groupBoxOut_ZDA
            // 
            this.groupBoxOut_ZDA.Controls.Add(this.dataGridViewOut_ZDA);
            this.groupBoxOut_ZDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOut_ZDA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOut_ZDA.Name = "groupBoxOut_ZDA";
            this.groupBoxOut_ZDA.Size = new System.Drawing.Size(376, 451);
            this.groupBoxOut_ZDA.TabIndex = 0;
            this.groupBoxOut_ZDA.TabStop = false;
            this.groupBoxOut_ZDA.Text = "Вывод:";
            // 
            // dataGridViewOut_ZDA
            // 
            this.dataGridViewOut_ZDA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOut_ZDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOut_ZDA.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewOut_ZDA.Name = "dataGridViewOut_ZDA";
            this.dataGridViewOut_ZDA.Size = new System.Drawing.Size(370, 432);
            this.dataGridViewOut_ZDA.TabIndex = 0;
            this.dataGridViewOut_ZDA.TabStop = false;
            // 
            // splitterBtw_ZDA
            // 
            this.splitterBtw_ZDA.Location = new System.Drawing.Point(377, 150);
            this.splitterBtw_ZDA.Name = "splitterBtw_ZDA";
            this.splitterBtw_ZDA.Size = new System.Drawing.Size(3, 451);
            this.splitterBtw_ZDA.TabIndex = 3;
            this.splitterBtw_ZDA.TabStop = false;
            // 
            // openFileDialogTask_ZDA
            // 
            this.openFileDialogTask_ZDA.FileName = "openFileDialogTask";
            // 
            // toolTipButton_ZDA
            // 
            this.toolTipButton_ZDA.IsBalloon = true;
            this.toolTipButton_ZDA.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipButton_ZDA.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 601);
            this.Controls.Add(this.splitterBtw_ZDA);
            this.Controls.Add(this.panelRight_ZDA);
            this.Controls.Add(this.panelLeft_ZDA);
            this.Controls.Add(this.panelUp_ZDA);
            this.MinimumSize = new System.Drawing.Size(440, 455);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 7 | Вариант 28 | ЗуборевД. А.";
            this.panelUp_ZDA.ResumeLayout(false);
            this.panelDown_ZDA.ResumeLayout(false);
            this.groupBoxTask_ZDA.ResumeLayout(false);
            this.groupBoxTask_ZDA.PerformLayout();
            this.panelLeft_ZDA.ResumeLayout(false);
            this.groupBoxIn_ZDA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_ZDA)).EndInit();
            this.panelRight_ZDA.ResumeLayout(false);
            this.groupBoxOut_ZDA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_ZDA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUp_ZDA;
        private System.Windows.Forms.Panel panelDown_ZDA;
        private System.Windows.Forms.Panel panelLeft_ZDA;
        private System.Windows.Forms.Panel panelRight_ZDA;
        private System.Windows.Forms.Splitter splitterBtw_ZDA;
        private System.Windows.Forms.Button buttonInfo_ZDA;
        private System.Windows.Forms.Button buttonSave_ZDA;
        private System.Windows.Forms.Button buttonPushMe_ZDA;
        private System.Windows.Forms.Button buttonFile_ZDA;
        private System.Windows.Forms.GroupBox groupBoxTask_ZDA;
        private System.Windows.Forms.TextBox textBoxTask_ZDA;
        private System.Windows.Forms.GroupBox groupBoxIn_ZDA;
        private System.Windows.Forms.GroupBox groupBoxOut_ZDA;
        private System.Windows.Forms.DataGridView dataGridViewIn_ZDA;
        private System.Windows.Forms.DataGridView dataGridViewOut_ZDA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_ZDA;
        private System.Windows.Forms.ToolTip toolTipButton_ZDA;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_ZDA;
    }
}

