using PharmaAssist.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PharmaAssist.Repositories
{
    public class BlogRepository:Repository<BlogPost>
    {
        public List<BlogPost>UserBlogs(int Id)
        {
            return this.contex.BlogPosts.Where(x => x.DoctorId == Id).ToList();
        }
    }
}