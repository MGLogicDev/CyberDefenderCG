namespace Cyber_DefenderTCG
{
    partial class SignInScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignInScreen));
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            LoginAccountButton = new Krypton.Toolkit.KryptonButton();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            EmailTxb = new TextBox();
            PasswordTxb = new TextBox();
            label3 = new Label();
            label2 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            ForgotPasswordButton = new Krypton.Toolkit.KryptonButton();
            CreateAccountButton = new Krypton.Toolkit.KryptonButton();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 600F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 2, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(1222, 681);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.FromArgb(230, 122, 121, 121);
            tableLayoutPanel2.BackgroundImageLayout = ImageLayout.Stretch;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(LoginAccountButton, 1, 5);
            tableLayoutPanel2.Controls.Add(bigLabel1, 1, 0);
            tableLayoutPanel2.Controls.Add(EmailTxb, 1, 2);
            tableLayoutPanel2.Controls.Add(PasswordTxb, 1, 4);
            tableLayoutPanel2.Controls.Add(label3, 1, 3);
            tableLayoutPanel2.Controls.Add(label2, 1, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(314, 139);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 7;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20.8929558F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.461776F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.415905F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.4617734F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.415905F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 23.8899117F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.4617734F));
            tableLayoutPanel2.Size = new Size(594, 402);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // LoginAccountButton
            // 
            LoginAccountButton.Dock = DockStyle.Fill;
            LoginAccountButton.Location = new Point(23, 274);
            LoginAccountButton.Name = "LoginAccountButton";
            LoginAccountButton.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Black;
            LoginAccountButton.Size = new Size(548, 90);
            LoginAccountButton.StateNormal.Back.Color1 = Color.DarkOrange;
            LoginAccountButton.StateNormal.Back.Color2 = Color.DarkOrange;
            LoginAccountButton.StateNormal.Back.Image = Properties.Resources.ButtonBG;
            LoginAccountButton.StateNormal.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            LoginAccountButton.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            LoginAccountButton.StateNormal.Border.Rounding = 7F;
            LoginAccountButton.StateNormal.Content.ShortText.Color1 = Color.White;
            LoginAccountButton.StateNormal.Content.ShortText.Color2 = Color.White;
            LoginAccountButton.StateNormal.Content.ShortText.Font = new Font("OCR A Extended", 30.25F, FontStyle.Bold);
            LoginAccountButton.StatePressed.Back.Color1 = Color.DarkOrange;
            LoginAccountButton.StatePressed.Back.Color2 = Color.DarkOrange;
            LoginAccountButton.StatePressed.Back.Image = Properties.Resources.ButtonBG;
            LoginAccountButton.StatePressed.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            LoginAccountButton.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            LoginAccountButton.StatePressed.Border.Rounding = 7F;
            LoginAccountButton.StatePressed.Content.ShortText.Color1 = Color.White;
            LoginAccountButton.StatePressed.Content.ShortText.Color2 = Color.White;
            LoginAccountButton.StatePressed.Content.ShortText.Font = new Font("OCR A Extended", 30.25F, FontStyle.Bold);
            LoginAccountButton.StateTracking.Back.Color1 = Color.DarkOrange;
            LoginAccountButton.StateTracking.Back.Color2 = Color.DarkOrange;
            LoginAccountButton.StateTracking.Back.Image = Properties.Resources.ButtonBG;
            LoginAccountButton.StateTracking.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            LoginAccountButton.StateTracking.Border.Color1 = Color.Cyan;
            LoginAccountButton.StateTracking.Border.Color2 = Color.Cyan;
            LoginAccountButton.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            LoginAccountButton.StateTracking.Border.Rounding = 7F;
            LoginAccountButton.StateTracking.Border.Width = 3;
            LoginAccountButton.StateTracking.Content.ShortText.Color1 = Color.White;
            LoginAccountButton.StateTracking.Content.ShortText.Color2 = Color.White;
            LoginAccountButton.StateTracking.Content.ShortText.Font = new Font("OCR A Extended", 30.25F, FontStyle.Bold);
            LoginAccountButton.TabIndex = 5;
            LoginAccountButton.Values.DropDownArrowColor = Color.Empty;
            LoginAccountButton.Values.Text = "Log In";
            LoginAccountButton.Click += LoginAccountButton_Click;
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Dock = DockStyle.Fill;
            bigLabel1.Font = new Font("OCR A Extended", 30.25F, FontStyle.Bold);
            bigLabel1.ForeColor = Color.White;
            bigLabel1.Location = new Point(23, 0);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(548, 83);
            bigLabel1.TabIndex = 1;
            bigLabel1.Text = "Welcome back!";
            bigLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EmailTxb
            // 
            EmailTxb.Dock = DockStyle.Fill;
            EmailTxb.Font = new Font("OCR A Extended", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmailTxb.Location = new Point(23, 115);
            EmailTxb.Name = "EmailTxb";
            EmailTxb.Size = new Size(548, 28);
            EmailTxb.TabIndex = 1;
            EmailTxb.KeyDown += EmailTxb_KeyDown;
            // 
            // PasswordTxb
            // 
            PasswordTxb.Dock = DockStyle.Fill;
            PasswordTxb.Font = new Font("OCR A Extended", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordTxb.Location = new Point(23, 209);
            PasswordTxb.Name = "PasswordTxb";
            PasswordTxb.PasswordChar = '*';
            PasswordTxb.Size = new Size(548, 28);
            PasswordTxb.TabIndex = 2;
            PasswordTxb.KeyDown += PasswordTxb_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("OCR A Extended", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(23, 177);
            label3.Name = "label3";
            label3.Size = new Size(548, 29);
            label3.TabIndex = 11;
            label3.Text = "Password";
            label3.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("OCR A Extended", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(23, 83);
            label2.Name = "label2";
            label2.Size = new Size(548, 29);
            label2.TabIndex = 10;
            label2.Text = "Email";
            label2.TextAlign = ContentAlignment.BottomLeft;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.66871F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.3312874F));
            tableLayoutPanel3.Controls.Add(ForgotPasswordButton, 1, 0);
            tableLayoutPanel3.Controls.Add(CreateAccountButton, 1, 2);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(914, 547);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 46.5648842F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 9.923664F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 43.51145F));
            tableLayoutPanel3.Size = new Size(305, 131);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // ForgotPasswordButton
            // 
            ForgotPasswordButton.Dock = DockStyle.Fill;
            ForgotPasswordButton.Location = new Point(178, 3);
            ForgotPasswordButton.Name = "ForgotPasswordButton";
            ForgotPasswordButton.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Black;
            ForgotPasswordButton.Size = new Size(124, 55);
            ForgotPasswordButton.StateNormal.Back.Color1 = Color.DarkOrange;
            ForgotPasswordButton.StateNormal.Back.Color2 = Color.DarkOrange;
            ForgotPasswordButton.StateNormal.Back.Image = Properties.Resources.ButtonBG;
            ForgotPasswordButton.StateNormal.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            ForgotPasswordButton.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            ForgotPasswordButton.StateNormal.Border.Rounding = 7F;
            ForgotPasswordButton.StateNormal.Content.ShortText.Color1 = Color.White;
            ForgotPasswordButton.StateNormal.Content.ShortText.Color2 = Color.White;
            ForgotPasswordButton.StateNormal.Content.ShortText.Font = new Font("OCR A Extended", 10F, FontStyle.Bold);
            ForgotPasswordButton.StatePressed.Back.Color1 = Color.DarkOrange;
            ForgotPasswordButton.StatePressed.Back.Color2 = Color.DarkOrange;
            ForgotPasswordButton.StatePressed.Back.Image = Properties.Resources.ButtonBG;
            ForgotPasswordButton.StatePressed.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            ForgotPasswordButton.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            ForgotPasswordButton.StatePressed.Border.Rounding = 7F;
            ForgotPasswordButton.StatePressed.Content.ShortText.Color1 = Color.White;
            ForgotPasswordButton.StatePressed.Content.ShortText.Color2 = Color.White;
            ForgotPasswordButton.StatePressed.Content.ShortText.Font = new Font("OCR A Extended", 10F, FontStyle.Bold);
            ForgotPasswordButton.StateTracking.Back.Color1 = Color.DarkOrange;
            ForgotPasswordButton.StateTracking.Back.Color2 = Color.DarkOrange;
            ForgotPasswordButton.StateTracking.Back.Image = Properties.Resources.ButtonBG;
            ForgotPasswordButton.StateTracking.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            ForgotPasswordButton.StateTracking.Border.Color1 = Color.Cyan;
            ForgotPasswordButton.StateTracking.Border.Color2 = Color.Cyan;
            ForgotPasswordButton.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            ForgotPasswordButton.StateTracking.Border.Rounding = 7F;
            ForgotPasswordButton.StateTracking.Border.Width = 3;
            ForgotPasswordButton.StateTracking.Content.ShortText.Color1 = Color.White;
            ForgotPasswordButton.StateTracking.Content.ShortText.Color2 = Color.White;
            ForgotPasswordButton.StateTracking.Content.ShortText.Font = new Font("OCR A Extended", 10F, FontStyle.Bold);
            ForgotPasswordButton.TabIndex = 14;
            ForgotPasswordButton.Values.DropDownArrowColor = Color.Empty;
            ForgotPasswordButton.Values.Text = "Contact\r\nSupport";
            ForgotPasswordButton.Click += SupportButton_Click;
            // 
            // CreateAccountButton
            // 
            CreateAccountButton.Dock = DockStyle.Fill;
            CreateAccountButton.Location = new Point(178, 77);
            CreateAccountButton.Name = "CreateAccountButton";
            CreateAccountButton.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Black;
            CreateAccountButton.Size = new Size(124, 51);
            CreateAccountButton.StateNormal.Back.Color1 = Color.DarkOrange;
            CreateAccountButton.StateNormal.Back.Color2 = Color.DarkOrange;
            CreateAccountButton.StateNormal.Back.Image = Properties.Resources.ButtonBG;
            CreateAccountButton.StateNormal.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            CreateAccountButton.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            CreateAccountButton.StateNormal.Border.Rounding = 7F;
            CreateAccountButton.StateNormal.Content.ShortText.Color1 = Color.White;
            CreateAccountButton.StateNormal.Content.ShortText.Color2 = Color.White;
            CreateAccountButton.StateNormal.Content.ShortText.Font = new Font("OCR A Extended", 10F, FontStyle.Bold);
            CreateAccountButton.StatePressed.Back.Color1 = Color.DarkOrange;
            CreateAccountButton.StatePressed.Back.Color2 = Color.DarkOrange;
            CreateAccountButton.StatePressed.Back.Image = Properties.Resources.ButtonBG;
            CreateAccountButton.StatePressed.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            CreateAccountButton.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            CreateAccountButton.StatePressed.Border.Rounding = 7F;
            CreateAccountButton.StatePressed.Content.ShortText.Color1 = Color.White;
            CreateAccountButton.StatePressed.Content.ShortText.Color2 = Color.White;
            CreateAccountButton.StatePressed.Content.ShortText.Font = new Font("OCR A Extended", 10F, FontStyle.Bold);
            CreateAccountButton.StateTracking.Back.Color1 = Color.DarkOrange;
            CreateAccountButton.StateTracking.Back.Color2 = Color.DarkOrange;
            CreateAccountButton.StateTracking.Back.Image = Properties.Resources.ButtonBG;
            CreateAccountButton.StateTracking.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            CreateAccountButton.StateTracking.Border.Color1 = Color.Cyan;
            CreateAccountButton.StateTracking.Border.Color2 = Color.Cyan;
            CreateAccountButton.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            CreateAccountButton.StateTracking.Border.Rounding = 7F;
            CreateAccountButton.StateTracking.Border.Width = 3;
            CreateAccountButton.StateTracking.Content.ShortText.Color1 = Color.White;
            CreateAccountButton.StateTracking.Content.ShortText.Color2 = Color.White;
            CreateAccountButton.StateTracking.Content.ShortText.Font = new Font("OCR A Extended", 10F, FontStyle.Bold);
            CreateAccountButton.TabIndex = 12;
            CreateAccountButton.Values.DropDownArrowColor = Color.Empty;
            CreateAccountButton.Values.Text = "Create an \r\n account\r\n";
            CreateAccountButton.Click += CreateAccountButton_Click;
            // 
            // SignInScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            BackgroundImage = Properties.Resources.LoginScreenBg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1222, 681);
            Controls.Add(tableLayoutPanel1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SignInScreen";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private TextBox EmailTxb;
        private TextBox PasswordTxb;
        private Label label3;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel3;
        private Krypton.Toolkit.KryptonButton LoginAccountButton;
        private Krypton.Toolkit.KryptonButton CreateAccountButton;
        private Krypton.Toolkit.KryptonButton ForgotPasswordButton;
    }
}