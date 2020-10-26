using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Loja.Models;
using Loja.ViewModels.BicicletaViewModels;
using Loja.Repositories;

namespace Loja.Controllers
{
  public class BicicletaController : Controller
  {
    private readonly BicicletaRepository _repository;

    public BicicletaController(BicicletaRepository repository)
    {
      _repository = repository;
    }

    [Route("v1/bicicletas")]
    [HttpGet]

    public IEnumerable<ListBicicletaViewModel> Get()
    {
        return _repository.Get();
    }

    [Route("v1/bicicletas/{id}")]
    [HttpGet]

    public Bicicleta Get(int id)
    {
        return _repository.Get(id);
    }

    [Route("v1/bicicletas")]
    [HttpPost]

    public ResultViewModel Post([FromBody]EditorBicicletaViewModel model)
    {
      model.Validate();
      if(model.Invalid)
        return new ResultViewModel
        {
          Sucess = false,
          Message = "Não foi possível cadastrar a bicicleta.",
          Data = model.Notifications
        };

        var bicicleta = new Bicicleta();
        bicicleta.Id = model.Id;
        bicicleta.Modelo = model.Modelo;
        bicicleta.Preco = model.Preco;
        bicicleta.QtdEstoque = model.QtdEstoque;
        bicicleta.DataCriacao = model.DataCriacao;

        _repository.Save(bicicleta);

        return new ResultViewModel
        {
          Sucess = true,
          Message = "Bicicleta cadastrada com sucesso!",
          Data = bicicleta
        };

    }

    [Route("v1/bicicletas")]
    [HttpPut]

    public ResultViewModel Put([FromBody]EditorBicicletaViewModel model)
    {
      model.Validate();
      if(model.Invalid)
        return new ResultViewModel
        {
          Sucess = false,
          Message = "Não foi possível alterar a bicicleta.",
          Data = model.Notifications
        };

        var bicicleta = _repository.Get(model.Id);
        bicicleta.Id = model.Id;
        bicicleta.Modelo = model.Modelo;
        bicicleta.Preco = model.Preco;
        bicicleta.QtdEstoque = model.QtdEstoque;
        bicicleta.DataCriacao = model.DataCriacao;

        _repository.Update(bicicleta);

        return new ResultViewModel
        {
          Sucess = true,
          Message = "Bicicleta cadastrada com sucesso!",
          Data = bicicleta
        };
    }

    [Route("v1/bicicletas")]
    [HttpDelete]

    public ResultViewModel Delete([FromBody] EditorBicicletaViewModel model)
    {
      model.Validate();
      if(model.Invalid)
        return new ResultViewModel
        {
          Sucess = false,
          Message = "Não foi possível deletar a bicicleta.",
          Data = model.Notifications
        };

        var bicicleta = _repository.Get(model.Id);
        bicicleta.Id = model.Id;
        bicicleta.Modelo = model.Modelo;
        bicicleta.Preco = model.Preco;
        bicicleta.QtdEstoque = model.QtdEstoque;
        bicicleta.DataCriacao = model.DataCriacao;

        _repository.Delete(bicicleta);


        return new ResultViewModel
        {
          Sucess = true,
          Message = "Bicicleta deletada com sucesso!",
          Data = bicicleta
        };
    }

  }
}