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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RM.Model
{
    public partial class frmCheckout : SampleAdd
    {
        public frmCheckout()
        {
            InitializeComponent();
        }

        public double amount;
        public int MainID = 0;

        private void textReceived_TextChanged(object sender, EventArgs e)
        {
            double amount = 0;
            double receipt = 0;
            double change = 0;

            double.TryParse(txtBillAmount.Text, out amount);
            double.TryParse(txtReceived.Text, out receipt);

            change = Math.Round(receipt - amount, 2); 

            if (change < 0)
            {
                change = 0;
            }


            txtChange.Text = change.ToString();

        }
        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(txtChange.Text) <= 0 && (Convert.ToDouble(txtReceived.Text) != Convert.ToDouble(txtBillAmount.Text)))
            {
                MessageBox.Show("Dinheiro insuficiente");
                return;
            }

            string qry = "";
            if (MainID != 0)
            {
                qry = @"Update tblMain set total = @total, received = @received , change=@change, status ='Paid' where MainID =@id";
            }
            else
            {
                qry = @"Insert into tblMain Values(@aDate, @aTime, @TableName, @WaiterName, @status, @orderType, @total, @received, @change)
                            Select SCOPE_IDENTITY()";
            }

            Hashtable ht = new Hashtable();
            ht.Add("@id", MainID);
            ht.Add("@total", Convert.ToDouble(txtBillAmount.Text));
            ht.Add("@received", Convert.ToDouble(txtReceived.Text));
            ht.Add("@change", Convert.ToDouble(txtChange.Text));

            if (MainID == 0)
            {
                ht.Add("@aDate", Convert.ToDateTime(DateTime.Now.Date));
                ht.Add("@aTime", DateTime.Now.ToShortTimeString());
                ht.Add("@TableName", "Balcão");
                ht.Add("@WaiterName", "Balcão");
                ht.Add("@status", "Paid");
                ht.Add("@orderType", "Din In");
            }

            if (MainClass.SQL(qry, ht) > 0)
            {
                MessageBox.Show("Salvo com sucesso");
                this.Close();
            }
        }

        private void frmCheckout_Load(object sender, EventArgs e)
        {
            txtBillAmount.Text = amount.ToString();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtReceived_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a digit or a comma
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                // Ignore the key press
                e.Handled = true;
            }
            else if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                // Replace dot with comma
                e.KeyChar = ',';

                // Check if there is already a comma in the textbox
                if (txtReceived.Text.Contains(","))
                {
                    // Ignore the key press if there is already a comma
                    e.Handled = true;
                }
                else if (txtReceived.SelectionStart == 0)
                {
                    // Ignore the key press if the comma is being added at the beginning
                    e.Handled = true;
                }
            }
            else if (char.IsDigit(e.KeyChar) && txtReceived.Text.Contains(","))
            {
                // Check if the number of digits after the comma exceeds 2
                int commaIndex = txtReceived.Text.IndexOf(",");
                int digitsAfterComma = txtReceived.Text.Length - commaIndex - 1;
                if (digitsAfterComma >= 2)
                {
                    // Ignore the key press if the maximum number of digits after the comma is reached
                    e.Handled = true;
                }
            }
        }
    }
}
