using System;

class Program {
  
  static string alfabeto = "abcdefghijklmñnopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ1234567890_-+,#$%&/()=¿?¡!|,.;:{}[]";
  public static void Main(){
      Console.WriteLine("Ingrese la frase a cifrar");

      string msj = Console.ReadLine();
      while (string.IsNullOrEmpty(msj))
      {
          Console.WriteLine("Ingrese un mensaje no vacio");
          msj = Console.ReadLine();
      }
      Program program = new Program();    
      string res = program.cifrar(msj);
      Console.WriteLine(res);

    Console.WriteLine("Ingrese la frase a descifrar");

    string msj1 = Console.ReadLine();
    while (string.IsNullOrEmpty(msj))
    {
        Console.WriteLine("Ingrese un mensaje no vacio");
        msj1 = Console.ReadLine();
    }    
    string res1 = program.descifrar(msj1);
    Console.WriteLine(res1);
    
  }

  public string cifrar(string msj) {
    string cifrado = "";
    foreach (char c in msj)
      {
            int pos = alfabeto.IndexOf(c);
            if (pos != -1)
            {
                pos = (pos + 7) % alfabeto.Length;
                cifrado += alfabeto[pos];
            }
            else
            {
                cifrado += c;
            }
        }
    return cifrado;
  }

  public string descifrar (string msj1){
    string descifrado = "";
      foreach (char c in msj1)
      {
          int pos = alfabeto.IndexOf(c);
            if (pos != -1)
            {
                pos = (pos - 7) % alfabeto.Length;
                descifrado += alfabeto[pos];
            }
            else
            {
                descifrado += c;
            }
      }
      return descifrado;
  }
}
using System;

class Program {
  
  static string alfabeto = "abcdefghijklmñnopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ1234567890_-+,#$%&/()=¿?¡!|,.;:{}[]";
  public static void Main(){
      Console.WriteLine("Ingrese la frase a cifrar");

      string msj = Console.ReadLine();
      while (string.IsNullOrEmpty(msj))
      {
          Console.WriteLine("Ingrese un mensaje no vacio");
          msj = Console.ReadLine();
      }
      Program program = new Program();    
      string res = program.cifrar(msj);
      Console.WriteLine(res);

    Console.WriteLine("Ingrese la frase a descifrar");

    string msj1 = Console.ReadLine();
    while (string.IsNullOrEmpty(msj))
    {
        Console.WriteLine("Ingrese un mensaje no vacio");
        msj1 = Console.ReadLine();
    }    
    string res1 = program.descifrar(msj1);
    Console.WriteLine(res1);
    
  }

  public string cifrar(string msj) {
    string cifrado = "";
    foreach (char c in msj)
      {
            int pos = alfabeto.IndexOf(c);
            if (pos != -1)
            {
                pos = (pos + 7) % alfabeto.Length;
                cifrado += alfabeto[pos];
            }
            else
            {
                cifrado += c;
            }
        }
    return cifrado;
  }

  public string descifrar (string msj1){
    string descifrado = "";
      foreach (char c in msj1)
      {
          int pos = alfabeto.IndexOf(c);
            if (pos != -1)
            {
                pos = (pos - 7) % alfabeto.Length;
                descifrado += alfabeto[pos];
            }
            else
            {
                descifrado += c;
            }
      }
      return descifrado;
  }
}
