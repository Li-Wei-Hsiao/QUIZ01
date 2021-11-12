using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUIZ01_9156242_3
{
    public partial class Form1 : Form
    {
        List<Button> buttons = new List<Button>();
        Boolean k = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text), y = Convert.ToInt32(textBox2.Text);
            create_button(x, y);
        }

        void create_button(int x, int y)
        {
            int number = x * y;
            int button_number = 0;

            if (k == false)
            {
                for (int i = 0; i < buttons.Count; i++)
                    this.Controls.Remove(buttons[i]);
                buttons.Clear();
                k = true;
            }

            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    int location_x = 50 + (60 * j);
                    int location_y = 90 + (60 * i);


                    Button button = new Button();
                    button.Location = new Point(location_x, location_y);
                    //button.Name = "button1";
                    button.Size = new Size(50, 50);
                    button.TabIndex = 0;
                    button.Text = (++button_number).ToString();
                    this.Controls.Add(button);
                    buttons.Add(button);
                }
            }

            k = false;
        }
    }
}
