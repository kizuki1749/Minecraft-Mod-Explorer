namespace Minecraft_Mod_Explorer
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.再読み込みRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modフォルダーを指定して再読み込みFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.終了EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modの管理MToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modの追加AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modの削除DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.forgeのインストールFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.起動UToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minecraftLauncherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.このModを削除DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルFToolStripMenuItem,
            this.modの管理MToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(576, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            this.ファイルFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.再読み込みRToolStripMenuItem,
            this.modフォルダーを指定して再読み込みFToolStripMenuItem,
            this.toolStripSeparator1,
            this.終了EToolStripMenuItem});
            this.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            this.ファイルFToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.ファイルFToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // 再読み込みRToolStripMenuItem
            // 
            this.再読み込みRToolStripMenuItem.Name = "再読み込みRToolStripMenuItem";
            this.再読み込みRToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.再読み込みRToolStripMenuItem.Text = "再読み込み(&R)";
            this.再読み込みRToolStripMenuItem.Click += new System.EventHandler(this.再読み込みRToolStripMenuItem_Click);
            // 
            // modフォルダーを指定して再読み込みFToolStripMenuItem
            // 
            this.modフォルダーを指定して再読み込みFToolStripMenuItem.Name = "modフォルダーを指定して再読み込みFToolStripMenuItem";
            this.modフォルダーを指定して再読み込みFToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.modフォルダーを指定して再読み込みFToolStripMenuItem.Text = "Modフォルダーを指定して再読み込み(&F)";
            this.modフォルダーを指定して再読み込みFToolStripMenuItem.Click += new System.EventHandler(this.modフォルダーを指定して再読み込みFToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(259, 6);
            // 
            // 終了EToolStripMenuItem
            // 
            this.終了EToolStripMenuItem.Name = "終了EToolStripMenuItem";
            this.終了EToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.終了EToolStripMenuItem.Text = "終了(&E)";
            this.終了EToolStripMenuItem.Click += new System.EventHandler(this.終了EToolStripMenuItem_Click);
            // 
            // modの管理MToolStripMenuItem
            // 
            this.modの管理MToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modの追加AToolStripMenuItem,
            this.modの削除DToolStripMenuItem,
            this.toolStripSeparator2,
            this.forgeのインストールFToolStripMenuItem,
            this.toolStripSeparator3,
            this.起動UToolStripMenuItem});
            this.modの管理MToolStripMenuItem.Name = "modの管理MToolStripMenuItem";
            this.modの管理MToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.modの管理MToolStripMenuItem.Text = "ツール(&T)";
            // 
            // modの追加AToolStripMenuItem
            // 
            this.modの追加AToolStripMenuItem.Name = "modの追加AToolStripMenuItem";
            this.modの追加AToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.modの追加AToolStripMenuItem.Text = "Modの追加(&A)";
            this.modの追加AToolStripMenuItem.Click += new System.EventHandler(this.modの追加AToolStripMenuItem_Click);
            // 
            // modの削除DToolStripMenuItem
            // 
            this.modの削除DToolStripMenuItem.Name = "modの削除DToolStripMenuItem";
            this.modの削除DToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.modの削除DToolStripMenuItem.Text = "Modの削除(&D)";
            this.modの削除DToolStripMenuItem.Click += new System.EventHandler(this.このModを削除DToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(180, 6);
            // 
            // forgeのインストールFToolStripMenuItem
            // 
            this.forgeのインストールFToolStripMenuItem.Name = "forgeのインストールFToolStripMenuItem";
            this.forgeのインストールFToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.forgeのインストールFToolStripMenuItem.Text = "Forgeのインストール(&G)";
            this.forgeのインストールFToolStripMenuItem.Click += new System.EventHandler(this.forgeのインストールFToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(180, 6);
            // 
            // 起動UToolStripMenuItem
            // 
            this.起動UToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minecraftLauncherToolStripMenuItem});
            this.起動UToolStripMenuItem.Name = "起動UToolStripMenuItem";
            this.起動UToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.起動UToolStripMenuItem.Text = "起動(&R)";
            // 
            // minecraftLauncherToolStripMenuItem
            // 
            this.minecraftLauncherToolStripMenuItem.Name = "minecraftLauncherToolStripMenuItem";
            this.minecraftLauncherToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.minecraftLauncherToolStripMenuItem.Text = "Minecraft Launcher(&M)";
            this.minecraftLauncherToolStripMenuItem.Click += new System.EventHandler(this.minecraftLauncherToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 350);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(576, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(62, 17);
            this.toolStripStatusLabel1.Text = "総Mod数: ";
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.listBox1.DisplayMember = "Name";
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(12, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(552, 316);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.このModを削除DToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(167, 26);
            // 
            // このModを削除DToolStripMenuItem
            // 
            this.このModを削除DToolStripMenuItem.Name = "このModを削除DToolStripMenuItem";
            this.このModを削除DToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.このModを削除DToolStripMenuItem.Text = "このModを削除(&D)";
            this.このModを削除DToolStripMenuItem.Click += new System.EventHandler(this.このModを削除DToolStripMenuItem_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Modsフォルダーを指定してください";
            this.folderBrowserDialog1.SelectedPath = "%appdata%\\roaming\\.minecraft";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "対応しているすべてのファイル|*.jar;*.zip|Executable Jar File|*.jar|圧縮ファイル|*.zip|すべてのファイル|*.*";
            this.openFileDialog1.SupportMultiDottedExtensions = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 372);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Minecraft Mod Explorer 1.0.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 再読み込みRToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStripMenuItem modフォルダーを指定して再読み込みFToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem このModを削除DToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 終了EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modの管理MToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modの追加AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modの削除DToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem forgeのインストールFToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 起動UToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minecraftLauncherToolStripMenuItem;
    }
}

