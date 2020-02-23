using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Crud_Produto_Marca.Models;
using Crud_Produto_Marca.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Crud_Produto_Marca.Controllers {
    public class MarcasController : Controller {

        private readonly IMarcaRepository _marcaRepository;

        public MarcasController(IMarcaRepository marcaRepository) {
            _marcaRepository = marcaRepository;
        }

        public IActionResult Index() {
            //Listagem

            var marcas = _marcaRepository.Listar();

            return View(marcas);
        }

        public IActionResult Cadastrar() {
            //Formulário de cadastro
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar([FromForm] Marca marca) {
            //Recebe o formulário e manda salvar no banco
            if (ModelState.IsValid) {
                _marcaRepository.Criar(marca);
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        public IActionResult Editar(int id) {
            // Formulário de Edição
            var marca = _marcaRepository.Buscar(id);
            return View(marca);
        }

        [HttpPost]
        public IActionResult Editar([FromForm] Marca marca) {
            //Recebe o formulário e manda editar no banco de dados.
            if (ModelState.IsValid) {
                _marcaRepository.Editar(marca);
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        public IActionResult Detalhar(int id) {
            //Detalha uma marca
            var marca = _marcaRepository.Buscar(id);
            return View(marca);
        }

        [HttpPost]
        public IActionResult Excluir(int id) {
            //Manda o banco de dados excluir a marca

            var marca = _marcaRepository.Buscar(id);
            if (marca != null) {
                _marcaRepository.Excluir(marca);
            }

            return RedirectToAction(nameof(Index));
        }

    }
}