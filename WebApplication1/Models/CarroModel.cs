using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class CarroModel
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public string Cor { get; set; }
        public int Id { get; set; }

        //public CarroModel()
        //{
        //    Marca = "Toyota";
        //    Modelo = "Corolla";
        //    Ano = 2017;
        //    Cor = "preto";
        //}

        //public static CarroModel CriarCarro()
        //{
        //    var carro = new CarroModel();
        //    carro.Modelo = "GM";
        //    return carro;
        //}

        //public static List<CarroModel> CriarLista()
        //{
        //    var lista = new List<CarroModel>();
        //    //lista.Add(new CarroModel());
        //    //lista.Add(CarroModel.CriarCarro());

        //    lista.Add(new CarroModel() { Marca = "VW", Modelo = "Brasilia", Ano = 1974, Cor = "amarelo" });
        //    lista.Add(new CarroModel() { Marca = "Toyota", Modelo = "Yaris", Ano = 2022, Cor = "prata" });
        //    lista.Add(new CarroModel() { Marca = "Ford", Modelo = "Escort", Ano = 1992, Cor = "azul" });
        //    lista.Add(new CarroModel() { Marca = "Peugeot", Modelo = "207", Ano = 2006, Cor = "preto" });
        //    lista.Add(new CarroModel() { Marca = "GM", Modelo = "Corsa", Ano = 2002, Cor = "cinza" });

        //    return lista;
        //}
    }
}
