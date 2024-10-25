namespace AdivinheONumero.cs{
    class Game : Maquina{
        
        public void Jogar(int numero){
            numero = Convert.ToInt32(Console.ReadLine());
        }

        public void Analisar(int numero, int maquina, int pontoVitoria, int pontoDerrota){

            UI ui = new UI();

            if (numero == maquina){
                pontoVitoria++;
                ui.ExibirVitoria("\nVocê venceu!");
            }
        
            else {
                pontoDerrota++;
                ui.ExibirErro("\nVocê perdeu!");
            }
        }

    }
}