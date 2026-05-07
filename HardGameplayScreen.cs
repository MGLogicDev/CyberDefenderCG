using Cyber_DefenderTCG.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace Cyber_DefenderTCG
{
    public partial class HardGameplayScreen : Form
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
        private GameEngine GameEngine;
        Helper helper = new Helper();
        private AnomalyManager anomalyManager;
        public HardGameplayScreen(Rectangle previousBounds, User activeUser)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Bounds = previousBounds;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);

            GameEngine = new GameEngine(activeUser);
            GameEngine.SetDifficulty("hard");

            anomalyManager = new AnomalyManager(this);
            StartNewRound();
        }

        private void StartNewRound()
        {
            GameEngine.DrawHand();
            GameEngine.RollAnomaly();
            UpdateUI();

            anomalyManager.ExecuteAnomaly(GameEngine.CurrentAnomaly, GameEngine.selectedDifficulty, () =>
            {
                int drain = (GameEngine.selectedDifficulty == "easy") ? 1 : 2;
                GameEngine.ModifyHealth(-drain); // Use the new method
                HPLabel.Text = $"{GameEngine.Health}%";
                HealthBar.Value = Math.Max(0, GameEngine.Health);
                if (GameEngine.Health <= 0) CheckMatchStatus();
            });

            if (GameEngine.CurrentAnomaly != null)
            {
                TipsLabel.Text = $"⚠ ANOMALY DETECTED: {GameEngine.CurrentAnomaly.Name}";
                TipsLabel.ForeColor = Color.Yellow;
            }
            else
            {
                TipsLabel.Text = "System Stable...";
                TipsLabel.ForeColor = Color.Cyan;
            }
        }


        private void UpdateUI()
        {
            ThreatCardNameLabel.Text = GameEngine.CurrentThreat.CardName;
            string key = GameEngine.CurrentThreat.ImageKey;
            object resource = Properties.Resources.ResourceManager.GetObject(key);

            if (resource != null)
            {
                ThreatCardPbox.Image = (Image)resource;
            }
            else
            {
                ThreatCardPbox.Image = Properties.Resources.CyberDefenderIiconImage_png;
            }

            HPLabel.Text = $"{GameEngine.Health}%";
            HealthBar.Value = GameEngine.Health;
            ThreatDefendedLabel.Text = $"{GameEngine.CorrectCount} / {GameEngine.TargetSuccesses}";
            DescriptionLabel.Text = GameEngine.CurrentThreat.Description;



            for (int i = 0; i < GameEngine.CurrentHand.Count; i++)
            {
                Panel cardPanel = this.Controls.Find($"CardContainer{i + 1}", true).FirstOrDefault() as Panel;

                if (cardPanel != null)
                {
                    DefenseCard card = GameEngine.CurrentHand[i];

                    Label lbl = cardPanel.Controls.Find($"CardLabel{i + 1}", true).FirstOrDefault() as Label;
                    if (lbl != null) lbl.Text = card.CardName;

                    PictureBox pbx = cardPanel.Controls.Find($"CardPbox{i + 1}", true).FirstOrDefault() as PictureBox;
                    if (pbx != null)
                    {
                        object imgResource = Properties.Resources.ResourceManager.GetObject(card.ImageKey);

                        if (imgResource != null)
                        {
                            pbx.Image = (Image)imgResource;
                        }
                        else
                        {
                            pbx.Image = Properties.Resources.CyberDefenderIiconImage_png;
                        }

                        pbx.Tag = card;
                    }
                    cardPanel.Tag = card;
                    if (lbl != null) lbl.Tag = card;
                }
            }
        }
        private void DefenseCard_Click(object sender, EventArgs e)
        {

            anomalyManager.StopAllAnomalies();
            Control clicked = (Control)sender;
            DefenseCard selected = clicked.Tag as DefenseCard;

            bool isCorrect = GameEngine.VerifyChoice(selected);

            if (isCorrect) AudioManager.PlayCorrect();
            else AudioManager.PlayIncorrect();
            DefenseCard correctCard = GameEngine.CurrentHand.FirstOrDefault(c => c.CardID == GameEngine.CurrentThreat.CounterID);

            ShowCounterPopup(isCorrect, correctCard, GameEngine.CurrentThreat.CounterReason);
            CheckMatchStatus();
        }
        private void ShowCounterPopup(bool wasCorrect, DefenseCard counter, string reason)
        {
            Image cardImg = Properties.Resources.CyberDefenderIiconImage_png;
            if (counter != null && !string.IsNullOrEmpty(counter.ImageKey))
            {
                object res = Properties.Resources.ResourceManager.GetObject(counter.ImageKey);
                if (res != null) cardImg = (Image)res;
            }

            TaskDialogPage page = new TaskDialogPage()
            {
                Caption = "Cyber Defender Intelligence",
                Heading = wasCorrect ? "✅ Correct Defense!" : "❌ Security Breach!",
                Text = $"The correct counter was: **{counter?.CardName}**\n\n{reason}",
                Icon = wasCorrect ? TaskDialogIcon.ShieldSuccessGreenBar : TaskDialogIcon.ShieldErrorRedBar,
                Buttons = { TaskDialogButton.OK }
            };

            page.Footnote = new TaskDialogFootnote()
            {
                Text = $"Analyzing Threat ID: {GameEngine.CurrentThreat.CardID}"
            };

            TaskDialog.ShowDialog(this, page);
        }
        private void CheckMatchStatus()
        {
            anomalyManager.StopAllAnomalies();

            if (GameEngine.Health <= 0)
            {
                GameEngine.MatchID = helper.EndGame(false, GameEngine.CurrentUser.UserID, GameEngine.selectedDifficulty, GameEngine.CorrectCount, GameEngine.WrongCount, GameEngine.Health);

                ResultScreen result = new ResultScreen(this.Bounds, GameEngine, false);
                result.Show();

                this.Hide();
                return;
            }

            int roundsPlayed = GameEngine.CorrectCount + GameEngine.WrongCount;

            if (GameEngine.TargetSuccesses < 9000 && roundsPlayed >= GameEngine.TargetSuccesses)
            {
                GameEngine.MatchID = helper.EndGame(true, GameEngine.CurrentUser.UserID, GameEngine.selectedDifficulty, GameEngine.CorrectCount, GameEngine.WrongCount, GameEngine.Health);
                ResultScreen result = new ResultScreen(this.Bounds, GameEngine, true);
                result.Show();
                this.Hide();
                return;
            }

            StartNewRound();
        }


        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {

            TipsLabel.Text = "Double click CyD The Robot, he knows stuff";
        }
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            TipsLabel.Text = "";
            StoryLabel.Text = "";
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            if (GameEngine != null && GameEngine.CurrentThreat != null)
            {
                AudioManager.PlayClick();
                StoryLabel.Text = GameEngine.CurrentThreat.Story;
            }
        }

        private void ForfeitButton_Click(object sender, EventArgs e)
        {
            AudioManager.PlayCancel();
            DialogResult confirmResult = MessageBox.Show("Are you sure you want to forfeit? Your progress will be lost.", "Confirm Forfeit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                GameEngine.MatchID = helper.EndGame(false, GameEngine.CurrentUser.UserID, GameEngine.selectedDifficulty, GameEngine.CorrectCount, GameEngine.WrongCount, GameEngine.Health);
                ResultScreen resultScreen = new ResultScreen(this.Bounds, GameEngine, false);
                resultScreen.SetForfeit();
                resultScreen.Show();
                resultScreen.Refresh();
                this.Hide();
            }
        }
    }
}
