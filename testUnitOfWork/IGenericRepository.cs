﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testUnitOfWork
{
    public interface IGenericRepository<T> where T : class
    {
        List<T> GetAll();
    }
}
