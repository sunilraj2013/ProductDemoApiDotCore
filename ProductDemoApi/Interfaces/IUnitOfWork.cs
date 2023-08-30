using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductDemoApi.Interfaces
{
    public interface IUnitOfWork
    {
        IProductRepository Products { get; }
    }
}
