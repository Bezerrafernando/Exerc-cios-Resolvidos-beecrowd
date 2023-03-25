# Exercícios Resolvidos beecrowd / Lógica de Programação

Exercícios resolvidos do site beecrowd (antigo URI)

https://www.beecrowd.com.br/judge/pt/categories


# Algoritmos e Lógica de programação: O que são e qual a importância?

# Introdução
Sempre que decidimos fazer qualquer atividade em nosso dia a dia, acabamos seguindo uma sequência lógica. Na maior parte do tempo, fazemos isso de maneira tão natural que nem nos damos conta, mas, quando percebemos, conseguimos enxergar passos que levaram ao resultado final.

Visualize a seguinte situação, você precisa fazer um bolo:

1.. Selecionar os ingredientes da receita;
2. Selecionar tigela;
3. Colocar farinha, de acordo com a medida;
4. Selecionar ovos;
5. Colocar manteiga e açúcar a gosto;
6. Colocar leite;
7. Misturar todos os ingredientes na tigela;
8. Despejar a massa na forma;
9. Levar ao forno;
10. Aguardar 40 minutos;
11. Retirar do forno;
12. Servir o bolo.

Cada pessoa define uma sequência de passos para fazer um bolo, podendo incluir ou remover alguns já definidos. Essa lógica é aplicada a qualquer coisa que fazemos diariamente e muitas das vezes não nos damos conta.

Em atividades rotineiras, não costumamos prestar atenção quando seguimos uma mesma ordem para executar tarefas. Porém, quando o assunto é programar, definir as etapas do que deve ser feito assume uma grande importância, uma vez que instruir um computador ainda é bem diferente do que instruir uma pessoa.

Quando a necessidade é desenvolver um programa ou rotina a ser executada pelo computador, precisamos deixar bem claro a sequência que deve ser seguida para atingir o resultado esperado. A esse encadeamento lógico na programação, chamamos de Lógica de Programação, e a descrição de como fazer, definimos como Algoritmos.

# Algoritmos
O que é algoritmo?
Algoritmos são sequências de passos que seguimos com a intenção de atingir um objetivo, pode ser desde atravessar uma rua, fazer um bolo ou definir qual critério usar para aprovar ou reprovar um aluno, por exemplo.

Como se faz um algoritmo e o que é preciso para desenvolver um?
No desenvolvimento de um algoritmo, devemos definir com clareza e forma precisa o conjunto de regras ou instruções que serão utilizadas para resolver aquele problema em específico.

Portanto, antes de programar, precisamos saber o que deve ser feito e planejar o passo a passo, ou seja, criar o algoritmo e avaliar se o resultado obtido é a solução esperada. Entendido isso, então definimos uma linguagem de programação para implementar nossos algoritmos.

# Como representar um algoritmo?
Existem algumas maneiras de representar algoritmos, que entram como um passo de preparação antes da programação. Podemos criar, por exemplo, uma narrativa semelhante ao exemplo do bolo, em que se descreve a sequência de execução até a obtenção do resultado desejado ou esperado.

Para mostrar as formas de representar um algoritmo, vamos usar como exemplo um algoritmo de cálculo da média:

No nosso caso é preciso analisar as notas de 3 bimestres para a disciplina de matemática e verificar se o aluno foi aprovado ou reprovado para uma média maior ou igual a 7:

1. Obter a nota do 1º bimestre;
2. Obter a nota do 2º bimestre;
3. Obter a nota do 3º bimestre;
4. Realizar o cálculo da média para cada aluno (maior ou igual a 7 para aprovação);
5. Informar se o aluno foi “aprovado ou reprovado”;
6. Informar a média obtida pelo aluno.

# Fluxograma
Note que, na forma de um texto narrativo, ou mesmo nas outras formas de representação, é desejado que o algoritmo seja objetivo e preciso na descrição de cada passo. Existe também a opção de usar um modelo visual, como um fluxograma.

# Pseudo-linguagem
Outra forma bem interessante de representar algoritmos é utilizando uma pseudo-linguagem, que escrevemos em português (também chamado de português estruturado) sem ambiguidades e sem toda a rigidez de uma linguagem de programação.


# Lógica de Programação

# O que é lógica de programação?
Na lógica de programação é onde aplicamos todos os conceitos de algoritmos, a definição do passo a passo e transferimos toda a lógica do algoritmo desenvolvido para uma linguagem de programação.

Em linhas gerais, lógica de programação é todo conjunto de regras e conceitos que precisamos aplicar para criar códigos que serão interpretados e executados por um computador.

# O que é preciso?
Para conseguirmos o objetivo de instruir o computador a fazer alguma coisa, precisamos de uma linguagem de programação, que é um meio estruturado para passar instruções para a máquina.

Para fazer isso, temos à disposição uma gama muito grande de linguagens como: C, Java, PHP, Python, JavaScript, entre outras. Cada uma delas tem suas características, particularidades e cenários de aplicação.

# Exemplo de código e algoritmos


É importante ressaltar que a linguagem de programação escolhida é somente mais uma ferramenta que você, enquanto pessoa desenvolvedora, precisará conhecer. A ideia do algoritmo não é ligada a nenhuma linguagem em específico, observe o mesmo algoritmo do cálculo da média usando a linguagem C#:

// Linguagem C#
static void Main(string[] args)
        {
            float nota1; float nota2; float nota3; float media;

            Console.WriteLine("Digite nota 1:");
            nota1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite nota 2:");
            nota2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite nota 3:");
            nota3 = float.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3) / 3;

            if(media>=6)
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
            }

            Console.WriteLine("A média do aluno é: " + media);
        }

Note que o algoritmo é o mesmo, o passo a passo está ali, contudo, escrito em uma linguagem diferente. Portanto, após definida a sequência de instruções, escolha a linguagem que você mais se identifica para implementar o algoritmo.

A lógica de programação utilizada para desenvolver uma solução, como um sistema web, desktop ou mobile, é toda estruturada a partir da definição dos algoritmos, por isso a importância e o relacionamento entre estes dois temas.



# Introdução e conceitos fundamentais da Linguagem C#

Programa - Algoritmo
Programas de computador são algoritmos executados pelo computador
(em linhas gerais).
Conclusão: o computador é uma máquina que automatiza a execução de
algoritmos.

Qualquer algoritmo? Não. Apenas algoritmos computacionais:
- Processamento de dados
- Cálculos

O que é preciso para se fazer um
programa de computador?
Vamos precisar de:
• Uma linguagem de programação: regras léxicas e sintáticas para se
escrever o programa
• Uma IDE: software para editar e testar o programa
• Um compilador: software para transformar o código fonte em código
objeto
• Um gerador de código ou máquina virtual: software que permite que o
programa seja executado

# Linguagem de programação, léxica, sintática

Vamos precisar de:
• Uma linguagem de programação: regras léxicas e sintáticas para se
escrever o programa
• Uma IDE: software para editar e testar o programa
• Um compilador: software para transformar o código fonte em código
objeto
• Um gerador de código ou máquina virtual: software que permite que
o programa seja executado

Vamos precisar de:
• Uma linguagem de programação: regras léxicas e sintáticas para se
escrever o programa
• Uma IDE: software para editar e testar o programa
• Um compilador: software para transformar o código fonte em código
objeto
• Um gerador de código ou máquina virtual: software que permite que
o programa seja executado


# Linguagem de programação
É um conjunto de regras léxicas (ortografia) e sintáticas (gramática)
para se escrever programas.

# Léxica
Diz respeito à correção das palavras "isoladas" (ortografia).

# Sintática
Diz respeito à correção das sentenças (gramática).

# Linguagem de programação
Exemplos de linguagens de programação:
C, Pascal, C++, Java, C#, Python, Ruby, PHP, JavaScript, etc.

# Funcionalidades de uma IDE
• Edição de código fonte (indentação, autocompletar, destaque de
palavras, etc.)
• Depuração e testes
• Construção do produto final (build)
• Sugestão de modelos (templates)
• Auxiliar em várias tarefas do seu projeto
• Etc.

Referências:

https://devsuperior.com.br
#Prof. Dr. Nelio Alves

#Alura
https://www.alura.com.br/artigos/algoritmos-e-logica-de-programacao
