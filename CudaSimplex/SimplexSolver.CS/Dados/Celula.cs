﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace SimplexSolver.CS.Dados
{
  public class Celula
  {
    public double ValorSuperior { get; set; }
    public double ValorInferior { get; set; }

    public Celula()
    {
      //valor setado propositalmente para controle do algoritmo
      ValorInferior = Double.NaN;
    }
  }
}