using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace final_project
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox1.Image = Properties.Resources.salary;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox1.Image = Properties.Resources.investment;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox1.Image = Properties.Resources.other;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 appfrm6 = new Form6();
            appfrm6.ShowDialog();
            label3.Text = appfrm6.monthCalendar1.SelectionEnd.Date.Year.ToString();
            label3.Text += "/" + appfrm6.monthCalendar1.SelectionEnd.Date.Month.ToString();
            label3.Text += "/" + appfrm6.monthCalendar1.SelectionEnd.Date.Day.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (label3.Text != "")
                {
                    if (textBox1.Text != "")
                    {
                        if (int.Parse(textBox1.Text) > 0)
                        {
                            if (radioButton1.Checked)
                            {
                                MessageBox.Show(label3.Text + " 收入:\n" + radioButton1.Text + "\t$" + textBox1.Text + "元");
                            }
                            else if (radioButton2.Checked)
                            {
                                MessageBox.Show(label3.Text + " 收入:\n" + radioButton2.Text + "\t$" + textBox1.Text + "元");
                            }
                            else if (radioButton3.Checked)
                            {
                                MessageBox.Show(label3.Text + " 收入:\n" + radioButton3.Text + "\t$" + textBox1.Text + "元");
                            }
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("輸入金額不得為負");
                        }
                    }
                    else
                    {
                        MessageBox.Show("請輸入金額");
                    }
                }
                else
                {
                    MessageBox.Show("請選擇日期");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
