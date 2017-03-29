using System;
using System.Collections;
using System.Collections.Generic;
using Slk.Models;

namespace Slk.Services
{
    public interface IGuideService
    {
        IEnumerable<Category> Categories { get; }
        IEnumerable<Article> Articles(int? userId = null);
        Article GetArticle(int id);
        bool PostArticle(Article request);
        bool DeleteArticle(int id);
        IEnumerable<Article> ArticlesByCategory(int categoryId);
        IEnumerable<Article> ArticlesByUser(int userId);        
    }
}