using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Diplom
{
    public partial class diplom : Form
    {
        public diplom()
        {
            InitializeComponent();
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) ||
                (!string.IsNullOrEmpty(textBox1.Text) && e.KeyChar == ','))
            {
                return;
            }

            e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" & textBox2.Text != "" & textBox3.Text != "" & textBox4.Text != "" & textBox5.Text != "" & textBox6.Text != "" & textBox7.Text != "" & textBox8.Text != "" & textBox9.Text != "" & textBox10.Text != "")
            {
                float a1 = Convert.ToSingle(textBox1.Text);
                float a2 = Convert.ToSingle(textBox2.Text);
                float a3 = Convert.ToSingle(textBox3.Text);
                float a4 = Convert.ToSingle(textBox4.Text);
                float a5 = Convert.ToSingle(textBox5.Text);
                float a6 = Convert.ToSingle(textBox6.Text);
                float a7 = Convert.ToSingle(textBox7.Text);
                float a8 = Convert.ToSingle(textBox8.Text);
                float a9 = Convert.ToSingle(textBox9.Text);
                float a10 = Convert.ToSingle(textBox10.Text);
                double a = ((a1 - 44) * 2 / 121 - 1) * 0.45036 + ((a2 - 2) * 2 / 55 - 1) * 0.086452 + ((a3 - 1.6) * 2 / 178.4 - 1) * 0.011855 + ((a4 - 0.94) * 2 / 4.96 - 1) * (-0.69913) + ((a5 - 0.67) * 2 / 86.33 - 1) * 0.51183 + (a6 - 1) * (-1.0227) + (a7 * 1 / 5 - 1) * (-0.091424) + (a8 * 1 / 36 - 1) * (-0.27696) + (a9 * 1 / 47 - 1) * (-0.17049) + (a10 * 2 / 19 - 1) * 0.11147 - 0.14472;
                a = 2 / (1 + Math.Exp(-2 * a)) * 3 / 2 + 1;
                if (checkBox1.Checked == true)
                {
                    label1.Text = Convert.ToString(Math.Round(a, 4));
                }
                else
                {
                    switch (Convert.ToInt32(Math.Round(a)))
                    {
                        case 1: label1.Text = "Здоров";
                            break;
                        case 2: label1.Text = "Необходимо амбулаторное лечение";
                            break;
                        case 3: label1.Text = "Необходимо стационарное лечение";
                            break;
                        case 4: label1.Text = "Экстренная госпитализация";
                            break;

                    }

                }
            }
            else
            {
                label1.Text = "Есть пустые поля";
            }
        }

    }
}

