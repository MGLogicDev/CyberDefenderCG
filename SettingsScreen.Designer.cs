namespace Cyber_DefenderTCG
{
    partial class SettingsScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsScreen));
            tableLayoutPanel1 = new TableLayoutPanel();
            CloseButton = new Krypton.Toolkit.KryptonButton();
            tableLayoutPanel2 = new TableLayoutPanel();
            MusicTrackBar = new ReaLTaiizor.Controls.MetroTrackBar();
            label4 = new Label();
            label1 = new Label();
            MasterTrackBar = new ReaLTaiizor.Controls.MetroTrackBar();
            tableLayoutPanel3 = new TableLayoutPanel();
            TutorialButton = new Krypton.Toolkit.KryptonButton();
            kryptonButton2 = new Krypton.Toolkit.KryptonButton();
            LogOutButton = new Krypton.Toolkit.KryptonButton();
            kryptonButton3 = new Krypton.Toolkit.KryptonButton();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.51948071F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 94.48052F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(CloseButton, 2, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 38.56209F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 61.43791F));
            tableLayoutPanel1.Size = new Size(776, 456);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // CloseButton
            // 
            CloseButton.Dock = DockStyle.Fill;
            CloseButton.Location = new Point(733, 3);
            CloseButton.Name = "CloseButton";
            CloseButton.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Black;
            CloseButton.Size = new Size(40, 36);
            CloseButton.StateNormal.Back.Color1 = Color.DarkOrange;
            CloseButton.StateNormal.Back.Color2 = Color.DarkOrange;
            CloseButton.StateNormal.Back.Image = Properties.Resources.ButtonBG;
            CloseButton.StateNormal.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            CloseButton.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            CloseButton.StateNormal.Border.Rounding = 7F;
            CloseButton.StateNormal.Content.ShortText.Color1 = Color.White;
            CloseButton.StateNormal.Content.ShortText.Color2 = Color.White;
            CloseButton.StateNormal.Content.ShortText.Font = new Font("OCR A Extended", 20.25F, FontStyle.Bold);
            CloseButton.StatePressed.Back.Color1 = Color.DarkOrange;
            CloseButton.StatePressed.Back.Color2 = Color.DarkOrange;
            CloseButton.StatePressed.Back.Image = Properties.Resources.ButtonBG;
            CloseButton.StatePressed.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            CloseButton.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            CloseButton.StatePressed.Border.Rounding = 7F;
            CloseButton.StatePressed.Content.ShortText.Color1 = Color.White;
            CloseButton.StatePressed.Content.ShortText.Color2 = Color.White;
            CloseButton.StatePressed.Content.ShortText.Font = new Font("OCR A Extended", 20.25F, FontStyle.Bold);
            CloseButton.StateTracking.Back.Color1 = Color.DarkOrange;
            CloseButton.StateTracking.Back.Color2 = Color.DarkOrange;
            CloseButton.StateTracking.Back.Image = Properties.Resources.ButtonBG;
            CloseButton.StateTracking.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            CloseButton.StateTracking.Border.Color1 = Color.Cyan;
            CloseButton.StateTracking.Border.Color2 = Color.Cyan;
            CloseButton.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            CloseButton.StateTracking.Border.Rounding = 7F;
            CloseButton.StateTracking.Border.Width = 3;
            CloseButton.StateTracking.Content.ShortText.Color1 = Color.White;
            CloseButton.StateTracking.Content.ShortText.Color2 = Color.White;
            CloseButton.StateTracking.Content.ShortText.Font = new Font("OCR A Extended", 20.25F, FontStyle.Bold);
            CloseButton.TabIndex = 10;
            CloseButton.Values.DropDownArrowColor = Color.Empty;
            CloseButton.Values.Text = "X ";
            CloseButton.Click += CloseButton_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.28571F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.42857F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel2.Controls.Add(MusicTrackBar, 1, 3);
            tableLayoutPanel2.Controls.Add(label4, 1, 4);
            tableLayoutPanel2.Controls.Add(label1, 1, 2);
            tableLayoutPanel2.Controls.Add(MasterTrackBar, 1, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(43, 45);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 6;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Size = new Size(684, 153);
            tableLayoutPanel2.TabIndex = 11;
            // 
            // MusicTrackBar
            // 
            MusicTrackBar.BackgroundColor = Color.FromArgb(205, 205, 205);
            MusicTrackBar.DisabledBackColor = Color.FromArgb(235, 235, 235);
            MusicTrackBar.DisabledBorderColor = Color.Empty;
            MusicTrackBar.DisabledHandlerColor = Color.FromArgb(196, 196, 196);
            MusicTrackBar.DisabledValueColor = Color.FromArgb(205, 205, 205);
            MusicTrackBar.Dock = DockStyle.Fill;
            MusicTrackBar.HandlerColor = Color.FromArgb(180, 180, 180);
            MusicTrackBar.IsDerivedStyle = true;
            MusicTrackBar.Location = new Point(100, 87);
            MusicTrackBar.Maximum = 100;
            MusicTrackBar.Minimum = 0;
            MusicTrackBar.Name = "MusicTrackBar";
            MusicTrackBar.Size = new Size(482, 16);
            MusicTrackBar.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            MusicTrackBar.StyleManager = null;
            MusicTrackBar.TabIndex = 11;
            MusicTrackBar.Text = "metroTrackBar2";
            MusicTrackBar.ThemeAuthor = "Taiizor";
            MusicTrackBar.ThemeName = "MetroLight";
            MusicTrackBar.Value = 0;
            MusicTrackBar.ValueColor = Color.FromArgb(65, 177, 225);
            MusicTrackBar.Scroll += MusicTrackBar_Scroll_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("OCR A Extended", 9F, FontStyle.Bold);
            label4.ForeColor = Color.Aqua;
            label4.Location = new Point(97, 108);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(488, 20);
            label4.TabIndex = 9;
            label4.Text = "Background Music Volume";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("OCR A Extended", 9F, FontStyle.Bold);
            label1.ForeColor = Color.Aqua;
            label1.Location = new Point(97, 64);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(488, 20);
            label1.TabIndex = 7;
            label1.Text = "Master Volume";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MasterTrackBar
            // 
            MasterTrackBar.BackgroundColor = Color.FromArgb(205, 205, 205);
            MasterTrackBar.DisabledBackColor = Color.FromArgb(235, 235, 235);
            MasterTrackBar.DisabledBorderColor = Color.Empty;
            MasterTrackBar.DisabledHandlerColor = Color.FromArgb(196, 196, 196);
            MasterTrackBar.DisabledValueColor = Color.FromArgb(205, 205, 205);
            MasterTrackBar.Dock = DockStyle.Fill;
            MasterTrackBar.HandlerColor = Color.FromArgb(180, 180, 180);
            MasterTrackBar.IsDerivedStyle = true;
            MasterTrackBar.Location = new Point(100, 43);
            MasterTrackBar.Maximum = 100;
            MasterTrackBar.Minimum = 0;
            MasterTrackBar.Name = "MasterTrackBar";
            MasterTrackBar.Size = new Size(482, 16);
            MasterTrackBar.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            MasterTrackBar.StyleManager = null;
            MasterTrackBar.TabIndex = 10;
            MasterTrackBar.Text = "metroTrackBar1";
            MasterTrackBar.ThemeAuthor = "Taiizor";
            MasterTrackBar.ThemeName = "MetroLight";
            MasterTrackBar.Value = 0;
            MasterTrackBar.ValueColor = Color.FromArgb(65, 177, 225);
            MasterTrackBar.Scroll += MasterTrackBar_Scroll;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel3.Controls.Add(TutorialButton, 2, 1);
            tableLayoutPanel3.Controls.Add(kryptonButton2, 2, 0);
            tableLayoutPanel3.Controls.Add(LogOutButton, 1, 0);
            tableLayoutPanel3.Controls.Add(kryptonButton3, 1, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(43, 204);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 26.3736267F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25.274725F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 48.0663F));
            tableLayoutPanel3.Size = new Size(684, 249);
            tableLayoutPanel3.TabIndex = 12;
            // 
            // TutorialButton
            // 
            TutorialButton.Dock = DockStyle.Fill;
            TutorialButton.Location = new Point(344, 68);
            TutorialButton.Name = "TutorialButton";
            TutorialButton.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Black;
            TutorialButton.Size = new Size(250, 57);
            TutorialButton.StateNormal.Back.Color1 = Color.DarkOrange;
            TutorialButton.StateNormal.Back.Color2 = Color.DarkOrange;
            TutorialButton.StateNormal.Back.Image = Properties.Resources.ButtonBG;
            TutorialButton.StateNormal.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            TutorialButton.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            TutorialButton.StateNormal.Border.Rounding = 7F;
            TutorialButton.StateNormal.Content.ShortText.Color1 = Color.White;
            TutorialButton.StateNormal.Content.ShortText.Color2 = Color.White;
            TutorialButton.StateNormal.Content.ShortText.Font = new Font("OCR A Extended", 17F, FontStyle.Bold);
            TutorialButton.StatePressed.Back.Color1 = Color.DarkOrange;
            TutorialButton.StatePressed.Back.Color2 = Color.DarkOrange;
            TutorialButton.StatePressed.Back.Image = Properties.Resources.ButtonBG;
            TutorialButton.StatePressed.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            TutorialButton.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            TutorialButton.StatePressed.Border.Rounding = 7F;
            TutorialButton.StatePressed.Content.ShortText.Color1 = Color.White;
            TutorialButton.StatePressed.Content.ShortText.Color2 = Color.White;
            TutorialButton.StatePressed.Content.ShortText.Font = new Font("OCR A Extended", 17F, FontStyle.Bold);
            TutorialButton.StateTracking.Back.Color1 = Color.DarkOrange;
            TutorialButton.StateTracking.Back.Color2 = Color.DarkOrange;
            TutorialButton.StateTracking.Back.Image = Properties.Resources.ButtonBG;
            TutorialButton.StateTracking.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            TutorialButton.StateTracking.Border.Color1 = Color.Cyan;
            TutorialButton.StateTracking.Border.Color2 = Color.Cyan;
            TutorialButton.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            TutorialButton.StateTracking.Border.Rounding = 7F;
            TutorialButton.StateTracking.Border.Width = 3;
            TutorialButton.StateTracking.Content.ShortText.Color1 = Color.White;
            TutorialButton.StateTracking.Content.ShortText.Color2 = Color.White;
            TutorialButton.StateTracking.Content.ShortText.Font = new Font("OCR A Extended", 17F, FontStyle.Bold);
            TutorialButton.TabIndex = 25;
            TutorialButton.Values.DropDownArrowColor = Color.Empty;
            TutorialButton.Values.Text = "Tutorial";
            TutorialButton.Click += TutorialButton_Click;
            // 
            // kryptonButton2
            // 
            kryptonButton2.Dock = DockStyle.Fill;
            kryptonButton2.Location = new Point(344, 3);
            kryptonButton2.Name = "kryptonButton2";
            kryptonButton2.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Black;
            kryptonButton2.Size = new Size(250, 59);
            kryptonButton2.StateNormal.Back.Color1 = Color.DarkOrange;
            kryptonButton2.StateNormal.Back.Color2 = Color.DarkOrange;
            kryptonButton2.StateNormal.Back.Image = Properties.Resources.ButtonBG;
            kryptonButton2.StateNormal.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            kryptonButton2.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            kryptonButton2.StateNormal.Border.Rounding = 7F;
            kryptonButton2.StateNormal.Content.ShortText.Color1 = Color.White;
            kryptonButton2.StateNormal.Content.ShortText.Color2 = Color.White;
            kryptonButton2.StateNormal.Content.ShortText.Font = new Font("OCR A Extended", 20.25F, FontStyle.Bold);
            kryptonButton2.StatePressed.Back.Color1 = Color.DarkOrange;
            kryptonButton2.StatePressed.Back.Color2 = Color.DarkOrange;
            kryptonButton2.StatePressed.Back.Image = Properties.Resources.ButtonBG;
            kryptonButton2.StatePressed.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            kryptonButton2.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            kryptonButton2.StatePressed.Border.Rounding = 7F;
            kryptonButton2.StatePressed.Content.ShortText.Color1 = Color.White;
            kryptonButton2.StatePressed.Content.ShortText.Color2 = Color.White;
            kryptonButton2.StatePressed.Content.ShortText.Font = new Font("OCR A Extended", 20.25F, FontStyle.Bold);
            kryptonButton2.StateTracking.Back.Color1 = Color.DarkOrange;
            kryptonButton2.StateTracking.Back.Color2 = Color.DarkOrange;
            kryptonButton2.StateTracking.Back.Image = Properties.Resources.ButtonBG;
            kryptonButton2.StateTracking.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            kryptonButton2.StateTracking.Border.Color1 = Color.Cyan;
            kryptonButton2.StateTracking.Border.Color2 = Color.Cyan;
            kryptonButton2.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            kryptonButton2.StateTracking.Border.Rounding = 7F;
            kryptonButton2.StateTracking.Border.Width = 3;
            kryptonButton2.StateTracking.Content.ShortText.Color1 = Color.White;
            kryptonButton2.StateTracking.Content.ShortText.Color2 = Color.White;
            kryptonButton2.StateTracking.Content.ShortText.Font = new Font("OCR A Extended", 20.25F, FontStyle.Bold);
            kryptonButton2.TabIndex = 19;
            kryptonButton2.Values.DropDownArrowColor = Color.Empty;
            kryptonButton2.Values.Text = "Rate Game";
            kryptonButton2.Click += RateGameButton_Click;
            // 
            // LogOutButton
            // 
            LogOutButton.Dock = DockStyle.Fill;
            LogOutButton.Location = new Point(88, 3);
            LogOutButton.Name = "LogOutButton";
            LogOutButton.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Black;
            LogOutButton.Size = new Size(250, 59);
            LogOutButton.StateNormal.Back.Color1 = Color.DarkOrange;
            LogOutButton.StateNormal.Back.Color2 = Color.DarkOrange;
            LogOutButton.StateNormal.Back.Image = Properties.Resources.ButtonBG;
            LogOutButton.StateNormal.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            LogOutButton.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            LogOutButton.StateNormal.Border.Rounding = 7F;
            LogOutButton.StateNormal.Content.ShortText.Color1 = Color.White;
            LogOutButton.StateNormal.Content.ShortText.Color2 = Color.White;
            LogOutButton.StateNormal.Content.ShortText.Font = new Font("OCR A Extended", 20.25F, FontStyle.Bold);
            LogOutButton.StatePressed.Back.Color1 = Color.DarkOrange;
            LogOutButton.StatePressed.Back.Color2 = Color.DarkOrange;
            LogOutButton.StatePressed.Back.Image = Properties.Resources.ButtonBG;
            LogOutButton.StatePressed.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            LogOutButton.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            LogOutButton.StatePressed.Border.Rounding = 7F;
            LogOutButton.StatePressed.Content.ShortText.Color1 = Color.White;
            LogOutButton.StatePressed.Content.ShortText.Color2 = Color.White;
            LogOutButton.StatePressed.Content.ShortText.Font = new Font("OCR A Extended", 20.25F, FontStyle.Bold);
            LogOutButton.StateTracking.Back.Color1 = Color.DarkOrange;
            LogOutButton.StateTracking.Back.Color2 = Color.DarkOrange;
            LogOutButton.StateTracking.Back.Image = Properties.Resources.ButtonBG;
            LogOutButton.StateTracking.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            LogOutButton.StateTracking.Border.Color1 = Color.Cyan;
            LogOutButton.StateTracking.Border.Color2 = Color.Cyan;
            LogOutButton.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            LogOutButton.StateTracking.Border.Rounding = 7F;
            LogOutButton.StateTracking.Border.Width = 3;
            LogOutButton.StateTracking.Content.ShortText.Color1 = Color.White;
            LogOutButton.StateTracking.Content.ShortText.Color2 = Color.White;
            LogOutButton.StateTracking.Content.ShortText.Font = new Font("OCR A Extended", 20.25F, FontStyle.Bold);
            LogOutButton.TabIndex = 17;
            LogOutButton.Values.DropDownArrowColor = Color.Empty;
            LogOutButton.Values.Text = "Log Out";
            LogOutButton.Click += LogoutButton_Click;
            // 
            // kryptonButton3
            // 
            kryptonButton3.Dock = DockStyle.Fill;
            kryptonButton3.Location = new Point(88, 68);
            kryptonButton3.Name = "kryptonButton3";
            kryptonButton3.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Black;
            kryptonButton3.Size = new Size(250, 57);
            kryptonButton3.StateNormal.Back.Color1 = Color.DarkOrange;
            kryptonButton3.StateNormal.Back.Color2 = Color.DarkOrange;
            kryptonButton3.StateNormal.Back.Image = Properties.Resources.ButtonBG;
            kryptonButton3.StateNormal.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            kryptonButton3.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            kryptonButton3.StateNormal.Border.Rounding = 7F;
            kryptonButton3.StateNormal.Content.ShortText.Color1 = Color.White;
            kryptonButton3.StateNormal.Content.ShortText.Color2 = Color.White;
            kryptonButton3.StateNormal.Content.ShortText.Font = new Font("OCR A Extended", 17F, FontStyle.Bold);
            kryptonButton3.StatePressed.Back.Color1 = Color.DarkOrange;
            kryptonButton3.StatePressed.Back.Color2 = Color.DarkOrange;
            kryptonButton3.StatePressed.Back.Image = Properties.Resources.ButtonBG;
            kryptonButton3.StatePressed.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            kryptonButton3.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            kryptonButton3.StatePressed.Border.Rounding = 7F;
            kryptonButton3.StatePressed.Content.ShortText.Color1 = Color.White;
            kryptonButton3.StatePressed.Content.ShortText.Color2 = Color.White;
            kryptonButton3.StatePressed.Content.ShortText.Font = new Font("OCR A Extended", 17F, FontStyle.Bold);
            kryptonButton3.StateTracking.Back.Color1 = Color.DarkOrange;
            kryptonButton3.StateTracking.Back.Color2 = Color.DarkOrange;
            kryptonButton3.StateTracking.Back.Image = Properties.Resources.ButtonBG;
            kryptonButton3.StateTracking.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            kryptonButton3.StateTracking.Border.Color1 = Color.Cyan;
            kryptonButton3.StateTracking.Border.Color2 = Color.Cyan;
            kryptonButton3.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            kryptonButton3.StateTracking.Border.Rounding = 7F;
            kryptonButton3.StateTracking.Border.Width = 3;
            kryptonButton3.StateTracking.Content.ShortText.Color1 = Color.White;
            kryptonButton3.StateTracking.Content.ShortText.Color2 = Color.White;
            kryptonButton3.StateTracking.Content.ShortText.Font = new Font("OCR A Extended", 17F, FontStyle.Bold);
            kryptonButton3.TabIndex = 21;
            kryptonButton3.Values.DropDownArrowColor = Color.Empty;
            kryptonButton3.Values.Text = "Contact Support";
            kryptonButton3.Click += SupportButton_Click;
            // 
            // SettingsScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            BackgroundImage = Properties.Resources.ResultScreenBg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(776, 456);
            Controls.Add(tableLayoutPanel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SettingsScreen";
            StartPosition = FormStartPosition.CenterScreen;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Krypton.Toolkit.KryptonButton CloseButton;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label4;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel3;
        private Krypton.Toolkit.KryptonButton LogOutButton;
        private ReaLTaiizor.Controls.MetroTrackBar MusicTrackBar;
        private ReaLTaiizor.Controls.MetroTrackBar MasterTrackBar;
        private Krypton.Toolkit.KryptonButton kryptonButton2;
        private Krypton.Toolkit.KryptonButton kryptonButton3;
        private Krypton.Toolkit.KryptonButton TutorialButton;
    }
}