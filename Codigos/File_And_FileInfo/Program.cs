var path = Path.Combine(Environment.CurrentDirectory, "teste.txt");

using var sw = File.CreateText(path);
sw.WriteLine("Está a linha 1 do arquivo");
sw.WriteLine("Está a linha 2 do arquivo");
sw.WriteLine("Está a linha 3 do arquivo");
sw.Flush();