using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class CategoryRepo : IRepo<Category, int>
    {
        LabEntities1 db = new LabEntities1();

        public void Add(Category obj)
        {
            db.Categories.Add(obj);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(Category obj)
        {
            throw new NotImplementedException();
        }

        public List<Category> Get()
        {
            throw new NotImplementedException();
        }

        public Category Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
