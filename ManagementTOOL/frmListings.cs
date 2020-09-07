using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementTOOL
{
    public partial class frmListings : Form
    {
        public frmListings()
        {
            InitializeComponent();
            dgvListings.Columns[0].Width = 60;
        }

        private void dgvListings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
