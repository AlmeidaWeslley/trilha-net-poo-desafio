using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Essa é ação do Nokia!");
Nokia nokia = new Nokia("999999999", "Modelo 1", "111111", 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n------------------\n");

Console.WriteLine("Essa é ação do Iphone!");
Iphone iphone = new Iphone("87878777271", "Modelo 4", "333333333333", 256);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Youtube");