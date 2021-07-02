using cadastroViagens.Models;
using cadastroViagens.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cadastroViagens.Controllers
{
    public class MotoristaController : Controller
    {
        private IMotoristaRepository _repository { get; set; }

        public MotoristaController(IMotoristaRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public IActionResult Cadastrar(Motorista motorista)
        {
            _repository.Cadastrar(motorista);
            _repository.Salvar();
            TempData["msg"] = "Cadastrado com sucesso!!";
            return RedirectToAction("Cadastrar");
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return View(_repository.Listar());
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            var Motorista = _repository.BuscarPorCodigo(id);
            return View(Motorista);
        }

        [HttpPost]
        public IActionResult Editar(Motorista motorista)
        {
            _repository.Atualizar(motorista);
            _repository.Salvar();
            TempData["msg"] = "Editado com sucesso!!";
            return RedirectToAction("Listar");
        }

        [HttpPost]
        public IActionResult Remover(int codigo)
        {
            _repository.Remover(codigo);
            _repository.Salvar();
            TempData["msg"] = "Removido com sucesso!!";
            return RedirectToAction("Listar");
        }
    }
}
