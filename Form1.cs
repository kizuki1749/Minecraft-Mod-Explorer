using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using Microsoft.VisualBasic.FileIO;
using System.Diagnostics;

namespace Minecraft_Mod_Explorer
{
    public partial class Form1 : Form
    {
        string folderpath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft\mods";
        private static Form1 _form1Instance;
        public static Form1 Form1Instance
        {
            get
            {
                return _form1Instance;
            }
            set
            {
                _form1Instance = value;
            }
        }
        public ListBox.ObjectCollection listBoxitems
        {
            get
            {
                return listBox1.Items;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            reload();
            このModを削除DToolStripMenuItem.Enabled = false;
            modの削除DToolStripMenuItem.Enabled = false;
            Form1.Form1Instance = this;
        }
        string[] files;
        string[] search = { "Buildcraft", "Industrialcraft", "Railcraft", "Redpower", "ProjectRed", "Optifine", "InfinityChest", "cutall", "mineall", "dokodemodoor-3", "TooManyItems", "codechickencore", "CoFH", "ComputerCraft", "fastcraft", "Bamboo", "CompactEngine", "ProjectE", "SlimevoidLibrary" , "DynamicTransport","AdvancedSolarPanel" , "QuarryPlus" , "LogisticsPipe" , "CodeChickenLib" , "ForgeMultiPart" , ".points" };
        public void reload()
        {
            このModを削除DToolStripMenuItem.Enabled = false;
            modの削除DToolStripMenuItem.Enabled = false;
            listBox1.Items.Clear();
            try
            {
                files = Directory.GetFiles(folderpath, "*.*", System.IO.SearchOption.TopDirectoryOnly);
                foreach (string file in files)
                {
                    string file2;
                    file2 = file;
                    foreach (string str in search)
                    {
                        if (file.IndexOf(str, StringComparison.OrdinalIgnoreCase) != -1)
                        {
                            switch (str)
                            {
                                case ".points":
                                    file2 += " [ Rei's Minimap Waypoints File ] ";
                                    break;

                                case "ForgeMultiPart":
                                    file2 += " [ 前提Mod ] ";
                                    break;

                                case "CodeChickenLib":
                                    file2 += " [ 前提Mod ] ";
                                    break;

                                case "QuarryPlus":
                                    file2 += " [ QuarryPlus ( Buildcraft アドオン ) ] ";
                                    break;

                                case "AdvancedSolarPanel":
                                    file2 += " [ Advanced Solar Panel ( Industrialcraft シリーズ アドオン ) ] ";
                                    break;

                                case "DynamicTransport":
                                    file2 += " [ DynamicElevator シリーズ ] ";
                                    break;

                                case "SlimevoidLibrary":
                                    file2 += " [ 前提Mod ] ";
                                    break;

                                case "ProjectRed":
                                    file2 += " [ ProjectRed シリーズ (RedPower互換) ] ";
                                    break;

                                case "ProjectE":
                                    file2 += " [ 錬金術Mod (互換) ] ";
                                    break;

                                case "CompactEngine":
                                    file2 += " [ めんdMod シリーズ ] ";
                                    break;

                                case "Bamboo":
                                    file2 += " [ 竹Mod ] ";
                                    break;

                                case "Optifine":
                                    file2 += " [ 軽量化Mod ] ";
                                    break;

                                case "fastcraft":
                                    file2 += " [ 軽量化Mod ] ";
                                    break;

                                case "codechickencore":
                                    file2 += " [ 前提Mod ] ";
                                    break;

                                case "CoFH":
                                    file2 += " [ 前提Mod ] ";
                                    break;

                                case "InfinityChest":
                                    file2 += " [ 20億チェスト ]";
                                    break;

                                case "cutall":
                                    file2 += "　[ 木こりMod ]";
                                    break;

                                case "mineall":
                                    file2 += "　[ 鉱石採掘Mod ]";
                                    break;
                                
                                case "dokodemodoor-3":
                                    file2 += "　[ 遠征どこでもドア 3 ]";
                                    break;

                                default:
                                    file2 += " [ " + str + " シリーズ ]";
                                    break;
                            }
                        }
                    }
                    listBox1.Items.Add(Path.GetFileName(file2));
                }
                Array.Sort(files);
                toolStripStatusLabel1.Text = "総Mod数: " + files.Length;
            }
            catch (Exception)
            {
                MessageBox.Show("Modsフォルダーが見つかりませんでした。ツールからForgeをインストールするか、手動でModsフォルダーを指定してください。","エラー",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void 再読み込みRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reload();
        }

        private void modフォルダーを指定して再読み込みFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft\mods";
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                folderpath = folderBrowserDialog1.SelectedPath;
                reload();
            }        
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                このModを削除DToolStripMenuItem.Enabled = true;
                modの削除DToolStripMenuItem.Enabled = true;
            }
        }

        private void 終了EToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void このModを削除DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(listBox1.SelectedItem.ToString() + " を削除しますか?", listBox1.SelectedItem.ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FileSystem.DeleteFile((files[listBox1.SelectedIndex]));
                reload();
                このModを削除DToolStripMenuItem.Enabled = false;
                modの削除DToolStripMenuItem.Enabled = false;
            }
        }

        private void modの追加AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileSystem.CopyFile(openFileDialog1.FileName,folderpath+"\\"+Path.GetFileName(openFileDialog1.FileName),true);
                reload();
            }
        }

        private void forgeのインストールFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void minecraftLauncherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(folderBrowserDialog1.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft\Launcher.jar");
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
