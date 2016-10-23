﻿using Mvc5CustomAuthWithSession.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace Mvc5CustomAuthWithSession.Security
{
    public class CustomPrincipal : IPrincipal
    {
        private Account Account;
        //private AccountModel accountModel = new AccountModel();

        public CustomPrincipal(Account account)
        {
            //this.Account = accountModel.Find(username);
            this.Account = account;
            this.Identity = new GenericIdentity(account.Username);
        }

        public IIdentity Identity
        {
            get;
            set;
        }

        public bool IsInRole(string role)
        {
            var roles = role.Split(new char[] { ',' });
            return roles.Any(r => this.Account.Roles.Contains(r));
        }
    }
}