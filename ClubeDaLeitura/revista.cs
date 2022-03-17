using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura
{
    internal class revista
    {
        public string colecao;
        public string nedicao;
        public bool estaDisponivel = true;
        public string dia;
        public string mes;
        public string anos;
        public string caixa;

        public Caixa caixadarevista;

        public void regrevista(Caixa[] caixa)
        {
            Console.WriteLine("Insira a colecao da revista?");
            colecao = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Insira o mes da revista!");
            dia = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Inita o mes da revista!");
            mes = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Insira o ano da revista!");
            anos = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Digite o numero de edição da revista!");
            nedicao = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Qual caixa deseja guardar?");
            for(int i = 0; i < caixa.Length; i++)
            {
                if(caixa[i] == null)
                    continue;
                Console.WriteLine($"Caixa: {caixa[i].ccaixa}, {caixa[i].ecaixa}, {caixa[i].ncaixa}. Caixa numero: {i}");
            }

        }









    }
}
