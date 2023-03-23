namespace RM.Model
{
    partial class frmTableAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTableAdd));
            txtName = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Location = new Point(218, 15);
            // 
            // panel1
            // 
            panel1.Size = new Size(380, 112);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 264);
            panel2.Size = new Size(380, 70);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.Location = new Point(130, 43);
            label1.Size = new Size(224, 32);
            label1.Text = "Detalhes das Mesas";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(38, 15);
            // 
            // txtName
            // 
            txtName.Location = new Point(38, 192);
            txtName.Name = "txtName";
            txtName.Size = new Size(297, 30);
            txtName.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 150);
            label2.Name = "label2";
            label2.Size = new Size(56, 23);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // frmTableAdd
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 334);
            Controls.Add(txtName);
            Controls.Add(label2);
            Name = "frmTableAdd";
            Text = "frmTableAdd";
            Controls.SetChildIndex(panel1, 0);
            Controls.SetChildIndex(panel2, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(txtName, 0);
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
    }
}