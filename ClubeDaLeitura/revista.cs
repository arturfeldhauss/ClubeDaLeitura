using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura
{
    internal class revista
    {
        public bool estadisponivel = true;
        public string colecao;
        public string nedicao;
        public bool estaDisponivel = true;
        public string dia;
        public string caixa;
        public DateTime datarevista;

        public Caixa caixadarevista;

        public void regrevista(Caixa[] caixa)
        {
            Console.WriteLine("Insira a colecao da revista?");
            colecao = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Inita a data revista!");
            datarevista = DateTime.Parse(Console.ReadLine());

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
