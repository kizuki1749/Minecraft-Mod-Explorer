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

namespace Minecraft_Mod_Explorer
{
    public partial class Form2 : Form
    {
        // versions
        string[] minor = { "1","2","5","6","7","8","9","10","11" };
        string[] build6 = { "2","4" };
        string[] build7 = { "2","10_pre4","10" };
        string[] build8 = { "0", "8", "9" };
        string[] build9 = { "0", "4" };
        string[] build1011 = { "0", "2" };

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                comboBox3.Items.Clear();
                comboBox2.Items.Clear();
                comboBox2.Items.AddRange(minor);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a = comboBox2.SelectedIndex;
            if (a != 0)
            {
                comboBox3.Enabled = true;
            }
            switch (a)
            {
                case 0:
                    comboBox3.Items.Clear();
                    comboBox3.Items.Add("0");
                    comboBox3.SelectedIndex = 0;
                    comboBox3.Enabled = false;
                    break;
                case 1:
                    comboBox3.Items.Clear();
                    comboBox3.Items.Add("5");
                    break;

                case 2:
                    comboBox3.Items.Clear();
                    comboBox3.Items.Add("2");
                    break;

                case 3:
                    comboBox3.Items.Clear();
                    comboBox3.Items.AddRange(build6);
                    break;
                case 4:
                    comboBox3.Items.Clear();
                    comboBox3.Items.AddRange(build7);
                    break;
                case 5:
                    comboBox3.Items.Clear();
                    comboBox3.Items.AddRange(build8);
                    break;
                case 6:
                    comboBox3.Items.Clear();
                    comboBox3.Items.AddRange(build9);
                    break;
                case 7:
                    comboBox3.Items.Clear();
                    comboBox3.Items.AddRange(build1011);
                    break;
                case 8:
                    comboBox3.Items.Clear();
                    comboBox3.Items.AddRange(build1011);
                    break;
            }
        }
        public void DoDownload(string url, string fileName)
        {
                //WebRequestを作成
                System.Net.HttpWebRequest webreq =
                    (System.Net.HttpWebRequest)System.Net.WebRequest.Create(url);

                //サーバーからの応答を受信するためのWebResponseを取得
                System.Net.HttpWebResponse webres =
                    (System.Net.HttpWebResponse)webreq.GetResponse();

                //応答データを受信するためのStreamを取得
                System.IO.Stream strm = webres.GetResponseStream();

                //ファイルに書き込むためのFileStreamを作成
                System.IO.FileStream fs = new System.IO.FileStream(
                    fileName, System.IO.FileMode.Create, System.IO.FileAccess.Write);

                //応答データをファイルに書き込む
                byte[] readData = new byte[1024];
                for (;;)
                {
                    //データを読み込む
                    int readSize = strm.Read(readData, 0, readData.Length);
                    if (readSize == 0)
                    {
                        //すべてのデータを読み込んだ時
                        break;
                    }
                    //読み込んだデータをファイルに書き込む
                    fs.Write(readData, 0, readSize);
                }

                //閉じる
                fs.Close();
                strm.Close();
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            string ver;
            label2.Text = "ダウンロード中です。(固まります)";
            await Task.Delay(1000);
            try
            {
                ver = comboBox1.SelectedItem.ToString();
                ver += comboBox2.SelectedItem.ToString();
                ver += comboBox3.SelectedItem.ToString();
            }
            catch (Exception)
            {
                label2.Text = "";
                MessageBox.Show("バージョンが指定されていません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SafeCreateDirectory(@"temp\");

            switch (ver)
            {
                case "110":
                    DoDownload("http://files.minecraftforge.net/maven/net/minecraftforge/forge/1.1-1.3.4.29/forge-1.1-1.3.4.29-client.zip", @"temp\forge-1.1-1.3.4.29-client.zip");
                    System.Diagnostics.Process.Start(@"temp\");
                    MessageBox.Show("1. 7-zip等でバニラの1.1のjarを開く。\r\n2. zip内のファイルを追加する。\r\n3. 起動", "この後の手順", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "125":
                    DoDownload("http://files.minecraftforge.net/maven/net/minecraftforge/forge/1.2.5-3.4.9.171/forge-1.2.5-3.4.9.171-client.zip", @"temp\forge-1.2.5-3.4.9.171-client.zip");
                    System.Diagnostics.Process.Start(@"temp\");
                    MessageBox.Show("1. 7-zip等でバニラの1.2.5のjarを開く。\r\n2. zip内のファイルを追加する。\r\n3. 起動","この後の手順",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    break;
                case "152":
                    DoDownload("http://files.minecraftforge.net/maven/net/minecraftforge/forge/1.5.2-7.8.1.738/forge-1.5.2-7.8.1.738-installer.jar", @"temp\forge-installer.jar");
                    System.Diagnostics.Process.Start(@"temp\forge-installer.jar");
                    break;
                case "162":
                    DoDownload("http://files.minecraftforge.net/maven/net/minecraftforge/forge/1.6.2-9.10.1.871/forge-1.6.2-9.10.1.871-installer.jar", @"temp\forge-installer.jar");
                    System.Diagnostics.Process.Start(@"temp\forge-installer.jar");
                    break;
                case "164":
                    DoDownload("http://files.minecraftforge.net/maven/net/minecraftforge/forge/1.6.4-9.11.1.1345/forge-1.6.4-9.11.1.1345-installer.jar", @"temp\forge-installer.jar");
                    System.Diagnostics.Process.Start(@"temp\forge-installer.jar");
                    break;
                case "172":
                    DoDownload("http://files.minecraftforge.net/maven/net/minecraftforge/forge/1.7.2-10.12.2.1147/forge-1.7.2-10.12.2.1147-installer.jar", @"temp\forge-installer.jar");
                    System.Diagnostics.Process.Start(@"temp\forge-installer.jar");
                    break;
                case "1710_pre4":
                    DoDownload("http://files.minecraftforge.net/maven/net/minecraftforge/forge/1.7.10_pre4-10.12.2.1149-prerelease/forge-1.7.10_pre4-10.12.2.1149-prerelease-installer.jar", @"temp\forge-installer.jar");
                    System.Diagnostics.Process.Start(@"temp\forge-installer.jar");
                    break;
                case "1710":
                    DoDownload("http://files.minecraftforge.net/maven/net/minecraftforge/forge/1.7.10-10.13.4.1614-1.7.10/forge-1.7.10-10.13.4.1614-1.7.10-installer.jar", @"temp\forge-installer.jar");
                    System.Diagnostics.Process.Start(@"temp\forge-installer.jar");
                    break;
                case "180":
                    DoDownload("http://files.minecraftforge.net/maven/net/minecraftforge/forge/1.8-11.14.4.1577/forge-1.8-11.14.4.1577-installer.jar", @"temp\forge-installer.jar");
                    System.Diagnostics.Process.Start(@"temp\forge-installer.jar");
                    break;
                case "188":
                    DoDownload("http://files.minecraftforge.net/maven/net/minecraftforge/forge/1.8.8-11.15.0.1655/forge-1.8.8-11.15.0.1655-installer.jar", @"temp\forge-installer.jar");
                    System.Diagnostics.Process.Start(@"temp\forge-installer.jar");
                    break;
                case "189":
                    DoDownload("http://files.minecraftforge.net/maven/net/minecraftforge/forge/1.8.9-11.15.1.1902-1.8.9/forge-1.8.9-11.15.1.1902-1.8.9-installer.jar", @"temp\forge-installer.jar");
                    System.Diagnostics.Process.Start(@"temp\forge-installer.jar");
                    break;
                case "190":
                    DoDownload("http://files.minecraftforge.net/maven/net/minecraftforge/forge/1.9-12.16.1.1887/forge-1.9-12.16.1.1887-installer.jar", @"temp\forge-installer.jar");
                    System.Diagnostics.Process.Start(@"temp\forge-installer.jar");
                    break;
                case "194":
                    DoDownload("http://files.minecraftforge.net/maven/net/minecraftforge/forge/1.9.4-12.17.0.2051/forge-1.9.4-12.17.0.2051-installer.jar", @"temp\forge-installer.jar");
                    System.Diagnostics.Process.Start(@"temp\forge-installer.jar");
                    break;
                case "1100":
                    DoDownload("http://files.minecraftforge.net/maven/net/minecraftforge/forge/1.10-12.18.0.2000-1.10.0/forge-1.10-12.18.0.2000-1.10.0-installer.jar", @"temp\forge-installer.jar");
                    System.Diagnostics.Process.Start(@"temp\forge-installer.jar");
                    break;
                case "1102":
                    DoDownload("http://files.minecraftforge.net/maven/net/minecraftforge/forge/1.10.2-12.18.3.2281/forge-1.10.2-12.18.3.2281-installer.jar", @"temp\forge-installer.jar");
                    System.Diagnostics.Process.Start(@"temp\forge-installer.jar");
                    break;
                case "1110":
                    DoDownload("http://files.minecraftforge.net/maven/net/minecraftforge/forge/1.11-13.19.1.2199/forge-1.11-13.19.1.2199-installer.jar", @"temp\forge-installer.jar");
                    System.Diagnostics.Process.Start(@"temp\forge-installer.jar");
                    break;
                case "1112":
                    DoDownload("http://files.minecraftforge.net/maven/net/minecraftforge/forge/1.11.2-13.20.0.2296/forge-1.11.2-13.20.0.2296-installer.jar", @"temp\forge-installer.jar");
                    System.Diagnostics.Process.Start(@"temp\forge-installer.jar");
                    break;
                default:
                    MessageBox.Show("バージョンが指定されていません。","エラー",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    break;
            }
            label2.Text = "";
        }

        public static DirectoryInfo SafeCreateDirectory(string path)
        {
            if (Directory.Exists(path))
            {
                return null;
            }
            return Directory.CreateDirectory(path);
        }
    }
}
