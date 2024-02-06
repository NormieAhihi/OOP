using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH
{
    public partial class FormQL : Form
    {
        public FormQL()
        {
            InitializeComponent();
        }

        private void FormQL_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.KHACHHANG' table. You can move, or remove it, as needed.
            this.kHACHHANGTableAdapter.Fill(this.dataSet1.KHACHHANG);

        }

    }
}
