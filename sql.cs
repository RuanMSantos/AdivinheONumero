using AdivinheONumero.db;

namespace AdivinheONumero.cs{
    public class SQL{
        public void Logar(string nome, string senha, bool verificador){

            using (var _db = new DbAdivinheONumeroContext()){
                
                var jogo = _db.Jogo.ToList()
                        .Where(j => j.NmJogador == nome && j.NmSenha == senha);

                if (){
                    
                    Console.WriteLine("Jogador não encontrado.");

                    verificador = false;
                }
            }
        }

        public void NovoUsuario(string nome, string email, string telefone, string senha){



        }

        
    }
}