using System;
class MediaALuno{
  static void Main(){
    try{
        /*
        somid = soma das idades dos alunos!
        menid = media das idades     ""!
        idalun = Idades dos alunos!
        nomalun = Nome dos alunos
        */
      float somid = 0;
      float medid = 0;
      int[] idalun = new int[5];
      string[] nomalun = new string[5];

      for (int x = 0; x < 5; x++)
      {
        Console.WriteLine("\nNome do " + (x + 1) + " aluno: \n");
        nomalun[x] = Console.ReadLine();

        Console.WriteLine("\nIdade do " + (x + 1) + " aluno: \n");
        idalun[x] = int.Parse(Console.ReadLine());
      }


      for (int x = 0; x < 5; x++){
        somid += idalun[x];
      }

      medid = somid / 5;
      Console.WriteLine("medias dos alunos");
      Console.WriteLine("- Nome do aluno" + "- idade do aluno\n");

      for (int x = 0; x < 5; x++){
        int size_14 = (nomalun[x].Length - 14) * -1;
        string space_string = new string(' ', size_14);

        Console.WriteLine(" - " + nomalun[x] + space_string + " - " + idalun[x]);
      }
      Console.Write("\nMedia das idades: " + medid);

    }
    catch{
      Console.WriteLine("ERRO!");
    }
  }
}
