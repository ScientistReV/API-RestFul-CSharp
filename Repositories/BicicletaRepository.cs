using Loja.Data;
using Loja.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Loja.ViewModels.BicicletaViewModels;

namespace Loja.Repositories
{
  public class BicicletaRepository
  {
    private readonly StoreDataContext _context;

    public BicicletaRepository(StoreDataContext context)
    {
      _context = context;
    }

    public IEnumerable<ListBicicletaViewModel> Get()
    {
      
      return _context.Bicicletas
        .Select(x => new ListBicicletaViewModel
        {
          Id = x.Id,
          Modelo = x.Modelo,
          Preco = x.Preco,
          QtdEstoque = x.QtdEstoque,
          DataCriacao = x.DataCriacao
        })
        .AsNoTracking()
        .ToList();
    }

    public Bicicleta Get(int id)
    {
      return _context.Bicicletas.Find(id);
    }
    public void Save(Bicicleta bicicleta)
    {
        _context.Bicicletas.Add(bicicleta);
        _context.SaveChanges();
    }

    public void Update(Bicicleta bicicleta){
        _context.Entry<Bicicleta>(bicicleta).State = EntityState.Modified;
        _context.SaveChanges();
    }

    public void Delete(Bicicleta bicicleta){
        _context.Remove(bicicleta);
        _context.SaveChanges();
    }

  }
}