using DesafioPOO.Models;


Console.WriteLine("Smartphone Iphone:");
Smartphone i1 = new Iphone(numero: "1", modelo: "modelo1", IMEI: "1", memoria: 0);
i1.Ligar();
i1.ReceberLigacao();
i1.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia:");
Smartphone n1 = new Nokia(numero: "1", modelo: "modelo1", IMEI: "1", memoria: 0);

n1.Ligar();
n1.ReceberLigacao();
n1.InstalarAplicativo("Instagram");
