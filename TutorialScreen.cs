using Cyber_DefenderTCG.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cyber_DefenderTCG
{
    public partial class TutorialScreen : Form
    {
        private int currentImageIndex = 1;
        private const int TotalImages = 21;

        public TutorialScreen(Rectangle previousBounds)
        {
            InitializeComponent();
            this.Bounds = previousBounds;
            this.StartPosition = FormStartPosition.Manual;

            UpdateDisplay();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            AudioManager.PlayClick();

            if (currentImageIndex < TotalImages)
            {
                currentImageIndex++;
                UpdateDisplay();
            }
            else
            {
                MessageBox.Show("Neural Link training complete.", "DATA UPLINK FINISHED");
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            AudioManager.PlayClick();

            if (currentImageIndex > 1)
            {
                currentImageIndex--;
                UpdateDisplay();
            }
        }

        private void UpdateDisplay()
        {
            string imageName = "T" + currentImageIndex.ToString();

            object resource = Properties.Resources.ResourceManager.GetObject(imageName);

            if (resource != null)
            {
                TutorialPictureBox.Image = (Image)resource;
            }

            BackButton.Enabled = (currentImageIndex > 1);
            NextButton.Text = (currentImageIndex == TotalImages) ? "FINISH" : "NEXT";

            if(currentImageIndex >= TotalImages)
            {
                Program.GlobalMainMenu.Show();
                this.Hide();
            }
        }

        private void ReturnToMenuButton_Click(object sender, EventArgs e)
        {
            AudioManager.PlayCancel();
            Form nextScreen = Program.GlobalMainMenu;
            nextScreen.Bounds = this.DesktopBounds;
            nextScreen.Show();
            this.Hide();
        }
    }
}