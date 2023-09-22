using AWorksDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWorksDomain.Entities;

public class testDefault : IBaseEntity
{
    public int Id { get; set; }
    public int Id2 { get; set; }
    public int? Id3 { get; set; }
    public DateTime? ModifiedDate { get; set; }
    public bool IsComplexType { get; init; }
}
