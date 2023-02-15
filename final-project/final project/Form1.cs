using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace final_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        struct Money
        {
            public string date;
            public string category;
            public int revenues;
            public int expenses;
            public int balance;
        }
        List<Money> account = new List<Money>();

        int rev, exp = 0;

        private int find_month()
        {
            string[] s = account[0].date.Split('/');
            int month = int.Parse(s[1]);
            return month;
        }

        private void listboxtotal()
        {
            listBox1.Items.RemoveAt(1);
            listBox1.Items.Insert(1, find_month() + "月\t " + "總額\t" + rev + "\t" + exp + "\t" + (rev - exp));
        }

        //新增支出
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 appfrm2 = new Form2();
            appfrm2.ShowDialog();
            if (appfrm2.textBox1.Text != "")
            {
                if (int.Parse(appfrm2.textBox1.Text) > 0)
                {
                    int ex = int.Parse(appfrm2.textBox1.Text);
                    exp += ex;
                    Money newmoney = new Money();
                    newmoney.date = appfrm2.label3.Text;
                    newmoney.revenues = 0;
                    newmoney.expenses = ex;
                    newmoney.balance = rev - exp;
                    if (appfrm2.radioButton1.Checked)
                    {
                        newmoney.category = appfrm2.radioButton1.Text;
                        account.Add(newmoney);
                        listboxtotal();
                        listBox1.Items.Add(appfrm2.label3.Text + "   " + appfrm2.radioButton1.Text + "\t" + 0 + "\t" + ex);
                    }
                    else if (appfrm2.radioButton2.Checked)
                    {
                        newmoney.category = appfrm2.radioButton2.Text;
                        account.Add(newmoney);
                        listboxtotal();
                        listBox1.Items.Add(appfrm2.label3.Text + "   " + appfrm2.radioButton2.Text + "\t" + 0 + "\t" + ex);
                    }
                    else if (appfrm2.radioButton3.Checked)
                    {
                        newmoney.category = appfrm2.radioButton3.Text;
                        account.Add(newmoney);
                        listboxtotal();
                        listBox1.Items.Add(appfrm2.label3.Text + "   " + appfrm2.radioButton3.Text + "\t" + 0 + "\t" + ex);
                    }
                    else if (appfrm2.radioButton4.Checked)
                    {
                        newmoney.category = appfrm2.radioButton4.Text;
                        account.Add(newmoney);
                        listboxtotal();
                        listBox1.Items.Add(appfrm2.label3.Text + "   " + appfrm2.radioButton4.Text + "\t" + 0 + "\t" + ex);
                    }
                    else if (appfrm2.radioButton5.Checked)
                    {
                        newmoney.category = appfrm2.radioButton5.Text;
                        account.Add(newmoney);
                        listboxtotal();
                        listBox1.Items.Add(appfrm2.label3.Text + "   " + appfrm2.radioButton5.Text + "\t" + 0 + "\t" + ex);
                    }
                    else if (appfrm2.radioButton6.Checked)
                    {
                        newmoney.category = appfrm2.radioButton6.Text;
                        account.Add(newmoney);
                        listboxtotal();
                        listBox1.Items.Add(appfrm2.label3.Text + "   " + appfrm2.radioButton6.Text + "\t" + 0 + "\t" + ex);
                    }
                    else if (appfrm2.radioButton7.Checked)
                    {
                        newmoney.category = appfrm2.radioButton7.Text;
                        account.Add(newmoney);
                        listboxtotal();
                        listBox1.Items.Add(appfrm2.label3.Text + "   " + appfrm2.radioButton7.Text + "\t" + 0 + "\t" + ex);
                    }
                    else if (appfrm2.radioButton8.Checked)
                    {
                        newmoney.category = appfrm2.radioButton8.Text;
                        account.Add(newmoney);
                        listboxtotal();
                        listBox1.Items.Add(appfrm2.label3.Text + "   " + appfrm2.radioButton8.Text + "\t" + 0 + "\t" + ex);
                    }
                    else if (appfrm2.radioButton9.Checked)
                    {
                        newmoney.category = appfrm2.radioButton9.Text;
                        account.Add(newmoney);
                        listboxtotal();
                        listBox1.Items.Add(appfrm2.label3.Text + "   " + appfrm2.radioButton9.Text + "\t" + 0 + "\t" + ex);
                    }
                    else if (appfrm2.radioButton10.Checked)
                    {
                        newmoney.category = appfrm2.radioButton10.Text;
                        account.Add(newmoney);
                        listboxtotal();
                        listBox1.Items.Add(appfrm2.label3.Text + "   " + appfrm2.radioButton10.Text + "\t" + 0 + "\t" + ex);
                    }
                    else if (appfrm2.radioButton11.Checked)
                    {
                        newmoney.category = appfrm2.radioButton11.Text;
                        account.Add(newmoney);
                        listboxtotal();
                        listBox1.Items.Add(appfrm2.label3.Text + "   " + appfrm2.radioButton11.Text + "\t" + 0 + "\t" + ex);
                    }
                    else if (appfrm2.radioButton12.Checked)
                    {
                        newmoney.category = appfrm2.radioButton12.Text;
                        account.Add(newmoney);
                        listboxtotal();
                        listBox1.Items.Add(appfrm2.label3.Text + "   " + appfrm2.radioButton12.Text + "\t" + 0 + "\t" + ex);
                    }
                    else if (appfrm2.radioButton13.Checked)
                    {
                        newmoney.category = appfrm2.radioButton13.Text;
                        account.Add(newmoney);
                        listboxtotal();
                        listBox1.Items.Add(appfrm2.label3.Text + "   " + appfrm2.radioButton13.Text + "\t" + 0 + "\t" + ex);
                    }
                }
            }
        }

        //讀檔
        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader inputfile;
            listBox1.Items.Clear();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                inputfile = File.OpenText(openFileDialog1.FileName);
                listBox1.Items.Add("日期\t 類別\t總收入\t總支出\t餘額");
                listBox1.Items.Add("0/0/0" + "\t 總額\t" + rev + "\t" + exp + "\t" + (rev - exp));
                listBox1.Items.Add("=====================================");
                while (!inputfile.EndOfStream)
                {
                    string record;
                    record = inputfile.ReadLine();
                    string[] fields = record.Split(',');
                    Money money = new Money();
                    money.date = fields[0];
                    money.category = fields[1];
                    money.revenues = int.Parse(fields[2]);
                    money.expenses = int.Parse(fields[3]);
                    money.balance = int.Parse(fields[4]);
                    rev += int.Parse(fields[2]);
                    exp += int.Parse(fields[3]);
                    account.Add(money);
                    listBox1.Items.Add(money.date + "\t " + money.category + "\t" + money.revenues + "\t" + money.expenses);
                    listboxtotal();
                }
                inputfile.Close();
                button1.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button9.Enabled = true;
                MessageBox.Show("讀檔讀取成功");
            }
            else
            {
                MessageBox.Show("取消讀檔");
            }
        }

        //各類別總額
        public void button7_Click(object sender, EventArgs e)
        {
            Form3 appfrm3 = new Form3();
            appfrm3.ShowDialog();
            int t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16;
            string s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12, s13, s14, s15, s16;
            t1 = t2 = t3 = t4 = t5 = t6 = t7 = t8 = t9 = t10 = t11 = t12 = t13 = t14 = t15 = t16 = 0;
            s1 = s2 = s3 = s4 = s5 = s6 = s7 = s8 = s9 = s10 = s11 = s12 = s13 = s14 = s15 = s16 = "";
            if (appfrm3.radioButton1.Checked)
            {
                for (int i = 0; i < account.Count; i++)
                {
                    if (account[i].category == "薪水")
                    {
                        t1 += account[i].revenues;
                        s1 += account[i].date + " " + account[i].category + " " + "$" + account[i].revenues + "\n";
                    }
                }
                MessageBox.Show("共存了" + t1.ToString() + "元" + "\n" +"如下:" + "\n"+ s1);
            }
            else if (appfrm3.radioButton2.Checked)
            {
                for (int i = 0; i < account.Count; i++)
                {
                    if (account[i].category == "投資")
                    {
                        t2 += account[i].revenues;
                        s2 += account[i].date + " " + account[i].category + " " + "$" + account[i].revenues + "\n";
                    }
                }
                MessageBox.Show("共存了" + t2.ToString() + "元" + "\n" + "如下:" + "\n" + s2);
            }
            else if (appfrm3.radioButton3.Checked)
            {
                for (int i = 0; i < account.Count; i++)
                {
                    if (account[i].revenues != 0)
                    {
                        if (account[i].category == "其他")
                        {
                            t3 += account[i].revenues;
                            s3 += account[i].date + " " + account[i].category + " " + "$" + account[i].revenues + "\n";
                        }
                    }
                }
                MessageBox.Show("共存了" + t3.ToString() + "元" + "\n" + "如下:" + "\n" + s3);
            }
            else if (appfrm3.radioButton16.Checked)
            {
                for (int i = 0; i < account.Count; i++)
                {
                    if (account[i].category == "早餐")
                    {
                        t4 += account[i].expenses;
                        s4 += account[i].date + " " + account[i].category + " " + "$" + account[i].expenses + "\n";
                    }
                }
                MessageBox.Show("共花了" + t4.ToString() + "元" + "\n" + "如下:" + "\n" + s4);
            }
            else if (appfrm3.radioButton14.Checked)
            {
                for (int i = 0; i < account.Count; i++)
                {
                    if (account[i].category == "午餐")
                    {
                        t5 += account[i].expenses;
                        s5 += account[i].date + " " + account[i].category + " " + "$" + account[i].expenses + "\n";
                    }
                }
                MessageBox.Show("共花了" + t5.ToString() + "元" + "\n" + "如下:" + "\n" + s5);
            }
            else if (appfrm3.radioButton15.Checked)
            {
                for (int i = 0; i < account.Count; i++)
                {
                    if (account[i].category == "晚餐")
                    {
                        t6 += account[i].expenses;
                        s6 += account[i].date + " " + account[i].category + " " + "$" + account[i].expenses + "\n";
                    }
                }
                MessageBox.Show("共花了" + t6.ToString() + "元" + "\n" + "如下:" + "\n" + s6);
            }
            else if (appfrm3.radioButton4.Checked)
            {
                for (int i = 0; i < account.Count; i++)
                {
                    if (account[i].category == "飲料")
                    {
                        t7 += account[i].expenses;
                        s7 += account[i].date + " " + account[i].category + " " + "$" + account[i].expenses + "\n";
                    }
                }
                MessageBox.Show("共花了" + t7.ToString() + "元" + "\n" + "如下:" + "\n" + s7);
            }
            else if (appfrm3.radioButton5.Checked)
            {
                for (int i = 0; i < account.Count; i++)
                {
                    if (account[i].category == "點心")
                    {
                        t8 += account[i].expenses;
                        s8 += account[i].date + " " + account[i].category + " " + "$" + account[i].expenses + "\n";
                    }
                }
                MessageBox.Show("共花了" + t8.ToString() + "元" + "\n" + "如下:" + "\n" + s8);
            }
            else if (appfrm3.radioButton6.Checked)
            {
                for (int i = 0; i < account.Count; i++)
                {
                    if (account[i].category == "交通")
                    {
                        t9 += account[i].expenses;
                        s9 += account[i].date + " " + account[i].category + " " + "$" + account[i].expenses + "\n";
                    }
                }
                MessageBox.Show("共花了" + t9.ToString() + "元" + "\n" + "如下:" + "\n" + s9);
            }
            else if (appfrm3.radioButton7.Checked)
            {
                for (int i = 0; i < account.Count; i++)
                {
                    if (account[i].category == "醫療")
                    {
                        t10 += account[i].expenses;
                        s10 += account[i].date + " " + account[i].category + " " + "$" + account[i].expenses + "\n";
                    }
                }
                MessageBox.Show("共花了" + t10.ToString() + "元" + "\n" + "如下:" + "\n" + s10);
            }
            else if (appfrm3.radioButton11.Checked)
            {
                for (int i = 0; i < account.Count; i++)
                {
                    if (account[i].category == "房租")
                    {
                        t11 += account[i].expenses;
                        s11 += account[i].date + " " + account[i].category + " " + "$" + account[i].expenses + "\n";
                    }
                }
                MessageBox.Show("共花了" + t11.ToString() + "元" + "\n" + "如下:" + "\n" + s11);
            }
            else if (appfrm3.radioButton8.Checked)
            {
                for (int i = 0; i < account.Count; i++)
                {
                    if (account[i].category == "購物")
                    {
                        t12 += account[i].expenses;
                        s12 += account[i].date + " " + account[i].category + " " + "$" + account[i].expenses + "\n";
                    }
                }
                MessageBox.Show("共花了" + t12.ToString() + "元" + "\n" + "如下:" + "\n" + s12);
            }
            else if (appfrm3.radioButton9.Checked)
            {
                for (int i = 0; i < account.Count; i++)
                {
                    if (account[i].category == "社交")
                    {
                        t13 += account[i].expenses;
                        s13 += account[i].date + " " + account[i].category + " " + "$" + account[i].expenses + "\n";
                    }
                }
                MessageBox.Show("共花了" + t13.ToString() + "元" + "\n" + "如下:" + "\n" + s13);
            }
            else if (appfrm3.radioButton12.Checked)
            {
                for (int i = 0; i < account.Count; i++)
                {
                    if (account[i].category == "娛樂")
                    {
                        t14 += account[i].expenses;
                        s14 += account[i].date + " " + account[i].category + " " + "$" + account[i].expenses + "\n";
                    }
                }
                MessageBox.Show("共花了" + t14.ToString() + "元" + "\n" + "如下:" + "\n" + s14);
            }
            else if (appfrm3.radioButton10.Checked)
            {
                for (int i = 0; i < account.Count; i++)
                {
                    if (account[i].category == "禮物")
                    {
                        t15 += account[i].expenses;
                        s15 += account[i].date + " " + account[i].category + " " + "$" + account[i].expenses + "\n";
                    }
                }
                MessageBox.Show("共花了" + t15.ToString() + "元" + "\n" + "如下:" + "\n" + s15);
            }
            else if (appfrm3.radioButton13.Checked)
            {
                for (int i = 0; i < account.Count; i++)
                {
                    if (account[i].expenses != 0)
                    {
                        if (account[i].category == "其他")
                        {
                            t16 += account[i].expenses;
                            s16 += account[i].date + " " + account[i].category + " " + "$" + account[i].expenses + "\n";
                        }
                    }
                }
                MessageBox.Show("共花了" + t16.ToString() + "元" + "\n" + "如下:" + "\n" + s16);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button9.Enabled = false;
        }

        //新增收入
        private void button3_Click(object sender, EventArgs e)
        {
            Form5 appfrm5 = new Form5();
            appfrm5.ShowDialog();
            if (appfrm5.textBox1.Text != "")
            {
                if (int.Parse(appfrm5.textBox1.Text) > 0)
                {
                    int re = int.Parse(appfrm5.textBox1.Text);
                    rev += re;
                    Money nmoney = new Money();
                    nmoney.date = appfrm5.label3.Text;
                    nmoney.revenues = re;
                    nmoney.expenses = 0;
                    nmoney.balance = rev - exp;
                    if (appfrm5.radioButton1.Checked)
                    {
                        nmoney.category = appfrm5.radioButton1.Text;
                        account.Add(nmoney);
                        listboxtotal();
                        listBox1.Items.Add(appfrm5.label3.Text + "   " + appfrm5.radioButton1.Text + "\t" + re + "\t" + 0);
                    }
                    else if (appfrm5.radioButton2.Checked)
                    {
                        nmoney.category = appfrm5.radioButton2.Text;
                        account.Add(nmoney);
                        listboxtotal();
                        listBox1.Items.Add(appfrm5.label3.Text + "   " + appfrm5.radioButton2.Text + "\t" + re + "\t" + 0);
                    }
                    else if (appfrm5.radioButton3.Checked)
                    {
                        nmoney.category = appfrm5.radioButton3.Text;
                        account.Add(nmoney);
                        listboxtotal();
                        listBox1.Items.Add(appfrm5.label3.Text + "   " + appfrm5.radioButton3.Text + "\t" + re + "\t" + 0);
                    }
                }
            }
        }

        //刪除
        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                int index = listBox1.SelectedIndex - 3;
                rev -= account[index].revenues;
                exp -= account[index].expenses;
                account.RemoveAt(index);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                listboxtotal();
                MessageBox.Show("刪除成功");
            }
            else
            {
                MessageBox.Show("請點選欲刪除的資料");
            }
        }

        //結束
        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("記得存檔~\n謝謝使用");
            this.Close();
        }

        private void Swap(int a, int b)
        {
            Money temp;
            temp = account[a];
            account[a] = account[b];
            account[b] = temp;
        }

        private void sorting()
        {
            int maxIndex;
            for (int startScan = 0; startScan < account.Count - 1; startScan++)
            {
                maxIndex = startScan;
                string[] s = account[startScan].date.Split('/');
                int year = int.Parse(s[0]);
                int month = int.Parse(s[1]);
                int day = int.Parse(s[2]);
                for (int index = startScan + 1; index < account.Count; index++)
                {
                    string[] s1 = account[index].date.Split('/');
                    int nyear = int.Parse(s1[0]);
                    int nmonth = int.Parse(s1[1]);
                    int nday = int.Parse(s1[2]);
                    if (nyear <= year && nmonth <= month && nday < day)
                    {
                        year = nyear;
                        month = nmonth;
                        day = nday;
                        maxIndex = index;
                    }
                }
                Swap(maxIndex, startScan);
            }
            MessageBox.Show("排序完成");
        }

        private void money_listing()
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("日期\t 類別\t總收入\t總支出\t餘額");
            listBox1.Items.Add("0/0/0" + "\t 總額\t" + rev + "\t" + exp + "\t" + (rev - exp));
            listBox1.Items.Add("=====================================");
            for (int index = 0; index < account.Count; index++)
            {
                listBox1.Items.Add(account[index].date + "\t " + account[index].category + "\t" + account[index].revenues + "\t" + account[index].expenses);
                listboxtotal();
            }
        }

        //排序
        private void button6_Click(object sender, EventArgs e)
        {
            sorting();
            money_listing();
        }

        //修改
        private void button9_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                int index = listBox1.SelectedIndex - 3;
                rev -= account[index].revenues;
                exp -= account[index].expenses;
                if (account[index].revenues != 0)
                {
                    Form5 appfrm5 = new Form5();
                    appfrm5.ShowDialog();
                    account.RemoveAt(index);
                    if (appfrm5.textBox1.Text != "")
                    {
                        if (int.Parse(appfrm5.textBox1.Text) > 0)
                        {
                            int re = int.Parse(appfrm5.textBox1.Text);
                            rev += re;
                            Money nmoney = new Money();
                            nmoney.date = appfrm5.label3.Text;
                            nmoney.revenues = re;
                            nmoney.expenses = 0;
                            nmoney.balance = rev - exp;
                            if (appfrm5.radioButton1.Checked)
                            {
                                nmoney.category = appfrm5.radioButton1.Text;
                                account.Insert(index, nmoney);
                                listboxtotal();
                                listBox1.Items.RemoveAt(index + 3);
                                listBox1.Items.Insert(index + 3, appfrm5.label3.Text + "   " + appfrm5.radioButton1.Text + "\t" + re + "\t" + 0);
                            }
                            else if (appfrm5.radioButton2.Checked)
                            {
                                nmoney.category = appfrm5.radioButton2.Text;
                                account.Insert(index, nmoney);
                                listboxtotal();
                                listBox1.Items.RemoveAt(index + 3);
                                listBox1.Items.Insert(index + 3, appfrm5.label3.Text + "   " + appfrm5.radioButton2.Text + "\t" + re + "\t" + 0);
                            }
                            else if (appfrm5.radioButton3.Checked)
                            {
                                nmoney.category = appfrm5.radioButton3.Text;
                                account.Insert(index, nmoney);
                                listboxtotal();
                                listBox1.Items.RemoveAt(index + 3);
                                listBox1.Items.Insert(index + 3, appfrm5.label3.Text + "   " + appfrm5.radioButton3.Text + "\t" + re + "\t" + 0);
                            }
                        }
                    }
                }
                else
                {
                    Form2 appfrm2 = new Form2();
                    appfrm2.ShowDialog();
                    account.RemoveAt(index);
                    if (appfrm2.textBox1.Text != "")
                    {
                        if (int.Parse(appfrm2.textBox1.Text) > 0)
                        {
                            int ex = int.Parse(appfrm2.textBox1.Text);
                            exp += ex;
                            Money newmoney = new Money();
                            newmoney.date = appfrm2.label3.Text;
                            newmoney.revenues = 0;
                            newmoney.expenses = ex;
                            newmoney.balance = rev - exp;
                            if (appfrm2.radioButton1.Checked)
                            {
                                newmoney.category = appfrm2.radioButton1.Text;
                                account.Insert(index, newmoney);
                                listboxtotal();
                                listBox1.Items.RemoveAt(index + 3);
                                listBox1.Items.Insert(index + 3, appfrm2.label3.Text + "   " + appfrm2.radioButton1.Text + "\t" + 0 + "\t" + ex);
                            }
                            else if (appfrm2.radioButton2.Checked)
                            {
                                newmoney.category = appfrm2.radioButton2.Text;
                                account.Insert(index, newmoney);
                                listboxtotal();
                                listBox1.Items.RemoveAt(index + 3);
                                listBox1.Items.Insert(index + 3, appfrm2.label3.Text + "   " + appfrm2.radioButton2.Text + "\t" + 0 + "\t" + ex);
                            }
                            else if (appfrm2.radioButton3.Checked)
                            {
                                newmoney.category = appfrm2.radioButton3.Text;
                                account.Insert(index, newmoney);
                                listboxtotal();
                                listBox1.Items.RemoveAt(index + 3);
                                listBox1.Items.Insert(index + 3, appfrm2.label3.Text + "   " + appfrm2.radioButton3.Text + "\t" + 0 + "\t" + ex);
                            }
                            else if (appfrm2.radioButton4.Checked)
                            {
                                newmoney.category = appfrm2.radioButton4.Text;
                                account.Insert(index, newmoney);
                                listboxtotal();
                                listBox1.Items.RemoveAt(index + 3);
                                listBox1.Items.Insert(index + 3, appfrm2.label3.Text + "   " + appfrm2.radioButton4.Text + "\t" + 0 + "\t" + ex);
                            }
                            else if (appfrm2.radioButton5.Checked)
                            {
                                newmoney.category = appfrm2.radioButton5.Text;
                                account.Insert(index, newmoney);
                                listboxtotal();
                                listBox1.Items.RemoveAt(index + 3);
                                listBox1.Items.Insert(index + 3, appfrm2.label3.Text + "   " + appfrm2.radioButton5.Text + "\t" + 0 + "\t" + ex);
                            }
                            else if (appfrm2.radioButton6.Checked)
                            {
                                newmoney.category = appfrm2.radioButton6.Text;
                                account.Insert(index, newmoney);
                                listboxtotal();
                                listBox1.Items.RemoveAt(index + 3);
                                listBox1.Items.Insert(index + 3, appfrm2.label3.Text + "   " + appfrm2.radioButton6.Text + "\t" + 0 + "\t" + ex);
                            }
                            else if (appfrm2.radioButton7.Checked)
                            {
                                newmoney.category = appfrm2.radioButton7.Text;
                                account.Insert(index, newmoney);
                                listboxtotal();
                                listBox1.Items.RemoveAt(index + 3);
                                listBox1.Items.Insert(index + 3, appfrm2.label3.Text + "   " + appfrm2.radioButton7.Text + "\t" + 0 + "\t" + ex);
                            }
                            else if (appfrm2.radioButton8.Checked)
                            {
                                newmoney.category = appfrm2.radioButton8.Text;
                                account.Insert(index, newmoney);
                                listboxtotal();
                                listBox1.Items.RemoveAt(index + 3);
                                listBox1.Items.Insert(index + 3, appfrm2.label3.Text + "   " + appfrm2.radioButton8.Text + "\t" + 0 + "\t" + ex);
                            }
                            else if (appfrm2.radioButton9.Checked)
                            {
                                newmoney.category = appfrm2.radioButton9.Text;
                                account.Insert(index, newmoney);
                                listboxtotal();
                                listBox1.Items.RemoveAt(index + 3);
                                listBox1.Items.Insert(index + 3, appfrm2.label3.Text + "   " + appfrm2.radioButton9.Text + "\t" + 0 + "\t" + ex);
                            }
                            else if (appfrm2.radioButton10.Checked)
                            {
                                newmoney.category = appfrm2.radioButton10.Text;
                                account.Insert(index, newmoney);
                                listboxtotal();
                                listBox1.Items.RemoveAt(index + 3);
                                listBox1.Items.Insert(index + 3, appfrm2.label3.Text + "   " + appfrm2.radioButton10.Text + "\t" + 0 + "\t" + ex);
                            }
                            else if (appfrm2.radioButton11.Checked)
                            {
                                newmoney.category = appfrm2.radioButton11.Text;
                                account.Insert(index, newmoney);
                                listboxtotal();
                                listBox1.Items.RemoveAt(index + 3);
                                listBox1.Items.Insert(index + 3, appfrm2.label3.Text + "   " + appfrm2.radioButton11.Text + "\t" + 0 + "\t" + ex);
                            }
                            else if (appfrm2.radioButton12.Checked)
                            {
                                newmoney.category = appfrm2.radioButton12.Text;
                                account.Insert(index, newmoney);
                                listboxtotal();
                                listBox1.Items.RemoveAt(index + 3);
                                listBox1.Items.Insert(index + 3, appfrm2.label3.Text + "   " + appfrm2.radioButton12.Text + "\t" + 0 + "\t" + ex);
                            }
                            else if (appfrm2.radioButton13.Checked)
                            {
                                newmoney.category = appfrm2.radioButton13.Text;
                                account.Insert(index, newmoney);
                                listboxtotal();
                                listBox1.Items.RemoveAt(index + 3);
                                listBox1.Items.Insert(index + 3, appfrm2.label3.Text + "   " + appfrm2.radioButton13.Text + "\t" + 0 + "\t" + ex);
                            }
                        }
                    }
                }
                MessageBox.Show("修改成功");
            }
            else
            {
                MessageBox.Show("請點選欲修改的資料");
            }
        }

        //存檔
        private void button4_Click(object sender, EventArgs e)
        {
            StreamWriter outputfile;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                outputfile = File.CreateText(saveFileDialog1.FileName);
                for (int index = 0; index < account.Count; index++)
                {
                    outputfile.WriteLine(account[index].date + "," + account[index].category + "," + account[index].revenues + "," + account[index].expenses + "," + account[index].balance);
                }
                outputfile.Close();
                MessageBox.Show("存檔成功");
            }
            else
            {
                MessageBox.Show("取消存檔");
            }
        }
    }
}
