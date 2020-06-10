namespace aula13uber
{
    public class Corrida : Motorista
    {
        public string localinicio;
        public string localchegada;
        public string statusdacorrida;
        public string motorista;
        public string passageiro;

        public string Cancelar(){
            return"Sua corrida foi cancelada";
        
        }
    }
}