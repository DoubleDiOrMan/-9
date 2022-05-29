using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RussianПраздники
{
    public partial class Form1 : Form
    {
        DateTime df;
        public Form1()
        {
            BackColor = Color.Ivory;
            InitializeComponent();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string s = comboBox1.Text;
           
            if (s == "Мир, Труд, Май")
            {
                df = new DateTime(2022, 5, 1);
            }
            else if (s == "Мой День рождения")
            {
                df = new DateTime(2022, 5, 16);
            }
            else if (s == "Прорыв блокады Ленинграда")
            {
                df = new DateTime(2022, 1, 18);
            }
            else if (s == "Международный Женский День")
            {
                df = new DateTime(2022, 3, 8);
            }
            else if (s == "День Города")
            {
                df = new DateTime(2021, 5, 27);
            }
            Form2 timerForm = new Form2(this, df, s);
            timerForm.Show();
            this.Hide();
            
        }
    }
}
