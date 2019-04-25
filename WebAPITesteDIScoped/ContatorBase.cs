using WebAPITesteDIScoped.Provider;

namespace WebAPITesteDIScoped
{
    public abstract class ContatorBase : IContador
    {
        protected IProvider<ContextoVolatil> scopedServiceProvider;

        public ContatorBase(IProvider<ContextoVolatil> scopedServiceProvider)
        {
            this.scopedServiceProvider = scopedServiceProvider;
        }

        public ContextoVolatil Contexto
        {
            get => scopedServiceProvider.Get();
            set { Contexto = value; }
        }

        public abstract void QtdLetras();

        public void QtdPalavras()
        {
            string texto = Contexto.textoRecebido;
            Contexto.Resposta.palavras = texto.Split(" ").Length;
        }
    }
}