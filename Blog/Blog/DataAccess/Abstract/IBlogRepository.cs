﻿using Blog.Core.DataAccess;
using Blog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IBlogRepository : IEntityRepository<BlogArticle>
    {
        List<BlogArticle> GetAllByCategory(int categoryId);
        Task AddWithCategories(BlogArticle blog);
    }
}
