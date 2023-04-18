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
    public partial class frmPOS : Form
    {
        public frmPOS()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPOS_Load(object sender, EventArgs e)
        {
            dataGridView1.BorderStyle = BorderStyle.FixedSingle;
            AddCategory();

            ProductPanel.Controls.Clear();
            LoadProducts();
        }

        private void AddCategory()
        {
            string qry = "Select * from Category";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            CategoryPanel.Controls.Clear();


            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    System.Windows.Forms.Button b = new System.Windows.Forms.Button();
                    b.BackColor = Color.FromArgb(50, 55, 89);
                    b.Size = new Size(134, 45);
                    b.Text = row["catName"].ToString();

                    //para o clique nas categorias
                    b.Click += new EventHandler(_Cick);

                    CategoryPanel.Controls.Add(b);
                }
            }
        }

        private void _Cick(object? sender, EventArgs e)
        {
            System.Windows.Forms.Button b = (System.Windows.Forms.Button)sender;
            foreach (var item in ProductPanel.Controls)
            {
                var pro = (ucProduct)item;
                pro.Visible = pro.PCategory.ToLower().Contains(b.Text.Trim().ToLower());
            }
        }

        private void AddItems(string id, string name, string cat, string price, Image pimage)
        {
            var w = new ucProduct()
            {
                PName = name,
                PPrice = price,
                PCategory = cat,
                PImage = pimage,
                id = Convert.ToInt32(id)
            };
            ProductPanel.Controls.Add(w);

            w.onSelect += (ss, ee) =>
            {
                var wdg = (ucProduct)ss;

                bool itemFound = false;
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    // verifica se ja esta na tabela
                    if (Convert.ToInt32(item.Cells["dgvid"].Value) == wdg.id)
                    {
                        itemFound = true;

                        //isto vai verificar se o produto ja esta la e depois adiciona um na quantidade e da update do preço
                        int newQty = int.Parse(item.Cells["dgvQty"].Value.ToString()) + 1;
                        double newAmount = newQty * double.Parse(item.Cells["dgvPrice"].Value.ToString());
                        item.Cells["dgvQty"].Value = newQty;
                        item.Cells["dgvAmount"].Value = newAmount;

                        break;
                    }
                }

                if (!itemFound)
                {
                    //esta linha adiciona um novo produto
                    dataGridView1.Rows.Add(new object[] { wdg.id, wdg.PName, 1, wdg.PPrice, wdg.PPrice });
                }

                GetTotal();
            };
        }

        //obter o produto da base de dados

        private void LoadProducts()
        {
            string qry = "Select * From products inner join category on catID = CategoryID";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                Byte[] imagearray = (byte[])item["pImage"];
                Byte[] imagebytearray = imagearray;

                AddItems(item["pID"].ToString(), item["pName"].ToString(), item["catName"].ToString(), item["pPrice"].ToString(), Image.FromStream(new MemoryStream(imagearray)));
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in ProductPanel.Controls)
            {
                var pro = (ucProduct)item;
                pro.Visible = pro.PName.ToLower().Contains(txtSearch.Text.Trim().ToLower());
            }
        }

        private void GetTotal()
        {
            double tot = 0;
            lblTotal.Text = "";
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                tot += double.Parse(item.Cells["dgvAmount"].Value.ToString());
            }
            lblTotal.Text = tot.ToString("N2");
            return;
        }
    }
}
