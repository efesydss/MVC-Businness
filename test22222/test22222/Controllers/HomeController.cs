using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test22222.Models;
using test22222.ViewModels;

namespace test22222.Controllers
{
    public class HomeController : Controller
    {
        public void data()
        {
            ViewData["key"] = "data";
            ViewData["key2"] = true;
            ViewData["key3"] = 123;
            ViewBag.bag1 = "bagg11";
            ViewBag.bag2 = true;
            TempData["temp1"] = "temp1";
           
        }
        [HttpGet]
        public ActionResult Index()
        {
            data();
            return View();
        }
        [HttpPost]
        public ActionResult Index(string list1,string text1, bool check1)//değişken isimleri post ile aynı olmalı
        {
            /*Rquest Form kullanmasanda yukarda parantezden paramtreyi al kullan yani bu extra yöntem*/
            var t1 = Request.Form["text1"];
            var t2 = Request.Form.GetValues("check1")[0];//check box kullanırken check box seçili olan itemi 0. id de döndürür yani false seçersen false,true döner sende 0. yı alcan ki seçili olanı almış ol of.
            var t3 = Request.Form["list1"];

           
            
            return View();
        }





        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            //modele data ekledim
            Person person = new Person();
            person.ad = "Efe";
            person.soyad = "sydss";
            person.yas = 22;
            //modeli yolladım
            Address address = new Address();
            address.City = "London";
            address.Name = "England";
            /*bir sayfaya birden fazla modewl göndermek için 3. bir model oluştur (ViewModels Klasörü altında)
             sonra onun içine bir class ve içine diğer iki modelden bir nesne oluştur ki bu 3. sınıfa o mdeller ekleyip sayfaya tek bir nesne Modeller nesnesi ni gönderebilesin böylece kaç tane model olursa olsun bunu bir Modeller Nesnesinde View Model ynai birleştirip gönderebilesin*/
            MyViewModels myViewModels = new MyViewModels();
            myViewModels.addressObject = address;
            myViewModels.personObject = person;
            return View(myViewModels);
        }
        [HttpPost]
        public ActionResult About(MyViewModels myViewModels)
        {
            ViewBag.Message = "(post)Your application description page.";
           
            return View(myViewModels);
        }

       public ActionResult Bootstrap()
        {
            return View();
        }
    }
}