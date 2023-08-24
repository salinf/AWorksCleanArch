using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWorksDomain.Interfaces;

public interface IBaseEntity
{
    public DateTime? ModifiedDate { get; set; }
    public bool IsComplexType { get; init; }

}
