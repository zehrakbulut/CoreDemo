using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBlogService
    {
        void TBlogAdd(Blog blog);
        void TBlogDelete(Blog blog);
        void TBlogUpdate(Blog blog);
        List<Blog> TGetList();
        Blog TGetByID(int id);

        List<Blog> TGetBlogListWithCategory();

        List<Blog> TGetBlogListByWriter(int id);
    }
}
