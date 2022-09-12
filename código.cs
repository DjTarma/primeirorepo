using System;

namespace myApp
{ 
  class questao1
  {
    static void Main()
    {
        int num1, num2, num3, arit, soma, produto;

        Console.WriteLine ("Digite seu Primeiro Numero Inteiro : ");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine ("Digite seu Segundo Numero Inteiro : ");
        num2 = int.Parse(Console.ReadLine());
        Console.WriteLine ("Digite seu Terceiro Numero Inteiro : ");
        num3 = int.Parse(Console.ReadLine());

        arit = (num1 + num2 + num3)/ 3;
        soma = num1 + num2 + num3;
        produto = num1 * num2 * num3;

        Console.WriteLine("Aritimética: " +arit);
        Console.WriteLine("Soma: " +soma);
        Console.WriteLine("Produto: " +produto);
    }
  }
}