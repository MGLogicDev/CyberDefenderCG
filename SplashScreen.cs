using System.Drawing.Imaging;
using System.Media;

namespace Cyber_DefenderTCG
{
    public partial class SplashScreen : Form
    {
        private enum SplashState 
        { 
            FadeIn1, 
            Stay1, 
            FadeOut1, 
            FadeIn2, 
            Stay2, 
            FadeOut2, 
            Done 
        }
        private SplashState currentState = SplashState.FadeIn1;

        private System.Windows.Forms.Timer transition = new System.Windows.Forms.Timer();
        private int displayCounter = 0;

        private const int StayDuration = 53;
        private const float FadeDuration = 0.05f;
        private float imageOpacity = 0.0f;

        private Image SplashScreen1 = Properties.Resources.SplashScreen1;
        private Image SplashScreen2 = Properties.Resources.SplashScreen2;
        private SoundPlayer splashSound;

        public SplashScreen()
        {
            InitializeComponent();
            this.Opacity = 1.0f;

            splashSound = new SoundPlayer(Properties.Resources.SplashScreenSound);
            transition.Interval = 30;
            transition.Tick += TransitionTick;
            splashSound.Play();
            transition.Start();
        }

        private void TransitionTick(object sender, EventArgs e)
        {
            switch (currentState)
            {

                case SplashState.FadeIn1:
                    imageOpacity += FadeDuration;
                    if (imageOpacity >= 1)
                    {
                        imageOpacity = 1;
                        currentState = SplashState.Stay1;
                    }
                    break;

                case SplashState.Stay1:
                    displayCounter++;
                    if (displayCounter >= StayDuration)
                    {
                        displayCounter = 0;
                        currentState = SplashState.FadeOut1;
                    }
                    break;

                case SplashState.FadeOut1:
                    imageOpacity -= FadeDuration;
                    if (imageOpacity <= 0)
                    {
                        imageOpacity = 0;
                        currentState = SplashState.FadeIn2;
                    }
                    break;
                case SplashState.FadeIn2:
                    imageOpacity += FadeDuration;
                    if (imageOpacity >= 1)
                    {
                        imageOpacity = 1;
                        currentState = SplashState.Stay2;
                    }
                    break;

                case SplashState.Stay2:
                    displayCounter++;
                    if (displayCounter >= StayDuration)
                    {
                        displayCounter = 0;
                        currentState = SplashState.FadeOut2;
                    }
                    break;

                case SplashState.FadeOut2:
                    imageOpacity -= FadeDuration;
                    if (imageOpacity <= 0)
                    {
                        transition.Stop();
                        this.DialogResult = DialogResult.OK;
                        
                        this.Close();
                        splashSound.Stop();
                    }
                    break;
            }

            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            e.Graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.Half;
            Image currentImg = (currentState <= SplashState.FadeOut1) ? SplashScreen1 : SplashScreen2;

            if (currentImg != null)
            {
                ColorMatrix matrix = new ColorMatrix { Matrix33 = imageOpacity };
                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                float ratio = Math.Min((float)this.Width / currentImg.Width, (float)this.Height / currentImg.Height);
                int newWidth = (int)(currentImg.Width * ratio);
                int newHeight = (int)(currentImg.Height * ratio);
                int posX = (this.Width - newWidth) / 2;
                int posY = (this.Height - newHeight) / 2;

                e.Graphics.DrawImage(currentImg,
                    new Rectangle(posX, posY, newWidth, newHeight),
                    0, 0, currentImg.Width, currentImg.Height,
                    GraphicsUnit.Pixel, attributes);
            }
        }
    }
}
