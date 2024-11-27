using MuseumWeb.BLL.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThePalaceMuseumWeb.EF.Model;

namespace ThePalaceMuseum.Controllers
{
    public class UserController : Controller
    {
        UserService userService = new UserService();
        // GET: Login
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        //public ActionResult Login(string UserId,string Password)
        public ActionResult Login(User users,string Verification)
        {
            User usersLogin = userService.Query<User>(a => a.UserId == users.UserId && a.Password == users.Password).FirstOrDefault();
            if (usersLogin == null)
            {
                //viewbag.info = "登录失败";
                ViewBag.info = "登录失败";
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
            //userservice.insert(users);
            //return View();
        }


        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(User user,string SurePassword)
        {
            User userAdd = userService.Insert(user);
            if (userAdd != null)
            {
                return Content("<script> alert('注册成功');location.href='/Home/Index'; </script>");
            }
            return View();
        }
    }
}