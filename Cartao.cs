namespace aula13uber
{
    public class Cartao
    {
        public string numero { get; set;}
        public string titular { get; set;}
        public string bandeira { get; set;}
        protected string cvv { get; set;}

        public string Cadastrar(){
            return "Seu cartão foi cadastrado com sucesso !";
        }

        public string Excluir(){
            return "Cartão excluido com sucesso";
        }
    }
}