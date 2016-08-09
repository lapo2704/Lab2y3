﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejemplo.Model;
using GenericRepository.EntityFramework;

namespace Ejemplo.BL.Repositorios
{
    public class Consultas
    {
        // contexto estático
        private static AdventureWorks2014Entities1 _myContext = new AdventureWorks2014Entities1();
        // repositorio privado
        private IEntityRepository<Person> _myPersonRepository = new EntityRepository<Person>(_myContext);
        private IEntityRepository<PersonPhone> _myPersonPhoneRepository = new EntityRepository<PersonPhone>(_myContext);
        private IEntityRepository<Employee> _myEmployeeRepository = new EntityRepository<Employee>(_myContext);
        private IEntityRepository<EmployeeDepartmentHistory> _myEmployeeDepartmentHistoryRepository = new EntityRepository<EmployeeDepartmentHistory>(_myContext);
        private IEntityRepository<Department> _myDepartmentRepository = new EntityRepository<Department>(_myContext);

        public IQueryable<Person> ConsultaEmpleadosPorNombreCompleto(string fullName)
        {
            return _myPersonRepository.FindBy(x => x.FirstName.Contains(fullName) || x.LastName.Contains(fullName));
        }

        public IQueryable<Person> GetAllPerson()
        {
            return _myPersonRepository.GetAll();
        }

        /*Conusltas de PersonePhone*/
        public IQueryable<PersonPhone> ConsultaEmpleadosPorTelefono(string number)
        {
            return _myPersonPhoneRepository.FindBy(x => x.PhoneNumber.Contains(number));
        }

        public IQueryable<PersonPhone> GetAllPersonPhone()
        {
            return _myPersonPhoneRepository.GetAll();
        }

        /*Consultas de Employee*/
        public IQueryable<Employee> ConsultaEmpleadosPorAntiguedad(int number1, int number2)
        {
            int numero = (DateTime.Today.Year - number2);
            int numero2 = (DateTime.Today.Year - number1);
            return _myEmployeeRepository.FindBy(x => x.HireDate.Year >= numero && x.HireDate.Year <= numero2);
        }

        public IQueryable<Employee> ConsultaEmpleadosPorEdad(int numero1, int numero2)
        {
            int year = (DateTime.Today.Year - numero2);
            int year2 = (DateTime.Today.Year - numero1);
            return _myEmployeeRepository.FindBy(x => x.BirthDate.Year >= year && x.BirthDate.Year <= year2);
        }

      /* public IQueryable<Employee> ConsultaPorNombreGrupo(string grupo)
        {
            // Join con un LinQ del elemento en la historia de departamentos de empleados de aquel registro que traer.

            //Obtiene id del departamento.
            IEnumerable<Department> getDep = _myDepartmentRepository.FindBy(x => x.GroupName.Contains(grupo));
            Department dep = getDep.First();

            // Obtiene los registros con los empleados del grupo
            IEnumerable<EmployeeDepartmentHistory> getEDH = dep.EmployeeDepartmentHistories.Where(x => x.DepartmentID == dep.DepartmentID);

            //-------FALTA-----------
            //Obtiene los datos de los empleados del grupo.
            IQueryable<Employee> Resultados = getEDH.GroupJoin(_myEmployeeRepository.GetAll);


            return _myEmployeeRepository.FindBy(x => x.ActualGroupName.Equals(grupo));
        }*/
        
        public IQueryable<Employee> GetAllEmployee()
        {
            return _myEmployeeRepository.GetAll();
        }

        public IQueryable<Employee> ConsultaTraerEmpleado(int ID)
        {
            return _myEmployeeRepository.FindBy(x => x.BusinessEntityID == ID);
        }

    }
}
