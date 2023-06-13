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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RM.Model
{
    public partial class frmProductAdd : SampleAdd
    {
        public frmProductAdd()
        {
            InitializeComponent();
        }

        public int id = 0;
        public int cID = 0;
        private void frmProductAdd_Load(object sender, EventArgs e)
        {
            //listar no cb
            string qry = "Select catID 'id' , catName 'name' from category";
            MainClass.CBFill(qry, cbCat);

            //dar update
            if (cID > 0)
            {
                cbCat.SelectedValue = cID;
            }

            if (id > 0)
            {
                ForUpdateLoadData();
            }
        }

        string filePath;
        Byte[] imageByteArray;

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images(.jpg, .png) | * .png; *.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
                txtImage.Image = new Bitmap(filePath);
            }
        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtPrice.Text == "" || cbCat.SelectedValue == null)
            {
                MessageBox.Show("Preencha todos os campos antes de guardar");
                return;
            }
            try
            {
                            MainClass.isFieldValid(txtName.Text, "Nome");
            MainClass.isFieldValid(txtPrice.Text, "Preço");
            }
            catch (InvalidDataException)
            {
                return;
            }

            
            string qry = "";

            if (id == 0) //inserir
            {
                qry = "Insert into products Values(@Name, @Price , @Cat , @Img)";
            }
            else  //update
            {
                qry = "Update products Set pName = @Name, pPrice = @Price , CategoryID = @Cat, pImage = @Img where pID = @id ";
            }

            //para a imagem 
            Image temp = new Bitmap(txtImage.Image);
            MemoryStream ms = new MemoryStream();
            temp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            imageByteArray = ms.ToArray();

            if (txtPrice.Text.Contains(","))
            {
                txtPrice.Text = txtPrice.Text.Replace(",", ".");
            }

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@Name", txtName.Text);
            ht.Add("@Price", txtPrice.Text);
            ht.Add("@Cat", Convert.ToInt32(cbCat.SelectedValue));
            ht.Add("@Img", imageByteArray);

            if (MainClass.SQL(qry, ht) > 0)
            {
                MessageBox.Show("Salvo com sucesso");
                id = 0;
                cID = 0;
                txtName.Text = "";
                txtPrice.Text = "";
                cbCat.SelectedIndex = 0;
                cbCat.SelectedIndex = -1;

                txtName.Focus();
            }

        }
        private void ForUpdateLoadData()
        {
            string qry = "Select * from products where pID = " + id + "";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                txtName.Text = dt.Rows[0]["pName"].ToString();
                txtPrice.Text = dt.Rows[0]["pPrice"].ToString();

                Byte[] imageArray = (byte[])(dt.Rows[0]["pImage"]);
                byte[] imageByteArray = imageArray;
                txtImage.Image = Image.FromStream(new MemoryStream(imageArray));
            }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

            if (System.Text.RegularExpressions.Regex.IsMatch(txtPrice.Text, "[^0-9\\.,]|(?<=([.,]\\d{2}|\\.\\d{2}))\\d+"))
            {
                MessageBox.Show("Escreva SE.");
                txtPrice.Text = txtPrice.Text.Remove(txtPrice.Text.Length - 1);
            }
        }
    }
}
