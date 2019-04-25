namespace WebAPITesteDIScoped
{
    public abstract class ContatorBase : IContador
    {
        protected ContextoVolatil Contexto;

        public ContatorBase(ContextoVolatil contexto)
        {
            Contexto = contexto;
        }

        public abstract void QtdLetras();

        public void QtdPalavras()
        {
            string texto = Contexto.textoRecebido;
            Contexto.Resposta.palavras = texto.Split(" ").Length;
        }
    }
}