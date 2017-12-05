using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A2_Courswork
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnThemedParties_Click(object sender, EventArgs e)
        {
            sendToThemedParties();
        }

        private void tSBMM1_Click(object sender, EventArgs e)
        {

        }

        private void tSBTP_Click(object sender, EventArgs e)
        {
            sendToThemedParties();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void tSBTPP1_Click(object sender, EventArgs e)
        {
            sendToThemedParties();
        }

        public void sendToThemedParties()
        {
            ThemedParties TP = new ThemedParties();
            TP.Show();
            this.Hide();
        }

        public void sendToAMM()
        {
            AMMMenu AMM = new AMMMenu();
            AMM.Show();
            this.Hide();
        }

        private void tSBAMM_Click(object sender, EventArgs e)
        {
            sendToAMM();
        }

        private void tSBAMM2_Click(object sender, EventArgs e)
        {
            sendToAMM();
        }

        private void tSBMM1_Click_1(object sender, EventArgs e)
        {

        }

        private void tSBTP_Click_1(object sender, EventArgs e)
        {
            sendToThemedParties();
        }
    }
}
