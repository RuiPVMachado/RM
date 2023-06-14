namespace RM.Model
{
    partial class frmBillList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBillList));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnExit = new Button();
            dataGridView1 = new DataGridView();
            dgvid = new DataGridViewTextBoxColumn();
            dgvtable = new DataGridViewTextBoxColumn();
            dgvWaiter = new DataGridViewTextBoxColumn();
            dgvType = new DataGridViewTextBoxColumn();
            dgvStatus = new DataGridViewTextBoxColumn();
            dgvTotal = new DataGridViewTextBoxColumn();
            dgvedit = new DataGridViewImageColumn();
            dgvdel = new DataGridViewImageColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnExit);
            panel1.Size = new Size(918, 112);
            panel1.Controls.SetChildIndex(pictureBox1, 0);
            panel1.Controls.SetChildIndex(label1, 0);
            panel1.Controls.SetChildIndex(btnExit, 0);
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 622);
            panel2.Size = new Size(918, 10);
            // 
            // label1
            // 
            label1.Location = new Point(135, 33);
            label1.Size = new Size(237, 32);
            label1.Text = "Lista de Faturamento";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnExit.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.Location = new Point(823, 21);
            btnExit.Name = "btnExit";
            btnExit.RightToLeft = RightToLeft.No;
            btnExit.Size = new Size(69, 59);
            btnExit.TabIndex = 2;
            btnExit.Text = "x";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dgvid, dgvtable, dgvWaiter, dgvType, dgvStatus, dgvTotal, dgvedit, dgvdel });
            dataGridView1.GridColor = Color.FromArgb(231, 229, 255);
            dataGridView1.Location = new Point(41, 141);
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
            dataGridView1.Size = new Size(851, 375);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // dgvid
            // 
            dgvid.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvid.HeaderText = "id";
            dgvid.MinimumWidth = 6;
            dgvid.Name = "dgvid";
            dgvid.ReadOnly = true;
            dgvid.Resizable = DataGridViewTriState.False;
            dgvid.Visible = false;
            dgvid.Width = 125;
            // 
            // dgvtable
            // 
            dgvtable.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvtable.HeaderText = "Mesa";
            dgvtable.MinimumWidth = 6;
            dgvtable.Name = "dgvtable";
            dgvtable.ReadOnly = true;
            dgvtable.Resizable = DataGridViewTriState.False;
            // 
            // dgvWaiter
            // 
            dgvWaiter.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvWaiter.HeaderText = "Empregado";
            dgvWaiter.MinimumWidth = 6;
            dgvWaiter.Name = "dgvWaiter";
            dgvWaiter.ReadOnly = true;
            dgvWaiter.Resizable = DataGridViewTriState.False;
            // 
            // dgvType
            // 
            dgvType.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvType.HeaderText = "Order Type";
            dgvType.MinimumWidth = 6;
            dgvType.Name = "dgvType";
            dgvType.ReadOnly = true;
            dgvType.Resizable = DataGridViewTriState.False;
            // 
            // dgvStatus
            // 
            dgvStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvStatus.HeaderText = "Order Status";
            dgvStatus.MinimumWidth = 6;
            dgvStatus.Name = "dgvStatus";
            dgvStatus.ReadOnly = true;
            dgvStatus.Resizable = DataGridViewTriState.False;
            // 
            // dgvTotal
            // 
            dgvTotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvTotal.HeaderText = "Total";
            dgvTotal.MinimumWidth = 6;
            dgvTotal.Name = "dgvTotal";
            dgvTotal.ReadOnly = true;
            dgvTotal.Resizable = DataGridViewTriState.False;
            // 
            // dgvedit
            // 
            dgvedit.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvedit.FillWeight = 50F;
            dgvedit.HeaderText = "";
            dgvedit.Image = (Image)resources.GetObject("dgvedit.Image");
            dgvedit.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvedit.MinimumWidth = 50;
            dgvedit.Name = "dgvedit";
            dgvedit.ReadOnly = true;
            dgvedit.Resizable = DataGridViewTriState.False;
            // 
            // dgvdel
            // 
            dgvdel.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvdel.FillWeight = 50F;
            dgvdel.HeaderText = "";
            dgvdel.Image = (Image)resources.GetObject("dgvdel.Image");
            dgvdel.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvdel.MinimumWidth = 50;
            dgvdel.Name = "dgvdel";
            dgvdel.ReadOnly = true;
            dgvdel.Resizable = DataGridViewTriState.False;
            dgvdel.Visible = false;
            dgvdel.Width = 50;
            // 
            // frmBillList
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 632);
            Controls.Add(dataGridView1);
            Name = "frmBillList";
            Text = "frmBillList";
            Load += frmBillList_Load;
            Controls.SetChildIndex(panel1, 0);
            Controls.SetChildIndex(panel2, 0);
            Controls.SetChildIndex(dataGridView1, 0);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnExit;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dgvid;
        private DataGridViewTextBoxColumn dgvtable;
        private DataGridViewTextBoxColumn dgvWaiter;
        private DataGridViewTextBoxColumn dgvType;
        private DataGridViewTextBoxColumn dgvStatus;
        private DataGridViewTextBoxColumn dgvTotal;
        private DataGridViewImageColumn dgvedit;
        private DataGridViewImageColumn dgvdel;
    }
}