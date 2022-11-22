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
    public class NewsService
    {
        public static void  Add(NewsRequest obj)
        {
            News news = new News();
            news.Id=obj.Id;
            news.CategroryId=obj.CategroryId;
            news.Title=obj.Title;   
            news.Date=obj.Date;

            new NewsRepo().Add(news);
        }
    }

}
