using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero:"987654321", modelo:"Nokia 3310", imei:"5566", memoria:64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Telegram");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero:"123456789", modelo:"Iphone 13", imei:"8596", memoria:128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");