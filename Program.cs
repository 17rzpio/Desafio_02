using System;

namespace Desafio_02
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Desafio 2");

            bool[] EhDev = new bool[3]; //array para ao comparar percorrer todos na memória e saber quantos são dev (item 4 do desafio 2)

            string nome1 = "Ubuntu1 Rodrigo";//tipo string é de caracter
            int idade1 = 31;//tipo int para idade
            double peso1 = 85.5;//tipo double para números com virgula, reais
            double altura1 = 1.75;
            EhDev[0] = true;//variavel tipo booleana por se tratar da pergunta se é dev ou não

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
            idadesSoma = idade1 + idade2 + idade3;//item 1 do desafio, a operação simples da soma de todas idades
            Console.WriteLine("A soma das idades eh: "+ idadesSoma.ToString());//para dizer qual a resposta converte para string

            string[] grupoNome = new string[3];//item2 do desafio 2 que pede para agrupar os nomes e foi agrupado com o vetor
            grupoNome[0] = nome1;
            grupoNome[1] = nome2;
            grupoNome[2] = nome3;

            Console.WriteLine("Nomes agrupados na memória");//exibe os nomes de modo agrupado
            for (int count = 0; count < 3; count++)
            {
                Console.WriteLine(grupoNome[count]);
            }
            Console.WriteLine("Concatenação da string nome: "+grupoNome[0]+grupoNome[1]+grupoNome[2]);//concatena a string com sinal de +

            double imc1, imc2, imc3;//declara variáveis tipo real necessário para cálculo IMC. item 3 do desafio2
            imc1 = peso1 / (altura1*altura1);//fórmula do IMC para cálculo é peso dividido pelo quadrado da altura
            Console.WriteLine("IMC do ubuntu "+ grupoNome[0]+" eh "+imc1.ToString());
            imc2 = peso2 / (altura2*altura2);
            Console.WriteLine("IMC do ubuntu "+ grupoNome[1]+ " eh "+ imc2.ToString());
            imc3 = peso3 / (altura3*altura3);
            Console.WriteLine("IMC do ubuntu "+ grupoNome[2]+ " eh "+ imc3.ToString());

            int totalEhDev = 0;//item 4 do desafio 2 é para estimar quanto são Dev dos cadastrados
            for (int count = 0; count < 3; count++)
            {
                if (EhDev[count] == true)
                {
                    totalEhDev++;
                }
            }
            Console.WriteLine("A quantidade de Ubuntu que são dev são" + totalEhDev.ToString());

            Console.WriteLine("Ubuntus que tem Silva no nome");//item 5 do desafio 2 é saber quais tem Silva no nome
            for (int count = 0; count < 3; count++)
            {
                
                string s1 = grupoNome[count];
                string s2 = "Silva";
                bool b = s1.Contains(s2);//Método Contains retorna bool quando encontra na string de objeto o texto colocado como parametro
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
