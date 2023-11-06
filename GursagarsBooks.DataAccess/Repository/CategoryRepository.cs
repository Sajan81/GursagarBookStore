﻿using GursagarsBooks.DataAccess.Repository.IRepository;
using GursagarBookStore.DataAccess.Data;
 using GursagarsBooks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GursagarsBooks.DataAccess.Repository
{
    class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Category category)
        {
            throw new NotImplementedException();
        }
    }
}