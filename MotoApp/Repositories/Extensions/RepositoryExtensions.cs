﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MotoApp.Entities;

namespace MotoApp.Repositories.Extensions
{
    
    public static class RepositoryExtensions
    {
    public static void AddBatch<T>(this IRepository<T> repository, T[] items)
    where T : class, IEntity
        {
            foreach (var item in items)
            {
                repository.Add(item);
            }
            repository.Save();
        }

        public static void AddBatch<T>(this string s, T[] items)
         where T : class, IEntity
        {
            //
        }
    }

   

}
