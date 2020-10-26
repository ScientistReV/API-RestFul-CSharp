using System;
using Flunt.Validations;
using Flunt.Notifications;

namespace Loja.ViewModels.BicicletaViewModels
{
  public class EditorBicicletaViewModel:Notifiable, IValidatable
  {
   public int Id{get; set;}

    public string Modelo{get; set;}

    public decimal Preco{get; set;}

    public int QtdEstoque{get; set;}

    public DateTime DataCriacao{get; set;}

    public void Validate()
    { 
      AddNotifications( 
        new Contract()
              .HasMaxLen(Modelo, 100, "Modelo", "O modelo pode conter até 100 digitos")
              .HasMinLen(Modelo, 3, "Modelo", "O modelo pode ter no minimo 3 digitos")
              .IsGreaterThan(Preco, 0, "Preco", "O preco tem que ser maior que zero")
              .IsGreaterThan(QtdEstoque, 0, "QtdEstoque", "O estoque tem que ser maior que zero")
      );
    }
    
  }
}
