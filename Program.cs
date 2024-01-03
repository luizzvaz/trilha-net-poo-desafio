// See https://aka.ms/new-console-template for more information
using DesafioPOO.Models;

Iphone ProMax = new Iphone(numero: "81987125516", modelo: "13ProMax", imei: "88445566", memoria: 256);

ProMax.InstalarAplicativo("itunes");
ProMax.Ligar();
ProMax.ReceberLigacao();
ProMax.InfoSmartphone();
Console.WriteLine("==========================================================");
Nokia i700 = new Nokia("81987125516", "I700", "388445566", 128);

i700.InstalarAplicativo("PlayStore");
i700.Ligar();
i700.ReceberLigacao();
i700.InfoSmartphone();