namespace RM.Model
{
    partial class ucProduct
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucProduct));
            panel1 = new Panel();
            panel2 = new Panel();
            lblName = new Label();
            txtImage = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtImage).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(txtImage);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 196);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblName);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 136);
            panel2.Name = "panel2";
            panel2.Size = new Size(198, 58);
            panel2.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(0, 1);
            lblName.Name = "lblName";
            lblName.Size = new Size(195, 57);
            lblName.TabIndex = 2;
            lblName.Text = "Nome do Produto";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtImage
            // 
            txtImage.Image = (Image)resources.GetObject("txtImage.Image");
            txtImage.Location = new Point(44, 16);
            txtImage.Name = "txtImage";
            txtImage.Size = new Size(110, 104);
            txtImage.SizeMode = PictureBoxSizeMode.Zoom;
            txtImage.TabIndex = 0;
            txtImage.TabStop = false;
            txtImage.Click += txtImage_Click;
            // 
            // ucProduct
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(panel1);
            Name = "ucProduct";
            Size = new Size(206, 202);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label lblName;
        private PictureBox txtImage;
    }
}
