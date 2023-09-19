using AWorksDomain.Interfaces;
using System.Text.Json.Serialization;

namespace AWorksDomain.Entities;

public class SalesCustomer : IBaseEntity, IHaveGuid
{
    private Guid _rowGuid;
    public SalesCustomer()
    {
        IsComplexType = false;
    }
    public int CustomerId { get; set; }
    public int? PersonId { get; set; }
    public int? StoreId { get; set; }
    public int? TerritoryId { get; set; }
    public string AccountNumber { get; set; } = string.Empty;
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
    [JsonIgnore]
    public bool IsComplexType { get; init; }
}
