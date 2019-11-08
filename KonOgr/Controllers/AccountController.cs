using KonOgr.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace KonOgr.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(User user)
        {
            if (LoginUser(user.Name, user.Password))
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.Name)
                };

                var userIdentity = new ClaimsIdentity(claims, "login");

                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);

                //Just redirect to our index after logging in. 
                return RedirectToAction("Index", "Main");
            }
            else
            {
                ViewBag.mesaj = "Geçersiz Kullanıcı veya Şifre";
                return View();
            }

        }

        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync();

            return RedirectToAction("Login");
        }


        private bool LoginUser(string username, string password)
        {

            SQLiteConnection con = new SQLiteConnection("Data Source=database.db;Version=3;");

            con.Open();

            string query = "SELECT * FROM kullanici WHERE Name = '" + username + "' AND Password = '" + password + "'";
            SQLiteCommand com = new SQLiteCommand(query, con);
            com.ExecuteNonQuery();

            SQLiteDataReader dr = com.ExecuteReader();

            int count = 0;

            while (dr.Read())
            {
                count++;
            }

            con.Close();

            if (count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
