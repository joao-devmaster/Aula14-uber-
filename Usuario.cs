namespace aula13uber
{
    public class Usuario
    { // Propriedade resumida
        public string Nome { get; set; }

        // Propriedade completa
        private int idade = 0;
        public int Idade
        {
            get { return idade; }
            set { 
                if(idade > 0){
                    idade = value;
                }  
            }
        }

        public string Foto { get; set; }
        private string login = "joao@gmail.com";
        private string senha = "senaiinfo";

        public string LocalizacaoAtual { get; set; }
        public string TokenLogin { get; set; } 
        public string TipoAcesso { get; set; }

        public bool Login(string login, string senha){

            if( this.login == login && this.senha == senha ){
                TokenLogin = "token :opopopopopopopopop9";
                return true;
            }

            return false;
        }

        public void Logout(){
            TokenLogin = "";
        }


       
    }
}