using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class Aluno2Controller : Controller
    {
        // GET: Aluno2
        public ActionResult Index()
        {
            return View(AlunoModel2.CriarLista());
        }

        // GET: Aluno2/Details/5
        public ActionResult Details(int id)
        {
            var aluno = AlunoModel2.CriarLista()[id];
            return View(aluno);


        }

        // GET: Aluno2/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Aluno2/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AlunoModel2 collection)
        {
            try
            {
                // TODO: Add insert logic here


                return RedirectToAction(nameof(Index));
                //return RedirectToAction(nameof(Details)); ***caso queira mandar o formulario pra pagina details depois***
            }
            catch
            {
                return View();
            }
        }

        // GET: Aluno2/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Aluno2/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Aluno2/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Aluno2/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}