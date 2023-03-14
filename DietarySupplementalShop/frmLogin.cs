using DataAccess.DataAccess;
using DataAccess.Repository;
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
                    if (account.Password != MD5Encryption(password))
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
        }

        public string MD5Encryption(string encryptionText)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] array = Encoding.UTF8.GetBytes(encryptionText);
            array = md5.ComputeHash(array);
            StringBuilder sb = new StringBuilder();
            foreach (byte ba in array)
            {
                sb.Append(ba.ToString("x2").ToLower());
            }
            return sb.ToString();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}

