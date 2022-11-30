using Core.Entities.Base;
using DataAccess.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Concrete
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
    }
}
