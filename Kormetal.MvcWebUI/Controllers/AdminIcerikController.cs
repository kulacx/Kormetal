using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kormetal.Interfaces;
using  Kormetal.Entities.Concrete;
using Kormetal.Entities;


namespace Kormetal.MvcWebUI.Controllers
{
    public class AdminIcerikController : Controller
    {
        //
        // GET: /AdminIcerik/

        private IIcerikService _icerikService;

        public AdminIcerikController(IIcerikService icerikService)
        {
            _icerikService = icerikService;
        }

        public ActionResult Index()
        {
            return View(_icerikService.GetAll());
        }

    }
}
