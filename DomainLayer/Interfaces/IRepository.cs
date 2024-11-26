﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Interfaces
{
    public class IRepository<T>
    {
        Task AddAsync(T entity);
    }
}
