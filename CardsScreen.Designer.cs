namespace Cyber_DefenderTCG
{
    partial class CardsScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardsScreen));
            tableLayoutPanel1 = new TableLayoutPanel();
            ReturnToMenuButton = new Krypton.Toolkit.KryptonButton();
            tableLayoutPanel3 = new TableLayoutPanel();
            DescrptionLabel = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            CardNameLabel = new Label();
            CardPbox = new PictureBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            label3 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            CardsGridView = new DataGridView();
            tableLayoutPanel7 = new TableLayoutPanel();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            LoadThreatCards = new Krypton.Toolkit.KryptonButton();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CardPbox).BeginInit();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CardsGridView).BeginInit();
            tableLayoutPanel7.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.Controls.Add(ReturnToMenuButton, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel6, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.461087F));
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
            ReturnToMenuButton.Size = new Size(246, 38);
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
            ReturnToMenuButton.TabIndex = 104;
            ReturnToMenuButton.Values.DropDownArrowColor = Color.Empty;
            ReturnToMenuButton.Values.Text = "Return to\r\nMain Menu\r\n";
            ReturnToMenuButton.Click += ReturnToMMenuButton_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.0000038F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.9999962F));
            tableLayoutPanel3.Controls.Add(DescrptionLabel, 1, 1);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel5, 1, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 2, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(255, 47);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Size = new Size(1006, 631);
            tableLayoutPanel3.TabIndex = 4;
            // 
            // DescrptionLabel
            // 
            DescrptionLabel.AutoSize = true;
            DescrptionLabel.BackColor = Color.Transparent;
            DescrptionLabel.Dock = DockStyle.Fill;
            DescrptionLabel.Font = new Font("OCR A Extended", 15F);
            DescrptionLabel.ForeColor = Color.White;
            DescrptionLabel.Location = new Point(304, 473);
            DescrptionLabel.Name = "DescrptionLabel";
            DescrptionLabel.Size = new Size(396, 158);
            DescrptionLabel.TabIndex = 2;
            DescrptionLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.BackColor = Color.FromArgb(255, 49, 49);
            tableLayoutPanel5.BackgroundImage = Properties.Resources.ThreatCardbg;
            tableLayoutPanel5.BackgroundImageLayout = ImageLayout.Stretch;
            tableLayoutPanel5.ColumnCount = 3;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel5.Controls.Add(CardNameLabel, 1, 1);
            tableLayoutPanel5.Controls.Add(CardPbox, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(304, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel5.Size = new Size(396, 467);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // CardNameLabel
            // 
            CardNameLabel.AutoSize = true;
            CardNameLabel.BackColor = Color.Transparent;
            CardNameLabel.Dock = DockStyle.Fill;
            CardNameLabel.Font = new Font("OCR A Extended", 25F, FontStyle.Bold);
            CardNameLabel.ForeColor = Color.White;
            CardNameLabel.Location = new Point(19, 326);
            CardNameLabel.Margin = new Padding(0);
            CardNameLabel.Name = "CardNameLabel";
            CardNameLabel.Size = new Size(356, 141);
            CardNameLabel.TabIndex = 13;
            CardNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CardPbox
            // 
            CardPbox.BackColor = Color.Transparent;
            CardPbox.Dock = DockStyle.Fill;
            CardPbox.Image = Properties.Resources.CyberDefenderIiconImage_png;
            CardPbox.Location = new Point(22, 3);
            CardPbox.Name = "CardPbox";
            CardPbox.Size = new Size(350, 320);
            CardPbox.SizeMode = PictureBoxSizeMode.StretchImage;
            CardPbox.TabIndex = 0;
            CardPbox.TabStop = false;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(706, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(297, 467);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.86703F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.1329689F));
            tableLayoutPanel6.Controls.Add(label3, 1, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(255, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(1006, 38);
            tableLayoutPanel6.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("OCR A Extended", 12F);
            label3.ForeColor = Color.Yellow;
            label3.Location = new Point(776, 0);
            label3.Name = "label3";
            label3.Size = new Size(227, 38);
            label3.TabIndex = 1;
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(CardsGridView, 0, 2);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel7, 0, 0);
            tableLayoutPanel2.Controls.Add(label1, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 47);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.926927F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.2764111F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 79.79666F));
            tableLayoutPanel2.Size = new Size(246, 631);
            tableLayoutPanel2.TabIndex = 6;
            // 
            // CardsGridView
            // 
            CardsGridView.AllowUserToAddRows = false;
            CardsGridView.AllowUserToDeleteRows = false;
            CardsGridView.AllowUserToResizeColumns = false;
            CardsGridView.AllowUserToResizeRows = false;
            CardsGridView.BackgroundColor = Color.DarkBlue;
            CardsGridView.BorderStyle = BorderStyle.Fixed3D;
            CardsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CardsGridView.Dock = DockStyle.Fill;
            CardsGridView.Location = new Point(3, 130);
            CardsGridView.MultiSelect = false;
            CardsGridView.Name = "CardsGridView";
            CardsGridView.ReadOnly = true;
            CardsGridView.RowHeadersVisible = false;
            CardsGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            CardsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CardsGridView.Size = new Size(240, 498);
            CardsGridView.TabIndex = 0;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel7.Controls.Add(kryptonButton1, 1, 0);
            tableLayoutPanel7.Controls.Add(LoadThreatCards, 0, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(0, 0);
            tableLayoutPanel7.Margin = new Padding(0);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Size = new Size(246, 50);
            tableLayoutPanel7.TabIndex = 2;
            // 
            // kryptonButton1
            // 
            kryptonButton1.Dock = DockStyle.Fill;
            kryptonButton1.Location = new Point(126, 3);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Black;
            kryptonButton1.Size = new Size(117, 44);
            kryptonButton1.StateNormal.Back.Color1 = Color.DarkOrange;
            kryptonButton1.StateNormal.Back.Color2 = Color.DarkOrange;
            kryptonButton1.StateNormal.Back.Image = Properties.Resources.ButtonBG;
            kryptonButton1.StateNormal.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            kryptonButton1.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            kryptonButton1.StateNormal.Border.Rounding = 7F;
            kryptonButton1.StateNormal.Content.ShortText.Color1 = Color.White;
            kryptonButton1.StateNormal.Content.ShortText.Color2 = Color.White;
            kryptonButton1.StateNormal.Content.ShortText.Font = new Font("OCR A Extended", 10F, FontStyle.Bold);
            kryptonButton1.StatePressed.Back.Color1 = Color.DarkOrange;
            kryptonButton1.StatePressed.Back.Color2 = Color.DarkOrange;
            kryptonButton1.StatePressed.Back.Image = Properties.Resources.ButtonBG;
            kryptonButton1.StatePressed.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            kryptonButton1.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            kryptonButton1.StatePressed.Border.Rounding = 7F;
            kryptonButton1.StatePressed.Content.ShortText.Color1 = Color.White;
            kryptonButton1.StatePressed.Content.ShortText.Color2 = Color.White;
            kryptonButton1.StatePressed.Content.ShortText.Font = new Font("OCR A Extended", 10F, FontStyle.Bold);
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
            kryptonButton1.StateTracking.Content.ShortText.Font = new Font("OCR A Extended", 10F, FontStyle.Bold);
            kryptonButton1.TabIndex = 119;
            kryptonButton1.Values.DropDownArrowColor = Color.Empty;
            kryptonButton1.Values.Text = "Defense";
            kryptonButton1.Click += ShowDefenseButton_Click;
            // 
            // LoadThreatCards
            // 
            LoadThreatCards.Dock = DockStyle.Fill;
            LoadThreatCards.Location = new Point(3, 3);
            LoadThreatCards.Name = "LoadThreatCards";
            LoadThreatCards.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Black;
            LoadThreatCards.Size = new Size(117, 44);
            LoadThreatCards.StateNormal.Back.Color1 = Color.DarkOrange;
            LoadThreatCards.StateNormal.Back.Color2 = Color.DarkOrange;
            LoadThreatCards.StateNormal.Back.Image = Properties.Resources.ButtonBG;
            LoadThreatCards.StateNormal.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            LoadThreatCards.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            LoadThreatCards.StateNormal.Border.Rounding = 7F;
            LoadThreatCards.StateNormal.Content.ShortText.Color1 = Color.White;
            LoadThreatCards.StateNormal.Content.ShortText.Color2 = Color.White;
            LoadThreatCards.StateNormal.Content.ShortText.Font = new Font("OCR A Extended", 10F, FontStyle.Bold);
            LoadThreatCards.StatePressed.Back.Color1 = Color.DarkOrange;
            LoadThreatCards.StatePressed.Back.Color2 = Color.DarkOrange;
            LoadThreatCards.StatePressed.Back.Image = Properties.Resources.ButtonBG;
            LoadThreatCards.StatePressed.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            LoadThreatCards.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            LoadThreatCards.StatePressed.Border.Rounding = 7F;
            LoadThreatCards.StatePressed.Content.ShortText.Color1 = Color.White;
            LoadThreatCards.StatePressed.Content.ShortText.Color2 = Color.White;
            LoadThreatCards.StatePressed.Content.ShortText.Font = new Font("OCR A Extended", 10F, FontStyle.Bold);
            LoadThreatCards.StateTracking.Back.Color1 = Color.DarkOrange;
            LoadThreatCards.StateTracking.Back.Color2 = Color.DarkOrange;
            LoadThreatCards.StateTracking.Back.Image = Properties.Resources.ButtonBG;
            LoadThreatCards.StateTracking.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            LoadThreatCards.StateTracking.Border.Color1 = Color.Cyan;
            LoadThreatCards.StateTracking.Border.Color2 = Color.Cyan;
            LoadThreatCards.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            LoadThreatCards.StateTracking.Border.Rounding = 7F;
            LoadThreatCards.StateTracking.Border.Width = 3;
            LoadThreatCards.StateTracking.Content.ShortText.Color1 = Color.White;
            LoadThreatCards.StateTracking.Content.ShortText.Color2 = Color.White;
            LoadThreatCards.StateTracking.Content.ShortText.Font = new Font("OCR A Extended", 10F, FontStyle.Bold);
            LoadThreatCards.TabIndex = 118;
            LoadThreatCards.Values.DropDownArrowColor = Color.Empty;
            LoadThreatCards.Values.Text = "Threat";
            LoadThreatCards.Click += ShowThreatsButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("OCR A Extended", 20F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 50);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(246, 77);
            label1.TabIndex = 1;
            label1.Text = "Cards List";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CardsScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            BackgroundImage = Properties.Resources.CardScreen;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1264, 681);
            Controls.Add(tableLayoutPanel1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(900, 700);
            Name = "CardsScreen";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CardPbox).EndInit();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CardsGridView).EndInit();
            tableLayoutPanel7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label1;
        private DataGridView CardsGridView;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel2;
        private Krypton.Toolkit.KryptonButton ReturnToMenuButton;
        private TableLayoutPanel tableLayoutPanel5;
        private Label CardNameLabel;
        private PictureBox CardPbox;
        private TableLayoutPanel tableLayoutPanel4;
        private Label DescrptionLabel;
        private TableLayoutPanel tableLayoutPanel7;
        private Krypton.Toolkit.KryptonButton LoadThreatCards;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
    }
}