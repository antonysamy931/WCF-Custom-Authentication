﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IdentityModel;
using System.IdentityModel.Selectors;
using System.ServiceModel;

namespace WcfServiceLibraryWs2007HttpBinding
{
    public class UsernamepasswordValidator : UserNamePasswordValidator
    {
        public override void Validate(string userName, string password)
        {
            if (userName == null || password == null)
                throw new ArgumentNullException();
            if (userName == "test" && password == "test")
                return;
            else
                throw new FaultException("Username or Password Incorrect");
        }
    }
}