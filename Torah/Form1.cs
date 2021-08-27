using INI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Torahapp;

namespace Torah
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bootnodeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void stupNodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();

            newForm.Show();
        }

        private void runNodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IniFiles ini = new IniFiles(Application.StartupPath + @"\config.ini");
            ;
            startnode(Application.StartupPath);

        }
        public void startnode(string pathbat) {
            Process proc = null;
            try
            {
                proc = new Process();
                proc.StartInfo.WorkingDirectory = pathbat;
                proc.StartInfo.FileName = "start.bat";
                proc.Start();
                proc.WaitForExit();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Occurred :{0},{1}", ex.Message, ex.StackTrace.ToString());
            }
        }

        private void activenodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();
            newForm.Show();
        }
    }
}
