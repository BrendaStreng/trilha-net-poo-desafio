using System.Numerics;
using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Nokia celular = new Nokia(numero: "12345", modelo: "V3", imei: "ABC1", memoria: 128);
celular.Ligar();
celular.InstalarAplicativo("Roblox");

// Console.WriteLine($"Numero: {celular.Numero}");
// Console.WriteLine($"Modelo: {celular.GetModelo()}");
// Console.WriteLine($"IMEI: {celular.GetImei()}");
// Console.WriteLine($"Memoria: {celular.GetMemoria()}");

Console.WriteLine("---------------------------------");

Console.WriteLine("Smartphone iPhone");
Iphone celular2 = new Iphone(numero: "22211", modelo: "15pro", imei: "AAB2", memoria: 250);
celular2.ReceberLigacao();
celular2.InstalarAplicativo("Minecraft");

// Console.WriteLine($"Numero: {celular2.Numero}");
// Console.WriteLine($"Modelo: {celular2.GetModelo()}");
// Console.WriteLine($"IMEI: {celular2.GetImei()}");
// Console.WriteLine($"Memoria: {celular2.GetMemoria()}");

