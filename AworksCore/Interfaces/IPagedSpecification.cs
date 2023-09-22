using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWorksDomain.Interfaces
{
    public interface IPagedSpecification
    {
        public int RowsPerPage { get; init; }
        public int PageNumber { get; init; }
    }
}
