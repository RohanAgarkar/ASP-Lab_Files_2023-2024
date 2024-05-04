using Microsoft.AspNetCore.Mvc;

namespace view_demo.Controllers{
    public class UserController:Controller{
        public ViewResult Signin(){
            return View();
        }
        public ViewResult Signout(){
            return View();
        }
    }
}