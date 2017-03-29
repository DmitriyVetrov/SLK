using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.SignalR;
using Slk.Models;
using Slk.Web.Models;
using Slk.Services;
using Slk.Web.Hubs;

namespace Slk.Web.Controllers
{
    public class GuideController : Controller
    {
        private readonly IGuideService _guideService = new GuideService();

        // GET: Guide
        public ActionResult Index(string topic, string article)
        {
            if (string.IsNullOrEmpty(topic) && string.IsNullOrEmpty(article))
            {
                // Main Page
                var articles = _guideService.Articles();

                return View("MainPage", articles);
            }

            if (!string.IsNullOrEmpty(topic) && string.IsNullOrEmpty(article))
            {
                // Topic Page
                return View("TopicPage");
            }

            var maxLength = 8;
            var startIndex = article.Length - maxLength;
            if (startIndex <= 0)
                throw new HttpException(404, "Some description");

            var str = article.Substring(startIndex);
            int id = 0;
            if (int.TryParse(str, out id))
            {
                var model = _guideService.GetArticle(id);
                return View("ArticlePage", model);
            }
            else throw new HttpException(404, "Some description");
        }

        // GET: Guide
        public ActionResult Index1(int id = 0)
        {
            id = id == 0 ? 1 : id;

            var cats = _guideService.Categories.Select(s => new Category
            {
                Id = s.Id,
                Title = s.Title,
                SubTitle = s.SubTitle,
                CreationDate = s.CreationDate,
                RecordState = s.RecordState
            });

            var articles = _guideService.ArticlesByCategory(id);

            var model = new GuideViewModel
            {
                Categories = cats,
                ActiveCategoryId = id,
                Articles = articles
            };

            return View(model);
        }

        //public ActionResult Push(string id = "")
        //{
        //    if (!string.IsNullOrEmpty(id))
        //    {
        //        IHubContext hub = GlobalHost.ConnectionManager.GetHubContext<BusinessHub>();
        //        var connections = BusinessHub.GetConnectionIdsByName(id);

        //        hub.Clients.Clients(connections).updatePage();
        //    }
        //    return null;
        //}

        //public ActionResult Index(string id)
        //{
        //    return View(new GuideViewModel());
        //}


        // GET: Article/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Article/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Article/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Article/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Article/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Article/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Article/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}