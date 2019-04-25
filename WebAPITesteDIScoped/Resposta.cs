using System;

namespace WebAPITesteDIScoped
{
    public class Resposta
    {
        public int palavras { get; set; }

        public int letras { get; set; }

        public bool sucesso { get; set; }

        public DateTime dtResposta { get; set; }

        public string Mensagem { get; set; }
    }
}