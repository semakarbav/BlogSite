using BlogSitesi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSitesi.ViewComponents
{
    public class CommentList :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentValues = new List<UserComment>
            {
                new UserComment
                {
                    Id=1,
                    Username="Sema"
                },
                new UserComment
                {
                    Id=2,
                    Username="Ahmet"
                },
                new UserComment
                {
                    Id=3,
                    Username="Ayşe"
                }
            };
            return View(commentValues);
        }
    }
}
