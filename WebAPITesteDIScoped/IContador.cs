using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPITesteDIScoped
{
    public interface IContador
    {
        void QtdPalavras();
        void QtdLetras();

        ContextoVolatil Contexto { get; set; }
    }
}
