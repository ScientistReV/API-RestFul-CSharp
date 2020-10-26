using System.Collections.Generic;
using System;

namespace Loja.Models
{

  public class Bicicleta
  {

    public int Id{get; set;}

    public string Modelo{get; set;}

    public decimal Preco{get; set;}

    public int QtdEstoque{get; set;}

    public DateTime DataCriacao{get; set;}
  }
}