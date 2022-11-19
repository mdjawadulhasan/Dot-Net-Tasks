using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NtierBLL;
using NtierBLL.DTO;

namespace NtierMVCLayer.Controllers
{
    public class NewsController : Controller
    {
        // GET: News
        public ActionResult Index()
        {
            var data = NewsService.GetAll();
            return View(data);
        }

        public ActionResult Create()
        {
            ViewBag.Cat = CategoryService.GetAll();
            return View();
        }

        [HttpPost]
        public ActionResult Create(NewsDTO nd)
        {


            try
            {

                if (ModelState.IsValid)
                {
                    NewsService.AddNews(nd);
                    return RedirectToAction("Index");
                }
             
                return View();

            }
            catch
            {

                return View();
            }

        }


        public ActionResult Edit(int id)
        {


            try
            {

                if (ModelState.IsValid)
                {
                    var news = NewsService.GetNews(id);
                    return View(news);
                }

                return View();

            }
            catch
            {

                return View();
            }

           
        }


        [HttpPost]
        public ActionResult Edit(NewsDTO nd)
        {
            NewsService.UpdateNews(nd);
            return RedirectToAction("Index");
        }


        public ActionResult Delete(int id)
        {
            var news = NewsService.GetNews(id);
            NewsService.Delete(news);
            return RedirectToAction("Index");
        }
    }
}