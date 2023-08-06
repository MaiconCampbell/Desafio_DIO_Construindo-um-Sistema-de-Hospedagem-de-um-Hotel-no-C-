using System.Text;
using _04___DESAFIO___RESERVA_DE_HOTEL.Models;

Console.OutputEncoding = Encoding.UTF8;

/* Criar os modelos de hóspedes:
  1 - Cadastrar pessoas que estaram utilizando a suite;
  2 - Inserir na lista de hóspedes
*/

// Instanciar a lista de hospedes
List<Pessoa> hospedes = new List<Pessoa>();

// 1
Pessoa pessoa1 = new Pessoa(nome: "João", sobreNome: "Da Silva");
Pessoa pessoa2 = new Pessoa(nome: "Maria", sobreNome: "Aparecida");

// 2
hospedes.Add(pessoa1);
hospedes.Add(pessoa2);

// Instanciar a suite
Suite suite = new Suite(tipoSuite: "basic+", capacidade: 2, valorDiaria: 80);

// Criar a reserva
Reserva reserva = new Reserva(diasReservados: 10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibir a quantidade de hóspedes e o valor da reserva
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
