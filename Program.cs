using desafioSistemHospedagem.Models;

List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa("yorran", "hopede1");
Pessoa p2 = new Pessoa("giovanna", "hopede2");
Pessoa p3 = new Pessoa("bruno", "");

hospedes.Add(p1);
hospedes.Add(p2);
hospedes.Add(p3);

Suites suites= new Suites(tipoSuite: "Premium", capacidade: 3, valorDiaria: 30);

Reserva reserva= new Reserva(diasReservados: 10);
reserva.CadastrarSuite(suites);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria().ToString("c2")}");



