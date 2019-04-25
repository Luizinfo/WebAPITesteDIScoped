namespace WebAPITesteDIScoped
{
    public class ContadorService : IContadorService
    {
        private IContador contatorA;
        private IContador contadorB;

        public ContadorService(ContadorA contatorA, ContadorB contadorB)
        {
            this.contatorA = contatorA;
            this.contadorB = contadorB;
        }

        public void Processar()
        {
            contatorA.QtdLetras();
            contatorA.QtdPalavras();

            contadorB.QtdLetras();
        }
    }
}