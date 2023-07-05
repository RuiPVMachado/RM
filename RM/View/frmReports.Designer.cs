namespace RM.View
{
    partial class frmReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReports));
            btnSales = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnSales
            // 
            btnSales.AccessibleRole = AccessibleRole.RadioButton;
            btnSales.AutoEllipsis = true;
            btnSales.BackColor = SystemColors.Highlight;
            btnSales.FlatStyle = FlatStyle.Flat;
            btnSales.ForeColor = SystemColors.ControlText;
            btnSales.Image = (Image)resources.GetObject("btnSales.Image");
            btnSales.ImageAlign = ContentAlignment.MiddleRight;
            btnSales.Location = new Point(57, 87);
            btnSales.Name = "btnSales";
            btnSales.Size = new Size(147, 105);
            btnSales.TabIndex = 3;
            btnSales.Text = "Vendas";
            btnSales.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSales.UseVisualStyleBackColor = false;
            btnSales.Click += btnSales_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(57, 30);
            label1.Name = "label1";
            label1.Size = new Size(132, 35);
            label1.TabIndex = 4;
            label1.Text = "Relatórios";
            // 
            // frmReports
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(900, 518);
            Controls.Add(label1);
            Controls.Add(btnSales);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmReports";
            Text = "frmReports";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSales;
        private Label label1;
    }
}