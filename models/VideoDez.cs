using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Threading.Tasks;

namespace logica_de_programacao_com_c_.models
{
    public class VideoDezDesafioUm
    {
        public int number { get; set; }


        public void execute()
        {
            Console.WriteLine("-------- MENU --------");
            Console.WriteLine("     [1] de 1 a 10    ");
            Console.WriteLine("     [2] de 10 a 1    ");
            Console.WriteLine("     [3] EXIT         ");
            Console.WriteLine("----------------------");

            do
            {
                Console.WriteLine("Escolha um número de 1 a 3");
                this.number = Convert.ToInt32(Console.ReadLine());

                if (this.number == 1)
                {
                    for (int i = 0; i <= 10; i++)
                    {
                        Console.WriteLine(i);
                    }
                }
                else if (this.number == 2)
                {
                    for (int a = 10; a > 0; a--)
                    {
                        Console.WriteLine(a);
                    }
                }
                else if (this.number == 3)
                {
                    Console.WriteLine("Saindo...");
                }

            } while (this.number != 3);
        }
    }

    public class VideoDezDesafioDois
    {
        public string? response { get; set; }
        public string? gender { get; set; }
        public int age { get; set; }
        public int colorHair { get; set; }
        public int numbersM { get; set; }
        public int numbersF { get; set; }


        public void execute()
        {
            do
            {
                Console.WriteLine("Qual o sexo? F/M ");
                this.gender = Console.ReadLine();

                Console.WriteLine("Qual a idade?");
                this.age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Qual a cor do cabelo?");

                Console.WriteLine("[1] Preto");
                Console.WriteLine("[2] Castanho");
                Console.WriteLine("[3] Loiro");
                Console.WriteLine("[4] Ruivo");

                this.colorHair = Convert.ToInt32(Console.ReadLine());

                if (this.gender == "M" && this.age >= 18 && this.colorHair == 2)
                {
                    this.numbersM = this.numbersM + 1;
                }
                else if (this.gender == "F" && this.age >= 25 && this.age <= 30 && this.colorHair == 3)
                {
                    this.numbersF = this.numbersF + 1;
                }

                Console.WriteLine("Quer continuar?");
                this.response = Console.ReadLine();

            } while (this.response == "sim");

            Console.WriteLine($"Homens, maior de 18, cabelo castanho: {this.numbersM}");
            Console.WriteLine($"Mulheres, entre 25 e 30, loiras: {this.numbersF}");
        }
    }
}