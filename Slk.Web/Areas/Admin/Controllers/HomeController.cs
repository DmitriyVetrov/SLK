using Slk.Models;
using Slk.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Slk.Common;
using Microsoft.AspNet.Identity;

namespace Slk.Web.Areas.Admin.Controllers
{
    [RequireHttps]
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IGuideService _guideService = new GuideService();

        // GET: Admin/Home
        public ActionResult Index()
        {
            //Microsoft.AspNet.Identity.u
            var userId = User.Identity.GetUserId<int>();

            var articles = _guideService.Articles(userId).ToList();

            return View(articles);
        }

        // GET: Admin/Home
        public ActionResult Edit(int id = 0)
        {
            var article = new Article();
            if (id != 0)
                article = _guideService.GetArticle(id);

            return View(article);
        }

        [HttpPost]
        public ActionResult Edit(Article model)
        {
            if (model.UploadImage != null)
            {
                var url = AwsBucket.StoreImage(model.UploadImage);
                model.BackgroundImageUrl = url;
            }

            if (string.IsNullOrEmpty(model.BackgroundImageUrl))
                model.BackgroundImageUrl = string.Empty;

            model.UserId = User.Identity.GetUserId<int>();
            var success = _guideService.PostArticle(model);

            if (!success)
                return RedirectToAction("Error");

            return RedirectToAction("Index");
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            var success = _guideService.DeleteArticle(id);
            if (!success)
                return Json(new { });

            return Json(new { id = id });
        }


        [HttpPost]
        public JsonResult UploadBg(HttpPostedFileBase file)
        {
            return Json("");
        }

    }
}