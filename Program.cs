using DesafioPOO.Models;
Console.WriteLine("Smartphone Nokia:");
Nokia c1 = new Nokia("01234-5678", "5630", "354523458798635", 128);
c1.Ligar();
c1.ReceberLigacao();
c1.InstalarAplicativo("WhatsApp");

Console.WriteLine("Smartphone Iphone:");
Iphone i1 = new Iphone("98584-2525", "16 Pro Max", "354523458798635", 512);
i1.Ligar();
i1.ReceberLigacao();
i1.InstalarAplicativo("Instagram");