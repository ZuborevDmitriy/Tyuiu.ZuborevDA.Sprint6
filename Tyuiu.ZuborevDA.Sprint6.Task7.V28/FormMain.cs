using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

using Tyuiu.ZuborevDA.Sprint6.Task7.V28.Lib;

namespace Tyuiu.ZuborevDA.Sprint6.Task7.V28
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            openFileDialogTask_ZDA.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_ZDA.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        static int rows;
        static int columns;
        static string openFilePath;

        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }

        private void buttonFile_ZDA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_ZDA.ShowDialog();
            openFilePath = openFileDialogTask_ZDA.FileName;

            int[,] arrayValues = new int[rows, columns];
            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewIn_ZDA.ColumnCount = columns;
            dataGridViewIn_ZDA.RowCount = rows;
            dataGridViewOut_ZDA.ColumnCount = columns;
            dataGridViewOut_ZDA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewIn_ZDA.Columns[i].Width = 25;
                dataGridViewOut_ZDA.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewIn_ZDA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(openFilePath);
            buttonPushMe_ZDA.Enabled = true;
        }

        private void buttonPushMe_ZDA_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOut_ZDA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSave_ZDA.Enabled = true;
        }

        private void buttonInfo_ZDA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonSave_ZDA_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_ZDA.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_ZDA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_ZDA.ShowDialog();

            string path = saveFileDialogMatrix_ZDA.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOut_ZDA.RowCount;
            int columns = dataGridViewOut_ZDA.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if(j!=columns-1)
                    {
                        str = str + dataGridViewOut_ZDA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOut_ZDA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonFile_ZDA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_ZDA.ToolTipTitle = "Открыть файл";
        }

        private void buttonPushMe_ZDA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_ZDA.ToolTipTitle = "Выполнить";
        }

        private void buttonSave_ZDA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_ZDA.ToolTipTitle = "Сохранить файл";
        }

        private void buttonInfo_ZDA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_ZDA.ToolTipTitle = "Справка";
        }
    }
}
    