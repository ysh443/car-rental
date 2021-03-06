﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarRent.BL;
using CarRent.MVC.Models;
using System.Web.Security;


namespace CarRent.MVC.Controllers
{
    public class LoginController : Controller
    {
        UsersManager UsersManager;
        SiteRoleProvider RoleManager;
        public LoginController()
        {
            UsersManager = new UsersManager();
            RoleManager = new SiteRoleProvider(); 
                
                }
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CheckLogin(UserVM user)
        {
            if (ModelState.IsValid)
            {
                FormsAuthentication.SetAuthCookie(user.UserName, false);


                if (UsersManager.VerifyUserCredentials(user.GetUserVMAsUser()))
                {
                    return Redirect(FormsAuthentication.DefaultUrl);
                }
                else
                {
                    // return Redirect(FormsAuthentication.LoginUrl);
                    return View("Index",user);
                }
            }
            else
            {
                return View("Index");
            }
        }

        public ActionResult Logout()
        {
            if (ModelState.IsValid)
            {
                //:TODO
                // check if user cart\actions are not completed and warn him?

                FormsAuthentication.SignOut();
                return Redirect(FormsAuthentication.DefaultUrl);

            }
            else
            {

                //where to send?? how do i set a default Error page for all trouble cases?
                throw new HttpException("Problem XYZ");

                //return View("Index");
            }
        }    
    }
}