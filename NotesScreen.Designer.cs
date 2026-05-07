namespace Cyber_DefenderTCG
{
    partial class NotesScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotesScreen));
            tableLayoutPanel1 = new TableLayoutPanel();
            ReturnToMenuButton = new Krypton.Toolkit.KryptonButton();
            tableLayoutPanel2 = new TableLayoutPanel();
            DeleteButton = new Krypton.Toolkit.KryptonButton();
            EditButton = new Krypton.Toolkit.KryptonButton();
            AddButton = new Krypton.Toolkit.KryptonButton();
            tableLayoutPanel3 = new TableLayoutPanel();
            label2 = new Label();
            label1 = new Label();
            NotesGrid = new DataGridView();
            tableLayoutPanel4 = new TableLayoutPanel();
            NotesTextBox = new TextBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            SaveButton = new Krypton.Toolkit.KryptonButton();
            tableLayoutPanel6 = new TableLayoutPanel();
            label3 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NotesGrid).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
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
            tableLayoutPanel1.TabIndex = 2;
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
            tableLayoutPanel2.Controls.Add(DeleteButton, 0, 7);
            tableLayoutPanel2.Controls.Add(EditButton, 0, 5);
            tableLayoutPanel2.Controls.Add(AddButton, 0, 3);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 47);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 11;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 17.85244F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10.80158F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 2.57180524F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10.80158F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 2.57180524F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10.80158F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 2.57180524F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10.80158F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 2.57180524F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10.80158F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 17.8524418F));
            tableLayoutPanel2.Size = new Size(154, 631);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // DeleteButton
            // 
            DeleteButton.Dock = DockStyle.Fill;
            DeleteButton.Location = new Point(3, 367);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Black;
            DeleteButton.Size = new Size(148, 62);
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
            DeleteButton.Values.Text = "Delete\r\n";
            DeleteButton.Click += DeleteButton_Click;
            DeleteButton.MouseLeave += DeleteButton_MouseLeave;
            DeleteButton.MouseHover += DeleteButton_MouseHover;
            // 
            // EditButton
            // 
            EditButton.Dock = DockStyle.Fill;
            EditButton.Location = new Point(3, 283);
            EditButton.Name = "EditButton";
            EditButton.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Black;
            EditButton.Size = new Size(148, 62);
            EditButton.StateNormal.Back.Color1 = Color.DarkOrange;
            EditButton.StateNormal.Back.Color2 = Color.DarkOrange;
            EditButton.StateNormal.Back.Image = Properties.Resources.ButtonBG;
            EditButton.StateNormal.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            EditButton.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            EditButton.StateNormal.Border.Rounding = 7F;
            EditButton.StateNormal.Content.ShortText.Color1 = Color.White;
            EditButton.StateNormal.Content.ShortText.Color2 = Color.White;
            EditButton.StateNormal.Content.ShortText.Font = new Font("OCR A Extended", 12F, FontStyle.Bold);
            EditButton.StatePressed.Back.Color1 = Color.DarkOrange;
            EditButton.StatePressed.Back.Color2 = Color.DarkOrange;
            EditButton.StatePressed.Back.Image = Properties.Resources.ButtonBG;
            EditButton.StatePressed.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            EditButton.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            EditButton.StatePressed.Border.Rounding = 7F;
            EditButton.StatePressed.Content.ShortText.Color1 = Color.White;
            EditButton.StatePressed.Content.ShortText.Color2 = Color.White;
            EditButton.StatePressed.Content.ShortText.Font = new Font("OCR A Extended", 12F, FontStyle.Bold);
            EditButton.StateTracking.Back.Color1 = Color.DarkOrange;
            EditButton.StateTracking.Back.Color2 = Color.DarkOrange;
            EditButton.StateTracking.Back.Image = Properties.Resources.ButtonBG;
            EditButton.StateTracking.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            EditButton.StateTracking.Border.Color1 = Color.Cyan;
            EditButton.StateTracking.Border.Color2 = Color.Cyan;
            EditButton.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            EditButton.StateTracking.Border.Rounding = 7F;
            EditButton.StateTracking.Border.Width = 3;
            EditButton.StateTracking.Content.ShortText.Color1 = Color.White;
            EditButton.StateTracking.Content.ShortText.Color2 = Color.White;
            EditButton.StateTracking.Content.ShortText.Font = new Font("OCR A Extended", 12F, FontStyle.Bold);
            EditButton.TabIndex = 112;
            EditButton.Values.DropDownArrowColor = Color.Empty;
            EditButton.Values.Text = "Edit";
            EditButton.Click += EditButton_Click;
            EditButton.MouseLeave += EditButton_MouseLeave;
            EditButton.MouseHover += EditButton_MouseHover;
            // 
            // AddButton
            // 
            AddButton.Dock = DockStyle.Fill;
            AddButton.Location = new Point(3, 199);
            AddButton.Name = "AddButton";
            AddButton.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Black;
            AddButton.Size = new Size(148, 62);
            AddButton.StateNormal.Back.Color1 = Color.DarkOrange;
            AddButton.StateNormal.Back.Color2 = Color.DarkOrange;
            AddButton.StateNormal.Back.Image = Properties.Resources.ButtonBG;
            AddButton.StateNormal.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            AddButton.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            AddButton.StateNormal.Border.Rounding = 7F;
            AddButton.StateNormal.Content.ShortText.Color1 = Color.White;
            AddButton.StateNormal.Content.ShortText.Color2 = Color.White;
            AddButton.StateNormal.Content.ShortText.Font = new Font("OCR A Extended", 12F, FontStyle.Bold);
            AddButton.StatePressed.Back.Color1 = Color.DarkOrange;
            AddButton.StatePressed.Back.Color2 = Color.DarkOrange;
            AddButton.StatePressed.Back.Image = Properties.Resources.ButtonBG;
            AddButton.StatePressed.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            AddButton.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            AddButton.StatePressed.Border.Rounding = 7F;
            AddButton.StatePressed.Content.ShortText.Color1 = Color.White;
            AddButton.StatePressed.Content.ShortText.Color2 = Color.White;
            AddButton.StatePressed.Content.ShortText.Font = new Font("OCR A Extended", 12F, FontStyle.Bold);
            AddButton.StateTracking.Back.Color1 = Color.DarkOrange;
            AddButton.StateTracking.Back.Color2 = Color.DarkOrange;
            AddButton.StateTracking.Back.Image = Properties.Resources.ButtonBG;
            AddButton.StateTracking.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            AddButton.StateTracking.Border.Color1 = Color.Cyan;
            AddButton.StateTracking.Border.Color2 = Color.Cyan;
            AddButton.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            AddButton.StateTracking.Border.Rounding = 7F;
            AddButton.StateTracking.Border.Width = 3;
            AddButton.StateTracking.Content.ShortText.Color1 = Color.White;
            AddButton.StateTracking.Content.ShortText.Color2 = Color.White;
            AddButton.StateTracking.Content.ShortText.Font = new Font("OCR A Extended", 12F, FontStyle.Bold);
            AddButton.TabIndex = 110;
            AddButton.Values.DropDownArrowColor = Color.Empty;
            AddButton.Values.Text = "Add\r\n";
            AddButton.Click += AddButton_Click;
            AddButton.MouseLeave += AddButton_MouseLeave;
            AddButton.MouseHover += AddButton_MouseHover;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.84518F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.1548271F));
            tableLayoutPanel3.Controls.Add(label2, 1, 0);
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Controls.Add(NotesGrid, 0, 1);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 1, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(163, 47);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 4.91283655F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 95.0871658F));
            tableLayoutPanel3.Size = new Size(1098, 631);
            tableLayoutPanel3.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("OCR A Extended", 20F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(712, 0);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(386, 30);
            label2.TabIndex = 3;
            label2.Text = "Edit Notes ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
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
            label1.Size = new Size(712, 30);
            label1.TabIndex = 1;
            label1.Text = "Notes List";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NotesGrid
            // 
            NotesGrid.AllowUserToResizeColumns = false;
            NotesGrid.AllowUserToResizeRows = false;
            NotesGrid.BackgroundColor = Color.DarkBlue;
            NotesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            NotesGrid.Dock = DockStyle.Fill;
            NotesGrid.Location = new Point(3, 33);
            NotesGrid.Name = "NotesGrid";
            NotesGrid.ReadOnly = true;
            NotesGrid.RowHeadersVisible = false;
            NotesGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            NotesGrid.Size = new Size(706, 595);
            NotesGrid.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(NotesTextBox, 0, 0);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(715, 33);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 84.0336151F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 15.9663868F));
            tableLayoutPanel4.Size = new Size(380, 595);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // NotesTextBox
            // 
            NotesTextBox.Dock = DockStyle.Fill;
            NotesTextBox.Font = new Font("OCR A Extended", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NotesTextBox.Location = new Point(3, 3);
            NotesTextBox.Multiline = true;
            NotesTextBox.Name = "NotesTextBox";
            NotesTextBox.Size = new Size(374, 494);
            NotesTextBox.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 3;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.Controls.Add(SaveButton, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 503);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(374, 89);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // SaveButton
            // 
            SaveButton.Dock = DockStyle.Fill;
            SaveButton.Location = new Point(96, 3);
            SaveButton.Name = "SaveButton";
            SaveButton.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Black;
            SaveButton.Size = new Size(181, 38);
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
            SaveButton.TabIndex = 106;
            SaveButton.Values.DropDownArrowColor = Color.Empty;
            SaveButton.Values.Text = "Save and Update";
            SaveButton.Click += SaveButton_Click;
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
            // NotesScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.MidnightBlue;
            BackgroundImage = Properties.Resources.ProfileScreen;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1264, 681);
            Controls.Add(tableLayoutPanel1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(900, 700);
            Name = "NotesScreen";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NotesGrid).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private DataGridView NotesGrid;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel4;
        private TextBox NotesTextBox;
        private Label label2;
        private Button button11;
        private TableLayoutPanel tableLayoutPanel5;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label3;
        private Krypton.Toolkit.KryptonButton ReturnToMenuButton;
        private Krypton.Toolkit.KryptonButton DeleteButton;
        private Krypton.Toolkit.KryptonButton EditButton;
        private Krypton.Toolkit.KryptonButton SaveButton;
        private Krypton.Toolkit.KryptonButton AddButton;
    }
}