namespace aula13uber
{
    public class Passageiro : Usuario
    {
        public string SolicitarMotorista(string nome){
            
            return $"por favor {nome} aguarde no local combinado, estamos Procurando um motorista";
        }

        public bool Pagar(string statusCorrida){

            if(statusCorrida == "finalizada"){
                return true;
            }
            return false;
        }
    }
}