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
namespace Course
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("result2.txt");
            string k = sr.ReadLine();
            Top = this.label1.Top;
            Left = this.label1.Left;
            int eks = Convert.ToInt32(k);
            k = sr.ReadLine();
            int nei = Convert.ToInt32(k);
            label1.Left = Left + eks * 15;
            label1.Top = Top -  nei * 15;
        }
    }
}
