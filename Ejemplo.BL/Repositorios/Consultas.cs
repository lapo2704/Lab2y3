using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejemplo.Model;
using GenericRepository.EntityFramework;
using System.Data;

namespace Ejemplo.BL.Repositorios
{
    public class Consultas
    {
        // contexto estático
        private static AdventureWorks2014Entities _myContext = new AdventureWorks2014Entities();
        // repositorio privado
        private IEntityRepository<Person> _myPersonRepository = new EntityRepository<Person>(_myContext);
        private IEntityRepository<PersonPhone> _myPersonPhoneRepository = new EntityRepository<PersonPhone>(_myContext);
        private IEntityRepository<Employee> _myEmployeeRepository = new EntityRepository<Employee>(_myContext);
        private IEntityRepository<EmployeeDepartmentHistory> _myEmployeeDepartmentHistoryRepository = new EntityRepository<EmployeeDepartmentHistory>(_myContext);
        private IEntityRepository<Department> _myDepartmentRepository = new EntityRepository<Department>(_myContext);
        
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

        public List<IQueryable<Employee>> ConsultaPorNombreGrupo(string grupo)
        {
            var query =
                        from depart in _myDepartmentRepository.GetAll().AsEnumerable()
                        join edh in _myEmployeeDepartmentHistoryRepository.GetAll().AsEnumerable() on depart.DepartmentID equals edh.DepartmentID
                        join employee in _myEmployeeRepository.GetAll().AsEnumerable() on edh.BusinessEntityID equals employee.BusinessEntityID
                        where edh.EndDate == null && grupo == depart.GroupName
                        select GetAllEmployee();

            return query.ToList();
        }

        public List<IQueryable<Employee>> ConsultaPorCodigoDepartamento(int id, int años)
          {
              int year = (DateTime.Today.Year - años);
              int years = DateTime.Today.Year;
              DateTime date = new DateTime(year, DateTime.Today.Month, DateTime.Today.Day);

              var query =
                          from depart in _myDepartmentRepository.GetAll().AsEnumerable()
                          join edh in _myEmployeeDepartmentHistoryRepository.GetAll().AsEnumerable() on depart.DepartmentID equals edh.DepartmentID
                          join employee in _myEmployeeRepository.GetAll().AsEnumerable() on edh.BusinessEntityID equals employee.BusinessEntityID
                          where (depart.DepartmentID == id) && ((edh.StartDate >= date) || (edh.EndDate == null) || (edh.EndDate >= date))
                          select GetAllEmployee();

              return query.ToList();
          }
     
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
