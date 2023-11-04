class Campeonato
{
    // atributos da classe
    public string nomeCampeonato;
    public  Equipe timeParticipante1;
    public Equipe timeParticipante2;

    // metodo para iniciar a partida entre os dois times
    public void iniciarPartida(Equipe timeParticipante1 , Equipe timeParticipante2)
    {
        timeParticipante1.primeiroJogador.Jogar();
        timeParticipante1.segundoJogador.Jogar();
        timeParticipante1.terceiroJogador.Jogar();
        timeParticipante1.quartoJogador.Jogar();
        timeParticipante1.quintoJogador.Jogar();

        timeParticipante2.primeiroJogador.Jogar();
        timeParticipante2.segundoJogador.Jogar();
        timeParticipante2.terceiroJogador.Jogar();
        timeParticipante2.quartoJogador.Jogar();
        timeParticipante2.quintoJogador.Jogar();       
    }

    // metodo para definir quais dos dois time e o vencedor
     public void Classificacao()
    {
        int pontuacaoEquipe1 = timeParticipante1.TotalPontos();
        int pontuacaoEquipe2 = timeParticipante2.TotalPontos();


        if (pontuacaoEquipe1 > pontuacaoEquipe2)
        {
            Console.WriteLine($"1º lugar: {timeParticipante1.nomeEquipe} - Pontuação: {pontuacaoEquipe1}");
            Console.WriteLine($"2º lugar: {timeParticipante2.nomeEquipe} - Pontuação: {pontuacaoEquipe2}");
        }
        else if (pontuacaoEquipe1 < pontuacaoEquipe2)
        {
            Console.WriteLine($"1º lugar: {timeParticipante2.nomeEquipe} - Pontuação: {pontuacaoEquipe2}");
            Console.WriteLine($"2º lugar: {timeParticipante1.nomeEquipe} - Pontuação: {pontuacaoEquipe1}");
        }
        else
        {
            Console.WriteLine($"Empate: {timeParticipante1.nomeEquipe} e {timeParticipante2.nomeEquipe} - Pontuação: {pontuacaoEquipe1}");
        }
    }
}
