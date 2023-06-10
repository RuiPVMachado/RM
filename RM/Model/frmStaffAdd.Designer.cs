namespace RM.Model
{
    partial class frmStaffAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStaffAdd));
            txtName = new TextBox();
            label2 = new Label();
            txtPhone = new TextBox();
            label3 = new Label();
            label4 = new Label();
            cbRole = new ComboBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Size = new Size(490, 112);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 349);
            panel2.Size = new Size(490, 70);
            panel2.TabIndex = 3;
            // 
            // label1
            // 
            label1.Size = new Size(162, 32);
            label1.TabIndex = 0;
            label1.Text = "Detalhes Staff";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            // 
            // txtName
            // 
            txtName.Location = new Point(21, 189);
            txtName.Name = "txtName";
            txtName.Size = new Size(186, 30);
            txtName.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 147);
            label2.Name = "label2";
            label2.Size = new Size(56, 23);
            label2.TabIndex = 5;
            label2.Text = "Name";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(239, 189);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(186, 30);
            txtPhone.TabIndex = 1;
            txtPhone.TextChanged += txtPhone_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(239, 147);
            label3.Name = "label3";
            label3.Size = new Size(85, 23);
            label3.TabIndex = 6;
            label3.Text = "Telemóvel";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 249);
            label4.Name = "label4";
            label4.Size = new Size(51, 23);
            label4.TabIndex = 7;
            label4.Text = "Papel";
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Items.AddRange(new object[] { "Operador de Caixa", "Empregado de Mesa", "Empregado de Limpeza", "Manager", "Outro" });
            cbRole.Location = new Point(21, 285);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(186, 31);
            cbRole.TabIndex = 2;
            // 
            // frmStaffAdd
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 419);
            Controls.Add(cbRole);
            Controls.Add(label4);
            Controls.Add(txtPhone);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Name = "frmStaffAdd";
            Text = "frmStaffAdd";
            Load += frmStaffAdd_Load;
            Controls.SetChildIndex(panel1, 0);
            Controls.SetChildIndex(panel2, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(txtName, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(txtPhone, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(cbRole, 0);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox txtName;
        private Label label2;
        public TextBox txtPhone;
        private Label label3;
        private Label label4;
        public ComboBox cbRole;
    }
}