using GursagarsBooks.DataAccess.Repository.IRepository;
using GursagarBookStore.DataAccess.Data;
using GursagarsBooks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GursagarsBooks.DataAccess.Repository.CoverTypeRepository;

namespace GursagarsBooks.DataAccess.Repository
{
    public class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepositroy
    {
        private readonly ApplicationDbContext _db;
        public CoverTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;

        }
        public void Update(CoverType covertype)
        {
            var objFromDb = _db.CoverType.FirstOrDefault(s => s.Id == covertype.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = covertype.Name;
                _db.SaveChanges();
            }
            throw new NotImplementedException();
        }

         
    }
}