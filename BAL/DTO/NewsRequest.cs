using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.DTO
{
    public class NewsRequest
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int CategroryId { get; set; }
        public DateTime Date { get; set; }
    }
}
