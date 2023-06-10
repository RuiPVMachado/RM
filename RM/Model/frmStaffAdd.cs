using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM.Model
{
    public partial class frmStaffAdd : SampleAdd
    {
        public frmStaffAdd()
        {
            InitializeComponent();
        }

        public int id = 0;

        private void frmStaffAdd_Load(object sender, EventArgs e)
        {

        }
        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtPhone.Text == "" || cbRole.Text == "")
            {
                MessageBox.Show("Preencha todos os campos antes de guardar");
                return;
            }
            try
            {
                MainClass.isFieldValid(txtName.Text, "Nome");
                MainClass.isFieldValid(txtPhone.Text, "Número");
            }
            catch (InvalidDataException)
            {
                return;
            }


            string qry = "";
            if (id == 0) //inserir
            {
                qry = "Insert into staff Values(@Name, @Phone , @Role)";
            }
            else  //update
            {
                qry = "Update staff Set sName = @Name, sPhone = @Phone , sRole = @Role where staffID = @id ";
            }
            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@Name", txtName.Text);
            ht.Add("@Phone", txtPhone.Text);
            ht.Add("@Role", cbRole.Text);

            if (MainClass.SQL(qry, ht) > 0)
            {
                MessageBox.Show("Salvo com sucesso");
                id = 0;
                txtName.Text = "";
                txtPhone.Text = "";
                cbRole.SelectedIndex = -1;
                txtName.Focus();
            }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPhone.Text, "[^0-9]"))
            {
                MessageBox.Show("Escreva só numeros.");
                txtPhone.Text = txtPhone.Text.Remove(txtPhone.Text.Length - 1);
            }
        }
    }
}
