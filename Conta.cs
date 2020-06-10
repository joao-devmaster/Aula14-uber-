namespace aula13uber
{
    public class Conta
    {
        private string agencia { get; set;}
        private string conta { get; set;}

        public string Cadastrar(){
            return "sua conta foi cadastrada com sucesso!";
        }
        public string Excluir(){
            return "sua conta foi excluida com sucesso!";
        }
    }
}