using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUIZ01_9156242_2
{
    public partial class Form1 : Form
    {
        Boolean k;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            check(sender);

            if (k)
            {
                int answer = (Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text)) * Convert.ToInt32(textBox3.Text);
                label_answer.Text = answer.ToString();
            }
            else
            {
                int answer = Convert.ToInt32(textBox1.Text) + (Convert.ToInt32(textBox2.Text) * Convert.ToInt32(textBox3.Text));
                label_answer.Text = answer.ToString();
            }
        }
        
        void check(object sender)
        {
            if (radioButton1.Checked)
                k = true;
            else
                k = false;
        }
    }
}
