using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWorksDomain.Interfaces;

public interface IComplexKey<out T> where T : new()
{
    public Type KeyType { get; init; }
    public T GetKey(string encodedKey);
}
