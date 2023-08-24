using AWorksDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWorksDomain.Entities;

public class AddressType : IBaseEntity, IHaveGuid
{
    public AddressType()
    {
        //KeyType = typeof(int);
        IsComplexType = false;
    }

    private Guid _rowGuid;
    public int AddressTypeID { get; set; }
    public string Name { get; set; }
    public DateTime? ModifiedDate { get; set; }
    public Guid rowguid
    {
        get
        {
            if (_rowGuid == Guid.Empty)
            {
                _rowGuid = Guid.NewGuid();
            }
            return _rowGuid;
        }
        set { _rowGuid = value; }
    }
    public bool IsComplexType { get; init; }
}
