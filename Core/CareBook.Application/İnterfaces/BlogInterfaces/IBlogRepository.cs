using CareBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Application.İnterfaces.BlogInterfaces
{
  public  interface IBlogRepository
    {
        public List<Blog> GetLat3BlogWithAuthor();
        public List<Blog> GetAllBlogsWithAuthor();
        public List<Blog> GetBlogByAuthorID(int id);
    }
}
