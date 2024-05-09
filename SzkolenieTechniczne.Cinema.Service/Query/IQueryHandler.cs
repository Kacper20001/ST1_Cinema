using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolenieTechniczne.Cinema.Service.Query
{
    public interface IQueryHandler<in Tquery, out TResult>
        where Tquery : IQuery<TResult>
    {
        TResult Handle(Tquery query);
    }
}
