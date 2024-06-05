using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero:"123456", modelo: "Modelo2", imei:"11111111", memoria:64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");
nokia.InformacaoDoAparelho();

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone");
Smartphone iphone = new Iphone(numero: "321", modelo: "Modelo1", imei: "222222", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
iphone.InformacaoDoAparelho();