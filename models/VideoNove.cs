namespace logica_de_programacao_com_c_.models
{
    public class VideoNoveDesafioUm
    {
        public int start { get; set; }

        public int end { get; set; }

        public int counter { get; set; }

        public void execute()
        {
            Console.WriteLine("Início: ");
            this.start = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Fim: ");
            this.end = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Contando...");

            if (start < end)
            {
                while (this.counter <= this.end)
                {
                    Console.WriteLine(this.counter);
                    counter++;

                }

            }
            else if (start > end)
            {
                while (this.counter < this.start)
                {
                    Console.WriteLine(this.counter);
                    counter++;

                }
            }
        }
    }

    public class VideoNoveDesafioDois
    {
        public int numberStudents { get; set; }

        public string? studentName { get; set; }

        public int studentNote { get; set; }

        public decimal mostHighGradeClass { get; set; }

        public string? student { get; set; }


        public void execute()
        {

            Console.WriteLine("Quantos alunos a turma tem?");
            this.numberStudents = Convert.ToInt32(Console.ReadLine());

            int counter = 1;
            this.mostHighGradeClass = 1;

            while (counter <= numberStudents)
            {
                Console.WriteLine($"Aluno: {counter}");

                Console.WriteLine("Nome do aluno: ");
                this.studentName = Console.ReadLine();

                Console.WriteLine($"Nota de {this.studentName}");
                this.studentNote = Convert.ToInt32(Console.ReadLine());

                if (this.studentNote > this.mostHighGradeClass)
                {
                    this.mostHighGradeClass = this.studentNote;
                    this.student = this.studentName;
                }

                counter++;
            }

            Console.WriteLine($"O melhor aproveitamento foi de {this.student} com a nota de {this.mostHighGradeClass}");

        }
    }
}