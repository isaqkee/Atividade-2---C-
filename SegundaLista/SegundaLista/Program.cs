using System;
namespace SegundaLista
{
    class Atividade
    {
        /*#1*/
        static void Main(string[] args)
        {

            int quantidadeSorvetes = 15;

            double valorAPagar;
            if (quantidadeSorvetes <= 25)
            {
                valorAPagar = quantidadeSorvetes * 1.50;
            }
            else
            {
                valorAPagar = quantidadeSorvetes * 1.25;
            }


            Console.WriteLine("O cliente irá pagar R$" + valorAPagar);
        }


        /*#2*/
        static void Main(string[] args)
        {
            int numero = 15;

            if (numero > 10)
            {
                int resultado = numero + 10 * 2;
                Console.WriteLine("O resultado é: " + resultado);
            }
            else
            {
                int resultado = numero + 9 * 3 - 8;
                Console.WriteLine("O resultado é: " + resultado);
            }
        }


        /*#3*/
        static void Main(string[] args)
        {
            int num = 6;
            if (num < 0)
            {
                Console.WriteLine("É negativo");
            }
            else
            {
                Console.WriteLine("É positivo");
            }
        }


    }
    static void Main(string[] args)
    {

        /*ATIVIDADE 04*/
        int num1 = 254;
        int num2 = 527;

        if (num2 > num1)
        {
            Console.WriteLine("O segundo é maior");
        }
        else if (num1 < num2)
        {

            Console.WriteLine("O primeiro não é maior que o segundo número");

        }
        else
        {

            Console.WriteLine("os números são iguais");
        }
    }

    /*
    #5*/
    static void Main(string[] args)
    {

        double nota1 = 8;
        double nota2 = 6;


        double media = (nota1 + nota2) / 2;


        if (media >= 7)
        {
            Console.WriteLine("Aprovado");
        }
        else
        {
            Console.WriteLine("Reprovado");
        }
    }



}