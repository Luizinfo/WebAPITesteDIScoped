using System;

namespace WebAPITesteDIScoped
{
    public class ContadorService : IContadorService
    {
        private IContador contatorA;

        public ContadorService(IContador contatorA)
        {
            this.contatorA = contatorA;
        }

        public Resposta Processar(string texto)
        {
            contatorA.Contexto.textoRecebido = texto;

            contatorA.QtdLetras();
            contatorA.QtdPalavras();

            contatorA.Contexto.Resposta.dtResposta = DateTime.Now;
            contatorA.Contexto.Resposta.sucesso = true;

            return contatorA.Contexto.Resposta;
        }
    }
}