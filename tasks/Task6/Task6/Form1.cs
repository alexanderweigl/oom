using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reactive.Linq;
using System.Reactive.Subjects;

namespace Task6
{
    public partial class Form1 : Form
    {
        Dictionary<int, Linie> linies;
        Dictionary<int, Platform> platforms;

        public Form1()
        {
            InitializeComponent();
            linies = new Dictionary<int, Linie>();

            //Settings
            listBox1.DisplayMember = "Value";
            listBox1.ValueMember = "Key";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var x in Enum.GetValues(typeof(Type)))
            {
                comboBox1.Items.Add(x);
            }

            var o = Task.Run(() =>
            {
                foreach (var i in GetCSV("http://data.wien.gv.at/csv/wienerlinien-ogd-linien.csv"))
                {
                    var row = i.Split(';');

                    if (Convert.ToInt32(row[3]) != 1)
                        linies.Add(Convert.ToInt32(row[0]), new Linie(row[1].Substring(1, row[1].Length - 2), Convert.ToInt32(row[2]), false, row[4].Substring(1, row[4].Length - 2), row[5].Substring(1, row[5].Length - 2)));
                    else
                        linies.Add(Convert.ToInt32(row[0]), new Linie(row[1].Substring(1, row[1].Length - 2), Convert.ToInt32(row[2]), true, row[4].Substring(1, row[4].Length - 2), row[5].Substring(1, row[5].Length - 2)));
                }
            });
            
        }

        public void GetPlatform(int id)
        {
            
        }

        public IEnumerable<string> GetCSV(string url)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();

            StreamReader sr = new StreamReader(resp.GetResponseStream());

            sr.ReadLine();

            while (sr.Peek() != -1)
            {
                yield return sr.ReadLine();
            }
            sr.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach(var x in linies)
            {
                if ((Type)comboBox1.SelectedItem == x.Value.LinieType)
                    listBox1.Items.Add(x);
            }

        }
    }
}
