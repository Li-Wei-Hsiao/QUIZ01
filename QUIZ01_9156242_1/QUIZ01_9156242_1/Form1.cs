using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUIZ01_9156242_1
{
    
    public partial class Form1 : Form
    {
        string k = "0";

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Picture_answer_Click(object sender, EventArgs e)
        {
            k = "2";
            show_answer(k);
        }

        private void Picture_Click(object sender, EventArgs e)
        {
            k = "1";
            show_answer(k);
            mix_picture(sender);
        }

        void show_answer(string k)
        {
            if (k.Equals("0"))
            {
                Answer.Visible = false;
                Answer.Text = "";
            }
            else if (k.Equals("1"))
            {
                Answer.Visible = true;
                Answer.Text = "不對哦，請再看仔細⼀點";
            }
            else if (k.Equals("2"))
            {
                Answer.Visible = true;
                Answer.Text = "答對了";
            }
        }

        void mix_picture(object sender)
        {
            Random random = new Random();
            Button[] button = {(Button)Picture_0, (Button)Picture_1, (Button)Picture_2, (Button)Picture_3, (Button)Picture_4, (Button)Picture_5, (Button)Picture_6, (Button)Picture_7, (Button)Picture_8, (Button)Picture_9};
            int number, button_x, button_y;

            for (int i = 1; i < 10; i++)
            {
                number = random.Next(1, 10);
                button[0].Location = button[number].Location;
                button[number].Location = button[i].Location;
                button[i].Location = button[0].Location;
            }
        }
    }
}
