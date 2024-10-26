using AdivinheONumero.cs;

namespace AdivinheONumero.cs{
    public class UI{
        public void ExibirBoasVindas(string texto){
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"{texto}");
            Console.ResetColor();
        }

        public void ExibirErro(string texto){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{texto}");
            Console.ResetColor();

        }
        public void ExibirOpcoesDeLogin(){
            ExibirComeco();
            Console.WriteLine();
            Console.WriteLine("[L]ogin..........");
            Console.WriteLine();
            Console.WriteLine("[N]ovo jogador...");
            Console.WriteLine();
            Console.WriteLine("[P]ular..........");
            Console.WriteLine();
        }

        public void ExibirTelaInicial(){
            Console.WriteLine("O que você que fazer?\n");
            Console.WriteLine("[J]ogar");
            Console.WriteLine("Ver [P]lacar");
        }

        public void ExibirVitoria(string texto){
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{texto}");
            Console.ResetColor();
        }
    
        public void ExibirFinal(int partidasJogador, int vitoriasJogador, int derrotasJogador, string nome){

            Console.WriteLine($"\n{nome}: {partidasJogador} partida(s), {vitoriasJogador} vitória(s), {derrotasJogador} derrota(s).");

            Thread.Sleep(200);
            Console.WriteLine("\nAté a próxima!\n");
        }

        public void ExibirComeco(bool verificador){
            Console.Clear();
            Console.Write("Olá, seja bem vindo ao ==> ");
            ExibirBoasVindas("ADIVINHE O NÚMERO");
        }
        public void ExibirComeco(){
            Console.Clear();
            ExibirBoasVindas("ADIVINHE O NÚMERO");
        }
    }
}
