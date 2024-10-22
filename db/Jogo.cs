using System;
using System.Collections.Generic;

namespace AdivinheONumero.db;

public partial class Jogo
{
    public int IdJogador { get; set; }

    public string NmJogador { get; set; } = null!;

    public string? NmEmail { get; set; }

    public string? NrTelefone { get; set; }

    public string NmSenha { get; set; } = null!;

    public int? NrPartida { get; set; }

    public int? NrVitoria { get; set; }

    public int? NrDerrota { get; set; }
}
