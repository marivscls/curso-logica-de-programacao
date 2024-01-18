using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;


namespace logica_de_programacao_com_c_.models
{
    public class VideoOitoDesafioUm
    {
        public decimal firstNote { get; set; }
        public decimal secondNote { get; set; }

        public void execute()
        {
            Console.WriteLine("Digite a primeira nota: ");
            this.firstNote = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            this.secondNote = Convert.ToDecimal(Console.ReadLine());

            decimal mediaNota = (this.firstNote + this.secondNote) / 2;

            if (mediaNota >= 9 && mediaNota < 10)
            {
                Console.WriteLine($"Aproveitamento: A");
            }

            else if (mediaNota >= 8 && mediaNota < 9)
            {
                Console.WriteLine($"Aproveitamento: B");
            }

            else if (mediaNota >= 7 && mediaNota < 8)
            {
                Console.WriteLine($"Aproveitamento: C");
            }

            else if (mediaNota >= 6 && mediaNota < 7)
            {
                Console.WriteLine($"Aproveitamento: D");
            }

            else if (mediaNota >= 5 && mediaNota < 6)
            {
                Console.WriteLine($"Aproveitamento: E");
            }
            else
            {
                Console.WriteLine("Aproveitamento: F");
            }
        }
    }


    public class VideoOitoDesafioDois()
    {
        public string? teamOne { get; set; }

        public string? teamTwo { get; set; }

        public int golsTeamOne { get; set; }

        public int golsTeamTwo { get; set; }

        public int diferenca { get; set; }

        public void execute()
        {
            Console.WriteLine("Time um: ");
            this.teamOne = Console.ReadLine();

            Console.WriteLine("time Dois: ");
            this.teamTwo = Console.ReadLine();

            Console.WriteLine($"Quantos gols fez o time {teamOne}?");
            this.golsTeamOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Quantos gols fez o time {teamTwo}?");
            this.golsTeamTwo = Convert.ToInt32(Console.ReadLine());

            if (this.golsTeamOne > this.golsTeamTwo)
            {
                this.diferenca = this.golsTeamOne - this.golsTeamTwo;
                Console.WriteLine($"A diferença de gols entre {teamOne} e {teamTwo} foi de {diferenca}");
            }
            else if (this.golsTeamTwo > this.golsTeamOne)
            {
                this.diferenca = this.golsTeamTwo - this.golsTeamOne;
                Console.WriteLine($"A diferença de gols entre {teamTwo} e {teamOne} foi de {diferenca}");
            }

            if (this.golsTeamOne == this.golsTeamTwo)
            {
                this.diferenca = this.golsTeamOne - this.golsTeamTwo;
                Console.WriteLine($"A diferença de gols entre {teamTwo} e {teamOne} foi de {diferenca}");
            }

            if (this.diferenca >= 5)
            {
                Console.WriteLine("status: GOLEADA");
            }

            if (this.diferenca < 5 && this.diferenca > 0)
            {
                Console.WriteLine("Status: Partida normal");
            }

            if (diferenca == 0)
            {
                Console.WriteLine("Status: Empate");
            }
        }
    }
}

