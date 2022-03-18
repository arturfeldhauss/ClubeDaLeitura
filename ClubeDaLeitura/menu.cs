using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura
{
    internal class menu
    {
        public int opcao;
        public int MenuPrincipal()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("AREA DE REGISTRO!");
            Console.ResetColor();
            Console.WriteLine("Digite 1 para registrar uma revista");
            Console.WriteLine("Digite 2 para registrar uma caixa");
            Console.WriteLine("Digite 3 para registrar um amigo");
            Console.WriteLine("Digite 4 para regitrar um emprestimo");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("AREA DE VISUALIZAÇÃO!");
            Console.ResetColor();
            Console.WriteLine("Digite 5 para visualizar as revistas");
            Console.WriteLine("Digite 6 para visualizar as caixas");
            Console.WriteLine("Digite 7 para visualizar os amigos");
            Console.WriteLine("Digite 8 para visualizar os emprestimos");
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("AREA DE RESERVA");
            Console.ResetColor();
            Console.WriteLine("Digite 9 para reservar uma revista");


            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("================");
            Console.WriteLine("Digite 10 para sair\n");
            Console.ResetColor();
            opcao = Convert.ToInt32(Console.ReadLine());
            return opcao;
        }
    }
}
