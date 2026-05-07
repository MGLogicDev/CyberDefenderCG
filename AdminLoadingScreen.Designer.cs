namespace Cyber_DefenderTCG
{
    partial class AdminLoadingScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLoadingScreen));
            tableLayoutPanel1 = new TableLayoutPanel();
            StatusLabel = new Label();
            LoadingPBar = new ReaLTaiizor.Controls.HopeProgressBar();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(StatusLabel, 1, 1);
            tableLayoutPanel1.Controls.Add(LoadingPBar, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.Size = new Size(1248, 642);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.BackColor = Color.Transparent;
            StatusLabel.Dock = DockStyle.Fill;
            StatusLabel.Font = new Font("OCR A Extended", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StatusLabel.ForeColor = SystemColors.ButtonFace;
            StatusLabel.Location = new Point(415, 545);
            StatusLabel.Margin = new Padding(0);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(416, 32);
            StatusLabel.TabIndex = 5;
            StatusLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoadingPBar
            // 
            LoadingPBar.BarColor = Color.FromArgb(220, 223, 230);
            LoadingPBar.BaseColor = Color.FromArgb(64, 158, 255);
            LoadingPBar.DangerColor = Color.FromArgb(245, 108, 108);
            LoadingPBar.Dock = DockStyle.Fill;
            LoadingPBar.Font = new Font("Segoe UI", 10F);
            LoadingPBar.ForeColor = Color.FromArgb(242, 246, 252);
            LoadingPBar.FullBallonColor = Color.FromArgb(103, 194, 58);
            LoadingPBar.FullBallonText = "Ok!";
            LoadingPBar.FullBarColor = Color.FromArgb(103, 194, 58);
            LoadingPBar.IsError = false;
            LoadingPBar.Location = new Point(418, 580);
            LoadingPBar.Name = "LoadingPBar";
            LoadingPBar.ProgressBarStyle = ReaLTaiizor.Controls.HopeProgressBar.Style.ToolTip;
            LoadingPBar.Size = new Size(410, 32);
            LoadingPBar.TabIndex = 6;
            LoadingPBar.Text = "hopeProgressBar1";
            LoadingPBar.ValueNumber = 0;
            // 
            // AdminLoadingScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.SplashScreen2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1248, 642);
            Controls.Add(tableLayoutPanel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdminLoadingScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminLoadingScreen";
            Load += LoadingScreen_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label StatusLabel;
        private ReaLTaiizor.Controls.HopeProgressBar LoadingPBar;
    }
}