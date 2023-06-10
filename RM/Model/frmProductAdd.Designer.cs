namespace RM.Model
{
    partial class frmProductAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductAdd));
            cbCat = new ComboBox();
            label4 = new Label();
            txtPrice = new TextBox();
            label3 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            txtImage = new PictureBox();
            btnBrowse = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtImage).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Size = new Size(800, 112);
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 380);
            panel2.Size = new Size(800, 70);
            // 
            // label1
            // 
            label1.Size = new Size(234, 32);
            label1.Text = "Detalhes do Produto";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            // 
            // cbCat
            // 
            cbCat.FormattingEnabled = true;
            cbCat.Location = new Point(21, 288);
            cbCat.Name = "cbCat";
            cbCat.Size = new Size(186, 31);
            cbCat.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 252);
            label4.Name = "label4";
            label4.Size = new Size(84, 23);
            label4.TabIndex = 13;
            label4.Text = "Categoria";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(239, 192);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(186, 30);
            txtPrice.TabIndex = 9;
            txtPrice.TextChanged += txtPrice_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(239, 150);
            label3.Name = "label3";
            label3.Size = new Size(53, 23);
            label3.TabIndex = 12;
            label3.Text = "Preço";
            // 
            // txtName
            // 
            txtName.Location = new Point(21, 192);
            txtName.Name = "txtName";
            txtName.Size = new Size(186, 30);
            txtName.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 150);
            label2.Name = "label2";
            label2.Size = new Size(57, 23);
            label2.TabIndex = 11;
            label2.Text = "Nome";
            // 
            // txtImage
            // 
            txtImage.Image = (Image)resources.GetObject("txtImage.Image");
            txtImage.Location = new Point(513, 160);
            txtImage.Name = "txtImage";
            txtImage.Size = new Size(178, 134);
            txtImage.SizeMode = PictureBoxSizeMode.Zoom;
            txtImage.TabIndex = 14;
            txtImage.TabStop = false;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(513, 318);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(178, 47);
            btnBrowse.TabIndex = 15;
            btnBrowse.Text = "Pesquisar";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // frmProductAdd
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBrowse);
            Controls.Add(txtImage);
            Controls.Add(cbCat);
            Controls.Add(label4);
            Controls.Add(txtPrice);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Name = "frmProductAdd";
            Text = "frmProductAdd";
            Load += frmProductAdd_Load;
            Controls.SetChildIndex(panel1, 0);
            Controls.SetChildIndex(panel2, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(txtName, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(txtPrice, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(cbCat, 0);
            Controls.SetChildIndex(txtImage, 0);
            Controls.SetChildIndex(btnBrowse, 0);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public ComboBox cbCat;
        private Label label4;
        public TextBox txtPrice;
        private Label label3;
        public TextBox txtName;
        private Label label2;
        private PictureBox txtImage;
        private Button btnBrowse;
    }
}