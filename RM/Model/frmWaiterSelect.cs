using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM.Model
{
    public partial class frmWaiterSelect : Form
    {
        public frmWaiterSelect()
        {
            InitializeComponent();
        }

        public string waiterName;

        private void frmWaiterSelect_Load(object sender, EventArgs e)
        {
            string qry = "Select * from staff where sRole = 'Empregado de Mesa'";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                System.Windows.Forms.Button b = new System.Windows.Forms.Button();
                b.Text = row["sName"].ToString();
                b.Width = 150;
                b.Height = 50;
                b.BackColor = Color.FromArgb(241, 85, 126);

                //para o clique
                b.Click += new EventHandler(b_Click);

                flowLayoutPanel1.Controls.Add(b);
            }

        }
        private void b_Click(object? sender, EventArgs e)
        {
            waiterName = (sender as System.Windows.Forms.Button).Text.ToString();
            this.Close();
        }
    }
}
