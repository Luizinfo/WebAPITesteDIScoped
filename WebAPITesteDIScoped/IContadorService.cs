using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPITesteDIScoped
{
    public interface IContadorService
    {
        Resposta Processar(string texto);
    }
}
