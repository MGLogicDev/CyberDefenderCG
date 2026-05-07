using System.Runtime.CompilerServices;
using System.Security.RightsManagement;

namespace Cyber_DefenderTCG.Classes
{
    internal static class Program
    {
        public static LoginScreen GlobalLogin;
        public static SignInScreen GlobalSignIn;
        public static SignUpScreen GlobalSignUp;
        public static MainMenuScreen GlobalMainMenu;
        public static CardsScreen GlobalCards;
        public static NotesScreen GlobalNotes;
        public static StatisticsScreen GlobalStatistics;
        public static SettingsScreen GlobalSettings;
        public static EasyGameScreen GlobalEasyGame;
        public static MediumGameplayScreen GlobalMediumGame;
        public static HardGameplayScreen GlobalHardGame;
        public static EndlessGameScreen GlobalEndlessGame;
        public static AdminLoadingScreen GlobalAdminLoading;
        public static LoadingScreen GlobalLoading;
        public static AdminMainMenu GlobalAdminMainMenu;
        public static ReviewsScreen GlobalReviews;
        public static AnalyticsScreen GlobalAnalytics;
        public static ProfileScreen GlobalProfile;
        public static TutorialScreen GlobalTutorial;


        [STAThread]
        static void Main()
        {
            Application.ThreadException += (s, e) => MessageBox.Show("CRITICAL_ERROR: " + e.Exception.Message);
            AppDomain.CurrentDomain.UnhandledException += (s, e) => MessageBox.Show("SYSTEM_HALT: " + e.ExceptionObject.ToString());
            Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Icon appIcon = Properties.Resources.CyberDefenderIcon;
            Rectangle startBounds = Screen.PrimaryScreen.Bounds;

            GlobalLogin = new LoginScreen();
            GlobalLogin.Icon = appIcon;
            GlobalSignIn = new SignInScreen(startBounds);
            GlobalLogin.Icon = appIcon;
            GlobalSignUp = new SignUpScreen(startBounds);
            GlobalSignUp.Icon = appIcon;

            _ = GlobalLogin.Handle;
            _ = GlobalSignIn.Handle;
            _ = GlobalSignUp.Handle;

            GlobalLogin.Opacity = 0;
            GlobalLogin.Show();

            using (SplashScreen splashScreen = new SplashScreen())
            {
                splashScreen.Owner = GlobalLogin;
                if (splashScreen.ShowDialog() == DialogResult.OK)
                {
                    GlobalLogin.Opacity = 1;
                   
                    Application.Run(GlobalLogin);
                }
                else
                {
                    Application.Exit();
                }
            }
        }
    }
}