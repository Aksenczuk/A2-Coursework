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
    public partial class ThemedParties : Form
    {
        public ThemedParties()
        {
            InitializeComponent();
        }

        private void ThemedParties_Load(object sender, EventArgs e)
        {

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

        public void sendToMainMenu()
        {
            MainMenu MM = new MainMenu();
            MM.Show();
            this.Hide();
        }

        private void btnAMM_Click(object sender, EventArgs e)
        {
            sendToAMM();
        }

        private void tSBTP_Click(object sender, EventArgs e)
        {
            sendToThemedParties();
        }

        private void tSBTPP1_Click(object sender, EventArgs e)
        {
            sendToThemedParties();
        }

        private void tSBAMM_Click(object sender, EventArgs e)
        {
            sendToAMM();
        }

        private void tSBAMM2_Click(object sender, EventArgs e)
        {
            sendToAMM();
        }

        private void tSBMM1_Click(object sender, EventArgs e)
        {
            sendToMainMenu();
        }
    }
}
