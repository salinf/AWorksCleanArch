using AWorksDomain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AWorksInfrastructure.Data
{
    public interface IAdventureWorksContext
    {
        DbSet<Address> Address { get; set; }
        DbSet<AddressType> AddressType { get; set; }
        DbSet<CountryRegion> CountryRegion { get; set; }
        DbSet<EmailAddress> EmailAddress { get; set; }
        DbSet<Person> Person { get; set; }
    }
}