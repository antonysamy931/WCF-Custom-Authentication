﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using System.IdentityModel;
using System.IdentityModel.Selectors;
using System.ServiceModel;

namespace WcfServiceAuth.Authorize.Service
{
    public class CustomUsernamePasswordValidator : UserNamePasswordValidator
    {
        public override void Validate(string userName, string password)
        {

            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
                throw new ArgumentNullException();
            if (string.Equals(userName, "test") && string.Equals(password, "test"))
            {                
                return;
            }
            else
                throw new FaultException("Invalid username and password");
        }
    }
}