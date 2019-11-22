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
    
    public partial class Form1 : Form
    {

        int count = System.IO.File.ReadAllLines("test.txt").Length;
        StreamReader sr = new StreamReader("test.txt", Encoding.Default);
        string s;
        int eks = 0; //счетчик экстраверсии
        int l = 2; //счетчик вопросов
        int nei=0; // счетчик нейтротизма
        int lie = 0; //счетчик лжи 
        Form3 f = new Form3();
        int[] m = new int [60];
        int[] n = new int [60];
        Form2 d = new Form2();
        Form4 f1 = new Form4();
        

        public Form1()
        {
            InitializeComponent();
            

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Text = "Вопрос №" + l;
          
            s = sr.ReadLine();
            label1.Text = s;
            m[l] = 1;
            d.Close();

            if (l == 58) //l == 58 
            {
                for (int i = 0; i < 59; i++) if (m[i] == 1)
                    {
                        switch (i)
                        {
                            case 1: eks++; break;
                            case 2: nei++; break;
                            case 3: eks++; break;
                            case 4: nei++; break;
                            case 6: lie++; break;
                            case 7: nei++; break;
                            case 8: eks++; break;
                            case 9: nei++; break;
                            case 10: eks++; break;
                            case 11: nei++; break;
                            case 13: eks++; break;
                            case 14: nei++; break;
                            case 16: nei++; break;
                            case 17: eks++; break;
                            case 19: nei++; break;
                            case 21: nei++; break;
                            case 22: eks++; break;
                            case 23: nei++; break;
                            case 24: lie++; break;
                            case 25: eks++; break;
                            case 26: nei++; break;
                            case 27: eks++; break;
                            case 28: nei++; break;
                            case 31: nei++; break;
                            case 33: nei++; break;
                            case 35: nei++; break;
                            case 36: lie++; break;
                            case 38: nei++; break;
                            case 39: eks++; break;
                            case 40: nei++; break;
                            case 43: nei++; break;
                            case 44: eks++; break;
                            case 45: nei++; break;
                            case 46: eks++; break;
                            case 47: nei++; break;
                            case 49: eks++; break;
                            case 50: nei++; break;
                            case 52: nei++; break;
                            case 53: eks++; break;
                            case 55: nei++; break;
                            case 56: eks++; break;
                            case 57: nei++; break;

                        }
                    }
            }
                if (l == 58)  //58
                
                
                {
                    StreamWriter sw = new StreamWriter("result2.txt");
                    sw.WriteLine(eks);
                    sw.WriteLine(nei);
                    sw.WriteLine(lie);
                    sw.Close();
                    f.Show();
                    f1.Show();
                    Close();
                }

            
            l++;

        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Text = "Вопрос №" + l;
            n[l] = 1;
            s = sr.ReadLine();
            label1.Text = s;
            d.Close();

            if (l == 57)
            {
                for (int i = 0; i < 59; i++) if (n[i] == 1)
                    {
                        switch (i)
                        {
                            case 5: eks++; break;
                            case 12: lie++; break;
                            case 15: eks++; break;
                            case 18: lie++; break;
                            case 30: lie++; break;
                            case 20: eks++; break;
                            case 29: eks++; break;
                            case 32: eks++; break;
                            case 34: eks++; break; 
                            case 37: eks++; break;
                            case 42: lie++; break;
                            case 41: eks++; break;
                            case 51: eks++; break;
                            case 48: lie++; break;
                            case 54: lie++; break;                         
                        }
                    }
            }
            
            if (l == 58)
            {
                
                StreamWriter sw = new StreamWriter("result2.txt");
                sw.WriteLine(eks);
                sw.WriteLine(nei);
                sw.WriteLine(lie);
                sw.Close();
                f.Show();
                f1.Show();
                
                Close();

            }
            l++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "Вопрос №1";
            s = sr.ReadLine();
            label1.Text = s;
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(f.Visible==false) Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
