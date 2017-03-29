using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Slk.Data;
using Slk.Models;

namespace Slk.Services
{
    public class GuideService : IGuideService
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                using (var context = new SlkContext())
                {
                    return context.inf_category
                        .Where(w => w.record_state != (int) EnumRStates.Deleted)
                        .Select(s => new Category
                        {
                            Id = s.id,
                            Title = s.title,
                            SubTitle = s.subtitle,
                            CreationDate = s.creation_date,
                            RecordState = (EnumRStates) s.record_state
                        }).ToList();
                }
            }
        }

        public IEnumerable<Article> Articles(int? userId)
        {
            using (var context = new SlkContext())
            {
                return context.inf_article
                    .Where(w => w.record_state != (int)EnumRStates.Deleted 
                        && ((userId.HasValue && w.user_id == userId.Value) || (!userId.HasValue)))
                    .OrderByDescending(o => o.creation_date)
                    .Select(s => new Article
                    {
                        Id = s.id,
                        Title = s.title,
                        SubTitle = s.subtitle,
                        Body = s.body,
                        BackgroundImageUrl = s.bg_image,

                        CategoryId = s.category_id,
                        CategoryName = s.inf_category.title,
                        UserId = s.user_id,
                        UserName = s.inf_user.first_name,

                        CreationDate = s.creation_date,
                        RecordState = (EnumRStates)s.record_state
                    }).ToList();
            }

            //throw new Exception("Under Construction!");
        }

        public Article GetArticle(int id)
        {
            using (var context = new SlkContext())
            {
                var article = new Article();

                var a = context.inf_article.FirstOrDefault(f => f.id == id);
                if (a != null)
                    article = new Article
                    {
                        Id = a.id,
                        Title = a.title,
                        SubTitle = a.subtitle,
                        Body = a.body,
                        BackgroundImageUrl = a.bg_image,

                        CategoryId = a.category_id,
                        CategoryName = a.inf_category.title,
                        UserId = a.user_id,
                        UserName = a.inf_user.first_name,

                        CreationDate = a.creation_date,
                        RecordState = (EnumRStates)a.record_state
                    };

                return article;
            }
        }

        public bool PostArticle(Article r)
        {
            using (var db = new SlkContext())
            {
                var entry = db.inf_article.Find(r.Id);
                if (entry != null)
                {
                    entry.body = r.Body;
                    entry.title = r.Title;
                    entry.subtitle = r.SubTitle;
                    entry.bg_image = r.BackgroundImageUrl;
                }
                else {
                    entry = new inf_article
                    {
                        bg_image = r.BackgroundImageUrl,
                        body = r.Body,
                        category_id = 1,
                        creation_date = DateTime.UtcNow,
                        record_state = 0,
                        subtitle = r.SubTitle,
                        title = r.Title,
                        user_id = r.UserId
                    };

                    db.inf_article.Add(entry);
                }

                try {
                    db.SaveChanges();
                } catch {
                    return false;
                }

                return true;                
            }
        }

        public bool DeleteArticle(int id)
        {
            using (var db = new SlkContext())
            {
                var entry = db.inf_article.Find(id);
                if (entry != null) {
                    entry.record_state = 1;
                    db.SaveChanges();
                    return true;
                }

                return false;
            }
        }

        public IEnumerable<Article> ArticlesByCategory(int categoryId)
        {
            //throw new Exception("Under Construction!");
            using (var context = new SlkContext())
            {
                var items =
                    context.inf_article.Where(
                        w => w.category_id == categoryId && w.record_state != (int)EnumRStates.Deleted)
                        .Select(s => new Article
                        {
                            Id = s.id,
                            Title = s.title,
                            SubTitle = "Some Text",
                            Body = s.body,

                            CategoryId = s.category_id,
                            CategoryName = s.inf_category.title,
                            UserId = s.inf_user.id,
                            UserName = s.inf_user.ToString(),

                            RecordState = (EnumRStates)s.record_state,
                            CreationDate = s.creation_date
                        }).ToList();

                return items;
            }
        }

        public IEnumerable<Article> ArticlesByUser(int userId)
        {
            throw new Exception("Under Construction!");
        }

    }
}
