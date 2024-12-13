//using System.ComponentModel.DataAnnotations.Schema;
namespace AWorksDomain.Entities;

//[Table("Person", Schema = "Person")]
public class Person
{
    //[Key]
    public int BusinessEntityID { get; set; }
    public string PersonType { get; set; } = String.Empty;
    public bool NameStyle { get; set; }
    public string Title { get; set; } = String.Empty;
    public string FirstName { get; set; } = String.Empty;
    public string MiddleName { get; set; } = String.Empty;
    public string LastName { get; set; } = String.Empty;
    public string Suffix { get; set; } = String.Empty;
    public int EmailPromotion { get; set; }
    public string AdditionalContactInfo { get; set; } = String.Empty;
    public string Demographics { get; set; } = String.Empty;
    public Guid rowguid { get; set; }
    public DateTime ModifiedDate { get; set; }

}
