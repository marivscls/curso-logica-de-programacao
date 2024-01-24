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


        public void execute()
        {

        }

    }
}