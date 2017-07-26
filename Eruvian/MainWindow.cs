using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eruvian
{
    public partial class MainWindow : Form
    {
        public UserProfile UP;
        public MainWindow()
        {
            InitializeComponent();
            UP = new UserProfile();

            UP.GoldUpdate += UpdateGold;

            UP.Gold += 200;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            UP.Gold += 500;
        }

        private void UpdateGold()
        {
            label1.Text = UP.Gold.ToString();
        }
    }
}
