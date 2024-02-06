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

namespace QLBH
{
    public partial class Form2 : Form
    {
        DataAccess dataAccess = new DataAccess();
        public Form2()
        {
            InitializeComponent();
            
            LoadData();

            cbbDonViTinh.DataSource = dataAccess.GetDataTable("select distinct DvTinh from VatTu");
            cbbDonViTinh.DisplayMember = "DvTinh";
            cbbDonViTinh.ValueMember = "DvTinh";


        }
        void LoadData()
        {
            dgvDMVatTu.DataSource = dataAccess.GetDataTable("select * from VatTu");
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataGridViewRow _dr = dgvDMVatTu.SelectedRows[0];
            string _MaVatTu = _dr.Cells["MaVTu"].Value.ToString();
            MessageBox.Show(_MaVatTu);

            dataAccess.UpdateData(string.Format("delete from VATTU where MaVTu ='{0}'", _MaVatTu));
            LoadData();

        }

        private void dgvDMVatTu_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow _dr = dgvDMVatTu.SelectedRows[0];
            string _MaVatTu = _dr.Cells["MaVTu"].Value.ToString();
            string _TenVatTu = _dr.Cells["TenVTu"].Value.ToString();

            txtMaVatTu.Text = _MaVatTu;
            txtTenVatTu.Text = _TenVatTu;
        }
    }
}
