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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            CustomizeDesign();
            
           
        }
        private void CustomizeDesign()
        {
            panelToolsSub.Visible = false;
            panelUserInfoSub.Visible = false;
            panelWareSub.Visible = false;
            //.

        }
        private void HideSubMenu()
        {
            if (panelToolsSub.Visible == true)
            {
                panelToolsSub.Visible = false;
            }
            if (panelWareSub.Visible == true)
            {
                panelWareSub.Visible = false;
            }
            if (panelUserInfoSub.Visible == true)
            {
                panelUserInfoSub.Visible = false;
            }
        }
        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        private void ShowCurrentSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == true)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
        }

        private void btnWare_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelWareSub);

        }

        private void btnUserInfo_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelUserInfoSub);
        }

        private void btnTools_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelToolsSub);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            //panel2.Controls.Add()
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBudget_Click(object sender, EventArgs e)
        {
          
        }

        private void btnBot_Click(object sender, EventArgs e)
        {
           
        }

        private void btnMails_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAddress_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
           
        }

        private void btnProxy_Click(object sender, EventArgs e)
        {
           
        }

        private void btnShippingCalc_Click(object sender, EventArgs e)
        {
           
        }

        private void btnEmailScraper_Click(object sender, EventArgs e)
        {
            
        }

        private void btnProxyTester_Click(object sender, EventArgs e)
        {
           
        }

        private void dgvListings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        //bei SubMenuButtons: hideSubMenu();
    }
}
