using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
//Implementado
Smartphone nokia = new Nokia("99199-9699", "C20", "357894561231234", 32);
Smartphone iphone = new Iphone("98659-3366", "I13 Pro Max", "353216549879632", 64);

Console.WriteLine("Smartphone Nokia");
nokia.Informacoes();
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine();

Console.WriteLine("Smartphone IPhone");
iphone.Informacoes();
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");