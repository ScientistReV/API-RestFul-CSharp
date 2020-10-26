using System;

namespace Loja.ViewModels.BicicletaViewModels
{
  public class ListBicicletaViewModel
  {
   public int Id{get; set;}

    public string Modelo{get; set;}

    public decimal Preco{get; set;}

    public int QtdEstoque{get; set;}

    public DateTime DataCriacao{get; set;}

  }
}
