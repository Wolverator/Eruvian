using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Eruvian
{
    public partial class MainWindow : Form
    {
        public UserProfile UP;
        public static Thread Adventure = null;

        public MainWindow()
        {
            InitializeComponent();
            UP = new UserProfile();

            UP.GoldUpdate += UpdateGold;

            UP.Gold += 200;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            Adventure = new Thread(Adventures.Start);
            Adventure.Priority = ThreadPriority.Normal;
            Adventure.IsBackground = true;
            Adventure.Start();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {

        }

        public static void WriteLog(string s)
        {
            Program.MW.LogTextBox.Text = DateTime.Now.ToLongTimeString() + " | " + s + "\n" + Program.MW.LogTextBox.Text;
        }
        private void UpdateGold()
        {
            label1.Text = UP.Gold.ToString();
        }
    }
}
