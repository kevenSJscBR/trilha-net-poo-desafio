using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia( "123456", "Modelo 1", 111111111, 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone: ");
Smartphone iphone = new Iphone("4987", "Modelo 2", 222222222, 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");