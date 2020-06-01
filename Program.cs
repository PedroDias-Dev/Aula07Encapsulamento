using System;

namespace Aula7Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Cartao card = new Cartao();
            card.AprovarCompra();

            MasterCard master = new MasterCard();
            master.parcelas = 3;
            //master.token = ""
            master.ComprarComDescontoMasterCard( 50f );
        }
    }
}
