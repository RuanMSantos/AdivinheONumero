namespace AdivinheONumero.cs{
    class Maquina{
        public int GerarNumeroAleatorio(int numero){
            numero = new Random().Next(1, 4);
            return numero;
        }
    }
}