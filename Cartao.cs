using System;

namespace Aula7Encapsulamento
{
    public class Cartao : MasterCard
    {
        public string numero { get ; set ;}
        public string titulo { get ; set ;}
        public string bandeira { get ; set ;}

        private string token = "asfasfshgef7gfifh89e8hfio";

        protected string cvv { get ; set ;}

        public void AprovarCompra(){
            Console.WriteLine("Sua compra foi aprovada!");
        }

        private bool ValidarToken(){
            if (token != null){
            return true;
            }
            return true;
        }

        private bool ValidarCompra (){
            return true;
        }


    }
}