using AdivinheONumero.db;

namespace AdivinheONumero.cs{
    public class SQL{
        public void Logar(string nome, string senha, bool verificador, int id){

            using (var _db = new DbAdivinheONumeroContext()){
                
                UI ui = new UI();
                
                var jogo = _db.Jogo.ToList<Jogo>()
                        .Where(j => j.NmJogador == nome && j.NmSenha == senha);

                if (jogo.Count() <= 0){
                    
                    ui.ExibirErro("\nErro! Jogador não encontrado...");

                    verificador = false;
                }

                var jogador = jogo.ElementAt(0);
                id = jogador.IdJogador;

                Console.WriteLine($"\nOlá {jogador.NmJogador}, seja bem vindo de volta!");
                Thread.Sleep(1000);
            }
        }

        public void NovoUsuario(string nome, string email, string telefone, string senha, int id){

                using (var _db = new DbAdivinheONumeroContext()){
                    
                    var jogo = new Jogo {
                        NmJogador = nome,
                        NmEmail = email,
                        NrTelefone = telefone,
                        NmSenha = senha,
                    };

                    _db.Add(jogo);
                    _db.SaveChanges();

                    id = jogo.IdJogador;
                }

        }

        public void ExibirPlacar(){
            
            int posicao = 1;
            
            Console.WriteLine("\nPlacar\n");
            
            using (var _db = new DbAdivinheONumeroContext()){

                UI ui = new UI();

                var jogo = _db.Jogo.ToList<Jogo>()
                        .OrderByDescending(j => j.NrVitoria);
            
                if (jogo.Count() <= 0){
                    
                    ui.ExibirErro("Erro! Ainda não existem jogadores para exibir o placar...");

                    return;
                }

                foreach (var j in jogo){
                    Console.WriteLine($"{posicao}° {j.NmJogador} {j.NrVitoria} vitória(s)");
                    posicao++;
                }
            }
        }        
    
        public void ModificarPlacarJogador(int partidasJogador, int vitoriasJogador, int derrotasJogador, int id){
 
            using (var _db = new DbAdivinheONumeroContext()){
                    
                UI ui = new UI();

                var jogo = _db.Jogo.Find(id);

                jogo.NrPartida += partidasJogador;
                jogo.NrVitoria += vitoriasJogador;
                jogo.NrDerrota += derrotasJogador;

                _db.SaveChanges();
            }
        }
    }
}