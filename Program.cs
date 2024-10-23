using AdivinheONumero.cs;
using AdivinheONumero.db;

UI ui = new UI();

Console.Clear();
Console.Write("Olá, seja bem vindo ao ==> ");
ui.ExibirBoasVindas("Adivinhe o número");

ui.ExibirOpcoesDeLogin();
string opcoesLogin = Console.ReadLine()!.Trim().ToLower();

ui.CaminhosLogin(opcoesLogin);