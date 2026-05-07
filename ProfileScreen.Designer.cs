namespace Cyber_DefenderTCG
{
    partial class ProfileScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileScreen));
            tableLayoutPanel1 = new TableLayoutPanel();
            ReturnToMenuButton = new Krypton.Toolkit.KryptonButton();
            tableLayoutPanel2 = new TableLayoutPanel();
            DeleteButton = new Krypton.Toolkit.KryptonButton();
            SaveButton = new Krypton.Toolkit.KryptonButton();
            tableLayoutPanel3 = new TableLayoutPanel();
            label1 = new Label();
            tableLayoutPanel7 = new TableLayoutPanel();
            PasswordTxb = new TextBox();
            EmailTxb = new TextBox();
            UsernameTxb = new TextBox();
            label9 = new Label();
            label7 = new Label();
            label5 = new Label();
            label2 = new Label();
            GenderCmb = new ComboBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            label3 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.6582279F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 87.341774F));
            tableLayoutPanel1.Controls.Add(ReturnToMenuButton, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel6, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.46108675F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 93.53891F));
            tableLayoutPanel1.Size = new Size(1264, 681);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // ReturnToMenuButton
            // 
            ReturnToMenuButton.Dock = DockStyle.Fill;
            ReturnToMenuButton.Location = new Point(3, 3);
            ReturnToMenuButton.Name = "ReturnToMenuButton";
            ReturnToMenuButton.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Black;
            ReturnToMenuButton.Size = new Size(154, 38);
            ReturnToMenuButton.StateNormal.Back.Color1 = Color.DarkOrange;
            ReturnToMenuButton.StateNormal.Back.Color2 = Color.DarkOrange;
            ReturnToMenuButton.StateNormal.Back.Image = Properties.Resources.ButtonBG;
            ReturnToMenuButton.StateNormal.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            ReturnToMenuButton.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            ReturnToMenuButton.StateNormal.Border.Rounding = 7F;
            ReturnToMenuButton.StateNormal.Content.ShortText.Color1 = Color.White;
            ReturnToMenuButton.StateNormal.Content.ShortText.Color2 = Color.White;
            ReturnToMenuButton.StateNormal.Content.ShortText.Font = new Font("OCR A Extended", 12F, FontStyle.Bold);
            ReturnToMenuButton.StatePressed.Back.Color1 = Color.DarkOrange;
            ReturnToMenuButton.StatePressed.Back.Color2 = Color.DarkOrange;
            ReturnToMenuButton.StatePressed.Back.Image = Properties.Resources.ButtonBG;
            ReturnToMenuButton.StatePressed.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            ReturnToMenuButton.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            ReturnToMenuButton.StatePressed.Border.Rounding = 7F;
            ReturnToMenuButton.StatePressed.Content.ShortText.Color1 = Color.White;
            ReturnToMenuButton.StatePressed.Content.ShortText.Color2 = Color.White;
            ReturnToMenuButton.StatePressed.Content.ShortText.Font = new Font("OCR A Extended", 12F, FontStyle.Bold);
            ReturnToMenuButton.StateTracking.Back.Color1 = Color.DarkOrange;
            ReturnToMenuButton.StateTracking.Back.Color2 = Color.DarkOrange;
            ReturnToMenuButton.StateTracking.Back.Image = Properties.Resources.ButtonBG;
            ReturnToMenuButton.StateTracking.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            ReturnToMenuButton.StateTracking.Border.Color1 = Color.Cyan;
            ReturnToMenuButton.StateTracking.Border.Color2 = Color.Cyan;
            ReturnToMenuButton.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            ReturnToMenuButton.StateTracking.Border.Rounding = 7F;
            ReturnToMenuButton.StateTracking.Border.Width = 3;
            ReturnToMenuButton.StateTracking.Content.ShortText.Color1 = Color.White;
            ReturnToMenuButton.StateTracking.Content.ShortText.Color2 = Color.White;
            ReturnToMenuButton.StateTracking.Content.ShortText.Font = new Font("OCR A Extended", 12F, FontStyle.Bold);
            ReturnToMenuButton.TabIndex = 105;
            ReturnToMenuButton.Values.DropDownArrowColor = Color.Empty;
            ReturnToMenuButton.Values.Text = "Return to\r\nMain Menu\r\n";
            ReturnToMenuButton.Click += ReturnToMMenuButton_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(DeleteButton, 0, 5);
            tableLayoutPanel2.Controls.Add(SaveButton, 0, 3);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 47);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 9;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20.6084938F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.4691257F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 2.96883965F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.4691257F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 2.96883965F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.4691257F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 2.96883965F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.4691257F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20.6084957F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(154, 631);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // DeleteButton
            // 
            DeleteButton.Dock = DockStyle.Fill;
            DeleteButton.Location = new Point(3, 325);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Black;
            DeleteButton.Size = new Size(148, 72);
            DeleteButton.StateNormal.Back.Color1 = Color.DarkOrange;
            DeleteButton.StateNormal.Back.Color2 = Color.DarkOrange;
            DeleteButton.StateNormal.Back.Image = Properties.Resources.ButtonBG;
            DeleteButton.StateNormal.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            DeleteButton.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            DeleteButton.StateNormal.Border.Rounding = 7F;
            DeleteButton.StateNormal.Content.ShortText.Color1 = Color.White;
            DeleteButton.StateNormal.Content.ShortText.Color2 = Color.White;
            DeleteButton.StateNormal.Content.ShortText.Font = new Font("OCR A Extended", 12F, FontStyle.Bold);
            DeleteButton.StatePressed.Back.Color1 = Color.DarkOrange;
            DeleteButton.StatePressed.Back.Color2 = Color.DarkOrange;
            DeleteButton.StatePressed.Back.Image = Properties.Resources.ButtonBG;
            DeleteButton.StatePressed.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            DeleteButton.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            DeleteButton.StatePressed.Border.Rounding = 7F;
            DeleteButton.StatePressed.Content.ShortText.Color1 = Color.White;
            DeleteButton.StatePressed.Content.ShortText.Color2 = Color.White;
            DeleteButton.StatePressed.Content.ShortText.Font = new Font("OCR A Extended", 12F, FontStyle.Bold);
            DeleteButton.StateTracking.Back.Color1 = Color.DarkOrange;
            DeleteButton.StateTracking.Back.Color2 = Color.DarkOrange;
            DeleteButton.StateTracking.Back.Image = Properties.Resources.ButtonBG;
            DeleteButton.StateTracking.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            DeleteButton.StateTracking.Border.Color1 = Color.Cyan;
            DeleteButton.StateTracking.Border.Color2 = Color.Cyan;
            DeleteButton.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            DeleteButton.StateTracking.Border.Rounding = 7F;
            DeleteButton.StateTracking.Border.Width = 3;
            DeleteButton.StateTracking.Content.ShortText.Color1 = Color.White;
            DeleteButton.StateTracking.Content.ShortText.Color2 = Color.White;
            DeleteButton.StateTracking.Content.ShortText.Font = new Font("OCR A Extended", 12F, FontStyle.Bold);
            DeleteButton.TabIndex = 114;
            DeleteButton.Values.DropDownArrowColor = Color.Empty;
            DeleteButton.Values.Text = " Delete\r\nAccount";
            DeleteButton.Click += DeleteAccountButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Dock = DockStyle.Fill;
            SaveButton.Location = new Point(3, 229);
            SaveButton.Name = "SaveButton";
            SaveButton.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Black;
            SaveButton.Size = new Size(148, 72);
            SaveButton.StateNormal.Back.Color1 = Color.DarkOrange;
            SaveButton.StateNormal.Back.Color2 = Color.DarkOrange;
            SaveButton.StateNormal.Back.Image = Properties.Resources.ButtonBG;
            SaveButton.StateNormal.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            SaveButton.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            SaveButton.StateNormal.Border.Rounding = 7F;
            SaveButton.StateNormal.Content.ShortText.Color1 = Color.White;
            SaveButton.StateNormal.Content.ShortText.Color2 = Color.White;
            SaveButton.StateNormal.Content.ShortText.Font = new Font("OCR A Extended", 12F, FontStyle.Bold);
            SaveButton.StatePressed.Back.Color1 = Color.DarkOrange;
            SaveButton.StatePressed.Back.Color2 = Color.DarkOrange;
            SaveButton.StatePressed.Back.Image = Properties.Resources.ButtonBG;
            SaveButton.StatePressed.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            SaveButton.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            SaveButton.StatePressed.Border.Rounding = 7F;
            SaveButton.StatePressed.Content.ShortText.Color1 = Color.White;
            SaveButton.StatePressed.Content.ShortText.Color2 = Color.White;
            SaveButton.StatePressed.Content.ShortText.Font = new Font("OCR A Extended", 12F, FontStyle.Bold);
            SaveButton.StateTracking.Back.Color1 = Color.DarkOrange;
            SaveButton.StateTracking.Back.Color2 = Color.DarkOrange;
            SaveButton.StateTracking.Back.Image = Properties.Resources.ButtonBG;
            SaveButton.StateTracking.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            SaveButton.StateTracking.Border.Color1 = Color.Cyan;
            SaveButton.StateTracking.Border.Color2 = Color.Cyan;
            SaveButton.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            SaveButton.StateTracking.Border.Rounding = 7F;
            SaveButton.StateTracking.Border.Width = 3;
            SaveButton.StateTracking.Content.ShortText.Color1 = Color.White;
            SaveButton.StateTracking.Content.ShortText.Color2 = Color.White;
            SaveButton.StateTracking.Content.ShortText.Font = new Font("OCR A Extended", 12F, FontStyle.Bold);
            SaveButton.TabIndex = 112;
            SaveButton.Values.DropDownArrowColor = Color.Empty;
            SaveButton.Values.Text = " Save \r\nChanges";
            SaveButton.Click += SaveButton_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.87067F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.12933F));
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel7, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(163, 47);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 9.519231F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 74.7569046F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 15.7238684F));
            tableLayoutPanel3.Size = new Size(1098, 631);
            tableLayoutPanel3.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("OCR A Extended", 20F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(865, 60);
            label1.TabIndex = 1;
            label1.Text = "Profile";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.BackColor = Color.FromArgb(220, 81, 100, 122);
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.69767F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.30233F));
            tableLayoutPanel7.Controls.Add(PasswordTxb, 1, 4);
            tableLayoutPanel7.Controls.Add(EmailTxb, 1, 3);
            tableLayoutPanel7.Controls.Add(UsernameTxb, 1, 2);
            tableLayoutPanel7.Controls.Add(label9, 0, 5);
            tableLayoutPanel7.Controls.Add(label7, 0, 4);
            tableLayoutPanel7.Controls.Add(label5, 0, 3);
            tableLayoutPanel7.Controls.Add(label2, 0, 2);
            tableLayoutPanel7.Controls.Add(GenderCmb, 1, 5);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(3, 63);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 10;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel7.Size = new Size(859, 465);
            tableLayoutPanel7.TabIndex = 3;
            // 
            // PasswordTxb
            // 
            PasswordTxb.BackColor = Color.FromArgb(81, 100, 122);
            PasswordTxb.Dock = DockStyle.Fill;
            PasswordTxb.Font = new Font("OCR A Extended", 20F);
            PasswordTxb.Location = new Point(309, 187);
            PasswordTxb.Name = "PasswordTxb";
            PasswordTxb.Size = new Size(547, 35);
            PasswordTxb.TabIndex = 20;
            // 
            // EmailTxb
            // 
            EmailTxb.BackColor = Color.FromArgb(81, 100, 122);
            EmailTxb.Dock = DockStyle.Fill;
            EmailTxb.Font = new Font("OCR A Extended", 20F);
            EmailTxb.Location = new Point(309, 141);
            EmailTxb.Name = "EmailTxb";
            EmailTxb.Size = new Size(547, 35);
            EmailTxb.TabIndex = 19;
            // 
            // UsernameTxb
            // 
            UsernameTxb.BackColor = Color.FromArgb(81, 100, 122);
            UsernameTxb.Dock = DockStyle.Fill;
            UsernameTxb.Font = new Font("OCR A Extended", 20F);
            UsernameTxb.Location = new Point(309, 95);
            UsernameTxb.Name = "UsernameTxb";
            UsernameTxb.Size = new Size(547, 35);
            UsernameTxb.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Dock = DockStyle.Fill;
            label9.Font = new Font("OCR A Extended", 20F, FontStyle.Bold);
            label9.ForeColor = Color.White;
            label9.Location = new Point(0, 230);
            label9.Margin = new Padding(0);
            label9.Name = "label9";
            label9.Size = new Size(306, 46);
            label9.TabIndex = 8;
            label9.Text = "Gender:";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("OCR A Extended", 20F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(0, 184);
            label7.Margin = new Padding(0);
            label7.Name = "label7";
            label7.Size = new Size(306, 46);
            label7.TabIndex = 6;
            label7.Text = "Password:";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("OCR A Extended", 20F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(0, 138);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(306, 46);
            label5.TabIndex = 4;
            label5.Text = "Email:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("OCR A Extended", 20F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 92);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(306, 46);
            label2.TabIndex = 2;
            label2.Text = "Username:";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // GenderCmb
            // 
            GenderCmb.BackColor = Color.FromArgb(81, 100, 122);
            GenderCmb.Dock = DockStyle.Fill;
            GenderCmb.Font = new Font("OCR A Extended", 20F);
            GenderCmb.FormattingEnabled = true;
            GenderCmb.Location = new Point(309, 233);
            GenderCmb.Name = "GenderCmb";
            GenderCmb.Size = new Size(547, 37);
            GenderCmb.TabIndex = 21;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.86703F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.1329689F));
            tableLayoutPanel6.Controls.Add(label3, 1, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(163, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(1098, 38);
            tableLayoutPanel6.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("OCR A Extended", 12F);
            label3.ForeColor = Color.Yellow;
            label3.Location = new Point(846, 0);
            label3.Name = "label3";
            label3.Size = new Size(249, 38);
            label3.TabIndex = 1;
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // ProfileScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1264, 681);
            Controls.Add(tableLayoutPanel1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(900, 700);
            Name = "ProfileScreen";
            Text = "ProfileScreen";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Krypton.Toolkit.KryptonButton ReturnToMenuButton;
        private TableLayoutPanel tableLayoutPanel2;
        private Krypton.Toolkit.KryptonButton DeleteButton;
        private Krypton.Toolkit.KryptonButton SaveButton;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel7;
        private Label label9;
        private Label label7;
        private Label label5;
        private Label label2;
        private TextBox PasswordTxb;
        private TextBox EmailTxb;
        private TextBox UsernameTxb;
        private ComboBox GenderCmb;
    }
}