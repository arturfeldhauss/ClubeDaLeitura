using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura
{
    internal class reserva
    {
        public Pessoa reservourevista;
        public revista revistareservada;
        public DateTime datareserva;
        public DateTime dataentrega;
        public int multa;
        public Pessoa fezreserva;
        int nrevista;
        int numeropessoa;
        public bool reservacom;

        public void reservarrevista(revista[] revistas, Pessoa[] amigo)
        {

            reservacom = true;
            Console.WriteLine("Data do emprestimo");
            datareserva = DateTime.Parse(Console.ReadLine());

            for (int i = 0; i < revistas.Length; i++)
            {

                if (revistas[i] == null)
                    continue;

                Console.WriteLine($"Revista: ,{revistas[i].nedicao}, {revistas[i].colecao}. Revista numero: {i}");
            }

            do
            {
                Console.WriteLine("Qual revista deseja reservar?");
            }
            while (!(int.TryParse(Console.ReadLine(), out nrevista)) || revistas[nrevista] == null || revistas[nrevista].estaDisponivel == false);
            revistareservada = revistas[nrevista];
            revistas[nrevista].estaDisponivel = false;

            for (int i = 0; i < amigo.Length; i++)
            {
                if (amigo[i] == null)
                    continue;

                Console.WriteLine($"Nome do amigo: {amigo[i].nome}, Nome do responsavel: {amigo[i].nomeDoResponsavel}, Endereço: {amigo[i].endereco}. Amigo numero: {i}");
            }

            do
            {
                Console.WriteLine("qual amigo deseja pegar emprestado");

            } while (!(int.TryParse(Console.ReadLine(), out numeropessoa)) || amigo[numeropessoa] == null || amigo[numeropessoa].jaTemUmaRevista == false);
            reservourevista = amigo[numeropessoa];

            amigo[numeropessoa].jaTemUmaRevista = true;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Revista reservada com sucesso :-)");
            Console.ResetColor();
            Console.ReadLine();

        }
        

    }
}
