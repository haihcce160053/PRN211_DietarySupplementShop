using DataAccess.DataAccess;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DietarySupplementalShop
{
    public partial class frmAccountCRUD : Form
    {
        private string username;
        private int CRUDStatus;
        public frmAccountCRUD(string username, int CRUDStatus)
        {
            InitializeComponent();
            this.username = username;
            this.CRUDStatus = CRUDStatus;
        }

        private void frmCRUD_Load(object sender, EventArgs e)
        {
            //Create
            if (CRUDStatus == 1)
            {
                btnProcess.Text = "Create new account";
                rdoMale.Checked = true;
                rdoPermissionCUS.Checked = true;
                this.Text = "Create new account";
            }

            //Update
            if (CRUDStatus == 2)
            {
                GetAccountInformation();
                txtUsername.Enabled = false;
                btnProcess.Text = "Update information";
                this.Text = "Update account information";
            }

            //Delete
            if (CRUDStatus == 3)
            {
                GetAccountInformation();
                txtUsername.Enabled = false;
                btnProcess.Text = "Delete account";
                this.Text = "Delete account";
            }

            //View
            if (CRUDStatus == 4)
            {
                GetAccountInformation();
                txtUsername.Enabled = false;
                btnProcess.Hide();
                this.Text = "View account information";
            }
        }

        private void GetAccountInformation()
        {
            IAccountRepository IAccount = new AccountRepository();
            IAccountInformationRepository IAccountInfo = new AccountInformationRepository();
            Account account = IAccount.GetAccountByUsername(username);
            AccountInformation accountInfo = IAccountInfo.GetAccountInformationByUsername(username);

            if (account != null && accountInfo != null)
            {
                txtFullname.Text = accountInfo.FullName;
                txtUsername.Text = account.Username;
                txtEmail.Text = accountInfo.Email;
                if (accountInfo.Gender == "Male")
                {
                    rdoMale.Checked = true;
                }
                else
                {
                    rdoFemale.Checked = true;
                }
                txtPassword.Text = account.Password;
                txtRePassword.Text = account.Password;
                txtPassword.Enabled = false;
                txtRePassword.Enabled = false;
                txtAnswer.Text = account.SercurityAnswer;
                txtPhone.Text = accountInfo.PhoneNumber.ToString();
                if (accountInfo.AccountTypeId == "AD")
                {
                    rdoPermissionAD.Checked = true;
                }
                else
                {
                    rdoPermissionCUS.Checked = true;
                }
            }
        }

        private void CreateAccount()
        {
            Account account = new Account();
            AccountInformation accountInfo = new AccountInformation();

            accountInfo.FullName = txtFullname.Text;
            account.Username = txtUsername.Text;
            accountInfo.Username = txtUsername.Text;
            accountInfo.Email = txtEmail.Text;
            if (rdoMale.Checked == true)
            {
                accountInfo.Gender = "Male";
            }
            else
            {
                accountInfo.Gender = "Female";
            }
            if (txtPassword.Text == txtRePassword.Text)
            {
                account.Password = txtPassword.Text;
            }
            account.SercurityAnswer = txtAnswer.Text;
            accountInfo.PhoneNumber = Convert.ToInt32(txtPhone.Text);
            if (rdoPermissionAD.Checked == true)
            {
                accountInfo.AccountTypeId = "AD";
            }
            else
            {
                accountInfo.AccountTypeId = "CUS";
            }

            IAccountRepository IAccount = new AccountRepository();
            IAccountInformationRepository IAccountInfo = new AccountInformationRepository();
            if (IAccount.AddAccount(account) == true && IAccountInfo.AddAccountInformation(accountInfo) == true)
            {
                MessageBox.Show("Create account for " + username + " successful");
            }
            else
            {
                MessageBox.Show("Create account for " + username + " failed");
            }
        }

        private void UpdateAccount()
        {
            Account account = new Account();
            AccountInformation accountInfo = new AccountInformation();

            accountInfo.FullName = txtFullname.Text;
            account.Username = txtUsername.Text;
            accountInfo.Username = txtUsername.Text;
            accountInfo.Email = txtEmail.Text;
            if (rdoMale.Checked == true)
            {
                accountInfo.Gender = "Male";
            }
            else
            {
                accountInfo.Gender = "Female";
            }
            if (txtPassword.Text == txtRePassword.Text)
            {
                account.Password = txtPassword.Text;
            }
            account.SercurityAnswer = txtAnswer.Text;
            accountInfo.PhoneNumber = Convert.ToInt32(txtPhone.Text);
            if (rdoPermissionAD.Checked == true)
            {
                accountInfo.AccountTypeId = "AD";
            }
            else
            {
                accountInfo.AccountTypeId = "CUS";
            }

            IAccountRepository IAccount = new AccountRepository();
            IAccountInformationRepository IAccountInfo = new AccountInformationRepository();
            if (IAccount.UpdateAccount(account) == true && IAccountInfo.UpdateAccountInformation(accountInfo) == true)
            {
                MessageBox.Show("Update account information for " + username + " successful");
            }
            else
            {
                MessageBox.Show("Update account information for " + username + " failed");
            }
        }

        private void DeleteAccount()
        {
            IAccountRepository IAccount = new AccountRepository();
            IAccountInformationRepository IAccountInfo = new AccountInformationRepository();
            if (IAccountInfo.DeleteAccountInformation(username) == true && IAccount.DeleteAccount(username) == true)
            {
                MessageBox.Show("Delete account for " + username + " successful");
            }
            else
            {
                MessageBox.Show("Delete account for " + username + " failed");
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            //Add new account
            if (CRUDStatus == 1)
            {
                CreateAccount();
                this.Close();
            }

            //Update information
            if (CRUDStatus == 2)
            {
                UpdateAccount();
                this.Close();
            }

            //Delete information
            if (CRUDStatus == 3)
            {
                DeleteAccount();
                this.Close();
            }
        }
    }
}
