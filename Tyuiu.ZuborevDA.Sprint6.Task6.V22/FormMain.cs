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

using Tyuiu.ZuborevDA.Sprint6.Task6.V22.Lib;

namespace Tyuiu.ZuborevDA.Sprint6.Task6.V22
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        string openFilePath;
        DataService ds = new DataService();

        private void buttonPushMe_ZDA_Click(object sender, EventArgs e)
        {
            string str = "**";
            textBoxOut_ZDA.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonHelp_ZDA_Click(object sender, EventArgs e)
        {
            FormAbout_ZDA formAbout = new FormAbout_ZDA();
            formAbout.ShowDialog();
        }

        private void buttonOpen_ZDA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_ZDA.ShowDialog();
            openFilePath = openFileDialogTask_ZDA.FileName;
            textBoxIn_ZDA.Text = File.ReadAllText(openFilePath);
            groupBoxIn_ZDA.Text = groupBoxOut_ZDA.Text + "" + openFileDialogTask_ZDA.FileName;
            buttonPushMe_ZDA.Enabled = true;
        }
    }
}
