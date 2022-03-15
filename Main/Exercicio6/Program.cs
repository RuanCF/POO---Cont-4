/*
Faça um programa que exiba quantas pessoas possuem mais de 18 anos. 
O algoritmo deverá ler a idade de 10 pessoas.
*/
using System;
class Reader{
    static void Main(){
        /*
        qtde = quantidade
        id = IDADE
        */
        int qtde = 0;
        int id = 0;

        Console.WriteLine("Verifique a pessoa maior de idade");

        int i = 0;

        while (i < 10){
            i = i + 1;
            Console.Write("Informe a idade da pessoa: ");
            id = Convert.ToInt32(Console.ReadLine());
            if (id >= 18){
                qtde = qtde + 1;
            }
        }
        Console.WriteLine("Existem " + qtde + " pessoas com mais de 18 anos");
        Console.ReadKey();
    }
}