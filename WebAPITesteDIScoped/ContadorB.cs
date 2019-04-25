namespace WebAPITesteDIScoped
{
    public class ContadorB : ContatorBase
    {
        public ContadorB(ContextoVolatil contexto) : base(contexto)
        {
        }

        public override void QtdLetras()
        {
            string texto = Contexto.textoRecebido;
            int qtd = 0;
            foreach (var item in texto)
            {
                if (item == 'b' || item == 'B')
                    qtd++;
            }

            Contexto.Resposta.letras += qtd;
            Contexto.Resposta.Mensagem += $" - Existem {qtd} letras B nesta frase.";
        }
    }
}