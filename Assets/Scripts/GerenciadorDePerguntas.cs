1. Algoritmos de Grafos
O algoritmo de grafos é o coração da estrutura do jogo, sendo utilizado para modelar o tabuleiro de perguntas. Cada casa do tabuleiro é representada como um vértice, e as perguntas entre as casas são representadas pelas arestas.

Destaques do Algoritmo:

Vértices Temáticos: Os temas abrangem áreas como Esportes, História, Geografia, Cultura Pop, Ciência e Linguagens.
Dificuldade Variável: Cada pergunta tem um peso que varia de 1 a 5, representando a dificuldade.
Movimentação Estratégica:

Utilizamos o Algoritmo de Dijkstra para encontrar o caminho mais curto no tabuleiro.
O cálculo leva em consideração o peso das arestas, ou seja, a dificuldade das perguntas.
Isso incentiva os jogadores a adotar uma estratégia para minimizar a dificuldade do caminho escolhido, proporcionando uma experiência dinâmica.
2. Algoritmos de IA
A inteligência artificial garante que o nível de dificuldade se adapte dinamicamente ao desempenho do jogador, tornando o jogo mais inclusivo e desafiador.

Destaques do Algoritmo A*:

Ajuste de Dificuldade: O algoritmo inicialmente ajusta o jogo para o nível mais fácil, mas adapta-se para níveis mais desafiadores se o jogador tiver um desempenho superior.
Cálculo Heurístico: Baseia-se no número de perguntas respondidas corretamente e na taxa de acertos:
Taxa acima de 80%: Aumenta a dificuldade do tabuleiro.
Taxa abaixo de 50%: Reduz o nível de dificuldade para manter a experiência equilibrada.
Personalização da Experiência:

A função AStarProximoNivel() calcula a transição ideal entre níveis com base no progresso.
Garante que o jogo esteja sempre adaptado às habilidades do jogador, mantendo o engajamento e a diversão.
Resumo Final
Este slide apresenta a integração entre teoria dos grafos e inteligência artificial para criar um jogo que é ao mesmo tempo desafiador, dinâmico e educativo. O uso de algoritmos como Dijkstra e A* permite uma experiência personalizada, onde o jogador aprende e se diverte enquanto avança no tabuleiro temático.