using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kormetal.Interfaces;
using Kormetal.Entities.Concrete;

namespace Kormetal.MvcWebUI.Controllers
{
    public class AdminKategoriController : Controller
    {
        private IKategoriService _kategoriService;

        public AdminKategoriController(IKategoriService kategoriService)
        {
            _kategoriService = kategoriService;
        }

        public ActionResult Index()
        {
            return View(_kategoriService.GetAll());
        }

    }
}
