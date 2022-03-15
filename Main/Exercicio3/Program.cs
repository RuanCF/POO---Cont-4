/*
Crie um algoritmo que verifique se um número informado é par ou ímpar.
*/
using System;
class media{
  static void Main(){
      
    int num = 0;
    Console.WriteLine("Digite o número a ser verificado: ");
    num = int.Parse(Console.ReadLine());

        switch (num % 2){
            case 0:
                Console.WriteLine("\nO valor inserido: " + num + " é par.");
                break;
            default:
                Console.WriteLine("\nO valor inserido: " + num + " é impar.");
                break;
        }
    }
}