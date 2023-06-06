# **TheReckoning - Linguagens de Programação 1**

#### Trabalho desenvolvido por:

- Henrique Monteiro - a22202855
- Margarida Teles - a22204247

### Partes do Trabalho desenvolvido por cada elemento:

**Margarida**:

- Desenvolveu o loop do jogo
- Desenvolveu Fase de Feitiços
- Desenvolveu Fase de Ataque
- Desenvolveu Fase de Comprar Cartas

**Henrique**:

- Desenvolveu o tutorial
- Auxilio no desenvolvimento das diferentes Fases
- Gestão do Repositório
- Desenvolveu a UI
- Desenvolveu o UML
- Desenvolveu o Markdown

## Descrição do Trabalho:

A solução do nosso jogo está dividida em duas fases especificas. O menu de opções e o da gameplay.

![image](https://github.com/MargaridaTeles/TheReckoning/assets/115217452/89bb3160-ec28-4fe5-85a7-e5b8e85b7eb8)

### Como jogar:

O jogador pode escolher se quer uma pequena introdução á jogabilidade do jogo, como regras bases e como as cartas ou monstros funcionam, ou então pode escolher informação quanto a como ganhar o jogo. Após concluir a leitura de um dos escolhidos tutoriais poderá ler o próximo se assim desejar ou voltar ao menu de opções.

### Jogar

Neste jogo dois jogadores lutam entre si com um deck de vinte cartas. Cada carda tem três parâmetros específicos. MP ou Mana points, DP ou defense points e AP ou attack points. Os mana points são o que cada carta custa para puder ser jogada, logo se um jogador não tiver mana suficiente, não pode jogar a carta. Cada jogador inicia a primeira ronda com 1 MP e continuar a ganhar mais 1 MP até á quinta ronda onde para de receber MP e a partir daí tem sempre 5MP no começo de cada Ronda de feitiços.

### Fase de Feitiços

A primeira fase de feitiços começa com o jogador já com 1 de MP, a partir dai pode escolher qual das 6 cartas iniciais pode jogar, se tiver MP suficientes. Depois de escolher é a vez do segundo jogador fazer o mesmo. A partir da primeira fase combate, todos os jogadores vao receber mais 1 de MP até á quinta ronda.

### Fase de combate

Na fase de combate os jogadores combatem com as cartas que escolheram anteriormente na fase de feitiços. Se uma carta atacar diretamente um jogador que não tenha cartas, o AP da carta atacante é subtraído á vida total do jogador (ambos os jogadores têm dez pontos de vida total). Se ambos os jogadores escolheram uma carta então o AP do das cartas é subtraído aos seus defense points (DP). Se o DP de uma carta chegar a zero então essa carda é destruída e retirada de jogo. Se uma carta tem 4 de AP e a carta que defende tem 2 de DP, a carta que defende morre e os restantes 2 de AP são subtraídos ao HP do jogador.
Após a batalha os jogadores podem escolher se querem desistir da partida.

### Sair

O jogador pode sair do programa.


### Referencias:
https://stackoverflow.com/questions/273313/randomize-a-listt - Random List

https://github.com/MargaridaTeles/TheReckoning - Link do Repositório


### UML

![LP1_PROJETO](https://github.com/MargaridaTeles/TheReckoning/assets/115217452/407fdeb7-0740-4a3f-8ca6-fdaf2352d901)

