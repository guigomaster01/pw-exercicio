using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CarroController : Controller
    {

        private static List<CarroModel> carros;
        // GET: Carro
        public ActionResult Index()
        {
            return View(carros);
        }

        public CarroController()
        {
            carros = new List<CarroModel>()
            {
                new CarroModel()
                {
                   Marca = "VW",
                    Modelo = "Brasilia",
                    Ano = 1974,
                    Cor = "amarelo",
                    Id=1,
                },
                new CarroModel()
                {
                    Marca = "Toyota",
                    Modelo = "Yaris",
                    Ano = 2022,
                    Cor = "prata",
                    Id=2,
                }
            };
        }

        // GET: Carro/Details/5
        public ActionResult Details(int id)
        {
            //var carro = CarroModel.CriarLista()[id];
            //return View(carro);
            var carro = carros.Find(e => e.Id == id);
            return View(carro);
        }

        // GET: Carro/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Carro/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                var car = new CarroModel();
                car.Marca = collection["Marca"];
                car.Modelo = collection["Modelo"];
                car.Ano = int.Parse(collection["Ano"]);
                car.Cor = collection["Cor"];
                car.Id = carros.Count + 1;
                carros.Add(car);
                return View("Index", carros);
                // TODO: Add insert logic here
            }
            catch
            {
                return View();
            }
        }

        // GET: Carro/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Carro/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                var car = carros.Find(e => e.Id == id);
                car.Ano = int.Parse(collection["Ano"]);
                car.Cor = collection["Cor"];
                car.Marca = collection["Marca"];
                car.Modelo = collection["Modelo"];
                return View("Index", carros);
            }
            catch
            {
                return View();
            }
        }

        // GET: Carro/Delete/5
        public ActionResult Delete(int id)
        {
            var car = carros.Find(e => e.Id == id);
            return View(car);
        }

        // POST: Carro/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                var car = carros.Find(e => e.Id == id);
                carros.Remove(car);

                return View("Index", carros);
            }
            catch
            {
                return View();
            }
        }
    }
}