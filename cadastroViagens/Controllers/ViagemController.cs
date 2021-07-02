using cadastroViagens.Models;
using cadastroViagens.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cadastroViagens.Controllers
{
    public class ViagemController : Controller
    {
        private IViagemRepository _repository { get; set; }

        private IMotoristaRepository _repositoryMotorista { get; set; }

        public ViagemController(IViagemRepository repository, IMotoristaRepository repositoryMotorista)
        {
            _repository = repository;
            _repositoryMotorista = repositoryMotorista;
        }

        private void PreencherComboMotorista()
        {
            var lista = _repositoryMotorista.Listar();
            ViewBag.combo = new SelectList(lista, "MotoristaId", "Nome");
        }

        [HttpPost]
        public IActionResult Cadastrar(Viagem viagem)
        {
            _repository.Cadastrar(viagem);
            _repository.Salvar();
            TempData["msg"] = "Cadastrado com sucesso!!";
            return RedirectToAction("Cadastrar");
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            PreencherComboMotorista();
            return View();
        }

        [HttpGet]
        public IActionResult Listar()
        {
            PreencherComboMotorista();
            return View(_repository.Listar());
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            PreencherComboMotorista();
            var Viagem = _repository.BuscarPorCodigo(id);
            return View(Viagem);
        }

        [HttpPost]
        public IActionResult Editar(Viagem viagem)
        {
            _repository.Atualizar(viagem);
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

