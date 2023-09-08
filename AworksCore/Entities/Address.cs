using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AWorksDomain.ClassExtensions;
using AWorksDomain.Interfaces;

namespace AWorksDomain.Entities;


public class Address : IBaseEntity, IHaveGuid
{
    private Guid _rowGuid;
    public Address()
    {
        //KeyType = typeof(int);
        IsComplexType = false;
    }

    public int AddressID { get; set; }
    public string AddressLine1 { get; set; } = string.Empty;
    public string? AddressLine2 { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public int StateProvinceID { get; set; }
    public string PostalCode { get; set; } = string.Empty;
    //public Geometry SpatialLocation { get; set; }
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
    public DateTime? ModifiedDate { get; set; }
    public bool IsComplexType { get; init; }
}
