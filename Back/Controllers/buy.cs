using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;



namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class buy : ControllerBase
    {
        //Временное решение
        //ссылки на товары для примера
        string[] links = { "https://www.mvideo.ru/products/smartfon-apple-iphone-12-128gb-black-mgja3ru-a-30052890", "https://www.mvideo.ru/products/smart-chasy-samsung-galaxy-watch-active2-sm-r830-vanil-30046029", "https://www.mvideo.ru/products/televizor-lg-oled55c1rla-10026091" };
        //id товаров
        int[] idt = { 473902, 340187, 129304 };
        //id стримеров
        int[] ids = { 152398, 789345 };
    
        

        [HttpGet("{st}/{id}")]
        public RedirectResult Get(int st, int id)
        {
            //Перенаправление по ссылке
            return Redirect(links[Array.IndexOf(idt,id)]);
        }
        [HttpPost]
        public string Area(string fullname, string email, string password, string confirmpassword)
        {
            //Обработка формы регистрации
            fullname = Request.Form["fullname"];
            email = Request.Form["email"];
            password = Request.Form["password"];
            confirmpassword = Request.Form["confirmpassword"];
            return $"Данные для входа" + fullname + " / " + email + " / " + password + " / " + confirmpassword;
        }

    }
}
