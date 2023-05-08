using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public void TBlogAdd(Blog blog)
        {
            throw new NotImplementedException();
        }

        public void TBlogDelete(Blog blog)
        {
            throw new NotImplementedException();
        }

        public void TBlogUpdate(Blog blog)
        {
            throw new NotImplementedException();
        }
        
        public List<Blog> TGetBlogListByWriter(int id)
        {
            return _blogDal.GetListAll(x => x.WriterID == id);
        }

        public List<Blog> TGetBlogListWithCategory()
        {
            return _blogDal.GetListWithCategory();
        }

        public Blog TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Blog> TGetList()
        {
            return _blogDal.GetListAll();
        }

        public List<Blog> GetBlogByID(int id)
        {
            return _blogDal.GetListAll(x => x.BlogID == id);
        }
        //------------------------------------------------------------













        //public List<Blog> GetBlogListWithCategory()
        //{
        //    return _blogDal.GetListWithCategory();
        //}





        //public List<Blog> GetList()
        //{
        //    return _blogDal.GetListAll();
        //}

        //public List<Blog> GetBlogListByWriter(int id)
        //{
        //    return _blogDal.GetListAll(x => x.WriterID == id);
        //}
    }
}
