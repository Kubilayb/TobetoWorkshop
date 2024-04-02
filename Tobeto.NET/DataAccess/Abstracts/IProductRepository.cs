using Core.DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
    //repositories java daki ismi
    //   public interface IProductRepository : IRepository<Product>
    public interface IProductRepository : IRepository<Product>, IAsyncRepository<Product>

    {

    }

}