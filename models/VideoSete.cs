using System;
using System.Security.Cryptography.X509Certificates;
using logica_de_programacao_com_c_.models;


public class VideoSeteDesafioUm
{
  public string? name { get; set; }

  public int birthYear { get; set; }

  public int currentYear { get; set; }

  public int age { get; set; }

  public void execute()
  {
    Console.WriteLine("Digite o seu nome");
    this.name = Console.ReadLine();

    Console.WriteLine("Digite o ano atual");
    this.currentYear = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Digite o ano de nascimento");
    this.birthYear = Convert.ToInt32(Console.ReadLine());

    this.age = this.currentYear - this.birthYear;

    Console.WriteLine($"{this.name}, tem {this.age} anos.");
  }
}

public class VideoSeteDesafioDois
{
  public string? name { get; set; }

  public int birthYear { get; set; }

  public int currentYear { get; set; }

  public int age { get; set; }

  public void execute()
  {
    Console.WriteLine("Digite o seu nome");
    this.name = Console.ReadLine();

    Console.WriteLine("Digite o ano atual");
    this.currentYear = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Digite o ano de nascimento");
    this.birthYear = Convert.ToInt32(Console.ReadLine());

    this.age = this.currentYear - this.birthYear;

    if (this.age >= 18)
    {
      Console.WriteLine($"{this.name} está apto a dirigir");

    }
    else
    {
      Console.WriteLine($"{this.name} nao está apto a dirigir");
    }

  }
}

public class VideoSeteDesafioTres
{
  public string? name { get; set; }
  public decimal firstNote { get; set; }
  public decimal secondNote { get; set; }


  public void execute()
  {
    Console.WriteLine("Digite o nome do aluno: ");
    this.name = Console.ReadLine();

    Console.WriteLine("Digite a Primeira nota: ");
    this.firstNote = Convert.ToDecimal(Console.ReadLine());

    Console.WriteLine($"Digite a segunda nota: ");
    this.secondNote = Convert.ToDecimal(Console.ReadLine());

    decimal media = (this.firstNote + this.secondNote) / 2;

    if (media >= 7)
    {
      Console.WriteLine($"{name} alcancou a media 7 entao foi aprovada!");
    }
    else
    {
      Console.WriteLine($"{name} nao alcancou a media de 7, reprovado!");
    }

  }
}



