using INI;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Torahapi;

namespace Torahapp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            IniFiles ini = new IniFiles(Application.StartupPath + @"\config.ini");
            string num = null;
            ini.IniReadValue("node", "num" ,ref num);
            //MessageBox.Show(num);
            int o = int.Parse(num);
            for (int i = 0; i < o; i++)
            { 
                string status_s = "run";
                int port = 100 + i;
                string url = "http://localhost:"+ port.ToString()+"5/addresses";
                IPAddress ip = IPAddress.Parse("127.0.0.1");
                IPEndPoint point = new IPEndPoint(ip, int.Parse(port.ToString()+"5"));
                try
                {
                    TcpClient tcp = new TcpClient();
                    tcp.Connect(point);
                    status_s = "run";
                    //MessageBox.Show("Node is run by port "+ port.ToString() + "5");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("error:" + "Node startup failed by port " + port.ToString() + "5---------------"+ex);
                    status_s = "stop";
                    continue;
                }
                var str = HttpClientHelper.Get(url);
                JObject jo = JObject.Parse(str);
                string address = jo["ethereum"].ToString();

                string eth_address = "http://balance.torah.ink/rinb?address=" + address;               
                var eth_b = HttpClientHelper.Get(eth_address);                
                JObject eth_jo = JObject.Parse(eth_b);
                string eth_st = eth_jo["result"].ToString();
                //MessageBox.Show(eth_st);
                string eth_address_t = "http://balance.torah.ink/rinbt?address=" + address;
                var eth_b_t = HttpClientHelper.Get(eth_address_t);
                JObject eth_jo_t = JObject.Parse(eth_b_t);
                string eth_st_t = eth_jo_t["result"].ToString();


                ListViewItem item = new ListViewItem();      
                item.Text = address;                            
                item.SubItems.Add(eth_st);                      
                item.SubItems.Add(eth_st_t);                     
                item.SubItems.Add(status_s);
                item.SubItems.Add((port.ToString() + "5"));
                listView1.Items.Add(item);                   
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_MouseDown(object sender, MouseEventArgs e)
        {
  
            if (e.Button == MouseButtons.Right)
            {
                
                Point p = listView1.PointToClient(Control.MousePosition);
                if (listView1.SelectedItems.Count > 0)
                {
 
                    ListViewItem li = listView1.GetItemAt(p.X, p.Y);
                    ListViewItem.ListViewSubItem ls = li.GetSubItemAt(p.X, p.Y);
                    string text = ls.Text;

                    try
                    {
                        Clipboard.SetDataObject(text);
                        MessageBox.Show("Copy : " + text);
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(this, ee.Message);
                    }



                }
                else
                {
                    MessageBox.Show(this, "no change");
                }

                //if (this.listView1.SelectedItems.Count > 0)
                //    {
                //        this.contextMenuStrip1.Show(this, e.Location);
                //    }
                //    else
                //    {
                //        this.contextMenuStrip1.Hide();
                //    }
                

            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
