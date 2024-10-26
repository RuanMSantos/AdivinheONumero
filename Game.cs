namespace AdivinheONumero.cs{
    class Game : Maquina{
        
        public int Jogar(int numero){
            Console.Write("Adivinhe o número de 1 à 3.   ");
            numero = Convert.ToInt32(Console.ReadLine());
            return numero;
        }

        /*public void Analisar(int numero, int maquina, int pontoVitoria, int pontoDerrota){

            UI ui = new UI();

            if (numero == maquina){
                pontoVitoria++;
                ui.ExibirVitoria("\nVocê venceu!");
            }
        
            else {
                pontoDerrota++;
                ui.ExibirErro("\nVocê perdeu!");
            }
        }*/

        public int AnalisarVitoria(int numero, int maquina, int pontoVitoria){

            UI ui = new UI();

            if (numero == maquina){
                ui.ExibirVitoria("\nVocê venceu!");
                pontoVitoria++;
                return pontoVitoria;
            } 
            else
                return 0;
        }
        
        public int AnalisarDerrota(int numero, int maquina, int pontoDerrota){

            UI ui = new UI();

            if (numero != maquina){
                ui.ExibirErro("\nVocê perdeu!");
                pontoDerrota++;
                return pontoDerrota;
            } 
            else
                return 0;
        }
    }
}