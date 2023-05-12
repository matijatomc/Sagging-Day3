using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Globalization;

namespace Sagging_Day3
{
    public partial class Form1 : Form
    {
        string[] filePath = new string[5];
        int brc = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "JSON Files (*.json)|*.json";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK && brc < 5)
                {
                    for(int i = 0; i < 5; i++)
                    {
                        if (filePath[i] == openFileDialog.FileName) return;
                    }
                    filePath[brc] = openFileDialog.FileName;
                    brc++;
                }
            }

            if (filePath[0] != null) lblFile1.Text = filePath[0];
            if (filePath[1] != null) lblFile2.Text = filePath[1];
            if (filePath[2] != null) lblFile3.Text = filePath[2];
            if (filePath[3] != null) lblFile4.Text = filePath[3];
            if (filePath[4] != null) lblFile5.Text = filePath[4];
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {

        }
    }
}
