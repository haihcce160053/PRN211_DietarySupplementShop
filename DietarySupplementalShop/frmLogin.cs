using DataAccess.DataAccess;
using DataAccess.Repository;
using DataAccess.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DietarySupplementalShop
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public static string myUsername = "";

        private void btnLogin_Click(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            IAccountRepository IAccount = new AccountRepository();
            IAccountInformationRepository IAccountInfo = new AccountInformationRepository();
            Account account = IAccount.GetAccountByUsername(username);
            AccountInformation accountInfo = IAccountInfo.GetAccountInformationByUsername(username);

            if (account != null && accountInfo != null)
            {
                if (accountInfo.AccountTypeId == "AD")
                {
                    MD5Encrypt md5 = new MD5Encrypt();
                    if (account.Password != md5.MD5Encryption(password))
                    {
                        MessageBox.Show("Login failed, please try again!");
                    }
                    else
                    {
                        myUsername = username;
                        frmMain frm = new frmMain();
                        frm.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("You don't have permission to access this system!");
                }
            }
            else
            {
                MessageBox.Show("Login failed, please try again!");
            }
            btnLogin.Enabled = true;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}

