using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejemplo.Model;
using System.Collections.Generic;
using System.Linq;
using GenericRepository.EntityFramework;

namespace Ejemplo.Tests
{
    [TestClass]
    public class Person
    {
        /* Metodos de consultas de la logica de negocio */

        // buenoooo
        //[TestMethod]
        //public void ConsultarPersonaCompleta()
        //{
        //    // definir el escenario de la prueba
        //    string name = "ken";
        //    int valorEsperado = 107;
        //    // repositorio
        //    var repositorio = new Ejemplo.BL.Repositorios.Consultas();

        //    // invocar al método correspondiente
        //    var listado = repositorio.ConsultaEmpleadosPorNombreCompleto(name).ToList();
        //    var cantidad = listado.Count();

        //    // compare
        //    Assert.AreEqual(valorEsperado, cantidad);
        //}

        /* Metodos de conusltas de las columnas calculadas */

        //buenoooo
        //[TestMethod]
        //public void ConsultarFullName()
        //{
        //    // definir el escenario de la prueba
        //    var person = new Ejemplo.Model.Person();
        //    person.Title = "Mr.";
        //    person.FirstName = "Jean";
        //    person.MiddleName = "Carlo";
        //    person.LastName = "Rojas";
        //    person.Suffix = " J";

        //    string valorEsperado = "Mr. Jean Carlo Rojas  J ";

        //    // invocar al método correspondiente
        //    string listado = person.FullName;
        //    //var cantidad = listado.Count();

        //    // compare
        //    Assert.AreEqual(valorEsperado, listado);
        //}

    }
}