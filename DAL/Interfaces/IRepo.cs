﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IRepo<CLASS, ID>
    {
        List<CLASS> Get();
        CLASS Get(ID id);
        void Add(CLASS obj);
        void Edit(CLASS obj);
        void Delete(ID id);
    }
}