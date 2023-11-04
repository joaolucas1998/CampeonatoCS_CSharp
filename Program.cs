Jogador jogador1 = new Jogador("Joao" , "PsychoLovers");
Jogador jogador2 = new Jogador("Pedro", "Pedrinho");
Jogador jogador3 = new Jogador("Carlos","Carlinhos");
Jogador jogador4 = new Jogador("Eduardo", "Duduzinho");
Jogador jogador5 = new Jogador("Vitor", "Vitinho");
Jogador jogador6 = new Jogador("Larie", "Lariezinha");
Jogador jogador7 = new Jogador("Rafael", "Faelzinho");
Jogador jogador8 = new Jogador("Gabriel", "Gabi");
Jogador jogador9 = new Jogador("Adriana", "Nana");
Jogador jogador10 = new Jogador("Alex", "Leco");

Equipe time1 = new Equipe();
time1.nomeEquipe = "Pain";
time1.adicionarJogador(jogador1);
time1.adicionarJogador(jogador2);
time1.adicionarJogador(jogador3);
time1.adicionarJogador(jogador4);
time1.adicionarJogador(jogador5);

Equipe time2 = new Equipe();
time2.nomeEquipe = "Furia";
time2.adicionarJogador(jogador6);
time2.adicionarJogador(jogador7);
time2.adicionarJogador(jogador8);
time2.adicionarJogador(jogador9);
time2.adicionarJogador(jogador10);

Campeonato campeonato = new Campeonato();
campeonato.nomeCampeonato = "CbLoL";
campeonato.timeParticipante1 = time1;
campeonato.timeParticipante2 = time2;

campeonato.iniciarPartida(time1 , time2);

campeonato.Classificacao();


