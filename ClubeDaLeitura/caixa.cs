using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura
{ 
    internal class Caixa
    {
        public int ncaixa;
        public string ccaixa;
        public string ecaixa;

        

        public void RegistrarCaixa()
        {

            Console.WriteLine("Qual o numero da caixa?");
            ncaixa = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Qual a cor da caixa?");
            ccaixa = Convert.ToString(Console.ReadLine());



            Console.WriteLine("Qual a entiqueta da caixa?");
            ecaixa = Convert.ToString(Console.ReadLine());
        }
        public void Mostrar()
        {                      
                    Console.WriteLine("Numero da caixa: " + ncaixa);

                    Console.WriteLine("Cor da caixa: " + ccaixa);

                    Console.WriteLine("Entiqueta da caixa: " + ecaixa);
           
            Console.ReadLine();
        }
    }
}
