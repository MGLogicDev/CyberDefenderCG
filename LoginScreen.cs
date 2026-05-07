using Cyber_DefenderTCG.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Media;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Cyber_DefenderTCG
{
    public partial class LoginScreen : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        public LoginScreen()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
            this.Icon = Properties.Resources.CyberDefenderIcon;

        }

        private async void SigningInButton_Click(object sender, EventArgs e)
        {

            AudioManager.PlayClick();
            Rectangle currentBounds = this.DesktopBounds;
            var nextScreen = Program.GlobalSignIn;

            nextScreen.Bounds = currentBounds;
            nextScreen.StartPosition = FormStartPosition.Manual;
            nextScreen.Show();
            nextScreen.Icon = this.Icon;
            nextScreen.Refresh();
            await Task.Delay(100);
            this.Hide();
        }

        private async void SignUpButton_Click(object sender, EventArgs e)
        {
            AudioManager.PlayClick();
            Rectangle currentBounds = this.DesktopBounds;
            var nextScreen = Program.GlobalSignUp;
            nextScreen.Bounds = currentBounds;
            nextScreen.StartPosition = FormStartPosition.Manual;
            nextScreen.Show();
            nextScreen.Icon = this.Icon;
            nextScreen.Refresh();
            await Task.Delay(100);
            this.Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            AudioManager.PlayCancel();
            Application.Exit();
        }

        


    }
}
