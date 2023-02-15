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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox1.Image = Properties.Resources.breakfast;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox1.Image = Properties.Resources.lunch;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox1.Image = Properties.Resources.dinner;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox1.Image = Properties.Resources.drinks;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox1.Image = Properties.Resources.snacks;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox1.Image = Properties.Resources.traffic;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox1.Image = Properties.Resources.medical;
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox1.Image = Properties.Resources.rent;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox1.Image = Properties.Resources.shopping;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox1.Image = Properties.Resources.social;
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox1.Image = Properties.Resources.entertainment;
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox1.Image = Properties.Resources.gift;
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox1.Image = Properties.Resources.other;
        }

        private void button1_Click(object sender, EventArgs e)
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
                                MessageBox.Show(label3.Text + " 支出:\n" + radioButton1.Text + "\t$" + textBox1.Text + "元");
                            }
                            else if (radioButton2.Checked)
                            {
                                MessageBox.Show(label3.Text + " 支出:\n" + radioButton2.Text + "\t$" + textBox1.Text + "元");
                            }
                            else if (radioButton3.Checked)
                            {
                                MessageBox.Show(label3.Text + " 支出:\n" + radioButton3.Text + "\t$" + textBox1.Text + "元");
                            }
                            else if (radioButton4.Checked)
                            {
                                MessageBox.Show(label3.Text + " 支出:\n" + radioButton4.Text + "\t$" + textBox1.Text + "元");
                            }
                            else if (radioButton5.Checked)
                            {
                                MessageBox.Show(label3.Text + " 支出:\n" + radioButton5.Text + "\t$" + textBox1.Text + "元");
                            }
                            else if (radioButton6.Checked)
                            {
                                MessageBox.Show(label3.Text + " 支出:\n" + radioButton6.Text + "\t$" + textBox1.Text + "元");
                            }
                            else if (radioButton7.Checked)
                            {
                                MessageBox.Show(label3.Text + " 支出:\n" + radioButton7.Text + "\t$" + textBox1.Text + "元");
                            }
                            else if (radioButton8.Checked)
                            {
                                MessageBox.Show(label3.Text + " 支出:\n" + radioButton8.Text + "\t$" + textBox1.Text + "元");
                            }
                            else if (radioButton9.Checked)
                            {
                                MessageBox.Show(label3.Text + " 支出:\n" + radioButton9.Text + "\t$" + textBox1.Text + "元");
                            }
                            else if (radioButton10.Checked)
                            {
                                MessageBox.Show(label3.Text + " 支出:\n" + radioButton10.Text + "\t$" + textBox1.Text + "元");
                            }
                            else if (radioButton11.Checked)
                            {
                                MessageBox.Show(label3.Text + " 支出:\n" + radioButton11.Text + "\t$" + textBox1.Text + "元");
                            }
                            else if (radioButton12.Checked)
                            {
                                MessageBox.Show(label3.Text + " 支出:\n" + radioButton12.Text + "\t$" + textBox1.Text + "元");
                            }
                            else if (radioButton13.Checked)
                            {
                                MessageBox.Show(label3.Text + " 支出:\n" + radioButton13.Text + "\t$" + textBox1.Text + "元");
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 appfrm4 = new Form4();
            appfrm4.ShowDialog();
            label3.Text = appfrm4.monthCalendar1.SelectionEnd.Date.Year.ToString();
            label3.Text += "/" + appfrm4.monthCalendar1.SelectionEnd.Date.Month.ToString();
            label3.Text += "/" + appfrm4.monthCalendar1.SelectionEnd.Date.Day.ToString();
        }
    }
}
