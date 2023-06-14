namespace RM.Model
{
    partial class frmCheckout
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
            txtBillAmount = new TextBox();
            label2 = new Label();
            txtReceived = new TextBox();
            label3 = new Label();
            txtChange = new TextBox();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnClose.Location = new Point(133, 15);
            btnClose.Size = new Size(134, 51);
            btnClose.Click += btnClose_Click_1;
            // 
            // panel1
            // 
            panel1.Size = new Size(552, 112);
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 372);
            panel2.Size = new Size(552, 78);
            // 
            // label1
            // 
            label1.Size = new Size(126, 32);
            label1.Text = "Check Out";
            // 
            // pictureBox1
            // 
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 15);
            btnSave.Size = new Size(109, 51);
            // 
            // txtBillAmount
            // 
            txtBillAmount.Enabled = false;
            txtBillAmount.Location = new Point(21, 195);
            txtBillAmount.Name = "txtBillAmount";
            txtBillAmount.Size = new Size(186, 30);
            txtBillAmount.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 153);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 7;
            label2.Text = "Valor Conta";
            // 
            // txtReceived
            // 
            txtReceived.Location = new Point(274, 195);
            txtReceived.MaxLength = 10;
            txtReceived.Name = "txtReceived";
            txtReceived.Size = new Size(186, 30);
            txtReceived.TabIndex = 8;
            txtReceived.TextChanged += textReceived_TextChanged;
            txtReceived.KeyPress += txtReceived_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(274, 153);
            label3.Name = "label3";
            label3.Size = new Size(189, 23);
            label3.TabIndex = 9;
            label3.Text = "Valor pago pelo Cliente";
            // 
            // txtChange
            // 
            txtChange.Enabled = false;
            txtChange.Location = new Point(21, 306);
            txtChange.Name = "txtChange";
            txtChange.Size = new Size(186, 30);
            txtChange.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 264);
            label4.Name = "label4";
            label4.Size = new Size(52, 23);
            label4.TabIndex = 11;
            label4.Text = "Troco";
            // 
            // frmCheckout
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 450);
            Controls.Add(txtChange);
            Controls.Add(label4);
            Controls.Add(txtReceived);
            Controls.Add(label3);
            Controls.Add(txtBillAmount);
            Controls.Add(label2);
            Name = "frmCheckout";
            Text = "frmCheckout";
            Load += frmCheckout_Load;
            Controls.SetChildIndex(panel1, 0);
            Controls.SetChildIndex(panel2, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(txtBillAmount, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(txtReceived, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(txtChange, 0);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public TextBox txtBillAmount;
        private Label label2;
        public TextBox txtReceived;
        private Label label3;
        public TextBox txtChange;
        private Label label4;
    }
}