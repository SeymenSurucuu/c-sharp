using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İKinci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {

        }


        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox2.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            comboBox1.Items.Add(textBox1.Text);
        
        
        }

        private void button3_Click(object sender, EventArgs e)


        {
                

            if (comboBox1.SelectedItem != null && listBox1.SelectedItem != null )
            {
                var hangisi = listBox1.SelectedItem.ToString();
                label6.Text = hangisi;

                var sehir = comboBox1.Text;
                label5.Text = sehir;

            }
            else {
                MessageBox.Show("Eksik veri Seçilmiş. Lütfen gerekli verileri seçiniz");
            }


        }
    }
}
