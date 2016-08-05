using System;
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

        public IQueryable<Employee> ConsultaPorNombreGrupo(string grupo)
        {
            return _myEmployeeRepository.FindBy(x => x.ActualGroupName.Equals(grupo));
        }

        //public IQueryable<Department> ConsultaPorNombreGrupo(string grupo)
        //{
        //    return _myDepartmentRepository.FindBy(x => x.GroupName.Equals(grupo));
        //}


        public IQueryable<Employee> GetAllEmployee()
        {
            return _myEmployeeRepository.GetAll();
        }

        /*Consulta de EmployeeDepartmentHistory*/
        public IQueryable<EmployeeDepartmentHistory> ConsultaDepartamentoPorID(int id, int years)
        {
            DateTime fecha = new DateTime(DateTime.Today.Year - years, DateTime.Today.Month, DateTime.Today.Day);
            return _myEmployeeDepartmentHistoryRepository.FindBy(x => x.DepartmentID == id && (x.StartDate >= fecha && (x.EndDate < fecha || x.EndDate == null)));
        }

        public IQueryable<EmployeeDepartmentHistory> GetAllEmployeeDepartmentHistory()
        {
            return _myEmployeeDepartmentHistoryRepository.GetAll();
        }
    }
}
