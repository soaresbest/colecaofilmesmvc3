﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ColecaoFilmes.Dominio.Entidades;
using ColecaoFilmes.Dominio.Servicos;

namespace ColecaoFilmesMVC3.Controllers
{
    public class FilmesController : Controller
    {
        private IServicoFilme _servico;
        //
        // GET: /Filmes/

        public FilmesController(IServicoFilme servicoFilme)
        {
            _servico = servicoFilme;
        }

        public ActionResult Index()
        {
            var filmes = _servico.RecuperarTodosFilmes();
            return View(filmes);
        }

        //
        // GET: /Filmes/Details/5

        public ActionResult Details(int id)
        {
            var filme = _servico.RecuperarFilme(id);
            return View(filme);
        }

        //
        // GET: /Filmes/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Filmes/Create

        [HttpPost]
        public ActionResult Create(Filme filme )
        {
            try
            {
                _servico.IncluirFilme(filme);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Filmes/Edit/5
 
        public ActionResult Edit(int id)
        {
            var filme = _servico.RecuperarFilme(id);
            return View(filme);
        }

        //
        // POST: /Filmes/Edit/5

        [HttpPost]
        public ActionResult Edit(Filme filme)
        {
            try
            {
                _servico.AlterarFilme(filme);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Filmes/Delete/5
 
        public ActionResult Delete(int id)
        {
            var filme = _servico.RecuperarFilme(id);
            return View(filme);
        }

        //
        // POST: /Filmes/Delete/5

        [HttpPost]
        public ActionResult Delete(Filme filme)
        {
            try
            {
                _servico.ExcluirFilme(filme);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
