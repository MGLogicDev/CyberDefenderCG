using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cyber_DefenderTCG.Classes
{
    internal class AnomalyManager
    {
        private Form gameScreen;
        private System.Windows.Forms.Timer anomalyTimer;
        private System.Windows.Forms.Timer drainTimer;
        private Random random = new Random();

        public bool RansomwareActive { get; private set; }

        public AnomalyManager(Form targetScreen)
        {
            this.gameScreen = targetScreen;
            anomalyTimer = new System.Windows.Forms.Timer();
            drainTimer = new System.Windows.Forms.Timer();
        }

        public void StopAllAnomalies()
        {
            anomalyTimer.Stop();
            drainTimer.Stop();
            anomalyTimer.Tick -= Flicker_Tick;
            drainTimer.Tick -= Drain_Tick;

            drainCallback = null; 
            RansomwareActive = false;
            gameScreen.Enabled = true;

            ResetUIEffects();
        }

        private void ResetUIEffects()
        {
            SetControlVisibility("ThreatCardNameLabel", true);
            SetControlVisibility("DescriptionLabel", true);
            SetControlVisibility("StoryLabel", true);

            foreach (var panel in gameScreen.Controls.OfType<Panel>().Where(p => p.Name.Contains("CardContainer")))
            {
                panel.Visible = true;
                foreach (Control child in panel.Controls) child.Visible = true;
            }
        }

        private void SetControlVisibility(string name, bool visible)
        {
            var control = gameScreen.Controls.Find(name, true).FirstOrDefault();
            if (control != null) control.Visible = visible;
        }

        public void ExecuteAnomaly(Anomaly anomaly, string difficulty, Action onHealthDrain)
        {
            StopAllAnomalies();
            if (anomaly == null) return;

            switch (anomaly.Name)
            {
                case "Memory Leak": StartMemoryLeak(onHealthDrain); break;
                case "Encrypted Uplink": ScrambleAllLabels(); break;
                case "Ransomware": ApplyRansomware(); break;
                
                
            }
        }


        private void Flicker_Tick(object sender, EventArgs e)
        {
            for (int i = 1; i <= 5; i++)
            {
                var lbl = gameScreen.Controls.Find($"CardLabel{i}", true).FirstOrDefault() as Label;
                var pbox = gameScreen.Controls.Find($"CardPbox{i}", true).FirstOrDefault() as PictureBox;

                if (lbl != null)
                {
                    lbl.ForeColor = (lbl.ForeColor == Color.White) ? Color.FromArgb(20, 20, 20) : Color.White;
                }

                if (pbox != null)
                {
                    if (pbox.Parent is Panel container)
                    {
                        container.BackColor = (container.BackColor == Color.Black) ? Color.HotPink : Color.Black;
                    }
                }
            }
        }

        private Action drainCallback;
       
        private void StartMemoryLeak(Action onHealthDrain)
        {
            drainCallback = onHealthDrain;
            drainTimer.Interval = 1000;
            drainTimer.Tick -= Drain_Tick;
            drainTimer.Tick += Drain_Tick;

            drainTimer.Start();
        }
        private void Drain_Tick(object sender, EventArgs e)
        {
            if (drainCallback != null)
            {
                drainCallback.Invoke();
            }
        }

        private void ScrambleAllLabels()
        {
            string glitch = "§$#!@&*";
            for (int i = 1; i <= 5; i++)
            {
                var lbl = gameScreen.Controls.Find($"CardLabel{i}", true).FirstOrDefault() as Label;
                if (lbl != null) lbl.Text = glitch;
            }
            var tLbl = gameScreen.Controls.Find("ThreatCardNameLabel", true).FirstOrDefault() as Label;
            if (tLbl != null) tLbl.Text = glitch;
        }

        private void ApplyRansomware()
        {
            RansomwareActive = true;
            SetControlVisibility("ThreatCardNameLabel", false);
            SetControlVisibility("DescriptionLabel", false);
            SetControlVisibility("StoryLabel", false);
        }

    }
}