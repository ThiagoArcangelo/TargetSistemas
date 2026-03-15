using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using TargetSistemas.Dto;

namespace TargetSistemas;

/*
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

    
*/



public class PercursoVeiculo
{
    /// <summary>
    /// Acrescenta o tempo de pedagio caso for necessario
    /// </summary>
    /// <param name="velocidade"></param>
    /// <param name="distancia"></param>
    /// <param name="tempo"></param>
    /// <returns></returns>
    private static double CalculoTempoComPedagio(PercursoDto dto)
    {
        double pedagio = dto.DistanciaFinal / 3;
        double minutos = 5;
        double hora = 60;

        double tempoPedagio = Math.Round((minutos / hora), 3);

        double retorno = 0;

        // Calcula a distancia percorrida do carro sem considerar pedagios
        retorno = Math.Round((dto.Distancia + (dto.Velocidade * dto.Tempo)), 3);


        // Subtraindo o tempo de pedagio
        if (retorno > pedagio && retorno < (pedagio * 2))
            dto.Tempo -= tempoPedagio;

        if (retorno > (pedagio * 2) && retorno < (pedagio * 3))
            dto.Tempo -= (tempoPedagio * 2);

        if (retorno > (pedagio * 3))
            dto.Tempo -= (tempoPedagio * 3);



        return dto.Tempo;
    }


    /// <summary>
    /// Calculo de percurso do carro
    /// </summary>
    /// <returns></returns>
    public static double CalculoPercurso(double velocidadeCarro, double velocidadeCaminhao, int distancia, string tipoVeiculo)
    {

        double tempo = 0;
        double percurso = 0;

        // CALCULO DO TEMPO 
        tempo = Math.Round((distancia / (velocidadeCarro + velocidadeCaminhao)), 3);

        if (tipoVeiculo == "CARRO")
        {
            PercursoDto CarroDto = new()
            {
                Velocidade = velocidadeCarro,
                Distancia = 0,
                Tempo = tempo,
                DistanciaFinal = distancia,
                TipoVeiculo = "CARRO"
            };

            double tempoCarro = CalculoTempoComPedagio(CarroDto);


            // EQUAÇÃO VEICULO 1
            percurso = 0 + (velocidadeCarro * tempoCarro);

        }
        else
        {
            // CALCULO DO TEMPO 
            tempo = Math.Round((distancia / (velocidadeCarro + velocidadeCaminhao)), 3);

            PercursoDto CaminhaoDto = new()
            {
                Velocidade = velocidadeCaminhao,
                Distancia = distancia,
                Tempo = tempo,
                DistanciaFinal = distancia,
                TipoVeiculo = "CAMINHAO"
            };


            // EQUAÇÃO VEICULO 2
            percurso = distancia - (velocidadeCaminhao * tempo);
        }



        double retorno = percurso;

        return retorno;
    }


}
