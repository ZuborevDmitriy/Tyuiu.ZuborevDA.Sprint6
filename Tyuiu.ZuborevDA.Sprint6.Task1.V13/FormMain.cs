using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.ZuborevDA.Sprint6.Task1.V13.Lib;

namespace Tyuiu.ZuborevDA.Sprint6.Task1.V13
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

                string strLine;

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);
                textBoxResult_ZDA.Text = "";
                textBoxResult_ZDA.AppendText("+--------+-----------+" + Environment.NewLine);
                textBoxResult_ZDA.AppendText("|    X   |    f(x)   |" + Environment.NewLine);
                textBoxResult_ZDA.AppendText("+--------+-----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}   |  {1,  5:f2}    |", startValue, valueArray[i]);
                    textBoxResult_ZDA.AppendText(strLine + Environment.NewLine);
                    startValue++;
                }

                textBoxResult_ZDA.AppendText("+--------+-----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonInform_ZDA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы АСОиУБ-23-2 Зуборев Дмитрий Александрович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
