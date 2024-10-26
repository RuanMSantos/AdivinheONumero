using AdivinheONumero.cs;

UI ui = new UI();
SQL sql = new SQL();
Game game = new Game();
string nomeUsuario = "", senhaUsuario = "", emailUsuario = "", numeroUsuario = "";
string funcao = "", jogarNovamente = "";
bool jogadorEncontrado = true, guest = false;
int partida = 0;
int vitoriasJogador = 0, derrotasJogador = 0, vitoriaTotal = 0, derrotaTotal = 0;
int identificador = 0, numeroAleatorio = 0, numeroDigitado = 0, id = 0, maquina = 0, jogada = 0;

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

            id = comandosSQL.Logar(nomeUsuario, senhaUsuario, jogadorEncontrado, identificador);
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

            id = comandosSQL.NovoUsuario(nomeUsuario, emailUsuario, numeroUsuario, senhaUsuario, identificador);
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
    Console.Clear();
    partida++;
    maquina = game.GerarNumeroAleatorio(numeroAleatorio);
    jogada = game.Jogar(numeroDigitado);
    vitoriaTotal += game.AnalisarVitoria(jogada, maquina, vitoriasJogador);
    derrotaTotal += game.AnalisarDerrota(jogada, maquina, derrotasJogador);
    
    Console.Write("\nJogar novamente? ");
    jogarNovamente = Console.ReadLine()!.Trim().ToLower().Substring(0, 1);
    
    if (jogarNovamente == "s"){
        Loop();
        return;
    } 

    if (guest == false){
        sql.ModificarPlacarJogador(partida, vitoriaTotal, derrotaTotal, id);
    }

    ui.ExibirFinal(partida, vitoriaTotal, derrotaTotal, nomeUsuario);
}