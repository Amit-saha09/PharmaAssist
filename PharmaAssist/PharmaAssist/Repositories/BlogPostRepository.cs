using PharmaAssist.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PharmaAssist.Repositories
{
    public class BlogPostRepository:Repository<BlogPost>
    {
        public List<BlogPost>GetUserPosts(int Id)
        {
            return this.contex.BlogPosts.Where(x => x.DoctorId == Id).ToList();
        }
    }
}