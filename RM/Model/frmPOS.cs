using System;
using System.Collections;
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
            if (lblTotal.Text == "0000.00")
            {
                btnCheckout.Visible = false;
            }
        }

        public int MainID = 0;
        public string OrderType;
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
                    b.Click += new EventHandler(b_Click);

                    CategoryPanel.Controls.Add(b);
                }
            }
        }

        private void b_Click(object? sender, EventArgs e)
        {
            System.Windows.Forms.Button b = (System.Windows.Forms.Button)sender;
            if (b.Text == "All Categories")
            {
                txtSearch.Text = "1";
                txtSearch.Text = "";
                return;
            }

            foreach (var item in ProductPanel.Controls)
            {
                var pro = (ucProduct)item;
                pro.Visible = pro.PCategory.ToLower().Contains(b.Text.Trim().ToLower());
            }
        }
        private void allProducts_Click(object sender, EventArgs e)
        {
            foreach (var item in ProductPanel.Controls)
            {
                var pro = (ucProduct)item;
                pro.Visible = true;
            }
        }
        private void AddItems(string id, string proID, string name, string cat, string price, Image pimage)
        {
            var w = new ucProduct()
            {
                PName = name,
                PPrice = price,
                PCategory = cat,
                PImage = pimage,
                id = Convert.ToInt32(proID)
            };
            ProductPanel.Controls.Add(w);

            w.onSelect += (ss, ee) =>
            {
                btnCheckout.Visible = true;
                var wdg = (ucProduct)ss;

                bool itemFound = false;
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {

                    // verifica se ja esta na tabela
                    if (Convert.ToInt32(item.Cells["dgvproID"].Value) == wdg.id)
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
                    int counter = 1;
                    dataGridView1.Rows.Add(new object[] { wdg.id, counter, wdg.PName, 1, wdg.PPrice, wdg.PPrice });
                    counter++;
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
                AddItems("0", item["pID"].ToString(), item["pName"].ToString(), item["catName"].ToString(), item["pPrice"].ToString(), Image.FromStream(new MemoryStream(imagearray)));
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

        private void btnNew_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Tem a certeza?", "Pergunta", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                lblTable.Text = "";
                lblWaiter.Text = "";
                lblTable.Visible = false;
                lblWaiter.Visible = false;
                dataGridView1.Rows.Clear();
                MainID = 0;
                lblTotal.Text = "0000.00";
                btnCheckout.Visible = false;
            }
        }

        private void btnDelivery_Click(object sender, EventArgs e)
        {
            lblTable.Text = "";
            lblWaiter.Text = "";
            lblTable.Visible = false;
            lblWaiter.Visible = false;
            OrderType = "Delivery";
        }

        private void btnTake_Click(object sender, EventArgs e)
        {
            lblTable.Text = "";
            lblWaiter.Text = "";
            lblTable.Visible = false;
            lblWaiter.Visible = false;
            OrderType = "Take Away";
        }

        private void btnDin_Click(object sender, EventArgs e)
        {
            OrderType = "Din In";

            frmTableSelect frm = new frmTableSelect();
            MainClass.BlurBackground(frm);
            if (frm.TableName != "")
            {
                lblTable.Text = frm.TableName;
                lblTable.Visible = true;
            }
            else
            {
                lblTable.Text = "";
                lblTable.Visible = false;
            }

            frmWaiterSelect frm2 = new frmWaiterSelect();
            MainClass.BlurBackground(frm2);
            if (frm2.waiterName != "")
            {
                lblWaiter.Text = frm2.waiterName;
                lblWaiter.Visible = true;
            }
            else
            {
                lblWaiter.Text = "";
                lblWaiter.Visible = false;
            }
        }

        private void btnKot_Click(object sender, EventArgs e)
        {
            string qry1 = ""; //tabela principal
            string qry2 = ""; //tabela de detalhes

            int detailID;

            if (String.IsNullOrEmpty(OrderType))
            {
                MessageBox.Show("Selecione primeiro um metodo de entrega");
                return;
            }
            if (lblTotal.Text == "0000.00")
            {
                MessageBox.Show("O valor total é de 0 ");
                return;
            }
            if (MainID == 0) //inserir
            {
                qry1 = @"Insert into tblMain Values(@aDate, @aTime, @TableName, @WaiterName, @status, @orderType, @total, @received, @change)
                            Select SCOPE_IDENTITY()"; //vai buscar o adicionar de valor de ID
            }
            else
            {
                qry1 = @"Update tblMain set status = @status, total = @total, received = @received, change = @change 
                        where MainID = @ID";
            }

            SqlCommand cmd = new SqlCommand(qry1, MainClass.con);

            cmd.Parameters.AddWithValue("@ID", MainID);
            cmd.Parameters.AddWithValue("@aDate", Convert.ToDateTime(DateTime.Now.Date));
            cmd.Parameters.AddWithValue("@aTime", DateTime.Now.ToShortTimeString());
            cmd.Parameters.AddWithValue("@TableName", lblTable.Text);
            cmd.Parameters.AddWithValue("@WaiterName", lblWaiter.Text);
            cmd.Parameters.AddWithValue("@status", "Pending");
            cmd.Parameters.AddWithValue("@orderType", OrderType);
            cmd.Parameters.AddWithValue("@total", Convert.ToDouble(lblTotal.Text));
            cmd.Parameters.AddWithValue("@received", Convert.ToDouble(0));
            cmd.Parameters.AddWithValue("@change", Convert.ToDouble(0));

            if (MainClass.con.State == ConnectionState.Closed) { MainClass.con.Open(); }
            if (MainID == 0) { MainID = Convert.ToInt32(cmd.ExecuteScalar()); } else { cmd.ExecuteNonQuery(); }
            if (MainClass.con.State == ConnectionState.Open) { MainClass.con.Close(); }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                detailID = Convert.ToInt32(row.Cells["dgvid"].Value);
                if (detailID != 0) //insert
                {
                    qry2 = @"Insert Into tblDetails (MainId, proID, qty, price, amount) Values (@MainID ,@proID ,@qty , @price, @amount)";
                }
                else //update
                {
                    qry2 = @"Update tblDetails Set proID = @proID ,qty = @qty , price = @price, amount = @amount
                            where MainID = @MainID";
                }

                SqlCommand cmd2 = new SqlCommand(qry2, MainClass.con);

                cmd2.Parameters.AddWithValue("@MainID", MainID);
                cmd2.Parameters.AddWithValue("@proID", Convert.ToInt32(row.Cells["dgvproID"].Value));
                cmd2.Parameters.AddWithValue("@qty", Convert.ToInt32(row.Cells["dgvQty"].Value));
                cmd2.Parameters.AddWithValue("@price", Convert.ToDouble(row.Cells["dgvPrice"].Value));
                cmd2.Parameters.AddWithValue("@amount", Convert.ToDouble(row.Cells["dgvAmount"].Value));


                if (MainClass.con.State == ConnectionState.Closed) { MainClass.con.Open(); }
                cmd2.ExecuteNonQuery();
                detailID -= 1;

            }

            MessageBox.Show("Salvo com sucesso");
            MainID = 0;
            dataGridView1.Rows.Clear();
            lblTable.Text = "";
            lblWaiter.Text = "";
            lblTable.Visible = false;
            lblWaiter.Visible = false;
            lblTotal.Text = "0000.00";
            OrderType = "";
            btnCheckout.Visible = false;

        }
        public int id = 0;

        private void btnBill_Click(object sender, EventArgs e)
        {
            frmBillList frm = new frmBillList();
            MainClass.BlurBackground(frm);

            if (frm.MainID > 0)
            {
                id = frm.MainID;
                LoadEntries();
            }
        }
        private void LoadEntries()
        {
            string qry = @"SELECT * FROM tblMain m 
                INNER JOIN tblDetails d ON m.MainID = d.MainID 
                INNER JOIN products p ON p.pID = d.proID  
                WHERE m.MainID = " + id;


            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            if (dt.Rows[0]["orderType"].ToString() == "Delivery")
            {
                lblWaiter.Visible = false;
                lblTable.Visible = false;
            }
            else if (dt.Rows[0]["orderType"].ToString() == "Take away")
            {
                lblWaiter.Visible = false;
                lblTable.Visible = false;
            }
            else
            {
                lblWaiter.Visible = true;
                lblTable.Visible = true;
            }


            dataGridView1.Rows.Clear();

            foreach (DataRow item in dt.Rows)
            {
                lblTable.Text = item["TableName"].ToString();
                lblWaiter.Text = item["WaiterName"].ToString();



                string detailID = item["DetailID"].ToString();
                string pName = item["pName"].ToString();
                string proID = item["proID"].ToString();
                string qty = item["qty"].ToString();
                string price = item["price"].ToString();
                string amount = item["amount"].ToString();


                object[] obj = { detailID, proID, pName, qty, price, amount };
                dataGridView1.Rows.Add(obj);
            }
            btnCheckout.Visible = true;
            GetTotal();
        }


        private void btnCheckout_Click(object sender, EventArgs e)
        {
            frmCheckout frm = new frmCheckout();
            frm.MainID = id;
            frm.amount = Convert.ToDouble(lblTotal.Text);
            MainClass.BlurBackground(frm);


            MainID = 0;
            dataGridView1.Rows.Clear();
            lblTable.Text = "";
            lblWaiter.Text = "";
            lblTable.Visible = false;
            lblWaiter.Visible = false;
            lblTotal.Text = "0000.00";
            OrderType = "";
            btnCheckout.Visible = false;

        }


    }
}
