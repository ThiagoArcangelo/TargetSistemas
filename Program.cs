

using System.Globalization;
using TargetSistemas;

Console.WriteLine(@"
#################################################
##########  DESAFIO TARGET SISTEMAS #############
#################################################");
Console.WriteLine("\n\n");


//=============================
// DESAFIO RESULTADO DA SOMA
//=============================

int resultadoSoma = Soma.Somar(12, 1); // Setado com os números do desafio

// Resultado da soma com os valores do desafio = 78

Console.WriteLine("DESAFIO - RESULTADO SOMA \n");
Console.WriteLine(resultadoSoma);
Console.WriteLine("-------------------------\n\n");


//============================
// DESAFIO - PROXIMO ELEMENTO
//============================

Console.WriteLine("DESAFIO - PROXIMO ELEMENTO");
Console.WriteLine("Somando + 2 a cada número !");
Console.WriteLine("1,3,5,7, ---- 9  \n");

Console.WriteLine("Dobrando os valores !");
Console.WriteLine("2,4,8,16,32,64, ---- 128 \n");

Console.WriteLine("Elevado ao quadrado!");
Console.WriteLine("0,1,4,9,16,25,36, ---- 49 \n");

Console.WriteLine("Também é elevado ao quadrado!");
Console.WriteLine("4,16,36,64, ----  100 \n");

Console.WriteLine("Soma dos dois números anteriores !");
Console.WriteLine("1,1,2,3,5,8, ----  13");

Console.WriteLine("Aparentemente todos os números começam com D!");
Console.WriteLine("2,10,12,16,17,18,19, ---- 200  \n");
Console.WriteLine("--------------------------\n\n");


//=============================================
// DESAFIO CALCULO DE FATURAMENTO
//=============================================


// Mock dos dias com e sem faturamento
double[] faturamento = { 1220, 0, 1550, 1440.5, 0, 4700, 1200.8, 0 }; //...

Console.WriteLine("DESAFIO - CALCULO DE FATURAMENTO \n");

Console.WriteLine("Mock do vetor para referência:  1220| 0 | 1550 | 1440.5 | 0 | 4700 | 1200.8 | 0 \n");
Console.WriteLine("-------------------------------------------------------------------------------");

Console.WriteLine("Cálculo do valor máximo de faturamento em um dia do ano!");
double valorMaximo = FaturamentoDiario.MaiorValorFaturamentoAno(faturamento);
Console.WriteLine(valorMaximo.ToString("C", new CultureInfo("pt-BR")));
Console.WriteLine("\n");

Console.WriteLine("Cálculo do valor minimo de faturamento em um dia do ano!");
double menorValor = FaturamentoDiario.MenorValorFaturamentoAno(faturamento);
Console.WriteLine(menorValor.ToString("C", new CultureInfo("pt-BR")));
Console.WriteLine("\n");

Console.WriteLine("Cálculo do valor medio anual para referência retirando dias sem faturamento!");
double valorMedio = FaturamentoDiario.MediaAno(faturamento);
Console.WriteLine(valorMedio.ToString("C", new CultureInfo("pt-BR")));
Console.WriteLine("\n");

Console.WriteLine("Dias que o faturamento diário superou a média de faturamento!");
double media = FaturamentoDiario.FaturamentoAcimaMedia(faturamento);
Console.WriteLine(media);
Console.WriteLine("-----------------------------------------------------------------\n\n");

// DESAFIO - PERCURSO DE VEICULOS
Console.WriteLine("DESAFIO PERCURSO DE VEICULOS EM SENTIDOS OPOSTOS\n");
double distanciaCarro = PercursoVeiculo.CalculoPercurso(90, 80, 125, "CARRO");
double distanciaCaminhao = PercursoVeiculo.CalculoPercurso(90, 80, 125, "CAMINHAO");

int distancia = 125;
double pontoDeEncontroCarro = Math.Round(0 + distanciaCarro);
double pontoDeEncontroCaminhao = Math.Round(distancia - distanciaCaminhao);


if (pontoDeEncontroCarro == pontoDeEncontroCaminhao)
    Console.WriteLine("Ambos estão na mesma distancia em relação a Ribeirão Preto \n");

if (pontoDeEncontroCarro < (pontoDeEncontroCaminhao))
    Console.WriteLine("O carro está mais próximo de Ribeirão Preto do que o caminhão!\n");

if (pontoDeEncontroCarro > (pontoDeEncontroCaminhao))
    Console.WriteLine("O Caminhão está mais próximo de Ribeirão Preto do que o carro!\n");


Console.WriteLine($"Carro: {pontoDeEncontroCarro}, Caminhão: {pontoDeEncontroCaminhao}");
Console.WriteLine("------------------------------------------------------\n\n");


Console.WriteLine("EXPLICAÇÃO DO PROBLEMA DE ENCONTRO DE VEICULOS NO PERCURSO ACIMA: \n");

Console.WriteLine(@"
    EXPLICAÇÃO DA RESOLUÇÃO 

    PF - POSIÇÃO FINAL
    P0 - POSIÇAO INICIAL
    V  - VELOCIDADE
    T1  - TEMPO CARRO
    T2 - TEMPO CAMINHAO

    CALCULO DO CARRO
    POSICAO CARRO: SA = 0 + (90*T)
    POSICAO CAMINHAO SB = 125 - (80*T)
    
    IGUALAR AS FUNÇÕES E ENCONTRAR O TEMPO  
    SB = SA => T = DISTANCIA/VELOCIDADE

    T = 0,735

    SUBTRAINDO O TEMPO DO PEDAGIO NO TRECHO PERCORRIDO CONSIDERANDO A INEXISTÊNCIA DO PEDÁGIO:
    TEMPO CARRO ADICIONANDO O TEMPO DE PEDÁGIO = 0,735 - 0,083 = 0,652

    SUBSTITUIR O TEMPO NAS EQUAÇÕES E IGUALANDO OS VALORES DOS DOIS LADOS
    
    SA = 90 * 0,652
    SB = 125 - 80 * 0, 735 

    RESULTADO DE AMBAS OPERAÇÕES PARA SIMPLICAÇÃO - APROXIMADAMENTE 59

    AMBOS SE ENCONTRAM NA ESTRADA NO MESMO PONTO EM RELAÇÃO A RIBEIRÃO PRETO    
");