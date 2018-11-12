using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamePlay
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private bool IsOpenTab(string tabName)
        {
            bool isOpened = false;

            foreach (TabItem tab in tabMain.Tabs)
            {
                if (tab.Name == tabName.Trim())
                {
                    isOpened = true;
                    tabMain.SelectedTab = tab;
                    break;
                }
            }
            return isOpened;
        }
        public void openWindow(Form frm, string Name)
        {
            DevComponents.DotNetBar.TabItem tp = new DevComponents.DotNetBar.TabItem();
            DevComponents.DotNetBar.TabControlPanel tcp = new DevComponents.DotNetBar.TabControlPanel();
            tp.MouseDown += new MouseEventHandler(tp_MouseDown);
            tcp.Dock = System.Windows.Forms.DockStyle.Fill;
            tcp.Location = new System.Drawing.Point(0, 0);

            frm.TopLevel = false;
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
            tcp.Controls.Add(frm);
            tp.Text = frm.Text;
            tp.Name = Name;

            if (!IsOpenTab(Name))
            {
                tcp.TabItem = tp;
                tp.AttachedControl = tcp;
                tabMain.Controls.Add(tcp);
                tabMain.Tabs.Add(tp);
                tabMain.SelectedTab = tp;
            }
            tabMain.Refresh();
        }

        private void tp_MouseDown(object sender, MouseEventArgs e)
        {
            tabMain.SelectedTab = (TabItem)sender;
            if (e.Button == MouseButtons.Right && tabMain.SelectedTab != null)
            {
                this.tabMain.Select();
                cms.Show(this.tabMain, e.X, e.Y);
            }
        }

        private void btItMemberOpen_Click(object sender, EventArgs e)
        {
            //开户窗口
            frmMemberOpen frm = new frmMemberOpen();
            //openWindow(frm, frm.Name);
            frm.Show();
        }

        private void btItRecharge_Click(object sender, EventArgs e)
        {
            //充值窗口
            frmRecharge frm = new frmRecharge();
            //openWindow(frm, frm.Name);
            frm.Show();
        }

        private void btItFetchCoin_Click(object sender, EventArgs e)
        {
            //提币窗口
            frmFetchCoin frm = new frmFetchCoin();
            //openWindow(frm, frm.Name);
            frm.Show();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btItAccount_Click(object sender, EventArgs e)
        {
            frmMemberAccount frm = new frmMemberAccount();
            //openWindow(frm, frm.Name);
            frm.Show();
        }

        private void btItMemberHistory_Click(object sender, EventArgs e)
        {
            frmMemberHistory frm = new frmMemberHistory();
            openWindow(frm, frm.Name);
        }

        private void btItFreezeCard_Click(object sender, EventArgs e)
        {
            frmFreezeCard frm = new frmFreezeCard();
            frm.Show();
        }

        private void btItUnfreezeCard_Click(object sender, EventArgs e)
        {
            frmUnfreezeCard frm = new frmUnfreezeCard();
            frm.Show();
        }

        private void btItReissueCard_Click(object sender, EventArgs e)
        {
            frmReissueCard frm = new frmReissueCard();
            frm.Show();
        }

        private void btItCloseAccount_Click(object sender, EventArgs e)
        {
            frmCloseAccount frm = new frmCloseAccount();
            frm.Show();
        }

        private void btItSellCoin_Click(object sender, EventArgs e)
        {
            frmSellCoin frm = new frmSellCoin();
            frm.Show();
        }

        private void btItSellTicket_Click(object sender, EventArgs e)
        {
            frmSellTicket frm = new frmSellTicket();
            frm.Show();
        }

        private void btITInqGoods_Click(object sender, EventArgs e)
        {
            frmInqGoods frm = new frmInqGoods();
            openWindow(frm, frm.Name);
        }

        private void btItInGoods_Click(object sender, EventArgs e)
        {
            frmInGoods frm = new frmInGoods();
            frm.Show();
        }

        private void btItOutGoods_Click(object sender, EventArgs e)
        {
            frmOutGoods frm = new frmOutGoods();
            frm.Show();
        }

        private void btItSellGoods_Click(object sender, EventArgs e)
        {
            frmSellGoods frm = new frmSellGoods();
            frm.Show();
        }

        private void btItExchangeGoods_Click(object sender, EventArgs e)
        {
            frmExchangeGoods frm = new frmExchangeGoods();
            frm.Show();
        }
    }
}
