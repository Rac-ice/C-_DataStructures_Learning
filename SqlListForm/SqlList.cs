using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SqlList;

namespace SqlListForm
{
    public partial class SqlList : Form
    {
        public SqlList()
        {
            InitializeComponent();
        }

        SqlListClass sqlList;

        private void SqlList_Load(object sender, EventArgs e)
        {
            sqlList = new SqlListClass();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] str = textBox1.Text.Trim().Split('，', ',');
            sqlList.CreateList(str);
            MessageBox.Show("创建成功");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = sqlList.DisplayList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = sqlList.ListLength();
            textBox3.Text = i.ToString().Trim();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(textBox5.Text.Trim());
            string s = string.Empty;
            bool b = sqlList.GetElem(i, ref s);
            textBox4.Text = s.Trim();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int i = sqlList.LocateElem(textBox6.Text.Trim());
            textBox7.Text = i.ToString().Trim();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(textBox8.Text.Trim());
            string s = textBox9.Text.Trim();
            bool b = sqlList.ListInsert(i, s);
            if (b)
            {
                textBox10.Text = sqlList.DisplayList().ToString();
            }
            else
            {
                MessageBox.Show("插入失败");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(textBox11.Text.Trim());
            string s = string.Empty;
            bool b = sqlList.ListDelete(i, ref s);
            if (b)
            {
                textBox12.Text = sqlList.DisplayList().ToString();
            }
            else
            {
                MessageBox.Show("删除失败");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            sqlList.Reverse(ref sqlList);
            textBox13.Text = sqlList.DisplayList().ToString();
        }

        SqlListClass SL1, SL2, SL3;

        private void button10_Click(object sender, EventArgs e)
        {
            string[] str = textBox15.Text.Trim().Split('，', ',');
            SL2 = new SqlListClass();
            SL2.CreateList(str);
            MessageBox.Show("创建成功");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string s = textBox18.Text.Trim();
            bool b = sqlList.ListRemoveElem(s);
            if (b)
            {
                textBox17.Text = sqlList.DisplayList();
            }
            else
            {
                MessageBox.Show("删除失败");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            SqlListClass odd = new SqlListClass();
            SqlListClass even = new SqlListClass();
            sqlList.OddAndEven(sqlList, ref odd, ref even);
            textBox19.Text = odd.DisplayList().ToString();
            textBox20.Text = even.DisplayList().ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            SL3 = new SqlListClass();
            SL3.Merge2(SL1, SL2, ref SL3);
            textBox16.Text = SL3.DisplayList();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string[] str = textBox14.Text.Trim().Split('，', ',');
            SL1 = new SqlListClass();
            SL1.CreateList(str);
            MessageBox.Show("创建成功");
        }
    }
}
