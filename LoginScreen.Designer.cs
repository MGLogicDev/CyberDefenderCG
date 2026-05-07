namespace Cyber_DefenderTCG
{
    partial class LoginScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            SigningInButton = new Krypton.Toolkit.KryptonButton();
            SignUpButton = new Krypton.Toolkit.KryptonButton();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            pictureBox2 = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 2);
            tableLayoutPanel1.Controls.Add(pictureBox2, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.Size = new Size(1248, 661);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel2.Controls.Add(SigningInButton, 1, 1);
            tableLayoutPanel2.Controls.Add(SignUpButton, 1, 3);
            tableLayoutPanel2.Controls.Add(kryptonButton1, 1, 5);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(252, 234);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 7;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Size = new Size(742, 390);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // SigningInButton
            // 
            SigningInButton.Dock = DockStyle.Fill;
            SigningInButton.Location = new Point(114, 90);
            SigningInButton.Name = "SigningInButton";
            SigningInButton.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Black;
            SigningInButton.Size = new Size(513, 52);
            SigningInButton.StateNormal.Back.Color1 = Color.DarkOrange;
            SigningInButton.StateNormal.Back.Color2 = Color.DarkOrange;
            SigningInButton.StateNormal.Back.Image = Properties.Resources.ButtonBG;
            SigningInButton.StateNormal.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            SigningInButton.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            SigningInButton.StateNormal.Border.Rounding = 7F;
            SigningInButton.StateNormal.Content.ShortText.Color1 = Color.White;
            SigningInButton.StateNormal.Content.ShortText.Color2 = Color.White;
            SigningInButton.StateNormal.Content.ShortText.Font = new Font("OCR A Extended", 30.25F, FontStyle.Bold);
            SigningInButton.StatePressed.Back.Color1 = Color.DarkOrange;
            SigningInButton.StatePressed.Back.Color2 = Color.DarkOrange;
            SigningInButton.StatePressed.Back.Image = Properties.Resources.ButtonBG;
            SigningInButton.StatePressed.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            SigningInButton.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            SigningInButton.StatePressed.Border.Rounding = 7F;
            SigningInButton.StatePressed.Content.ShortText.Color1 = Color.White;
            SigningInButton.StatePressed.Content.ShortText.Color2 = Color.White;
            SigningInButton.StatePressed.Content.ShortText.Font = new Font("OCR A Extended", 30.25F, FontStyle.Bold);
            SigningInButton.StateTracking.Back.Color1 = Color.DarkOrange;
            SigningInButton.StateTracking.Back.Color2 = Color.DarkOrange;
            SigningInButton.StateTracking.Back.Image = Properties.Resources.ButtonBG;
            SigningInButton.StateTracking.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            SigningInButton.StateTracking.Border.Color1 = Color.Cyan;
            SigningInButton.StateTracking.Border.Color2 = Color.Cyan;
            SigningInButton.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            SigningInButton.StateTracking.Border.Rounding = 7F;
            SigningInButton.StateTracking.Border.Width = 3;
            SigningInButton.StateTracking.Content.ShortText.Color1 = Color.White;
            SigningInButton.StateTracking.Content.ShortText.Color2 = Color.White;
            SigningInButton.StateTracking.Content.ShortText.Font = new Font("OCR A Extended", 30.25F, FontStyle.Bold);
            SigningInButton.TabIndex = 4;
            SigningInButton.Values.DropDownArrowColor = Color.Empty;
            SigningInButton.Values.Text = "Sign In";
            SigningInButton.Click += SigningInButton_Click;
            // 
            // SignUpButton
            // 
            SignUpButton.Dock = DockStyle.Fill;
            SignUpButton.Location = new Point(114, 168);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Black;
            SignUpButton.Size = new Size(513, 52);
            SignUpButton.StateNormal.Back.Color1 = Color.DarkOrange;
            SignUpButton.StateNormal.Back.Color2 = Color.DarkOrange;
            SignUpButton.StateNormal.Back.Image = Properties.Resources.ButtonBG;
            SignUpButton.StateNormal.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            SignUpButton.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            SignUpButton.StateNormal.Border.Rounding = 7F;
            SignUpButton.StateNormal.Content.ShortText.Color1 = Color.White;
            SignUpButton.StateNormal.Content.ShortText.Color2 = Color.White;
            SignUpButton.StateNormal.Content.ShortText.Font = new Font("OCR A Extended", 30.25F, FontStyle.Bold);
            SignUpButton.StatePressed.Back.Color1 = Color.DarkOrange;
            SignUpButton.StatePressed.Back.Color2 = Color.DarkOrange;
            SignUpButton.StatePressed.Back.Image = Properties.Resources.ButtonBG;
            SignUpButton.StatePressed.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            SignUpButton.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            SignUpButton.StatePressed.Border.Rounding = 7F;
            SignUpButton.StatePressed.Content.ShortText.Color1 = Color.White;
            SignUpButton.StatePressed.Content.ShortText.Color2 = Color.White;
            SignUpButton.StatePressed.Content.ShortText.Font = new Font("OCR A Extended", 30.25F, FontStyle.Bold);
            SignUpButton.StateTracking.Back.Color1 = Color.DarkOrange;
            SignUpButton.StateTracking.Back.Color2 = Color.DarkOrange;
            SignUpButton.StateTracking.Back.Image = Properties.Resources.ButtonBG;
            SignUpButton.StateTracking.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            SignUpButton.StateTracking.Border.Color1 = Color.Cyan;
            SignUpButton.StateTracking.Border.Color2 = Color.Cyan;
            SignUpButton.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            SignUpButton.StateTracking.Border.Rounding = 7F;
            SignUpButton.StateTracking.Border.Width = 3;
            SignUpButton.StateTracking.Content.ShortText.Color1 = Color.White;
            SignUpButton.StateTracking.Content.ShortText.Color2 = Color.White;
            SignUpButton.StateTracking.Content.ShortText.Font = new Font("OCR A Extended", 30.25F, FontStyle.Bold);
            SignUpButton.TabIndex = 5;
            SignUpButton.Values.DropDownArrowColor = Color.Empty;
            SignUpButton.Values.Text = "Sign Up";
            SignUpButton.Click += SignUpButton_Click;
            // 
            // kryptonButton1
            // 
            kryptonButton1.Dock = DockStyle.Fill;
            kryptonButton1.Location = new Point(114, 246);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Black;
            kryptonButton1.Size = new Size(513, 52);
            kryptonButton1.StateNormal.Back.Color1 = Color.DarkOrange;
            kryptonButton1.StateNormal.Back.Color2 = Color.DarkOrange;
            kryptonButton1.StateNormal.Back.Image = Properties.Resources.ButtonBG;
            kryptonButton1.StateNormal.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            kryptonButton1.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            kryptonButton1.StateNormal.Border.Rounding = 7F;
            kryptonButton1.StateNormal.Content.ShortText.Color1 = Color.White;
            kryptonButton1.StateNormal.Content.ShortText.Color2 = Color.White;
            kryptonButton1.StateNormal.Content.ShortText.Font = new Font("OCR A Extended", 30.25F, FontStyle.Bold);
            kryptonButton1.StatePressed.Back.Color1 = Color.DarkOrange;
            kryptonButton1.StatePressed.Back.Color2 = Color.DarkOrange;
            kryptonButton1.StatePressed.Back.Image = Properties.Resources.ButtonBG;
            kryptonButton1.StatePressed.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            kryptonButton1.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            kryptonButton1.StatePressed.Border.Rounding = 7F;
            kryptonButton1.StatePressed.Content.ShortText.Color1 = Color.White;
            kryptonButton1.StatePressed.Content.ShortText.Color2 = Color.White;
            kryptonButton1.StatePressed.Content.ShortText.Font = new Font("OCR A Extended", 30.25F, FontStyle.Bold);
            kryptonButton1.StateTracking.Back.Color1 = Color.DarkOrange;
            kryptonButton1.StateTracking.Back.Color2 = Color.DarkOrange;
            kryptonButton1.StateTracking.Back.Image = Properties.Resources.ButtonBG;
            kryptonButton1.StateTracking.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            kryptonButton1.StateTracking.Border.Color1 = Color.Cyan;
            kryptonButton1.StateTracking.Border.Color2 = Color.Cyan;
            kryptonButton1.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            kryptonButton1.StateTracking.Border.Rounding = 7F;
            kryptonButton1.StateTracking.Border.Width = 3;
            kryptonButton1.StateTracking.Content.ShortText.Color1 = Color.White;
            kryptonButton1.StateTracking.Content.ShortText.Color2 = Color.White;
            kryptonButton1.StateTracking.Content.ShortText.Font = new Font("OCR A Extended", 30.25F, FontStyle.Bold);
            kryptonButton1.TabIndex = 6;
            kryptonButton1.Values.DropDownArrowColor = Color.Empty;
            kryptonButton1.Values.Text = "Exit";
            kryptonButton1.Click += ExitButton_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = Properties.Resources.Banner_png_no_bg;
            pictureBox2.Location = new Point(252, 36);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(742, 192);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            BackgroundImage = Properties.Resources.LoginScreenBg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1248, 661);
            Controls.Add(tableLayoutPanel1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(900, 700);
            Name = "LoginScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cyber Defender";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button SignInButton;
        private PictureBox pictureBox2;
        private Krypton.Toolkit.KryptonButton SigningInButton;
        private Krypton.Toolkit.KryptonButton SignUpButton;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
    }
}