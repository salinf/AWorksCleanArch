using System;
using AWorksDomain.ClassExtensions;
using AWorksDomain.Interfaces;

namespace AWorksDomain.Entities;

public class CountryRegion : IBaseEntity
{
    public CountryRegion()
    {
        // KeyType = typeof(int);
        IsComplexType = false;
    }
    public string CountryRegionCode { get; set; }
    public string Name { get; set; }
    public DateTime? ModifiedDate { get; set; }
    public bool IsComplexType { get; init; }
}
