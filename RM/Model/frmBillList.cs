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
    public partial class frmBillList : SampleAdd
    {
        public frmBillList()
        {
            InitializeComponent();
        }
        public int MainID = 0;
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBillList_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            string qry = "select MainID,TableName , WaiterName,orderType, status,total from tblMain where status = 'Complete'";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvtable);
            lb.Items.Add(dgvWaiter);
            lb.Items.Add(dgvType);
            lb.Items.Add(dgvStatus);
            lb.Items.Add(dgvTotal);

            MainClass.LoadData(qry, dataGridView1, lb);
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.CurrentCell.OwningColumn.Name == "dgvedit")
            {
                MainID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["dgvid"].Value);
                this.Close();
            }
        }
    }
}
