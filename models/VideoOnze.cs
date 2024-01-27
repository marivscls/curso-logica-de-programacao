namespace logica_de_programacao_com_c_.models
{
    public class VideoOnzeDesafioUm
    {

        public void execute()
        {
            int term1 = 0;
            int term2 = 1;

            Console.WriteLine(term1);
            Console.WriteLine(term2);

            for (int counter = 0; counter <= 10; counter++)
            {

                int fib = term1 + term2;
                term1 = term2;
                term2 = fib;
                Console.WriteLine(fib);
            }
        }
    }

    public class VideoOnzeDesafioDois
    {
        public int value { get; set; }
        public int sum { get; set; }
        public decimal average { get; set; }
        public int evenPar { get; set; }
        public int divFive { get; set; }
        public int valueNull { get; set; }
        public void execute()
        {
            for (int counter = 1; counter <= 5; counter++)
            {
                Console.WriteLine($"Digite o {counter}° valor: ");
                this.value = Convert.ToInt32(Console.ReadLine());

                this.sum = value + this.sum;

                this.average = this.sum / 5;

                if (this.value % 5 == 0)
                {
                    this.divFive = this.divFive + 1;
                }

                if (this.value == 0)
                {
                    this.valueNull = value + 1;
                }

                if (this.value % 2 == 0)
                {
                    this.evenPar = this.evenPar + value;
                }
            }

            Console.WriteLine($"A soma entre os valores é: {this.sum}");
            Console.WriteLine($"A média entre os valores é: {this.average}");
            Console.WriteLine($"Valores divisíveis por 5: {this.divFive} ");
            Console.WriteLine($"valores nulos: {this.valueNull}");
            Console.WriteLine($"A soma entre os valores pares: {this.evenPar}");
        }
    }
}