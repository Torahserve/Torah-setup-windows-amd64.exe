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
using INI;

namespace Torah
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            InsertDriversToCommbox();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void InsertDriversToCommbox()
        {
            String[] drives = Environment.GetLogicalDrives();
            int iLen = drives.Length, i = 0;
            while (i < iLen)
                comboBox1.Items.Add(drives[i++]);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))
                    e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string path = comboBox1.Text;
            string count = Convert.ToString(99 + Convert.ToInt32(textBox1.Text));
            for (int i = 0; i < Convert.ToInt32(textBox1.Text); i++)
            {
                string ii = Convert.ToString(100 + i);
                string dp = path + Convert.ToString(100 + i);
                Directory.Exists(dp);                
                Directory.CreateDirectory(dp);
                string yaml = dp + "\\Torah.yaml";
                string bat = dp + "\\runnode.bat";
                string fFilePath = System.Windows.Forms.Application.StartupPath + "\\Torah.exe";
                string sFilePath = dp + "\\Torah.exe";
                copyfile(fFilePath, sFilePath);
                SaveyamlTxtFile(yaml,dp,textBox2.Text, Convert.ToString(100 + i),textBox3.Text,textBox4.Text, ii);
                SaveTxtFile(bat);
                
            }
            IniFiles ini = new IniFiles(Application.StartupPath + @"\config.ini");
            ini.IniWriteValue("node","path", path);
            ini.IniWriteValue("node", "num", textBox1.Text);
            mbat(Application.StartupPath + @"\start.bat",path, count);
            MessageBox.Show("Success!");
        }
        public void copyfile(string s, string d) {
            if (File.Exists(s))
            {
                File.Copy(s, d, true);
            }
        }
        public void SaveyamlTxtFile(string filePath,string tdp,string tpwd,string ti,string boot,string swapend,string ii)
        {           
            string text = "clef-signer-enable: false " + "\r\n" +
                "api-addr: :"+ ii + "3\r\n" +
                "p2p-addr: :" + ii + "4\r\n" +
                "debug-api-addr: :" + ii + "5\r\n" +
                "data-dir: "+ tdp + "\r\n" +
                "swap-enable: true " + "\r\n" +
                "bootnode: "+boot + "\r\n" +
                "swap-endpoint: " + swapend + "\r\n" +
                "verbosity: trace " + "\r\n" +
                "welcome-message: \"Torah node\" " + "\r\n" +
                "debug-api-enable: true " + "\r\n" +
                "password:  "+tpwd+ "\r\n";
            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Write))
                {
                    StreamWriter sw = new StreamWriter(fs);
                    sw.Write(text);
                    sw.Flush();
                    sw.Close();
                    fs.Close();
                }
            }
            catch
            {
            }

        }

        public void SaveTxtFile(string filePath) {
            string text = "Torah.exe start --config Torah.yaml";
            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Write))
                {
                    StreamWriter sw = new StreamWriter(fs);
                    sw.Write(text);
                    sw.Flush();
                    sw.Close();
                    fs.Close();
                }
            }
            catch
            {
            }
        }
        public void mbat(string filePath,string p,string i)
        {
            string text = "@echo on " + "\r\n" +
                "for /l %%i in (100,1,"+i+") do ( " + "\r\n" +
                 p.Substring(0,2)  + "\r\n" +
                "cd " + p + "%%i " + "\r\n" +
                "start cmd /k runnode.bat " + "\r\n" +
                "ping /n 3 127.0.0.1 >nul " + "\r\n" +
                ") ";
            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Write))
                {
                    StreamWriter sw = new StreamWriter(fs);
                    sw.Write(text);
                    sw.Flush();
                    sw.Close();
                    fs.Close();
                }
            }
            catch
            {
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
