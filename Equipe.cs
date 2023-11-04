class Equipe
{
    //criando os atributos da classe equipe
    public string nomeEquipe;
    public Jogador primeiroJogador;
    public Jogador segundoJogador;
    public Jogador terceiroJogador;
    public Jogador quartoJogador;
    public Jogador quintoJogador;

    
    // criando o metodo para atribuir os pontos a equipe
    public int TotalPontos()
    {
        int totalPontos = 0;
        totalPontos += (primeiroJogador != null)? primeiroJogador.getPontos():0;
        totalPontos += (segundoJogador != null)? segundoJogador.getPontos():0;
        totalPontos += (terceiroJogador != null)? terceiroJogador.getPontos():0;
        totalPontos += (quartoJogador != null)? quartoJogador.getPontos():0;
        totalPontos += (quintoJogador != null)? quintoJogador.getPontos():0;
        return totalPontos;
    }

    // criando metodo para adicionar os jogadores na equipe e fazer a verificacao de quantidade.

    public void adicionarJogador(Jogador jogador)
    {
        if (primeiroJogador == null)
        {
            primeiroJogador = jogador;
        }
        else if(segundoJogador == null)
        {
            segundoJogador = jogador;
        }
        else if(terceiroJogador == null)
        {
            terceiroJogador = jogador;
        }
        else if(quartoJogador == null)
        {
            quartoJogador = jogador;
        }
        else if(quintoJogador == null)
        {
            quintoJogador = jogador;
        }
        else 
        {
            Console.WriteLine("Os 5 espacos da equipe ja foram preenchidos!");

        }

    }

}