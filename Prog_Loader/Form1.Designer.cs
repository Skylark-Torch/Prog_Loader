using System.Windows.Forms;


namespace Prog_Loader
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxQuark = new System.Windows.Forms.CheckBox();
            this.checkBoxDogecoin = new System.Windows.Forms.CheckBox();
            this.checkBoxLitecoin = new System.Windows.Forms.CheckBox();
            this.checkBoxBitcoin = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBoxCryptoMiners = new System.Windows.Forms.GroupBox();
            this.checkBoxMinerd = new System.Windows.Forms.CheckBox();
            this.checkBoxDCL = new System.Windows.Forms.CheckBox();
            this.groupBoxCryptoWallets = new System.Windows.Forms.GroupBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBoxSubSync = new System.Windows.Forms.GroupBox();
            this.checkBoxChrome = new System.Windows.Forms.CheckBox();
            this.checkBoxMouseWithoutBorders = new System.Windows.Forms.CheckBox();
            this.checkBoxGyazo = new System.Windows.Forms.CheckBox();
            this.checkBoxRazerSynapse = new System.Windows.Forms.CheckBox();
            this.checkBoxAMDGE = new System.Windows.Forms.CheckBox();
            this.checkBoxSteam = new System.Windows.Forms.CheckBox();
            this.groupBoxFileManagers = new System.Windows.Forms.GroupBox();
            this.checkBoxGoogleMusic = new System.Windows.Forms.CheckBox();
            this.checkBoxDropbox = new System.Windows.Forms.CheckBox();
            this.checkBoxGoogleDrive = new System.Windows.Forms.CheckBox();
            this.checkBoxBTSync = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxCryptoMiners.SuspendLayout();
            this.groupBoxCryptoWallets.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBoxSubSync.SuspendLayout();
            this.groupBoxFileManagers.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Work in Progress";
            // 
            // checkBoxQuark
            // 
            this.checkBoxQuark.AutoSize = true;
            this.checkBoxQuark.Location = new System.Drawing.Point(6, 90);
            this.checkBoxQuark.Name = "checkBoxQuark";
            this.checkBoxQuark.Size = new System.Drawing.Size(55, 17);
            this.checkBoxQuark.TabIndex = 3;
            this.checkBoxQuark.Text = "Quark";
            this.checkBoxQuark.UseVisualStyleBackColor = true;
            // 
            // checkBoxDogecoin
            // 
            this.checkBoxDogecoin.AutoSize = true;
            this.checkBoxDogecoin.Location = new System.Drawing.Point(6, 66);
            this.checkBoxDogecoin.Name = "checkBoxDogecoin";
            this.checkBoxDogecoin.Size = new System.Drawing.Size(72, 17);
            this.checkBoxDogecoin.TabIndex = 2;
            this.checkBoxDogecoin.Text = "Dogecoin";
            this.checkBoxDogecoin.UseVisualStyleBackColor = true;
            // 
            // checkBoxLitecoin
            // 
            this.checkBoxLitecoin.AutoSize = true;
            this.checkBoxLitecoin.Location = new System.Drawing.Point(6, 42);
            this.checkBoxLitecoin.Name = "checkBoxLitecoin";
            this.checkBoxLitecoin.Size = new System.Drawing.Size(63, 17);
            this.checkBoxLitecoin.TabIndex = 1;
            this.checkBoxLitecoin.Text = "Litecoin";
            this.checkBoxLitecoin.UseVisualStyleBackColor = true;
            // 
            // checkBoxBitcoin
            // 
            this.checkBoxBitcoin.AutoSize = true;
            this.checkBoxBitcoin.Location = new System.Drawing.Point(6, 19);
            this.checkBoxBitcoin.Name = "checkBoxBitcoin";
            this.checkBoxBitcoin.Size = new System.Drawing.Size(58, 17);
            this.checkBoxBitcoin.TabIndex = 0;
            this.checkBoxBitcoin.Text = "Bitcoin";
            this.checkBoxBitcoin.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(297, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 22);
            this.button1.TabIndex = 0;
            this.button1.Text = "Launch";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(360, 385);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBoxCryptoMiners);
            this.tabPage1.Controls.Add(this.groupBoxCryptoWallets);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(352, 359);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Crypto Currency";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBoxCryptoMiners
            // 
            this.groupBoxCryptoMiners.Controls.Add(this.checkBoxMinerd);
            this.groupBoxCryptoMiners.Controls.Add(this.checkBoxDCL);
            this.groupBoxCryptoMiners.Location = new System.Drawing.Point(105, 6);
            this.groupBoxCryptoMiners.Name = "groupBoxCryptoMiners";
            this.groupBoxCryptoMiners.Size = new System.Drawing.Size(93, 69);
            this.groupBoxCryptoMiners.TabIndex = 7;
            this.groupBoxCryptoMiners.TabStop = false;
            this.groupBoxCryptoMiners.Text = "Miners";
            this.groupBoxCryptoMiners.MouseDown += new System.Windows.Forms.MouseEventHandler(this.groupBoxCryptoMiners_MouseDown);
            // 
            // checkBoxMinerd
            // 
            this.checkBoxMinerd.AutoSize = true;
            this.checkBoxMinerd.Location = new System.Drawing.Point(6, 42);
            this.checkBoxMinerd.Name = "checkBoxMinerd";
            this.checkBoxMinerd.Size = new System.Drawing.Size(58, 17);
            this.checkBoxMinerd.TabIndex = 1;
            this.checkBoxMinerd.Text = "Minerd";
            this.checkBoxMinerd.UseVisualStyleBackColor = true;
            // 
            // checkBoxDCL
            // 
            this.checkBoxDCL.AutoSize = true;
            this.checkBoxDCL.Location = new System.Drawing.Point(6, 19);
            this.checkBoxDCL.Name = "checkBoxDCL";
            this.checkBoxDCL.Size = new System.Drawing.Size(50, 17);
            this.checkBoxDCL.TabIndex = 0;
            this.checkBoxDCL.Text = "DC-L";
            this.checkBoxDCL.UseVisualStyleBackColor = true;
            // 
            // groupBoxCryptoWallets
            // 
            this.groupBoxCryptoWallets.Controls.Add(this.checkBoxQuark);
            this.groupBoxCryptoWallets.Controls.Add(this.checkBoxBitcoin);
            this.groupBoxCryptoWallets.Controls.Add(this.checkBoxDogecoin);
            this.groupBoxCryptoWallets.Controls.Add(this.checkBoxLitecoin);
            this.groupBoxCryptoWallets.Location = new System.Drawing.Point(6, 6);
            this.groupBoxCryptoWallets.Name = "groupBoxCryptoWallets";
            this.groupBoxCryptoWallets.Size = new System.Drawing.Size(93, 113);
            this.groupBoxCryptoWallets.TabIndex = 6;
            this.groupBoxCryptoWallets.TabStop = false;
            this.groupBoxCryptoWallets.Text = "Crypto Wallets";
            this.groupBoxCryptoWallets.MouseDown += new System.Windows.Forms.MouseEventHandler(this.groupBoxCryptoWallets_MouseDown);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBoxSubSync);
            this.tabPage2.Controls.Add(this.groupBoxFileManagers);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(352, 359);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Other";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBoxSubSync
            // 
            this.groupBoxSubSync.Controls.Add(this.checkBoxChrome);
            this.groupBoxSubSync.Controls.Add(this.checkBoxMouseWithoutBorders);
            this.groupBoxSubSync.Controls.Add(this.checkBoxGyazo);
            this.groupBoxSubSync.Controls.Add(this.checkBoxRazerSynapse);
            this.groupBoxSubSync.Controls.Add(this.checkBoxAMDGE);
            this.groupBoxSubSync.Controls.Add(this.checkBoxSteam);
            this.groupBoxSubSync.Location = new System.Drawing.Point(109, 6);
            this.groupBoxSubSync.Name = "groupBoxSubSync";
            this.groupBoxSubSync.Size = new System.Drawing.Size(93, 172);
            this.groupBoxSubSync.TabIndex = 8;
            this.groupBoxSubSync.TabStop = false;
            this.groupBoxSubSync.Text = "Group";
            this.groupBoxSubSync.MouseDown += new System.Windows.Forms.MouseEventHandler(this.groupBoxSubSync_MouseDown);
            // 
            // checkBoxChrome
            // 
            this.checkBoxChrome.AutoSize = true;
            this.checkBoxChrome.Location = new System.Drawing.Point(6, 148);
            this.checkBoxChrome.Name = "checkBoxChrome";
            this.checkBoxChrome.Size = new System.Drawing.Size(62, 17);
            this.checkBoxChrome.TabIndex = 3;
            this.checkBoxChrome.Text = "Chrome";
            this.checkBoxChrome.UseVisualStyleBackColor = true;
            this.checkBoxChrome.CheckedChanged += new System.EventHandler(this.checkBoxChrome_CheckedChanged);
            // 
            // checkBoxMouseWithoutBorders
            // 
            this.checkBoxMouseWithoutBorders.AutoSize = true;
            this.checkBoxMouseWithoutBorders.Location = new System.Drawing.Point(6, 125);
            this.checkBoxMouseWithoutBorders.Name = "checkBoxMouseWithoutBorders";
            this.checkBoxMouseWithoutBorders.Size = new System.Drawing.Size(53, 17);
            this.checkBoxMouseWithoutBorders.TabIndex = 3;
            this.checkBoxMouseWithoutBorders.Text = "MWB";
            this.checkBoxMouseWithoutBorders.UseVisualStyleBackColor = true;
            this.checkBoxMouseWithoutBorders.CheckedChanged += new System.EventHandler(this.checkBoxMouseWithoutBorders_CheckedChanged);
            // 
            // checkBoxGyazo
            // 
            this.checkBoxGyazo.AutoSize = true;
            this.checkBoxGyazo.Location = new System.Drawing.Point(6, 102);
            this.checkBoxGyazo.Name = "checkBoxGyazo";
            this.checkBoxGyazo.Size = new System.Drawing.Size(56, 17);
            this.checkBoxGyazo.TabIndex = 3;
            this.checkBoxGyazo.Text = "Gyazo";
            this.checkBoxGyazo.UseVisualStyleBackColor = true;
            this.checkBoxGyazo.CheckedChanged += new System.EventHandler(this.checkBoxGyazo_CheckedChanged);
            // 
            // checkBoxRazerSynapse
            // 
            this.checkBoxRazerSynapse.AccessibleDescription = "Razer Synapse";
            this.checkBoxRazerSynapse.AutoSize = true;
            this.checkBoxRazerSynapse.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRazerSynapse.Location = new System.Drawing.Point(6, 19);
            this.checkBoxRazerSynapse.Name = "checkBoxRazerSynapse";
            this.checkBoxRazerSynapse.Size = new System.Drawing.Size(87, 16);
            this.checkBoxRazerSynapse.TabIndex = 0;
            this.checkBoxRazerSynapse.Text = "Razer Synapse";
            this.checkBoxRazerSynapse.UseVisualStyleBackColor = true;
            this.checkBoxRazerSynapse.CheckedChanged += new System.EventHandler(this.checkBoxRazerSynapse_CheckedChanged);
            // 
            // checkBoxAMDGE
            // 
            this.checkBoxAMDGE.AutoSize = true;
            this.checkBoxAMDGE.Location = new System.Drawing.Point(6, 66);
            this.checkBoxAMDGE.Name = "checkBoxAMDGE";
            this.checkBoxAMDGE.Size = new System.Drawing.Size(89, 30);
            this.checkBoxAMDGE.TabIndex = 2;
            this.checkBoxAMDGE.Text = "AMD Gaming\r\nEvolved";
            this.checkBoxAMDGE.UseVisualStyleBackColor = true;
            this.checkBoxAMDGE.CheckedChanged += new System.EventHandler(this.checkBoxAMDGE_CheckedChanged);
            // 
            // checkBoxSteam
            // 
            this.checkBoxSteam.AutoSize = true;
            this.checkBoxSteam.Location = new System.Drawing.Point(6, 42);
            this.checkBoxSteam.Name = "checkBoxSteam";
            this.checkBoxSteam.Size = new System.Drawing.Size(56, 17);
            this.checkBoxSteam.TabIndex = 1;
            this.checkBoxSteam.Text = "Steam";
            this.checkBoxSteam.UseVisualStyleBackColor = true;
            this.checkBoxSteam.CheckedChanged += new System.EventHandler(this.checkBoxSteam_CheckedChanged);
            // 
            // groupBoxFileManagers
            // 
            this.groupBoxFileManagers.Controls.Add(this.checkBoxGoogleMusic);
            this.groupBoxFileManagers.Controls.Add(this.checkBoxDropbox);
            this.groupBoxFileManagers.Controls.Add(this.checkBoxGoogleDrive);
            this.groupBoxFileManagers.Controls.Add(this.checkBoxBTSync);
            this.groupBoxFileManagers.Location = new System.Drawing.Point(6, 6);
            this.groupBoxFileManagers.Name = "groupBoxFileManagers";
            this.groupBoxFileManagers.Size = new System.Drawing.Size(93, 113);
            this.groupBoxFileManagers.TabIndex = 7;
            this.groupBoxFileManagers.TabStop = false;
            this.groupBoxFileManagers.Text = "File Managers";
            this.groupBoxFileManagers.MouseDown += new System.Windows.Forms.MouseEventHandler(this.groupBoxFileManagers_MouseDown);
            // 
            // checkBoxGoogleMusic
            // 
            this.checkBoxGoogleMusic.AutoSize = true;
            this.checkBoxGoogleMusic.Location = new System.Drawing.Point(6, 90);
            this.checkBoxGoogleMusic.Name = "checkBoxGoogleMusic";
            this.checkBoxGoogleMusic.Size = new System.Drawing.Size(91, 17);
            this.checkBoxGoogleMusic.TabIndex = 3;
            this.checkBoxGoogleMusic.Text = "Google Music";
            this.checkBoxGoogleMusic.UseVisualStyleBackColor = true;
            // 
            // checkBoxDropbox
            // 
            this.checkBoxDropbox.AutoSize = true;
            this.checkBoxDropbox.Location = new System.Drawing.Point(6, 19);
            this.checkBoxDropbox.Name = "checkBoxDropbox";
            this.checkBoxDropbox.Size = new System.Drawing.Size(66, 17);
            this.checkBoxDropbox.TabIndex = 0;
            this.checkBoxDropbox.Text = "Dropbox";
            this.checkBoxDropbox.UseVisualStyleBackColor = true;
            this.checkBoxDropbox.CheckedChanged += new System.EventHandler(this.checkBoxDropbox_CheckedChanged);
            // 
            // checkBoxGoogleDrive
            // 
            this.checkBoxGoogleDrive.AutoSize = true;
            this.checkBoxGoogleDrive.Location = new System.Drawing.Point(6, 66);
            this.checkBoxGoogleDrive.Name = "checkBoxGoogleDrive";
            this.checkBoxGoogleDrive.Size = new System.Drawing.Size(88, 17);
            this.checkBoxGoogleDrive.TabIndex = 2;
            this.checkBoxGoogleDrive.Text = "Google Drive";
            this.checkBoxGoogleDrive.UseVisualStyleBackColor = true;
            // 
            // checkBoxBTSync
            // 
            this.checkBoxBTSync.AutoSize = true;
            this.checkBoxBTSync.Location = new System.Drawing.Point(6, 42);
            this.checkBoxBTSync.Name = "checkBoxBTSync";
            this.checkBoxBTSync.Size = new System.Drawing.Size(67, 17);
            this.checkBoxBTSync.TabIndex = 1;
            this.checkBoxBTSync.Text = "BT Sync";
            this.checkBoxBTSync.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Prog_Loader";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 420);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(117, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Start with Windows";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 444);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Prog_Loader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBoxCryptoMiners.ResumeLayout(false);
            this.groupBoxCryptoMiners.PerformLayout();
            this.groupBoxCryptoWallets.ResumeLayout(false);
            this.groupBoxCryptoWallets.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBoxSubSync.ResumeLayout(false);
            this.groupBoxSubSync.PerformLayout();
            this.groupBoxFileManagers.ResumeLayout(false);
            this.groupBoxFileManagers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxQuark;
        private System.Windows.Forms.CheckBox checkBoxDogecoin;
        private System.Windows.Forms.CheckBox checkBoxLitecoin;
        private System.Windows.Forms.CheckBox checkBoxBitcoin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBoxCryptoMiners;
        private System.Windows.Forms.CheckBox checkBoxMinerd;
        private System.Windows.Forms.CheckBox checkBoxDCL;
        private System.Windows.Forms.GroupBox groupBoxCryptoWallets;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Timer timer1;
        private NotifyIcon notifyIcon1;
        private CheckBox checkBox1;
        private GroupBox groupBoxFileManagers;
        private CheckBox checkBoxGoogleMusic;
        private CheckBox checkBoxDropbox;
        private CheckBox checkBoxGoogleDrive;
        private CheckBox checkBoxBTSync;
        private GroupBox groupBoxSubSync;
        private CheckBox checkBoxGyazo;
        private CheckBox checkBoxRazerSynapse;
        private CheckBox checkBoxAMDGE;
        private CheckBox checkBoxSteam;
        private CheckBox checkBoxChrome;
        private CheckBox checkBoxMouseWithoutBorders;

    }
}

