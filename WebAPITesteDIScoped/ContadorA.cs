﻿namespace WebAPITesteDIScoped
{
    public class ContadorA : ContatorBase
    {
        public ContadorA(ContextoVolatil contexto) : base(contexto)
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

            Contexto.Resposta.letras += qtd;
            Contexto.Resposta.Mensagem = $"Existem {qtd} letras A nesta frase.";
        }
    }
}