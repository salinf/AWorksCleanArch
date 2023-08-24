using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWorksDomain.Interfaces;

public interface IHaveGuid
{
    public Guid rowguid { get; set; }
}
