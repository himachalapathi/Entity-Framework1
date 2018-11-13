using System;using System.Collections.Generic;using System.Linq;using System.Web;using System.Web.Mvc;using EntityFrameworork.Models;

namespace EntityFramework1.Controllers{    public class NorthwindController : Controller    {        NorthWindContext db = new NorthWindContext();
        // GET: NareshReddy
        public ActionResult Index()        {            db.CatagoriesTable.ToList();            db.productsTable.ToList();            return View();        }    }}