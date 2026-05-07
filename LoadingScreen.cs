using Cyber_DefenderTCG.Classes;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cyber_DefenderTCG
{
    public partial class LoadingScreen : Form
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
        private User authenticatedUser;

        public LoadingScreen(Rectangle previousBounds, User user)
        {
            InitializeComponent();
            this.authenticatedUser = user;
            this.StartPosition = FormStartPosition.Manual;
            this.Bounds = previousBounds;

            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();
        }

        private async void LoadingScreen_Load(object sender, EventArgs e)
        {
            try
            {

                Icon appIcon = Properties.Resources.CyberDefenderIcon;
                
                

                await AnimateProgress(20, "Loading Audio Assets...");
                AudioManager.LoadAllSounds();
                AudioManager.PlayBGMusic();

                await AnimateProgress(40, "Building Menu...");
                Program.GlobalMainMenu = new MainMenuScreen(this.DesktopBounds, authenticatedUser);
                Program.GlobalMainMenu.Icon = appIcon;
                _ = Program.GlobalMainMenu.Handle;

                await AnimateProgress(60, "Loading Statistics...");
                Program.GlobalStatistics = new StatisticsScreen(this.DesktopBounds, authenticatedUser);
                Program.GlobalStatistics.Icon = appIcon;
                _ = Program.GlobalStatistics.Handle;

                await AnimateProgress(65, "Loading Cards...");
                Program.GlobalCards = new CardsScreen(this.DesktopBounds, authenticatedUser);
                Program.GlobalCards.Icon = appIcon;
                _ = Program.GlobalCards.Handle;
               
                await AnimateProgress(70, "Loading Notes...");
                Program.GlobalNotes = new NotesScreen(this.DesktopBounds, authenticatedUser);
                Program.GlobalNotes.Icon = appIcon;
                _ = Program.GlobalNotes.Handle;

                await AnimateProgress(75, "Loading Profile...");
                Program.GlobalProfile = new ProfileScreen(this.DesktopBounds, authenticatedUser);
                Program.GlobalProfile.Icon = appIcon;
                _ = Program.GlobalProfile.Handle;


                await AnimateProgress(80, "Finalizing...");
                Program.GlobalSettings = new SettingsScreen( authenticatedUser);
                Program.GlobalTutorial = new TutorialScreen(this.DesktopBounds);
                Program.GlobalSettings.Icon = appIcon;
                Program.GlobalTutorial.Icon = appIcon;
                _ = Program.GlobalSettings.Handle;
                _ = Program.GlobalTutorial.Handle;

                await AnimateProgress(100, "Welcome Agent " + authenticatedUser.Username);
                Helper dbHelper = new Helper();
                if (dbHelper.IsNewAgent(authenticatedUser.UserID))
                {
                    await Task.Delay(500);
                    Program.GlobalTutorial = new TutorialScreen(this.DesktopBounds);
                    Program.GlobalTutorial.Show();
                    this.Hide();

                }
                else
                {
                    await Task.Delay(500);
                    Program.GlobalMainMenu.Show();
                    this.Hide();
                }


                
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during loading: " + ex.Message, "Loading Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

  
        private async Task AnimateProgress(int targetValue, string status, int speed = 15)
        {
            StatusLabel.Text = status;

            while (LoadingPBar.ValueNumber < targetValue)
            {

                LoadingPBar.ValueNumber++;
                await Task.Delay(speed);
            }
        }
    }
}