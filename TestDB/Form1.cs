using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOpenCSV_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(new FileStream("market.csv", FileMode.Open),
                          Encoding.Default);


            string str = "";

            var line = sr.ReadLine();
            var headers = line.Split(','); //,기준으로 단어를 뽑아서 

            foreach (string header in headers)
            {
                textBoxCSVViewer.Text += header + "\t";
            }


            /*
            while (sr.EndOfStream == false)
            {
                line = sr.ReadLine();
                var valuse = line.Split(','); //,기준으로 단어를 뽑아서 
                str += valuse[0] + "\r\n"; //첫번째 컬럼값만 나온다.

            }

            textBoxCSVViewer.Text = str;
            */

            sr.Close();
        }
    }
}
