using System;

namespace Desafio_02
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Desafio 2");

            bool[] EhDev = new bool[3];

            string nome1 = "Ubuntu1 Rodrigo";
            int idade1 = 31;
            double peso1 = 85.5;
            double altura1 = 1.75;
            EhDev[0] = true;

            string nome2 = "Ubuntu2 Silva";
            int idade2 = 33;
            double peso2 = 88.5;
            double altura2 = 1.65;
            EhDev[1] = true;

            string nome3 = "Ubuntu3 Santos";
            int idade3 = 25;
            double peso3 = 109.8;
            double altura3 = 1.91;
            EhDev[2] = false;

            int idadesSoma;
            idadesSoma = idade1 + idade2 + idade3;
            Console.WriteLine("A soma das idades eh: "+ idadesSoma.ToString());

            string[] grupoNome = new string[3];
            grupoNome[0] = nome1;
            grupoNome[1] = nome2;
            grupoNome[2] = nome3;

            Console.WriteLine("Nomes agrupados na memória");
            for (int count = 0; count < 3; count++)
            {
                Console.WriteLine(grupoNome[count]);
            }

            double imc1, imc2, imc3;
            imc1 = peso1 / altura1;
            Console.WriteLine("IMC do ubuntu "+ grupoNome[0]+" eh "+imc1.ToString());
            imc2 = peso2 / altura2;
            Console.WriteLine("IMC do ubuntu "+ grupoNome[1]+ " eh "+ imc2.ToString());
            imc3 = peso3 / altura3;
            Console.WriteLine("IMC do ubuntu "+ grupoNome[2]+ " eh "+ imc3.ToString());

            int totalEhDev = 0;
            for (int count = 0; count < 3; count++)
            {
                if (EhDev[count] == true)
                {
                    totalEhDev++;
                }
            }
            Console.WriteLine("A quantidade de Ubuntu que são dev são" + totalEhDev.ToString());

            Console.WriteLine("Ubuntus que tem Silva no nome");
            for (int count = 0; count < 3; count++)
            {
                
                string s1 = grupoNome[count];
                string s2 = "Silva";
                bool b = s1.Contains(s2);
                if (b == true)
                {
                    Console.WriteLine(grupoNome[count]);
                }
            }
            /*
            //Imprime na tela
            Console.WriteLine("UBUNTU 002 - STARTS...");

            string nome1 = "Ubuntu1 Silva";
            int idade1   = 33;
            double peso1 = 88.50;
            decimal altura1 = 1.65M;
            bool EhDev1  = true;

            string nome2 = "Ubuntu2 Santos";
            int idade2 = 26;
            double peso2 = 84.50;
            decimal altura2 = 2.10M;
            bool EhDev2 = true;

            string nome3 = "Ubuntu3 Silva";
            int idade3 = 85;
            double peso3 = 66.50;
            decimal altura3 = 1.40M;
            bool EhDev3 = false;


            //T1 - Somar a idade de todos Ubuntus

            //T2 - Agrupar os nomes de todos Ubuntus

            //T3 - Calcular Média dos IMC de todos Ubuntus

            //T4 - Contar quantos Ubuntus sao Devs

            //T5 - Exibir somente Ubuntu com nome Silva



            //Imprime na tela
            Console.WriteLine("UBUNTU 002 - ENDS...");

            //PAUSA NA TELA (GAMBIARRA PERMITIDA PRA INICIANTES)
            Console.Read();*/
        }


    }
}
