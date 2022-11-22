using BAL.DTO;
using DAL.EF;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Services
{
    public class CategoryService
    {
        public static void Add(CategoryRequest obj)
        {
            Category category = new Category();
            category.Name = obj.Name;   
            category.Id = obj.Id;

            new CategoryRepo().Add(category);
        }

      

    }
}
