using AdivinheONumero.cs;

UI ui = new UI();
SQL sql = new SQL();
Game game = new Game();
string nomeUsuario = "", senhaUsuario = "", emailUsuario = "", numeroUsuario = "";
string funcao = "", jogarNovamente = "";
bool jogadorEncontrado = true, guest = false;
int partidas = 0;
int vitoriasJogador = 0, derrotasJogador = 0;
int id = 0, numeroAleatorio = 0, numeroDigitado = 0;

Console.Clear();
Console.Write("Olá, seja bem vindo ao ==> ");
ui.ExibirBoasVindas("Adivinhe o número");

Console.WriteLine();
ui.ExibirTelaInicial();
Console.WriteLine();

funcao = Console.ReadLine()!.Trim().ToUpper().Substring(0, 1);

switch (funcao){
    case "J": ui.ExibirOpcoesDeLogin();
    break;
    case "P": sql.ExibirPlacar();
    break;
}
if (funcao == "P") return;

string opcoesLogin = Console.ReadLine()!.Trim().ToUpper().Substring(0, 1);

CaminhosLogin(opcoesLogin);
if (opcoesLogin != "L" && opcoesLogin != "N" && opcoesLogin != "P") return;
if (jogadorEncontrado == false) return;


Loop();


void CaminhosLogin(string opcoes){
    
    SQL comandosSQL = new SQL();
            
        switch (opcoes){
            case "L": 
            Console.Write("\nDigite seu usuário: ");
            nomeUsuario = Console.ReadLine()!;

            Console.Write("Digite sua senha: ");
            senhaUsuario = Console.ReadLine()!;

            comandosSQL.Logar(nomeUsuario, senhaUsuario, jogadorEncontrado, id);
            break;

            case "N": 
            Console.Write("\nDigite seu nome: ");
            nomeUsuario = Console.ReadLine()!;

            Console.Write("Digite seu email: ");
            emailUsuario = Console.ReadLine()!;
            
            Console.Write("Digite seu número de telefone: ");
            numeroUsuario = Console.ReadLine()!;

            Console.Write("Digite sua senha: ");
            senhaUsuario = Console.ReadLine()!;

            comandosSQL.NovoUsuario(nomeUsuario, emailUsuario, numeroUsuario, senhaUsuario, id);
            break;
           
            case "P":
            nomeUsuario = "Guest";
            guest = true;
            break;
            
            default: ui.ExibirErro("Erro! Algo está errado...");
            break;
        }
}

void Loop(){
    partidas++;
    game.GerarNumeroAleatorio(numeroAleatorio);
    game.Jogar(numeroDigitado);
    game.Analisar(numeroDigitado, numeroAleatorio, vitoriasJogador, derrotasJogador);
    
    Console.Write("Jogar novamente? ");
    jogarNovamente = Console.ReadLine()!.Trim().ToLower().Substring(0, 1);
    
    if (jogarNovamente == "s") Loop();

    sql.ModificarPlacarJogador(partidas, vitoriasJogador, derrotasJogador, guest, id);
}