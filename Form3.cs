using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minecraft_Mod_Explorer
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int cnt = 0;
            int icnt = Form1.Form1Instance.listBox1.Items.Count;
            for (cnt = 0; cnt == icnt; cnt++)
            {
                if (radioButton1.Checked == true)
                {
                    int a = Form1.Form1Instance.listBox1.FindStringExact(textBox1.Text, cnt);
                    Form1.Form1Instance.listBox1.SelectedIndex = a;
                    string b = Form1.Form1Instance.listBox1.Text;
                    listBox1.Items.Add(b);
                }
                else
                {
                    int a = Form1.Form1Instance.listBox1.FindString(textBox1.Text, cnt);
                    Form1.Form1Instance.listBox1.SelectedIndex = a;
                    string b = Form1.Form1Instance.listBox1.Text;
                    listBox1.Items.Add(b);
                }
            }
        }
    }
}

static class Extensions
{
    public static ListViewItem[] Find(this ListView listView, string keyWord)
    {
        return FindSubItems(listView, keyWord, 0);
    }

    public static ListViewItem[] FindSubItems(this ListView listView, string keyWord, int index)
    {
        List<ListViewItem> hitItemList = new List<ListViewItem>();
        foreach (ListViewItem item in listView.Items)
            if (item.SubItems[index].Text.Contains(keyWord))
                hitItemList.Add(item);

        return hitItemList.ToArray<ListViewItem>();
    }
}
