string leet;

Console.WriteLine("---Texto a ser traduzido---");
leet = Console.ReadLine().ToUpper();

leet = leet
          .Replace("A", "4")
          .Replace("E", "3")
          .Replace("I", "1")
          .Replace("L", "1")
          .Replace("O", "0")
          .Replace("T", "7")
          .Replace("S", "5")
;

Console.Write(leet);