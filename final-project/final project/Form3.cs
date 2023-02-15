using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_project
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButton1.Checked | radioButton2.Checked | radioButton3.Checked | radioButton16.Checked | radioButton14.Checked | radioButton15.Checked | radioButton4.Checked)
                {
                    this.Close();
                }
                else if (radioButton5.Checked | radioButton6.Checked | radioButton7.Checked | radioButton11.Checked | radioButton8.Checked | radioButton9.Checked | radioButton12.Checked | radioButton10.Checked | radioButton13.Checked)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("請選擇類別");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
