using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exchange
{
    public partial class Form1 : Form
    { 
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int change;
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

            try
            {
                change = int.Parse(textBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("請輸入正整數值！", "錯誤訊息", MessageBoxButtons.OK);
                textBox1.Clear();
                return;
            }
            if (change < 0)
            {
                MessageBox.Show("請輸入正整數值！", "錯誤訊息", MessageBoxButtons.OK);
                textBox1.Clear();
                return;
            }
            if (checkBox1.Checked == true)
            {
                textBox2.Text = (change / 50).ToString();
                change = change % 50;
            }
            if (checkBox2.Checked == true)
            {
                textBox3.Text = (change / 10).ToString();
                change = change % 10;
            }
            if (checkBox3.Checked == true)
            {
                textBox4.Text = (change / 5).ToString();
                change = change % 5;
            }

            textBox5.Text = change.ToString();
        }
    }
}
