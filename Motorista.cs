namespace aula13uber
{
    public class Motorista 
    {
        public string carro;
        public string placa;

        public string AceitarPassageiro(string nome){
           return $"{nome} a corrida iniciara em instantes ";

        }
        public bool ReceberPagameento(string statusCorrida){
            if(statusCorrida == "finalizada" ){
                return true;
            }else{
                return false;
            }
        }
    }
}