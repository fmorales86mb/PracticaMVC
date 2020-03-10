using MvcAplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcAplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Listado = this.GetMocks(6);
            return View();
        }

        //public ActionResult TableView()
        //{

        //    return View();
        //}

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        private List<MuseoViewModel> GetMocks(int cant)
        {
            List<MuseoViewModel> lista = new List<MuseoViewModel>();

            for(int i = 1; i<= cant; i++)
            {
                MuseoViewModel model = new MuseoViewModel()
                {
                    Id = i.ToString(),
                    Nombre = string.Format("Nombre{0}", i.ToString())
                };

                lista.Add(model);
            }

            return lista;
        }

    }
}