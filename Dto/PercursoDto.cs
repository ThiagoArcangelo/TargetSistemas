using System;
using System.Collections.Generic;
using System.Text;

namespace TargetSistemas.Dto;

public class PercursoDto
{
    public double Velocidade { get; set; }
    public double Tempo { get; set; }
    public int Distancia { get; set; }
    public int DistanciaFinal { get; set; }
    public string TipoVeiculo { get; set; } = string.Empty;
}
