using DataAccess.DataAccess;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DietarySupplementalShop
{
    public partial class AccountManagement : Form
    {
        public AccountManagement()
        {
            InitializeComponent();
        }

        private void AccountManagement_Load(object sender, EventArgs e)
        {
            LoadAccount();
        }

        private void LoadAccount()
        {
            IAccountRepository IAccount = new AccountRepository();
            List<Account> account = new List<Account>(IAccount.GetAccountList());
            if (account != null)
            {
                dataGridView1.Columns.Clear();
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                dataGridView1.Columns.Add("AccountUsername", "Username");
                dataGridView1.Columns.Add("AccountSecurityAnswer", "Security Answer");
                dataGridView1.ClearSelection();

                for (int i = 0; i < account.Count; i++)
                {
                    dataGridView1.Rows.Add(account[i].Username, account[i].SercurityAnswer);
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (dataGridView1.SelectedCells[0].Value != null
               && dataGridView1.SelectedCells[1].Value != null)
                {
                    txtUsername.Text = dataGridView1.SelectedCells[0].Value.ToString();
                    txtSecurityAnswer.Text = dataGridView1.SelectedCells[1].Value.ToString();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAccountCRUD crud = new frmAccountCRUD(txtUsername.Text, 1);
            crud.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmAccountCRUD crud = new frmAccountCRUD(txtUsername.Text, 2);
            crud.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            frmAccountCRUD crud = new frmAccountCRUD(txtUsername.Text, 3);
            crud.Show();
        }

        private void btnViewDetail_Click(object sender, EventArgs e)
        {
            frmAccountCRUD crud = new frmAccountCRUD(txtUsername.Text, 4);
            crud.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }
    }
}
