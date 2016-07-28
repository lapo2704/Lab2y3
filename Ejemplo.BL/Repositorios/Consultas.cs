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

        /* Consultas de Person*/
        public IQueryable <Person> ConsultaEmpleadosPorNombreCompleto (string fullName)
        {
            return _myPersonRepository.FindBy(x => x.FullName.Contains (fullName));           
        }

        public IQueryable<Person> GetAllPerson()
         {
             return _myPersonRepository.GetAll();
         }

        /*Conusltas de PersonePhone*/
        public IQueryable <PersonPhone> ConsultaEmpleadosPorTelefono (string number)
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
            return _myEmployeeRepository.FindBy(x => x.Antiquity >= number1 && x.Antiquity <= number2);
        }

        public IQueryable<Employee> ConsultaEmpleadosPorEdad(int number1, int number2)
        {
            return _myEmployeeRepository.FindBy(x => x.AgeInYears >= number1 && x.AgeInYears <= number2);
        }

        public IQueryable<Employee> GetAllEmployee()
        {
            return _myEmployeeRepository.GetAll();
        }
    }
}
