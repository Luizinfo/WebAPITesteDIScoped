namespace WebAPITesteDIScoped
{
    public class ContextoVolatil
    {
        public ContextoVolatil()
        {
            Resposta = new Resposta();
            textoRecebido = "";
        }

        public string textoRecebido { get; set; }

        public Resposta Resposta { get; set; }
    }
}