using System;

namespace Aula7Encapsulamento
{
    public class MasterCard
    {
        public int parcelas { get ; set ;}

        public void ComprarComDescontoMasterCard(float desconto){

            //cvv = "456";

            Console.WriteLine($"Compra realizada com {parcelas} parcelas e R$ {desconto} de desconto");
        }
    }
}