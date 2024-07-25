using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_cash_management_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            signUpFrm signUp = new signUpFrm();
            signUp.TopLevel = false;
            panelcontent.Controls.Add(signUp);
            signUp.BringToFront();
            signUp.Show();
        }

        private void recExpBtn_Click(object sender, EventArgs e)
        {
            ExpRecFrm exRec = new ExpRecFrm();
            exRec.TopLevel = false;
            panelcontent.Controls.Add(exRec);
            exRec.BringToFront();
            exRec.Show();
        }

        private void recIncBtn_Click(object sender, EventArgs e)
        {
            IncRecFrm incRec = new IncRecFrm();
            incRec.TopLevel = false;
            panelcontent.Controls.Add(incRec);
            incRec.BringToFront();
            incRec.Show();
        }

        private void expCatMasBtn_Click(object sender, EventArgs e)
        {
            ExpCatMastFrm expMas = new ExpCatMastFrm();
            expMas.TopLevel = false;
            panelcontent.Controls.Add(expMas);
            expMas.BringToFront();
            expMas.Show();
        }

        private void incCatMasBtn_Click(object sender, EventArgs e)
        {
            IncCatMastFrm incMas = new IncCatMastFrm();
            incMas.TopLevel = false;
            panelcontent.Controls.Add(incMas);
            incMas.BringToFront();
            incMas.Show();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 home = new Form1();
            home.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close(); 

                LoginFrm lg = new LoginFrm();
                lg.Show();
            }
        }
    }
}
