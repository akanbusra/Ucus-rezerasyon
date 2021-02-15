using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace örnek_proje_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(" Rota:" + comboBox2.Text + "-" + comboBox1.Text +"  Tarih:" + dateTimePicker1.Text + "  Saat: " + maskedTextBox1.Text );
            listBox1.Items.Add(" Yolcu adı-soyadı:" + textBox1.Text + "  TC:" + maskedTextBox2.Text + "  Telefon numarası: " + maskedTextBox3.Text );

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label9.Text = comboBox1.Text;
            comboBox1.Text = comboBox2.Text;
            comboBox2.Text = label9.Text;
        }
    }
}
