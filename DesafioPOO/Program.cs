using DesafioPOO.Models;

Console.WriteLine("Nokia:");
Nokia nokia = new Nokia("123", "M1", "1111", 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("");

Console.WriteLine("Iphone:");
Iphone iphone = new Iphone("1234", "M1", "2222", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");