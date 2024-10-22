namespace AdivinheONumero.cs{
    public class UI{
        public void ExibirBoasVindas(string texto){
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"{texto}");
            Console.ResetColor();
        }

        public void ExibirOpcoesDeLogin(){
            Console.WriteLine();
            Console.WriteLine("1 => Login");
            Console.WriteLine("2 => Novo jogador");
            Console.WriteLine("3 => Pular");
            Console.WriteLine();
        }
    }
}