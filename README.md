# Salary-Calculation

Exercicios propostos na faculdade UCL para o curso de Algoritmos e Estrutura de Dados I. Abaixo deixei o enunciado do mesmo.
A UCL precisa de um programa novo de contabilidade e, por isso, decidiu contratar os alunos de Sistemas de Informação para desenvolver um programa em C# para calcular o salário líquido mensal dos professores da faculdade. 
Para cada professor, o número de matrícula, o número de horas semanais (HS) e a titulação devem ser lidos.

As seguintes Regras de Negócio devem ser consideradas:

O programa deve calcular o Salário Bruto a partir do cálculo abaixo:

Número de Horas semanais multiplicado pelo valor da hora multiplicado por 4 semanas do mês.
Sobre o valor obtido é ainda incluído 15% de planejamento
O salário líquido é o salário bruto menos os descontos; os descontos são: 

Contribuição para a previdência (INSS);
Imposto de renda retido na fonte (IR). 
O valor-hora pago a cada professor por titulação baseia-se na tabela a seguir: 

Titulação            Valor da Hora
Especialista (E)     R$ 15,00
Mestre (M)            R$ 20,00
Doutor (D)             R$ 30,00

O cálculo do recolhimento para o INSS baseia-se na tabela a seguir: 
Faixa Salarial Bruta              Taxa de Contribuição
R$151,00 a R$256,00                           8%
R$256,01 a R$510,00                           9%
R$510,01 a R$1200,00                        10%
Acima de 1200,00                                11%

Após o desconto do INSS, obtém-se o salário base para o cálculo do IR que é efetuado de acordo com a tabela a seguir:
Faixa Salarial Base                      Taxa do IR
Abaixo de R$800,00                     Isento
R$ 801,01 a R$1200,00                10%
R$ 1200,01 a R$2400,00              15%
R$ 2400,01 a R$3200,00              20%
R$ 3200,01 a R$5750,00              25%
Acima de 5750,00                       27,5%

O programa deve ser capaz de processar os dados de um professor de cada vez. 
Para cada professor, ele imprimirá os descontos discriminadamente e o salário líquido a receber. 
Teste o programa com diversos valores de entrada, de modo a verificar todas as faixas salariais. 
