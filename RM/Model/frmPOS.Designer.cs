namespace RM.Model
{
    partial class frmPOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPOS));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnExit = new PictureBox();
            lblWaiter = new Label();
            lblTable = new Label();
            btnDin = new Button();
            btnTake = new Button();
            btnDelivery = new Button();
            btnKot = new Button();
            btnBill = new Button();
            btnHold = new Button();
            btnNew = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnCheckout = new Button();
            lblTotal = new Label();
            label2 = new Label();
            CategoryPanel = new FlowLayoutPanel();
            ProductPanel = new FlowLayoutPanel();
            dataGridView1 = new DataGridView();
            dgvproID = new DataGridViewTextBoxColumn();
            dgvid = new DataGridViewTextBoxColumn();
            dgvName = new DataGridViewTextBoxColumn();
            dgvQty = new DataGridViewTextBoxColumn();
            dgvPrice = new DataGridViewTextBoxColumn();
            dgvAmount = new DataGridViewTextBoxColumn();
            txtSearch = new TextBox();
            allProducts = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnExit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(lblWaiter);
            panel1.Controls.Add(lblTable);
            panel1.Controls.Add(btnDin);
            panel1.Controls.Add(btnTake);
            panel1.Controls.Add(btnDelivery);
            panel1.Controls.Add(btnKot);
            panel1.Controls.Add(btnBill);
            panel1.Controls.Add(btnHold);
            panel1.Controls.Add(btnNew);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1372, 95);
            panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.Location = new Point(1293, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(67, 67);
            btnExit.SizeMode = PictureBoxSizeMode.Zoom;
            btnExit.TabIndex = 11;
            btnExit.TabStop = false;
            btnExit.Click += btnExit_Click;
            // 
            // lblWaiter
            // 
            lblWaiter.AutoSize = true;
            lblWaiter.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblWaiter.Location = new Point(993, 49);
            lblWaiter.Name = "lblWaiter";
            lblWaiter.Size = new Size(155, 37);
            lblWaiter.TabIndex = 10;
            lblWaiter.Text = "Empregado";
            lblWaiter.Visible = false;
            // 
            // lblTable
            // 
            lblTable.AutoSize = true;
            lblTable.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblTable.Location = new Point(993, 12);
            lblTable.Name = "lblTable";
            lblTable.Size = new Size(80, 37);
            lblTable.TabIndex = 9;
            lblTable.Text = "Mesa";
            lblTable.Visible = false;
            // 
            // btnDin
            // 
            btnDin.BackColor = Color.FromArgb(22, 114, 184);
            btnDin.Location = new Point(867, 12);
            btnDin.Name = "btnDin";
            btnDin.Size = new Size(78, 78);
            btnDin.TabIndex = 8;
            btnDin.Text = "Din in";
            btnDin.UseVisualStyleBackColor = false;
            btnDin.Click += btnDin_Click;
            // 
            // btnTake
            // 
            btnTake.BackColor = Color.FromArgb(22, 114, 184);
            btnTake.Location = new Point(773, 12);
            btnTake.Name = "btnTake";
            btnTake.Size = new Size(78, 78);
            btnTake.TabIndex = 7;
            btnTake.Text = "Take Away";
            btnTake.UseVisualStyleBackColor = false;
            btnTake.Click += btnTake_Click;
            // 
            // btnDelivery
            // 
            btnDelivery.BackColor = Color.FromArgb(22, 114, 184);
            btnDelivery.Location = new Point(674, 12);
            btnDelivery.Name = "btnDelivery";
            btnDelivery.Size = new Size(84, 78);
            btnDelivery.TabIndex = 6;
            btnDelivery.Text = "Entregas";
            btnDelivery.UseVisualStyleBackColor = false;
            btnDelivery.Click += btnDelivery_Click;
            // 
            // btnKot
            // 
            btnKot.BackColor = Color.FromArgb(22, 114, 184);
            btnKot.Image = (Image)resources.GetObject("btnKot.Image");
            btnKot.ImageAlign = ContentAlignment.TopCenter;
            btnKot.Location = new Point(581, 12);
            btnKot.Name = "btnKot";
            btnKot.Size = new Size(78, 78);
            btnKot.TabIndex = 5;
            btnKot.Text = "\r\nKOT";
            btnKot.UseVisualStyleBackColor = false;
            btnKot.Click += btnKot_Click;
            // 
            // btnBill
            // 
            btnBill.BackColor = Color.FromArgb(22, 114, 184);
            btnBill.Image = (Image)resources.GetObject("btnBill.Image");
            btnBill.ImageAlign = ContentAlignment.TopCenter;
            btnBill.Location = new Point(449, 9);
            btnBill.Name = "btnBill";
            btnBill.Size = new Size(117, 78);
            btnBill.TabIndex = 4;
            btnBill.Text = "\r\nLista de Faturamento";
            btnBill.UseVisualStyleBackColor = false;
            btnBill.Click += btnBill_Click;
            // 
            // btnHold
            // 
            btnHold.BackColor = Color.FromArgb(22, 114, 184);
            btnHold.Image = Properties.Resources.hold;
            btnHold.ImageAlign = ContentAlignment.TopCenter;
            btnHold.Location = new Point(355, 9);
            btnHold.Name = "btnHold";
            btnHold.Size = new Size(78, 78);
            btnHold.TabIndex = 3;
            btnHold.Text = "\r\nSegurar";
            btnHold.UseVisualStyleBackColor = false;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.FromArgb(22, 114, 184);
            btnNew.Image = Properties.Resources.newTicket;
            btnNew.ImageAlign = ContentAlignment.TopCenter;
            btnNew.Location = new Point(261, 9);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(78, 78);
            btnNew.TabIndex = 2;
            btnNew.Text = "\r\nNovo";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(85, 31);
            label1.Name = "label1";
            label1.Size = new Size(66, 37);
            label1.TabIndex = 1;
            label1.Text = "POS";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.payment_terminalMED;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(btnCheckout);
            panel2.Controls.Add(lblTotal);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 593);
            panel2.Name = "panel2";
            panel2.Size = new Size(1372, 81);
            panel2.TabIndex = 1;
            // 
            // btnCheckout
            // 
            btnCheckout.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnCheckout.BackColor = Color.FromArgb(22, 114, 184);
            btnCheckout.ForeColor = Color.White;
            btnCheckout.Location = new Point(900, 26);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(136, 43);
            btnCheckout.TabIndex = 4;
            btnCheckout.Text = "Check Out";
            btnCheckout.UseVisualStyleBackColor = false;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotal.Location = new Point(1196, 18);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(164, 54);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "0000.00";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(1092, 18);
            label2.Name = "label2";
            label2.Size = new Size(107, 54);
            label2.TabIndex = 2;
            label2.Text = "Total";
            // 
            // CategoryPanel
            // 
            CategoryPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            CategoryPanel.AutoScroll = true;
            CategoryPanel.Location = new Point(12, 153);
            CategoryPanel.Name = "CategoryPanel";
            CategoryPanel.Size = new Size(139, 434);
            CategoryPanel.TabIndex = 2;
            // 
            // ProductPanel
            // 
            ProductPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ProductPanel.AutoScroll = true;
            ProductPanel.Location = new Point(157, 153);
            ProductPanel.Name = "ProductPanel";
            ProductPanel.Size = new Size(704, 434);
            ProductPanel.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(232, 234, 237);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 40;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dgvproID, dgvid, dgvName, dgvQty, dgvPrice, dgvAmount });
            dataGridView1.GridColor = Color.FromArgb(231, 229, 255);
            dataGridView1.Location = new Point(867, 153);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(239, 241, 243);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(493, 434);
            dataGridView1.TabIndex = 7;
            // 
            // dgvproID
            // 
            dgvproID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvproID.HeaderText = "ProductID";
            dgvproID.MinimumWidth = 6;
            dgvproID.Name = "dgvproID";
            dgvproID.ReadOnly = true;
            dgvproID.Resizable = DataGridViewTriState.False;
            dgvproID.Visible = false;
            dgvproID.Width = 63;
            // 
            // dgvid
            // 
            dgvid.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvid.HeaderText = "id";
            dgvid.MinimumWidth = 6;
            dgvid.Name = "dgvid";
            dgvid.ReadOnly = true;
            dgvid.Visible = false;
            dgvid.Width = 125;
            // 
            // dgvName
            // 
            dgvName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvName.HeaderText = "Nome";
            dgvName.MinimumWidth = 6;
            dgvName.Name = "dgvName";
            dgvName.ReadOnly = true;
            dgvName.Resizable = DataGridViewTriState.False;
            // 
            // dgvQty
            // 
            dgvQty.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvQty.HeaderText = "Qty";
            dgvQty.MinimumWidth = 6;
            dgvQty.Name = "dgvQty";
            dgvQty.ReadOnly = true;
            // 
            // dgvPrice
            // 
            dgvPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvPrice.HeaderText = "Preço";
            dgvPrice.MinimumWidth = 6;
            dgvPrice.Name = "dgvPrice";
            dgvPrice.ReadOnly = true;
            // 
            // dgvAmount
            // 
            dgvAmount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvAmount.HeaderText = "Quantidade";
            dgvAmount.MinimumWidth = 6;
            dgvAmount.Name = "dgvAmount";
            dgvAmount.ReadOnly = true;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtSearch.Location = new Point(157, 111);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Pesquise Aqui";
            txtSearch.Size = new Size(285, 30);
            txtSearch.TabIndex = 8;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // allProducts
            // 
            allProducts.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            allProducts.Location = new Point(12, 106);
            allProducts.Name = "allProducts";
            allProducts.Size = new Size(139, 41);
            allProducts.TabIndex = 9;
            allProducts.Text = "Todos os Produtos";
            allProducts.UseVisualStyleBackColor = true;
            allProducts.Click += allProducts_Click;
            // 
            // frmPOS
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1372, 674);
            Controls.Add(allProducts);
            Controls.Add(txtSearch);
            Controls.Add(dataGridView1);
            Controls.Add(ProductPanel);
            Controls.Add(CategoryPanel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPOS";
            Text = "frmPOS";
            WindowState = FormWindowState.Maximized;
            Load += frmPOS_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnExit).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button btnNew;
        private Label label1;
        private Button btnDin;
        private Button btnTake;
        private Button btnDelivery;
        private Button btnKot;
        private Button btnBill;
        private Button btnHold;
        private PictureBox btnExit;
        private Label lblWaiter;
        private Label lblTable;
        private FlowLayoutPanel CategoryPanel;
        private FlowLayoutPanel ProductPanel;
        private DataGridView dataGridView1;
        private ucProduct ucProduct1;
        private ucProduct ucProduct2;
        public TextBox txtSearch;
        private Label lblTotal;
        private Label label2;
        public Button btnCheckout;
        private DataGridViewTextBoxColumn dgvproID;
        private DataGridViewTextBoxColumn dgvid;
        private DataGridViewTextBoxColumn dgvName;
        private DataGridViewTextBoxColumn dgvQty;
        private DataGridViewTextBoxColumn dgvPrice;
        private DataGridViewTextBoxColumn dgvAmount;
        private Button allProducts;
    }
}