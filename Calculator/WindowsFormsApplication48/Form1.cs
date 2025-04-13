using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication48
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void process1_Exited(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = null;
            label4.Text = null;

            int persestema = (int)numericUpDown3.Value;
            MyCalc calc = new MyCalc();
            bool flag1 = true;
            int razm;
            string znach = calc.ReverseString(textBox1.Text);
            int chislov10;

            if (textBox1.Text == "0")
                label3.Text = "0";
          flag1 = calc.flag(textBox1.Text, (int)numericUpDown3.Value);
          calc.start(znach, (int)numericUpDown3.Value, out chislov10);
          if (flag1 == true)
          {

              razm = calc.razm(chislov10, (int)numericUpDown2.Value);
              string[] obratn = new string[razm];
              string[] norm = new string[razm];
              obratn = calc.obr(chislov10, (int)numericUpDown2.Value, obratn);

              for (int i = 0, j = norm.Length - 1; i < norm.Length; i++, j--)

                  norm[j] = obratn[i];

              for (int i = 0; i < norm.Length; i++)
                  label3.Text = label3.Text + (norm[i]);
          }
          else label4.Text = "Неверное представление числа";
        }
    }
}