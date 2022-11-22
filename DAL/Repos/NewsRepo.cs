using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class NewsRepo : IRepo<News, int>
    {
        LabEntities1 db = new LabEntities1();

        public void Add(News obj)
        {
            db.News.Add(obj);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(News obj)
        {
            throw new NotImplementedException();
        }

        public List<News> Get()
        {
            throw new NotImplementedException();
        }

        public News Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
