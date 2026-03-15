using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;

namespace TargetSistemas;

public class FaturamentoDiario
{
    //public static double[] faturamento = { 1220, 0, 1550, 1440.5, 0, 4700, 1200.8, 0 }; //...


    /// <summary>
    /// Calcula o dia com maior faturamento
    /// </summary>
    /// <param name="faturamento"></param>
    /// <returns></returns>
    public static double MaiorValorFaturamentoAno(double[] faturamento)
    {
        double valorComparacao = 0;
        double apoio = 0;

        foreach (var item in faturamento)
        {
            if (item > valorComparacao)
            {
                if (item < apoio)
                {
                    valorComparacao = apoio;
                    continue;
                }

                apoio = valorComparacao;
                valorComparacao = item;

                //    double valor = faturamento.Max(); // Algortimo manual acima
            }
        }

        //double valor = faturamento.Min();
        return valorComparacao;
    }

    /// <summary>
    /// Calcula do dia com menor faturamento
    /// </summary>
    /// <param name="faturamento"></param>
    /// <returns></returns>
    public static double MenorValorFaturamentoAno(double[] faturamento)
    {
        double valorComparacao = faturamento[0];
        double apoio = 0;

        foreach (var item in faturamento)
        {


            if (item > 0 && item < valorComparacao)
            {
                apoio = valorComparacao;

                valorComparacao = item;


                if (apoio < valorComparacao)
                    valorComparacao = apoio;
            }
        }

        //double valor = faturamento.Min(); // Algoritmo manual acima
        return valorComparacao;
    }

    /// <summary>
    /// Calcula o valor medio anual
    /// </summary>
    /// <param name="faturamento"></param>
    /// <returns></returns>
    public static double MediaAno(double[] faturamento)
    {
        double media = 0;
        double valor = 0;
        int contador = 0;

        foreach(var item in faturamento)
        {
            // Captura a quantidade de dias e executa a soma
            if (item > 0)
            {
                contador++;
                valor+= item;
            }
                


        }

        media = valor / contador;

        return valor;
    }

    /// <summary>
    /// Numero de dias que o faturamento diario é maior que a media
    /// </summary>
    /// <param name="faturamento"></param>
    /// <returns></returns>
    public static double FaturamentoAcimaMedia(double[] faturamento)
    {
        double valor = 0;
        double contador = 0;

        double media = MediaAno(faturamento);

        foreach(double item in faturamento)
        {
            if (item > media && item > 0)
                contador++;
        }

        return contador;
    }
}
