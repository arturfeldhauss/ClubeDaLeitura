using System;

namespace ClubeDaLeitura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            menu menu = new menu();
            revista[] revista = new revista[100];
            Caixa[] caixa = new Caixa[100];
            Pessoa[] pessoa = new Pessoa[100];
            Emprestimo[] emprestimo = new Emprestimo[100];
            AcharObjeto acharObjeto = new AcharObjeto();
            reserva reserva = new reserva();
            do
            {
                switch (menu.MenuPrincipal())
                {
                    case 1:
                        int posicao = acharObjeto.AcharPosicaoParaOObjeto(revista);
                        revista[posicao] = new();
                        revista[posicao].regrevista(caixa);
                        break;

                    case 2:
                        posicao = acharObjeto.AcharPosicaoParaOObjeto(caixa);
                        caixa[posicao] = new();
                        caixa[posicao].RegistrarCaixa();
                        break;
                    case 3:
                        posicao = acharObjeto.AcharPosicaoParaOObjeto(pessoa);
                        pessoa[posicao] = new();
                        pessoa[posicao].RegistrarPessoa();
                        break;
                    case 4:
                        posicao = acharObjeto.AcharPosicaoParaOObjeto(emprestimo);
                        emprestimo[posicao] = new();
                        emprestimo[posicao].RegistrarEmprestimo(revista, pessoa);
                        break;
                    case 5:

                        Mostrar(revista);
                        break;
                    case 6:
                        Mostrar(pessoa);
                        break;

                    case 7:
                        Mostrar(caixa);
                        break;

                    case 8:
                        Mostrar(emprestimo);
                        break;

                    case 9:
                        
                        reserva.reservarrevista(revista, pessoa);
                        break;

                    case 10:
                        return;

                }
            } while (true);
        }

        private static void Mostrar(dynamic[] variavel)
        {
            for (int i = 0; i < variavel.Length; i++)
            {
                if (variavel[i] == null)
                    continue;
                Console.WriteLine($"ID : {i}");
                variavel[i].Mostrar();
            }
        }
    }
}

