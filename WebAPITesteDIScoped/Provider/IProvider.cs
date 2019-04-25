using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPITesteDIScoped.Provider
{
    public interface IProvider<T>
    {
        T Get();
    }
}
