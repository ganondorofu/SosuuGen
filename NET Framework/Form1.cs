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

namespace NET_Framework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string test = "2,";
            int hoge;
            int roop;
            string x = (textBox1.Text);
            int y = int.Parse(x);
            if (y >= 2)
            {
                List<string> lines = new List<string>();
                lines.Add("2");
                for (int i = 3; i <= y; i += 2)
                {
                    roop = 2;
                    hoge = (i + 1) / 2;
                    while (true)
                    {
                        if (i % roop == 0)
                        {
                            break;
                        }
                        if (roop == hoge)
                        {
                            string z = i.ToString();
                            lines.Add(z);
                            test = test + i + "\n";
                            break;
                        }
                        roop++;
                    }
                }
                System.Console.WriteLine(test);
                File.WriteAllLines("Result.txt", lines, Encoding.GetEncoding("shift-jis"));
            }
            else
            {
                MessageBox.Show("InvaildNumber","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
