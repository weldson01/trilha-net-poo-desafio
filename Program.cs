using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia nokia = new Nokia("3333333", "N1", "222322", 350000);
Iphone iphone = new Iphone("444444", "Generico 20", "9999999", 1111111);

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Atizapi");

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("uartizapi");

