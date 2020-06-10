using System;

namespace aula13uber
{
    class Program
    {
        static void Main(string[] args)
        {
            Passageiro joao = new Passageiro();

            System.Console.WriteLine("\r\ndigite seu login ");
            string login = Console.ReadLine();
            
            System.Console.WriteLine("\r\ndigite sua senha");
            string senha = Console.ReadLine();
            
            joao.Login(login, senha);

            if(joao.TokenLogin != "" && joao.TokenLogin != null){
                System.Console.WriteLine("\r\nLogin autorizado!\r\n");
                System.Console.WriteLine(joao.TokenLogin);
            }else{
                System.Console.WriteLine("\r\nNão é possivel utilizar o app");
            }

           
            System.Console.WriteLine("\r\nUber console \r\nolá, digite o numero da operação desejada \r\n1 - chamar um motorista\r\n2 - Adicionar um novo cartão \r\n3 - Excluir um cartão ");
            string resp = Console.ReadLine();

            if(resp == "1"){

                System.Console.WriteLine("\r\nDigite sua localizacao atual");
                joao.LocalizacaoAtual = Console.ReadLine();

                System.Console.WriteLine("\r\ndigite seu destino");
                string localchegada = Console.ReadLine();

                System.Console.WriteLine(joao.SolicitarMotorista("joao"));

                { System.Console.WriteLine("\r\nchegamos ao seu destino, a corrida custou R$15,75 qual sera a forma de pagamento ?\r\n1 - Cartao\r\n2 - Dinheiro");
               string formadpag = Console.ReadLine();

               if(formadpag == "1"){
                   System.Console.WriteLine("\r\npagamento no cartao realizado com sucesso");
                
               }else if(formadpag == "2"){
                   System.Console.WriteLine("\r\npagamento realizado em dinehiro");
               }}
                


            }else if (resp == "2"){

                System.Console.WriteLine("\r\nDigite o numero do cartão");
                string numero = Console.ReadLine();

                System.Console.WriteLine("\r\nDigite o nome completo do titular");
                string titular = Console.ReadLine();
                
                System.Console.WriteLine("\r\ndigite a bandeira do cartão");
                string bandeira = Console.ReadLine();
                
                System.Console.WriteLine("\r\ndigite o cvv do cartão");
                string cvv = Console.ReadLine();

                System.Console.WriteLine("\r\nCartão adicionado com sucesso!");
                
            }

            else if(resp == "3"){

                System.Console.WriteLine("\r\nCartão excluido com sucesso !");
                
                
            }


           

            
                
            
            





              

          

            


        }
    }
}
