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

using Tyuiu.ZuborevDA.Sprint6.Task4.V28.Lib;

namespace Tyuiu.ZuborevDA.Sprint6.Task4.V28
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonPushMe_ZDA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_ZDA.Text);
                int stoptStep = Convert.ToInt32(textBoxStop_ZDA.Text);

                int len = ds.GetMassFunction(startStep, stoptStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stoptStep);

                this.chartFunction_ZDA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_ZDA.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxResult_ZDA.Text = "";

                chartFunction_ZDA.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartFunction_ZDA.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResult_ZDA.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInform_ZDA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы АСОиУБ-23-2 Зуборев Дмитрий Александрович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSave_ZDA_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4.txt";
                File.WriteAllText(path, textBoxResult_ZDA.Text);

                DialogResult dialogResult = MessageBox.Show($"Файл {path} сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Произошла ошибка при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonPushMe_ZDA_MouseEnter(object sender, EventArgs e)
        {
            buttonPushMe_ZDA.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void buttonSave_ZDA_MouseEnter(object sender, EventArgs e)
        {
            buttonSave_ZDA.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void buttonInform_ZDA_MouseEnter(object sender, EventArgs e)
        {
            buttonInform_ZDA.Cursor = System.Windows.Forms.Cursors.Hand;
        }
    }
}
