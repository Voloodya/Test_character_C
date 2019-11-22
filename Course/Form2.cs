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
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
            string s = textBox1.Text;
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
         
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1(); 

            f.Show();
            this.Hide();
            string s = textBox1.Text;
            StreamWriter sw = new StreamWriter("name.txt");
            if (s == null)
            {
                sw.WriteLine();

            }
            else
            {
                sw.WriteLine(s);

            }
            sw.Close();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
            

        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = "Вам предлагается ответить на 57 вопросов. Вопросы направлены на выявление вашего обычного способа поведения.Постарайтесь представить типичные ситуации и  дайте первый «естественный» ответ, который придет вам в голову. Если вы согласны с утверждением, нажмите на кнопку Да, если не согласны, то на кнопку Нет. Для записи результата введите свое имя в форму ниже.";
            Form4 f = new Form4();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e) { }
        
    }
}
