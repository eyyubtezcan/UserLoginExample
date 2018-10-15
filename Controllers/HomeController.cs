using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;




namespace UserLoginExample.Controllers
{
    
    public class HomeController : Controller
    {
        string[] name = { "admin", "teacher", "student1", "student2" };
        string[] pass = { "admin", "123456", "0000", "test" };
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string userName,string userPass)
        {
            if((userName !="") && (userPass!="" ))
            { 
                if(Session["UserName"] == null)
                {
                    for(int i=0;i<name.Length;i++)
                    {
                        if((name[i]==userName)&&(pass[i]==userPass))
                        {
                            Session["UserName"] = userName;
                            break;
                        }
                    }
                }
            }
           
            return View();
        }
    }
}