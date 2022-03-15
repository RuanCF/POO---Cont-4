/*
Escreva um programa para ler as dimensões de um retângulo (base e altura)
calcular e escrever a área do retângulo. (ar = b*a )
*/
using System;
class areaRetan{
  static void Main()
  {
    float basret, altret, areret;

    Console.Write("Insira o valor da base do retângulo: ");
    basret = float.Parse(Console.ReadLine());

    Console.Write("Insira o valor da altura do retângulo: ");
    altret = float.Parse(Console.ReadLine());

    areret = basret * altret;

    Console.Write("\nA area do retângulo é: " + areret);
  }
}