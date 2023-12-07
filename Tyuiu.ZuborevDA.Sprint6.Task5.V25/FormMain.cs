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

using Tyuiu.ZuborevDA.Sprint6.Task5.V25.Lib;

namespace Tyuiu.ZuborevDA.Sprint6.Task5.V25
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        string path = @"C:\Users\BobaBibkov\source\repos\Tyuiu.ZuborevDA.Sprint6\FileTask5\InPutFileTask5V25.txt";

        private void buttonPushMe_ZDA_Click(object sender, EventArgs e)
        {
            dataGridViewResult_ZDA.ColumnCount = 2;
            dataGridViewResult_ZDA.Columns[0].Width = 20;
            dataGridViewResult_ZDA.Columns[1].Width = 50;

            this.chartFunction_ZDA.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartFunction_ZDA.ChartAreas[0].AxisY.Title = "Ось Y";

            chartFunction_ZDA.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewResult_ZDA.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartFunction_ZDA.Series[0].Points.AddXY(i, numsMass[i]);
            }

        }

        private void buttonOpen_ZDA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonInfo_ZDA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы АСОиУБ-23-2 Зуборев Дмитрий", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonPushMe_ZDA_MouseEnter(object sender, EventArgs e)
        {
            buttonPushMe_ZDA.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void buttonOpen_ZDA_MouseEnter(object sender, EventArgs e)
        {
            buttonOpen_ZDA.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void buttonInfo_ZDA_MouseEnter(object sender, EventArgs e)
        {
            buttonInfo_ZDA.Cursor = System.Windows.Forms.Cursors.Hand;
        }
    }
}
