using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejemplo.Model;
using System.Collections.Generic;
using System.Linq;

namespace Ejemplo.Tests
{
    [TestClass]
    public class Employee

    {
        /* Metodos de consultas de la logica de negocio */

        //buenooooo
        //[TestMethod]
        //public void ConsultarEmpleadosxTelefono()
        //{
        //    definir el escenario de la prueba
        //    string phone = "697-555-0142";
        //    int valorEsperado = 1;
        //    repositorio
        //   var repositorio = new Ejemplo.BL.Repositorios.Consultas();

        //    invocar al método correspondiente
        //    var listado = repositorio.ConsultaEmpleadosPorTelefono(phone).ToList();
        //    var cantidad = listado.Count();

        //    compare
        //    Assert.AreEqual(valorEsperado, cantidad);
        //}

        //buenooo
        //[TestMethod]
        //public void ConsultarEmpleadoxCodigoDepartamento()
        //{
        //    // definir el escenario de la prueba
        //    int cod = 1; int años = 5;

        //    int valorEsperado = 6;
        //    // repositorio
        //    var repositorio = new Ejemplo.BL.Repositorios.Consultas();

        //    // invocar al método correspondiente
        //    var listado = repositorio.ConsultaPorCodigoDepartamento(cod, años).ToList();
        //    int cantidad = listado.Count();

        //    // compare
        //    Assert.AreEqual(valorEsperado, cantidad);
        //}

        // buenoo
        //[TestMethod]
        //public void ConsultarEmpleadoxGrupo()
        //{
        //    // definir el escenario de la prueba
        //    string grupo = "Manufacturing";

        //    int valorEsperado = 185;
        //    // repositorio
        //    var repositorio = new Ejemplo.BL.Repositorios.Consultas();

        //    // invocar al método correspondiente
        //    var listado = repositorio.ConsultaPorNombreGrupo(grupo).ToList();
        //    int cantidad = listado.Count();

        //    // compare
        //    Assert.AreEqual(valorEsperado, cantidad);
        //}

        // buenoooo
        //[TestMethod]
        //public void ConsultarEmpleadosxAntiguedad()
        //{
        //    // definir el escenario de la prueba
        //    int numero1 = 7;
        //    int numero2 = 9;
        //    int valorEsperado = 228;
        //    // repositorio
        //    var repositorio = new Ejemplo.BL.Repositorios.Consultas();

        //    // invocar al método correspondiente
        //    var listado = repositorio.ConsultaEmpleadosPorAntiguedad(numero1, numero2).ToList();
        //    var cantidad = listado.Count();

        //    // compare
        //    Assert.AreEqual(valorEsperado, cantidad);
        //}

        // buenooo
        //[TestMethod]
        //public void ConsultarEmpleadosxEdad()
        //{
        //    // definir el escenario de la prueba
        //    int edad1 = 40;
        //    int edad2 = 50;
        //    int valorEsperado = 86;
        //    // repositorio
        //    var repositorio = new Ejemplo.BL.Repositorios.Consultas();

        //    // invocar al método correspondiente
        //    var listado = repositorio.ConsultaEmpleadosPorEdad(edad1, edad2).ToList();
        //    var cantidad = listado.Count();

        //    // compare
        //    Assert.AreEqual(valorEsperado, cantidad);
        //}

        /* Metodos de conusltas de las columnas calculadas */

        // buenooo
        //[TestMethod]
        //public void ConsultarAgeInYears()
        //{
        //    // definir el escenario de la prueba
        //    var employee = new Ejemplo.Model.Employee();
        //    employee.BirthDate = Convert.ToDateTime("1976-8-9");

        //    int valorEsperado = 40;

        //    // invocar al método correspondiente
        //    int listado = employee.AgeInYears;
        //    //var cantidad = listado.Count();

        //    // compare
        //    Assert.AreEqual(valorEsperado, listado);
        //}

        ////buenooo
        //[TestMethod]
        //public void ConsultarAdditionalMonths()
        //{
        //    // definir el escenario de la prueba
        //    var employee = new Ejemplo.Model.Employee();
        //    employee.BirthDate = Convert.ToDateTime("1976-11-9");

        //    int valorEsperado = 3;

        //    // invocar al método correspondiente
        //    int listado = employee.AgeInMonths;
        //    //var cantidad = listado.Count();

        //    // compare
        //    Assert.AreEqual(valorEsperado, listado);
        //}

        // buenooo
        //[TestMethod]
        //public void ConsultarMartialStatusName()
        //{
        //    // definir el escenario de la prueba
        //    var employee = new Ejemplo.Model.Employee();
        //    employee.MaritalStatus = "S";

        //    string valorEsperado = "Single";

        //    // invocar al método correspondiente
        //    string listado = employee.MaritalStatusName;
        //    //var cantidad = listado.Count();

        //    // compare
        //    Assert.AreEqual(valorEsperado, listado);
        //}

        // buenooo
        //[TestMethod]
        //public void ConsultarGenderName()
        //{
        //    // definir el escenario de la prueba
        //    var employee = new Ejemplo.Model.Employee();
        //    employee.Gender = "M";

        //    string valorEsperado = "Male";

        //    // invocar al método correspondiente
        //    string listado = employee.GenderName;
        //    //var cantidad = listado.Count();

        //    // compare
        //    Assert.AreEqual(valorEsperado, listado);
        //}

        // //buenooo
        //[TestMethod]
        //public void ConsultarAntiquity()
        //{
        //    // definir el escenario de la prueba
        //    var employee = new Ejemplo.Model.Employee();
        //    employee.HireDate = Convert.ToDateTime("2009-7-9");

        //    int valorEsperado = 7;

        //    // invocar al método correspondiente
        //    int listado = employee.Antiquity;
        //    //var cantidad = listado.Count();

        //    // compare
        //    Assert.AreEqual(valorEsperado, listado);
        //}

        // buenooo
        //[TestMethod]
        //public void ConsultarAdditionalAntiquityInMonths()
        //{
        //    // definir el escenario de la prueba
        //    var employee = new Ejemplo.Model.Employee();
        //    employee.HireDate = Convert.ToDateTime("2009-12-9");

        //    int valorEsperado = 8;

        //    // invocar al método correspondiente
        //    int listado = employee.AdditionalAntitiquityMonths;
        //    //var cantidad = listado.Count();

        //    // compare
        //    Assert.AreEqual(valorEsperado, listado);
        //}

        //FALTA
        //[TestMethod]
        //public void ConsultarActualDepartmentName()
        //{
        //    // definir el escenario de la prueba
        //    var employee = new Ejemplo.Model.Employee();
        //    var consulta = new Ejemplo.BL.Repositorios.Consultas();

        //    string valorEsperado = "Executive";

        //    // invocar al método correspondiente
        //    //var empleado = consulta.ConsultaTraerEmpleado(1);
        //    //employee = empleado.First();
        //    string listado = employee.ActualDepartmentName;

        //    //employee.BusinessEntityID = 1;

        //    // compare
        //    Assert.AreEqual(valorEsperado, employee);
        //}

        //// FALTA
        //[TestMethod]
        //public void ConsultarActualGroupName()
        //{
        //    // definir el escenario de la prueba
        //    var employee = new Ejemplo.Model.Employee();
        //    employee.BirthDate = Convert.ToDateTime("1976-8-9");

        //    int valorEsperado = 40;

        //    // invocar al método correspondiente
        //    int listado = employee.AgeInYears;
        //    //var cantidad = listado.Count();

        //    // compare
        //    Assert.AreEqual(valorEsperado, listado);
        //}

    }
}