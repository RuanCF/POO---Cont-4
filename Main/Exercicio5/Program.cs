/*
Faça um programa que leia a idade de uma pessoa expressa em anos, meses e dias
 e escreva a idade dessa pessoa expressa apenas em dias.
Considerar ano com 365 dias e mês com 30 dias.
*/
using System;
class Converter{
    static void Main(){
        /*
        id = idade
        mes = meses
        di = dias
        */
        int id, mes, di;

        Console.Write("Insira a sua idade com numeros inteiros: ");
        id = int.Parse(Console.ReadLine());

        mes = id * 12;
        di = mes * 365;

        Console.Write("\nSua idade é: " + id + " anos;" + mes + " meses; " + di + " dias.");
    }
}