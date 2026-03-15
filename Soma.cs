using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TargetSistemas.Util;

namespace TargetSistemas
{
    public class Soma
    {
        // O compilador do c# acusaria a falta de parametros no método Somar
        // A validação de dados foi adicionada de forma simples pois sistemas 
        // reais precisam de validação na entrada de dados.

        public static int Somar(int indice, int k)
        {
            int soma = 0;

            if (string.IsNullOrEmpty(indice.ToString())) // Convertida para string pois o 0 existe como indice e é um valor inteiro
                throw new ArgumentException(Constantes.INDICE_NAO_INFORMADO);

            if (string.IsNullOrEmpty(k.ToString())) // Convertida para string pois 0 é um valor inteiro
                throw new ArgumentException(Constantes.VALOR_NAO_INFORMADO);

            while (k < indice)
            {
                k += 1;
                soma += k;
            }

            return soma;
        }
    }
}