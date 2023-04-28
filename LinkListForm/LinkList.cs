using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LinkList;

namespace LinkListForm
{
    public partial class LinkList : Form
    {
        public LinkList()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            string[] str = textBox1.Text.Trim().Split('，', ',');
            linkList.CreateListR(str);
            MessageBox.Show("创建成功");

        }

        LinkListClass linkList;

        private void LinkList_Load(object sender, EventArgs e)
        {
            linkList = new LinkListClass();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = linkList.DisplayList().ToString();  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = linkList.ListLength().ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(textBox5.Text.Trim());
            string s = string.Empty;
            bool b = linkList.GetElem(i,ref s);
            textBox4.Text = s.Trim();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int i = linkList.LocateElem(textBox6.Text.Trim());
            textBox7.Text = i.ToString().Trim();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(textBox8.Text.Trim());
            string s = textBox9.Text.Trim();
            linkList.ListInsert(i,s);
            textBox10.Text = linkList.DisplayList().ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(textBox18.Text.Trim());
            string s = string.Empty;
            linkList.ListDelete(i,ref s);
            textBox17.Text = linkList.DisplayList().ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string s = textBox12.Text.Trim();
            linkList.ListRemoveElem(s);
            textBox11.Text = linkList.DisplayList().ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            linkList.Reveres(ref linkList);
            textBox13.Text = linkList.DisplayList().ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int i = linkList.Findlast(linkList, textBox14.Text.Trim());
            textBox15.Text = i.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string s = string.Empty;
            linkList.DeleteMax(ref s);
            textBox16.Text = s;
            textBox19.Text = linkList.DisplayList().ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string[] str = textBox1.Text.Trim().Split('，', ',');
            linkList.Sort(str);
            textBox20.Text = linkList.DisplayList().ToString();
        }
    }
}
