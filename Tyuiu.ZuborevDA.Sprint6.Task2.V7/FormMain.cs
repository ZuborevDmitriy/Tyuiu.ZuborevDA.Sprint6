using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.ZuborevDA.Sprint6.Task2.V7.Lib;

namespace Tyuiu.ZuborevDA.Sprint6.Task2.V7
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
                int startValue = Convert.ToInt32(textBoxStartV_ZDA.Text);
                int stopValue = Convert.ToInt32(textBoxStopV_ZDA.Text);

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);

                this.chartFunction.Titles.Add("График функции 3x + 2 - ((2x-x)/(cos(x)+1))");

                this.chartFunction.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_ZDA.Rows.Add(Convert.ToString(startValue), Convert.ToString(valueArray[i]));

                    this.chartFunction.Series[0].Points.AddXY(startValue, valueArray[i]);

                    startValue++;
                }

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInform_ZDA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы АСОиУБ-23-2 Зуборев Дмитрий Александрович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonPushMe_ZDA_MouseEnter(object sender, EventArgs e)
        {
            buttonPushMe_ZDA.BackColor = Color.Red;
        }

        private void buttonPushMe_ZDA_MouseLeave(object sender, EventArgs e)
        {
            buttonPushMe_ZDA.BackColor = Color.Green;
        }

        private void buttonPushMe_ZDA_MouseDown(object sender, MouseEventArgs e)
        {
            buttonPushMe_ZDA.BackColor = Color.Blue;
        }
    }
}
