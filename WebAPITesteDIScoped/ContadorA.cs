using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPITesteDIScoped.Provider;

namespace WebAPITesteDIScoped
{
    public class ContadorA : ContatorBase
    {
        public ContadorA(IProvider<ContextoVolatil> scopedServiceProvider) : base(scopedServiceProvider)
        {
        }

        public override void QtdLetras()
        {
            string texto = Contexto.textoRecebido;
            int qtd = 0;
            foreach (var item in texto)
            {
                if (item == 'a' || item == 'A')
                    qtd++;
            }

            Contexto.Resposta.letras = qtd;
            Contexto.Resposta.Mensagem = $"Existem {qtd} letras A nesta frase.";
        }
    }
}
