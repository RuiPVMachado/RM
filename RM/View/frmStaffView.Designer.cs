namespace RM.View
{
    partial class frmStaffView
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStaffView));
            dataGridView1 = new DataGridView();
            dgvid = new DataGridViewTextBoxColumn();
            dgvName = new DataGridViewTextBoxColumn();
            dgvPhone = new DataGridViewTextBoxColumn();
            dgvRole = new DataGridViewTextBoxColumn();
            dgvedit = new DataGridViewImageColumn();
            dgvdel = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Size = new Size(150, 32);
            label2.Text = "Lista de Staff";
            // 
            // label1
            // 
            label1.Location = new Point(593, 79);
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(593, 105);
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dgvid, dgvName, dgvPhone, dgvRole, dgvedit, dgvdel });
            dataGridView1.GridColor = Color.FromArgb(231, 229, 255);
            dataGridView1.Location = new Point(46, 159);
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
            dataGridView1.Size = new Size(832, 372);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // dgvid
            // 
            dgvid.HeaderText = "id";
            dgvid.MinimumWidth = 6;
            dgvid.Name = "dgvid";
            dgvid.ReadOnly = true;
            dgvid.Resizable = DataGridViewTriState.False;
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
            // dgvPhone
            // 
            dgvPhone.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvPhone.HeaderText = "Telemóvel";
            dgvPhone.MinimumWidth = 6;
            dgvPhone.Name = "dgvPhone";
            dgvPhone.ReadOnly = true;
            // 
            // dgvRole
            // 
            dgvRole.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvRole.HeaderText = "Papel";
            dgvRole.MinimumWidth = 6;
            dgvRole.Name = "dgvRole";
            dgvRole.ReadOnly = true;
            // 
            // dgvedit
            // 
            dgvedit.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvedit.FillWeight = 50F;
            dgvedit.HeaderText = "";
            dgvedit.Image = (Image)resources.GetObject("dgvedit.Image");
            dgvedit.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvedit.MinimumWidth = 50;
            dgvedit.Name = "dgvedit";
            dgvedit.ReadOnly = true;
            dgvedit.Resizable = DataGridViewTriState.False;
            dgvedit.Width = 50;
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
            dgvdel.Width = 50;
            // 
            // frmStaffView
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 552);
            Controls.Add(dataGridView1);
            Name = "frmStaffView";
            Text = "frmStaffView";
            Load += frmStaffView_Load;
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(txtSearch, 0);
            Controls.SetChildIndex(btnAdd, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(dataGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dgvid;
        private DataGridViewTextBoxColumn dgvName;
        private DataGridViewTextBoxColumn dgvPhone;
        private DataGridViewTextBoxColumn dgvRole;
        private DataGridViewImageColumn dgvedit;
        private DataGridViewImageColumn dgvdel;
    }
}