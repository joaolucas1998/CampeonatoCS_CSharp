class Jogador 
{
    //atributos da classe
    public string nome;
    public string nickname;
    public int pontos;

    // get no pontos
    public int getPontos()
    {
        return pontos;
    }

    //construtor
    public Jogador(string nome , string nickname)
    {
        this.nome = nome;
        this.nickname = nickname;
    }

    //metodo para gerar pontos
    public void Jogar()
    {
        Random random = new Random();
        int score = random.Next(1,101);
        pontos += score;
    }
}