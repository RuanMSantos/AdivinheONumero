using AdivinheONumero.db;

namespace AdivinheONumero.cs{
    public class SQL{
        public void Logar(string nome, string senha, bool verificador){

            using (var _db = new DbAdivinheONumeroContext()){
                
                var jogo = _db.Jogo.ToList<Jogo>()
                        .Where(j => j.NmJogador == nome && j.NmSenha == senha);

                if (jogo.Count() <= 0){
                    
                    Console.WriteLine("Jogador não encontrado.");

                    verificador = false;
                }
        
            }
        }

        public void NovoUsuario(string nome, string email, string telefone, string senha){

                using (var _db = new DbAdivinheONumeroContext()){
                    
                    var jogo = new Jogo {
                        NmJogador = nome,
                        NmEmail = email,
                        NrTelefone = telefone,
                        NmSenha = senha,
                    };

                    _db.Add(jogo);
                    _db.SaveChanges();

                }

        }

        
    }
}