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
    public partial class Form3 : Form
    {
        

        int eks=0, nei=0, lie=0;
        string k;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader sr3 = new StreamReader("name.txt", Encoding.Default);
            string name = sr3.ReadLine();
            sr3.Close();
            string[] s = richTextBox1.Text.Split('\n');


            saveFileDialog1.FileName = name;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                for (int i = 0; i < 16; i++)
                {
                    sw.WriteLine(s[i]);
                }
                
                sw.Close();
                StreamWriter sw1 = new StreamWriter("name.txt");
                sw1.WriteLine(' ');
                sw1.Close();
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        
        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {

            Application.Exit();

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
                      
        }

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Form1 d = new Form1();
            d.Close();
            StreamReader sr = new StreamReader("result2.txt");
            StreamReader sr1 = new StreamReader("end.txt", Encoding.Default);
            k = sr.ReadLine();
            eks = Convert.ToInt32(k);
            k = sr.ReadLine();
            nei = Convert.ToInt32(k);
            k = sr.ReadLine();
            lie = Convert.ToInt32(k);
            sr.Close();
            
            string[] str = new string[7];
            for (int i=0; i<3; i++)
            {
                str[i] = sr1.ReadLine(); //str[0] - экстраверт, str[1] - интроверт, str[2] - нейротизм
            }
            StreamReader sr3 = new StreamReader("name.txt", Encoding.Default);
            string l = sr3.ReadLine();
            string q = sr1.ReadToEnd();
            string[] s = q.Split('*');
            if (eks > 12 && nei < 12) { richTextBox1.Text = l + System.Environment.NewLine +  s[0] + System.Environment.NewLine + System.Environment.NewLine + "Уровень экстраверсии-интроверсии: " + eks + System.Environment.NewLine + System.Environment.NewLine + str[0] +  System.Environment.NewLine + System.Environment.NewLine + "Уровень нейротизма: " + nei + System.Environment.NewLine + System.Environment.NewLine + str[2] + System.Environment.NewLine + System.Environment.NewLine + "Уровень лжи: " + lie + System.Environment.NewLine + System.Environment.NewLine + "Уровень лжи определяет насколько честно отвечал человек на вопросы, норма от 0 до 4"; }
            if (eks > 12 && nei > 12) { richTextBox1.Text = l + System.Environment.NewLine + s[1] + System.Environment.NewLine + System.Environment.NewLine + "Уровень экстраверсии-интроверсии: " + eks + System.Environment.NewLine + System.Environment.NewLine + str[0] + System.Environment.NewLine + System.Environment.NewLine + "Уровень нейротизма: " + nei + System.Environment.NewLine + System.Environment.NewLine + str[2] + System.Environment.NewLine + System.Environment.NewLine + "Уровень лжи: " + lie + System.Environment.NewLine + System.Environment.NewLine + "Уровень лжи определяет насколько честно отвечал человек на вопросы, норма от 0 до 4"; }
            if (eks <=12 && nei < 12) { richTextBox1.Text = l + System.Environment.NewLine + s[2] + System.Environment.NewLine + System.Environment.NewLine + "Уровень экстраверсии-интроверсии: " + eks + System.Environment.NewLine + System.Environment.NewLine + str[1] + System.Environment.NewLine + System.Environment.NewLine + "Уровень нейротизма: " + nei + System.Environment.NewLine + System.Environment.NewLine + str[2] + System.Environment.NewLine + System.Environment.NewLine + "Уровень лжи: " + lie + System.Environment.NewLine + System.Environment.NewLine + "Уровень лжи определяет насколько честно отвечал человек на вопросы, норма от 0 до 4"; }
            if (eks <=12 && nei > 12) { richTextBox1.Text = l + System.Environment.NewLine + s[3] + System.Environment.NewLine + System.Environment.NewLine + "Уровень экстраверсии-интроверсии: " + eks + System.Environment.NewLine + System.Environment.NewLine + str[1] + System.Environment.NewLine + System.Environment.NewLine + "Уровень нейротизма: " + nei + System.Environment.NewLine + System.Environment.NewLine + str[2] + System.Environment.NewLine + System.Environment.NewLine + "Уровень лжи: " + lie + System.Environment.NewLine + System.Environment.NewLine + "Уровень лжи определяет насколько честно отвечал человек на вопросы, норма от 0 до 4"; }
        }
    }
}
