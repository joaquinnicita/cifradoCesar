using System;

class Program {
  
  static string alfabeto = "abcdefghijklmñnopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ1234567890_-+,#$%&/()=¿?¡!|,.;:{}[]";
  public static void Main(){
      Console.WriteLine("Ingrese la frase a cifrar");

      string msj = Console.ReadLine();
    
      Console.WriteLine("Ingrese la distancia");
      int distancia = int.Parse(Console.ReadLine());    
    
      while (string.IsNullOrEmpty(msj))
      {
          Console.WriteLine("Ingrese un mensaje no vacio");
          msj = Console.ReadLine();
      }
      Program program = new Program();    
      string res = program.cifrar(msj, distancia);
      Console.WriteLine(res);
    
      Console.WriteLine("Ingrese la frase a descifrar");
      string msj1 = Console.ReadLine();
    
      Console.WriteLine("Ingrese la distancia");
    
      int distancia1 = int.Parse(Console.ReadLine());   
      while (string.IsNullOrEmpty(msj))
    {
        Console.WriteLine("Ingrese un mensaje no vacio");
        msj1 = Console.ReadLine();
    }    
    string res1 = program.descifrar(msj1, distancia1);
    Console.WriteLine(res1);
    
    
  }

  public string cifrar(string msj, int distancia) {
    string cifrado = "";
    foreach (char c in msj)
      {
            int pos = alfabeto.IndexOf(c);
            if (pos != -1)
            {
                pos = (pos + distancia) % alfabeto.Length;
                cifrado += alfabeto[pos];
            }
            else
            {
                cifrado += c;
            }
        }
    return cifrado;
  }

  public string descifrar (string msj1, int distancia1){
    string descifrado = "";
      foreach (char c in msj1)
      {
          int pos = alfabeto.IndexOf(c);
            if (pos != -1)
            {
                pos = (pos - distancia1) % alfabeto.Length;
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

