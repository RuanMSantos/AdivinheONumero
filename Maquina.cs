namespace AdivinheONumero.cs{
    class Maquina{
        public void GerarNumeroAleatorio(int numero){
            numero = new Random().Next(1, 4);
        }
    }
}