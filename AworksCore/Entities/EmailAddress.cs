using System;
using AWorksDomain.ClassExtensions;
using AWorksDomain.Interfaces;

namespace AWorksDomain.Entities;


public class EmailAddress : IBaseEntity, IHaveGuid, IComplexKey<EmailAddress.eaKey>
{
    //public record eaKey (int BusinessEntityId, int EmailAddressId);
    public record eaKey()
    {
        public int BusinessEntityId { get; set; }
        public int EmailAddressId { get; set; }
    }

    private Guid _rowGuid;
    public EmailAddress()
    {
        //KeyType = typeof(int);
        IsComplexType = true;
    }
    public int BusinessEntityId { get; set; }
    public int EmailAddressId { get; set; }
    public string EmailAddress1 { get; set; }
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
    public Type KeyType { get; init; }
    //public int GetKey(string encodedKey)
    //{
    //    int x = 0;
    //    int.TryParse(encodedKey.DecodeBase64(), out x);
    //    return x;
    //}
    public bool IsComplexType { get; init; }
    public eaKey GetKey(string encodedKey)
    {
        return new eaKey() { BusinessEntityId = 1, EmailAddressId = 1 };
    }
}
