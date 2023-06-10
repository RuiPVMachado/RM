namespace RM
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            panel1 = new Panel();
            btnSettings = new Button();
            btnKitchen = new Button();
            btnPOS = new Button();
            btnStaff = new Button();
            btnTable = new Button();
            brnProducts = new Button();
            btnCategory = new Button();
            btnHome = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            lblUser = new Label();
            button3 = new Button();
            button2 = new Button();
            btnExit = new Button();
            CenterPanel = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(btnSettings);
            panel1.Controls.Add(btnKitchen);
            panel1.Controls.Add(btnPOS);
            panel1.Controls.Add(btnStaff);
            panel1.Controls.Add(btnTable);
            panel1.Controls.Add(brnProducts);
            panel1.Controls.Add(btnCategory);
            panel1.Controls.Add(btnHome);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(287, 778);
            panel1.TabIndex = 0;
            // 
            // btnSettings
            // 
            btnSettings.AccessibleRole = AccessibleRole.RadioButton;
            btnSettings.AutoEllipsis = true;
            btnSettings.BackColor = Color.Transparent;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Image = (Image)resources.GetObject("btnSettings.Image");
            btnSettings.ImageAlign = ContentAlignment.MiddleRight;
            btnSettings.Location = new Point(54, 769);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(188, 64);
            btnSettings.TabIndex = 8;
            btnSettings.Text = "Definições";
            btnSettings.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSettings.UseVisualStyleBackColor = false;
            // 
            // btnKitchen
            // 
            btnKitchen.AccessibleRole = AccessibleRole.RadioButton;
            btnKitchen.AutoEllipsis = true;
            btnKitchen.BackColor = Color.Transparent;
            btnKitchen.FlatStyle = FlatStyle.Flat;
            btnKitchen.Image = (Image)resources.GetObject("btnKitchen.Image");
            btnKitchen.ImageAlign = ContentAlignment.MiddleRight;
            btnKitchen.Location = new Point(54, 684);
            btnKitchen.Name = "btnKitchen";
            btnKitchen.Size = new Size(188, 64);
            btnKitchen.TabIndex = 7;
            btnKitchen.Text = "Cozinha";
            btnKitchen.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnKitchen.UseVisualStyleBackColor = false;
            // 
            // btnPOS
            // 
            btnPOS.AccessibleRole = AccessibleRole.RadioButton;
            btnPOS.AutoEllipsis = true;
            btnPOS.BackColor = Color.Transparent;
            btnPOS.FlatStyle = FlatStyle.Flat;
            btnPOS.Image = (Image)resources.GetObject("btnPOS.Image");
            btnPOS.ImageAlign = ContentAlignment.MiddleRight;
            btnPOS.Location = new Point(54, 598);
            btnPOS.Name = "btnPOS";
            btnPOS.Size = new Size(188, 64);
            btnPOS.TabIndex = 6;
            btnPOS.Text = "POS";
            btnPOS.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPOS.UseVisualStyleBackColor = false;
            btnPOS.Click += btnPOS_Click;
            // 
            // btnStaff
            // 
            btnStaff.AccessibleRole = AccessibleRole.RadioButton;
            btnStaff.AutoEllipsis = true;
            btnStaff.BackColor = Color.Transparent;
            btnStaff.FlatStyle = FlatStyle.Flat;
            btnStaff.Image = (Image)resources.GetObject("btnStaff.Image");
            btnStaff.ImageAlign = ContentAlignment.MiddleRight;
            btnStaff.Location = new Point(54, 507);
            btnStaff.Name = "btnStaff";
            btnStaff.Size = new Size(188, 64);
            btnStaff.TabIndex = 3;
            btnStaff.Text = "Staff";
            btnStaff.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnStaff.UseVisualStyleBackColor = false;
            btnStaff.Click += btnStaff_Click;
            // 
            // btnTable
            // 
            btnTable.AccessibleRole = AccessibleRole.RadioButton;
            btnTable.AutoEllipsis = true;
            btnTable.BackColor = Color.Transparent;
            btnTable.FlatStyle = FlatStyle.Flat;
            btnTable.Image = (Image)resources.GetObject("btnTable.Image");
            btnTable.ImageAlign = ContentAlignment.MiddleRight;
            btnTable.Location = new Point(54, 417);
            btnTable.Name = "btnTable";
            btnTable.Size = new Size(188, 64);
            btnTable.TabIndex = 5;
            btnTable.Text = "Mesas";
            btnTable.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTable.UseVisualStyleBackColor = false;
            btnTable.Click += btnTable_Click;
            // 
            // brnProducts
            // 
            brnProducts.AccessibleRole = AccessibleRole.RadioButton;
            brnProducts.AutoEllipsis = true;
            brnProducts.BackColor = Color.Transparent;
            brnProducts.FlatStyle = FlatStyle.Flat;
            brnProducts.Image = (Image)resources.GetObject("brnProducts.Image");
            brnProducts.ImageAlign = ContentAlignment.MiddleRight;
            brnProducts.Location = new Point(54, 328);
            brnProducts.Name = "brnProducts";
            brnProducts.Size = new Size(188, 64);
            brnProducts.TabIndex = 4;
            brnProducts.Text = "Produtos";
            brnProducts.TextImageRelation = TextImageRelation.ImageBeforeText;
            brnProducts.UseVisualStyleBackColor = false;
            brnProducts.Click += brnProducts_Click;
            // 
            // btnCategory
            // 
            btnCategory.AccessibleRole = AccessibleRole.RadioButton;
            btnCategory.AutoEllipsis = true;
            btnCategory.BackColor = Color.Transparent;
            btnCategory.FlatStyle = FlatStyle.Flat;
            btnCategory.Image = (Image)resources.GetObject("btnCategory.Image");
            btnCategory.ImageAlign = ContentAlignment.MiddleRight;
            btnCategory.Location = new Point(54, 246);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(188, 60);
            btnCategory.TabIndex = 3;
            btnCategory.Text = "Categorias";
            btnCategory.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCategory.UseVisualStyleBackColor = true;
            btnCategory.Click += btnCategory_Click;
            // 
            // btnHome
            // 
            btnHome.AccessibleRole = AccessibleRole.RadioButton;
            btnHome.AutoEllipsis = true;
            btnHome.BackColor = Color.Transparent;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.ForeColor = SystemColors.ControlText;
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.ImageAlign = ContentAlignment.MiddleRight;
            btnHome.Location = new Point(54, 165);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(188, 58);
            btnHome.TabIndex = 2;
            btnHome.Text = "Home";
            btnHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(54, 98);
            label1.Name = "label1";
            label1.Size = new Size(188, 34);
            label1.TabIndex = 1;
            label1.Text = "POS Restauração";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.png_transparent_fork_steak_knife_drawing_table_knives_garfo_kitchen_bedroom_fork_removebg_preview;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(287, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(lblUser);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(btnExit);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(287, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1090, 69);
            panel3.TabIndex = 2;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUser.Location = new Point(37, 24);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(65, 28);
            lblUser.TabIndex = 3;
            lblUser.Text = "label2";
            // 
            // button3
            // 
            button3.Dock = DockStyle.Right;
            button3.Location = new Point(898, 0);
            button3.Name = "button3";
            button3.Size = new Size(66, 69);
            button3.TabIndex = 2;
            button3.Text = "⬜";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Right;
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(964, 0);
            button2.Name = "button2";
            button2.Size = new Size(63, 69);
            button2.TabIndex = 1;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Dock = DockStyle.Right;
            btnExit.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.Location = new Point(1027, 0);
            btnExit.Name = "btnExit";
            btnExit.RightToLeft = RightToLeft.No;
            btnExit.Size = new Size(63, 69);
            btnExit.TabIndex = 0;
            btnExit.Text = "x";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // CenterPanel
            // 
            CenterPanel.Dock = DockStyle.Fill;
            CenterPanel.Location = new Point(287, 69);
            CenterPanel.Name = "CenterPanel";
            CenterPanel.Size = new Size(1090, 709);
            CenterPanel.TabIndex = 3;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1377, 778);
            Controls.Add(CenterPanel);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMain";
            Text = "frmMain";
            WindowState = FormWindowState.Maximized;
            Load += frmMain_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Button button3;
        private Button button2;
        private Button btnExit;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnHome;
        private Button btnSettings;
        private Button btnKitchen;
        private Button btnPOS;
        private Button btnStaff;
        private Button btnTable;
        private Button brnProducts;
        private Button btnCategory;
        private Label lblUser;
        private Panel CenterPanel;
    }
}