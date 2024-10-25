using AdivinheONumero.cs;
using AdivinheONumero.db;

UI ui = new UI();
SQL sql = new SQL();
string nomeUsuario = "", senhaUsuario = "", emailUsuario = "", numeroUsuario = "";
string funcao = "";
bool jogadorEncontrado = true;
int pontuacaoJogador = 0;

Console.Clear();
Console.Write("Olá, seja bem vindo ao ==> ");
ui.ExibirBoasVindas("Adivinhe o número");

switch (funcao){
    case "J":
    ui.ExibirOpcoesDeLogin();
    break;
    case "P":
    break;
}

string opcoesLogin = Console.ReadLine()!.Trim().ToUpper().Substring(0, 1);

CaminhosLogin(opcoesLogin);
if (opcoesLogin != "L" && opcoesLogin != "N" && opcoesLogin != "P") return;
if (jogadorEncontrado == false) return;




void CaminhosLogin(string opcoes){
    
    SQL comandosSQL = new SQL();
            
        switch (opcoes){
            case "L": 
            Console.Write("Digite seu usuário: ");
            nomeUsuario = Console.ReadLine()!;

            Console.Write("Digite sua senha: ");
            senhaUsuario = Console.ReadLine()!;

            comandosSQL.Logar(nomeUsuario, senhaUsuario, jogadorEncontrado);
            break;

            case "N": 
            Console.Write("Digite seu nome: ");
            nomeUsuario = Console.ReadLine()!;

            Console.Write("Digite seu email: ");
            emailUsuario = Console.ReadLine()!;
            
            Console.Write("Digite seu número de telefone: ");
            numeroUsuario = Console.ReadLine()!;

            Console.Write("Digite sua senha: ");
            senhaUsuario = Console.ReadLine()!;

            comandosSQL.NovoUsuario(nomeUsuario, emailUsuario, numeroUsuario, senhaUsuario);
            break;
           
            case "P":
            nomeUsuario = "Guest";
            break;
            
            default: ui.ExibirErro("Erro! Algo está errado...");
            break;
        }
}