using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Loader
{
    public partial class Form1 : Form
    {

        private Rectangle hitTestRectangle = new Rectangle();
        private Rectangle doubleClickRectangle = new Rectangle();
        private bool isFirstClick = true;
        private bool isDoubleClick = false;
        private int milliseconds = 0;


        private object lastClickedBox;



        public Form1()
        {
            InitializeComponent();
        }





        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        //=======================================================================
        //Group Box Specifiers.
        private void groupBoxCryptoWallets_MouseDown(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("Click success!");
            //checkBoxBitcoin.Checked = true;
            //checkBoxLitecoin.Checked = true;
            //checkBoxDogecoin.Checked = true;
            //checkBoxQuark.Checked = true;
            lastClickedBox = sender;
            mouseDown(e);
            
        }
        //Group Box
        private void groupBoxCryptoMiners_MouseDown(object sender, MouseEventArgs e)
        {
            lastClickedBox = sender;
            mouseDown(e);
        }
        //Group Box
        private void groupBoxFileManagers_MouseDown(object sender, MouseEventArgs e)
        {
            lastClickedBox = sender;
            mouseDown(e);
        }
        //Group Box
        private void groupBoxSubSync_MouseDown(object sender, MouseEventArgs e)
        {
            lastClickedBox = sender;
            mouseDown(e);
        }

        //Group Box Specifiers.
        //=======================================================================

        //=======================================================================
        //Double click a box to toggle checks. Prepare below.

        //if (lastClickedBox == groupBox)
        //{
        //        //If is checked, or -- 
        //    if (checkBox.Checked == true &&
        //        checkBox.Checked == true)
        //    {
        //        //They are all checked. Uncheck them all.
        //        checkBox.Checked = false;
        //        checkBox.Checked = false;
        //    }
        //    else
        //    {
        //        //They are not all checked. Check them all.
        //        checkBox.Checked = true;
        //        checkBox.Checked = true;
        //    }
        //}


        private void groupBoxLogic()
        {
            //DoubleClick
            if (lastClickedBox == groupBoxCryptoWallets)
            {
                //CryptoWallet Toggler
                if (checkBoxBitcoin.Checked == true &&
                    checkBoxLitecoin.Checked == true &&
                    checkBoxDogecoin.Checked == true &&
                    checkBoxQuark.Checked == true)
                {
                    checkBoxBitcoin.Checked = false;
                    checkBoxLitecoin.Checked = false;
                    checkBoxDogecoin.Checked = false;
                    checkBoxQuark.Checked = false;
                }
                else
                {
                    checkBoxBitcoin.Checked = true;
                    checkBoxLitecoin.Checked = true;
                    checkBoxDogecoin.Checked = true;
                    checkBoxQuark.Checked = true;
                }
            }
            //DoubleClick
            if (lastClickedBox == groupBoxCryptoMiners)
            {

                //CryptoMiner Toggler
                if (checkBoxDCL.Checked == true &&
                    checkBoxMinerd.Checked == true)
                {
                    checkBoxDCL.Checked = false;
                    checkBoxMinerd.Checked = false;

                }
                else
                {
                    checkBoxDCL.Checked = true;
                    checkBoxMinerd.Checked = true;
                }
            }
            //DoubleClick
            if (lastClickedBox == groupBoxFileManagers)
            {
                //FileManagers Toggler
                if (checkBoxDropbox.Checked == true &&
                    checkBoxBTSync.Checked == true &&
                    checkBoxGoogleDrive.Checked == true &&
                    checkBoxGoogleMusic.Checked == true)
                {
                    checkBoxDropbox.Checked = false;
                    checkBoxBTSync.Checked = false;
                    checkBoxGoogleDrive.Checked = false;
                    checkBoxGoogleMusic.Checked = false;
                }
                else
                {
                    checkBoxDropbox.Checked = true;
                    checkBoxBTSync.Checked = true;
                    checkBoxGoogleDrive.Checked = true;
                    checkBoxGoogleMusic.Checked = true;
                }
            }
            //DoubleClick
            //finish me
            if (lastClickedBox == groupBoxSubSync)
            {
                //FileManagers Toggler
                if (checkBoxRazerSynapse.Checked == true &&
                    checkBoxSteam.Checked == true &&
                    checkBoxAMDGE.Checked == true &&
                    checkBoxGyazo.Checked == true &&
                    checkBoxGitHub.Checked == true &&
                    checkBoxChrome.Checked == true)
                {
                    checkBoxRazerSynapse.Checked = false;
                    checkBoxSteam.Checked = false;
                    checkBoxAMDGE.Checked = false;
                    checkBoxGyazo.Checked = false;
                    checkBoxGitHub.Checked = false;
                    checkBoxChrome.Checked = false;
                }
                else
                {
                    checkBoxRazerSynapse.Checked = true;
                    checkBoxSteam.Checked = true;
                    checkBoxAMDGE.Checked = true;
                    checkBoxGyazo.Checked = true;
                    checkBoxGitHub.Checked = true;
                    checkBoxChrome.Checked = true;
                }
            }
        }
        //DoubleClick
        //=======================================================================
        //
        //
        //=======================================================================
        //Check Boxes

        private void button1_Click(object sender, EventArgs e)
        {
            //CheckBoxes
            if (checkBoxBitcoin.Checked == true)
            {
                try
                {
                    System.Diagnostics.Process.Start(@"D:\Curreny Mining\2. Wallets\Bitcoin\bitcoin-qt.exe");
                }
                catch
                {
                    MessageBox.Show("Bitcoin Wallet not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
            }
            //CheckBoxes
            if (checkBoxLitecoin.Checked == true)
            {
                try
                {
                    System.Diagnostics.Process.Start(@"D:\Curreny Mining\2. Wallets\Litecoin\litecoin-qt.exe");
                }
                catch
                {
                    MessageBox.Show("Litecoin Wallet not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
            }
            //CheckBoxes
            if (checkBoxDogecoin.Checked == true)
            {
                try
                {
                    System.Diagnostics.Process.Start(@"D:\Curreny Mining\2. Wallets\Dogecoin\dogecoin-qt.exe");
                }
                catch
                {
                    MessageBox.Show("Dogecoin Wallet not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
            }
            //CheckBoxes
            if (checkBoxQuark.Checked == true)
            {
                try
                {
                    System.Diagnostics.Process.Start(@"D:\Curreny Mining\2. Wallets\Quark\quarkcoin-qt.exe");
                }
                catch
                {
                    MessageBox.Show("Quark Wallet not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
            }
            //CheckBoxes
            if (checkBoxDCL.Checked == true)
            {
                try
                {
                    Process proc = new Process();
                    proc.StartInfo.FileName = @"D:\Curreny Mining\1. Miners\DC-L.bat - Shortcut";
                    proc.Start();
                }
                catch
                {
                    MessageBox.Show("Dogecoin-Light Miner -- NOT FOUND!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
            }
            //CheckBoxes
            if (checkBoxMinerd.Checked == true)
            {
                try
                {
                    Process proc = new Process();
                    proc.StartInfo.FileName = @"D:\Curreny Mining\1. Miners\Minerd.bat - Mine Quark Full CPU";
                    proc.Start();
                }
                catch
                {
                    MessageBox.Show("Quark Miner -- NOT FOUND!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
            }
            //CheckBoxes
            if (checkBoxDropbox.Checked == true)
            {
                try
                {
                    Process proc = new Process();
                    proc.StartInfo.FileName = @"C:\Users\Stephen\AppData\Roaming\Dropbox\bin\dropbox.exe";
                    proc.Start();
                }
                catch
                {
                    MessageBox.Show("dropbox.exe -- NOT FOUND!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
            }
            //CheckBoxes
            if (checkBoxBTSync.Checked == true)
            {
                try
                {
                    Process proc = new Process();
                    proc.StartInfo.FileName = @"D:\Installations\BitTorrent Sync\BTSync.exe";
                    proc.Start();
                }
                catch
                {
                    MessageBox.Show("BTSync.exe -- NOT FOUND!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
            }
            //CheckBoxes
            if (checkBoxGoogleDrive.Checked == true)
            {
                try
                {
                    Process proc = new Process();
                    proc.StartInfo.FileName = @"C:\Program Files (x86)\Google\Drive\googledrivesync.exe";
                    proc.Start();
                }
                catch
                {
                    MessageBox.Show("googledrivesync.exe -- NOT FOUND!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
            }
            //CheckBoxes
            if (checkBoxGoogleMusic.Checked == true)
            {
                try
                {
                    Process proc = new Process();
                    proc.StartInfo.FileName = @"C:\Users\Stephen\AppData\Local\Programs\Google\MusicManager\MusicManager.exe";
                    proc.Start();
                }
                catch
                {
                    MessageBox.Show("MusicManager.exe -- NOT FOUND!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
            }
            //CheckBoxes
            if (checkBoxRazerSynapse.Checked == true)
            {
                try
                {
                    Process proc = new Process();
                    proc.StartInfo.FileName = @"C:\Program Files (x86)\Razer\Synapse\RzSynapse.exe";
                    proc.Start();
                }
                catch
                {
                    MessageBox.Show("RzSynapse.exe -- NOT FOUND!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
            }
            //CheckBoxes
            if (checkBoxSteam.Checked == true)
            {
                try
                {
                    Process proc = new Process();
                    proc.StartInfo.FileName = @"C:\Program Files (x86)\Steam\Steam.exe";
                    proc.Start();
                }
                catch
                {
                    MessageBox.Show("Steam.exe -- NOT FOUND!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
            }
            //CheckBoxes
            if (checkBoxAMDGE.Checked == true)
            {
                try
                {
                    Process proc = new Process();
                    proc.StartInfo.FileName = @"C:\Program Files (x86)\Raptr\raptrstub.exe";
                    proc.Start();
                }
                catch
                {
                    MessageBox.Show("raptrstub.exe -- NOT FOUND!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
            }
            //CheckBoxes
            if (checkBoxGyazo.Checked == true)
            {
                try
                {
                    Process proc = new Process();
                    proc.StartInfo.FileName = @"C:\Program Files (x86)\Gyazo\GyStation.exe";
                    proc.Start();
                }
                catch
                {
                    MessageBox.Show("GyStation.exe -- NOT FOUND!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
            }
            //CheckBoxes
            if (checkBoxGitHub.Checked == true)
            {
                try
                {
                    Process proc = new Process();
                    proc.StartInfo.FileName = @"D:\Users\Stephen\Desktop\Programs\GitHub.appref-ms";
                    proc.Start();
                }
                catch
                {
                    MessageBox.Show("GitHub -- NOT FOUND!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
            }
            //CheckBoxes
            //
            if (checkBoxChrome.Checked == true)
            {
                try
                {
                    Process proc = new Process();
                    proc.StartInfo.FileName = @"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe";
                    proc.Start();
                }
                catch
                {
                    MessageBox.Show("chrome.exe -- NOT FOUND!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
            }
        }
        //CheckBoxes
        //=======================================================================


        private void timer1_Tick(object sender, EventArgs e)
        {
            milliseconds += timer1.Interval;

            // The timer has reached the double click time limit. 
            if (milliseconds >= SystemInformation.DoubleClickTime)
            {
                timer1.Stop();

                if (isDoubleClick)
                {
                    groupBoxLogic();
                }
                else
                {

                }

                // Allow the MouseDown event handler to process clicks again.
                isFirstClick = true;
                isDoubleClick = false;
                milliseconds = 0;
            }
        }
        private void mouseDown(MouseEventArgs e)
        {
            // This is the first mouse click. 
            if (isFirstClick)
            {
                isFirstClick = false;

                // Determine the location and size of the double click  
                // rectangle area to draw around the cursor point.
                doubleClickRectangle = new Rectangle(
                    e.X - (SystemInformation.DoubleClickSize.Width / 2),
                    e.Y - (SystemInformation.DoubleClickSize.Height / 2),
                    SystemInformation.DoubleClickSize.Width,
                    SystemInformation.DoubleClickSize.Height);
                Invalidate();

                // Start the double click timer.
                timer1.Start();
            }

            // This is the second mouse click. 
            else
            {
                // Verify that the mouse click is within the double click 
                // rectangle and is within the system-defined double  
                // click period. 
                if (doubleClickRectangle.Contains(e.Location) &&
                    milliseconds < SystemInformation.DoubleClickTime)
                {
                    isDoubleClick = true;
                }
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon1.Visible = true;
                this.Hide();
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon1.Visible = false;
            }
        }

        private void RegisterInStartup(bool isChecked)
        {
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey
                    ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (isChecked)
            {
                registryKey.SetValue("ApplicationName", Application.ExecutablePath);
            }
            else
            {
                registryKey.DeleteValue("ApplicationName");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                RegisterInStartup(true);
            }
            else
            {
                RegisterInStartup(false); 
            }
        }
        private void checkBoxDropbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxRazerSynapse_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxSteam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxAMDGE_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxGyazo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxGitHub_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxChrome_CheckedChanged(object sender, EventArgs e)
        {

        }







    }
}
