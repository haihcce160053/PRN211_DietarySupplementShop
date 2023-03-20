using DataAccess.DataAccess;
using DataAccess.Repository;
using DataAccess.Security;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Principal;

namespace DietarySupplementalShopWeb.Controllers
{
    public class AccountController : Controller
    {
        IAccountRepository accountRepository = null;
        IAccountInformationRepository accountInformationRepository = null;
        public AccountController()
        {
            accountRepository = new AccountRepository();
            accountInformationRepository = new AccountInformationRepository();
        }

        // GET: AccountController
        public ActionResult Login()
        {
            return View();
        }

        // POST: Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(string username, string password)
        {
            if (username == null || password == null)
            {
                ViewBag.LoginMessage = "Login failed, please try again!";
                return RedirectToAction(nameof(Login));
            }
            var login = accountRepository.GetAccountByUsername(username);
            if (login != null)
            {
                MD5Encrypt md5 = new MD5Encrypt();
                if (login.Password.Equals(md5.MD5Encryption(password)))
                {
                    ViewBag.isLogin = true;
                    return RedirectToAction("Index", "Main");
                }
                else
                {
                    ViewBag.isLogin = false;
                    return RedirectToAction(nameof(Login));
                }
            }
            else
            {
                ViewBag.isLogin = false;
                ViewBag.LoginMessage = "Account not exist!";
                return RedirectToAction(nameof(Login));
            }
        }

        // GET: AccountController
        public ActionResult Index()
        {
            var accountList = accountRepository.GetAccountList();
            return View(accountList);
        }

        // GET: AccountController/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            AccountViewModel accountView = new AccountViewModel();
            accountView.Account = accountRepository.GetAccountByUsername(id);
            accountView.AccountInformation = accountInformationRepository.GetAccountInformationByUsername(id);
            if (accountView == null)
            {
                return NotFound();
            }
            return View(accountView);
        }

        // GET: AccountController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AccountController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AccountViewModel AccountViewModel)
        {
            if(AccountViewModel == null)
            {
                return NotFound();
            }
            accountRepository.AddAccount(AccountViewModel.Account);
            accountInformationRepository.AddAccountInformation(AccountViewModel.AccountInformation);
            return RedirectToAction(nameof(Index));
        }


        // GET: AccountController/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            AccountViewModel accountView = new AccountViewModel();
            accountView.Account = accountRepository.GetAccountByUsername(id);
            accountView.AccountInformation = accountInformationRepository.GetAccountInformationByUsername(id);
            if (accountView == null)
            {
                return NotFound();
            }
            return View(accountView);
        }

        // POST: AccountController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(AccountViewModel accountView)
        {
            try
            {
                if (accountView == null)
                {
                    return NotFound();
                }
                accountRepository.UpdateAccount(accountView.Account);
                accountInformationRepository.UpdateAccountInformation(accountView.AccountInformation);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();
            }
        }

        //GET
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            ViewBag.Username = id;
            return View();
        }
        
        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(AccountViewModel accountView)
        {
            try
            {
                if (accountView == null)
                {
                    return NotFound();
                }
                accountInformationRepository.DeleteAccountInformation(accountView.Account.Username);
                accountRepository.DeleteAccount(accountView.AccountInformation.Username);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return RedirectToAction(nameof(Index));
            }
        }
    }
}
