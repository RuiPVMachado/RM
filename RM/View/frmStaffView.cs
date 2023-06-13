using RM.Model;
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
using System.Xml.Linq;

namespace RM.View
{
    public partial class frmStaffView : SampleView
    {
        public frmStaffView()
        {
            InitializeComponent();
        }

        private void frmStaffView_Load(object sender, EventArgs e)
        {
            GetData();
        }

        public void GetData()
        {

            string qry = "Select * From staff where sName like '%" + txtSearch.Text + "%' ";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvName);
            lb.Items.Add(dgvPhone);
            lb.Items.Add(dgvRole);

            MainClass.LoadData(qry, dataGridView1, lb);
        }

        public override void btnAdd_Click(object sender, EventArgs e)
        {
            //frmCategoryAdd frm = new frmCategoryAdd();
            //frm.ShowDialog();
            MainClass.BlurBackground(new Model.frmStaffAdd());
            GetData();
        }

        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.CurrentCell.OwningColumn.Name == "dgvedit")
            {
                frmStaffAdd frm = new frmStaffAdd();
                frm.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["dgvid"].Value);
                frm.txtName.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["dgvName"].Value);
                frm.txtPhone.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["dgvPhone"].Value);
                frm.cbRole.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["dgvRole"].Value);
                MainClass.BlurBackground(frm);
                GetData();
            }
            if (dataGridView1.CurrentCell.OwningColumn.Name == "dgvdel")
            {
                DialogResult dialogResult = MessageBox.Show("Tem a certeza?", "Pergunta", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["dgvid"].Value);
                    string qry = "Delete from staff where staffID = " + id + " ";
                    Hashtable ht = new Hashtable();
                    MainClass.SQL(qry, ht);
                    MessageBox.Show("Eliminado com Sucesso");
                    GetData();
                }

            }
        }

    }
}
