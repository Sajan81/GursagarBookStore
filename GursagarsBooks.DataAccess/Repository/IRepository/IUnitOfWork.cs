using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GursagarsBooks.DataAccess.Repository.CoverTypeRepository;

namespace GursagarsBooks.DataAccess.Repository.IRepository
{
     public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Category { get; }
        ICoverTypeRepositroy CoverType { get; }
        IProductRepositroy Product { get; }

        ISP_Call SP_Call { get; }

        void Save();
    }
}
