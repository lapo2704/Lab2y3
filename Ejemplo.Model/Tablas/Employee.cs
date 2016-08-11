using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericRepository;


namespace Ejemplo.Model
{
    [MetadataType(typeof(EmployeeMetadata))]
    public partial class Employee : IEntity
    {
 
        [NotMapped]
        public int Id { get; set; }

        [NotMapped]
        public int AgeInYears
        {
            get
            {
                return GetDifferenceInYears(DateTime.Today, BirthDate);
            }
        } // Cierra metodo Age in years

        public int GetDifferenceInYears(DateTime startDate, DateTime endDate)
        {
            //Excel documentation says "COMPLETE calendar years in between dates"
            int years = startDate.Year - endDate.Year;

            if (startDate.Month == endDate.Month &&// if the start month and the end month are the same
                endDate.Day > startDate.Day)// BUT the end day is less than the start day
            {
                years--;
            }
            else if (endDate.Month < startDate.Month)// if the end month is less than the start month
            {
                years--;
            }
            return years;
        } // Cierra metodo Get Difference in years

        [NotMapped]
        public int AgeInMonths
        {
            get
            {
                return GetDifferenceInMonths(DateTime.Today, BirthDate);
            }
        } // Cierra metodo Age in Months

        public int GetDifferenceInMonths(DateTime startDate, DateTime endDate)
        {

            int month = endDate.Month - startDate.Month;

            if (month < 0)
            {
                month = month + 12;
            }
            return month;
        } // Cierra metodo get difference in months

        [NotMapped]
        public string MaritalStatusName
        {
            get
            {
                string resultado = "";

                switch (this.MaritalStatus)
                {
                    case "M":
                        resultado = "Married";
                        break;

                    case "S":
                        resultado = "Single";
                        break;
                }
                return (resultado);
            }
        } //  Cierra metodo Marital Status Name

        [NotMapped]
        public string GenderName
        {
            get
            {
                string resultado = "";

                switch (this.Gender)
                {
                    case "M":
                        resultado = "Male";
                        break;

                    case "F":
                        resultado = "Female";
                        break;
                }
                return (resultado);
            }
        } //  Cierra metodo Gender Name

        [NotMapped]
        public int Antiquity
        {
            get
            {
                return GetDifferenceAntiquityInYears(DateTime.Today, HireDate);
            }
        } // Cierra metodo Antiquity

        public int GetDifferenceAntiquityInYears(DateTime startDate, DateTime endDate)
        {
            //Excel documentation says "COMPLETE calendar years in between dates"
            int years = startDate.Year - endDate.Year;

            if (startDate.Month == endDate.Month &&// if the start month and the end month are the same
                endDate.Day > startDate.Day)// BUT the end day is less than the start day
            {
                years--;
            }
            else if (endDate.Month > startDate.Month)// if the end month is less than the start month
            {
                years--;
            }
            return years;
        } // Cierra metodo Get Difference in years

        [NotMapped]
        public int AdditionalAntitiquityMonths
        {
            get
            {
                return GetDifferenceInMonths(DateTime.Today, HireDate);
            }
        } // Cierra metodo Additional Antitiquity Months


        [NotMapped]
        public string ActualDepartmentName
        {
            get
            {
                //IEnumerable<EmployeeDepartmentHistory> EDH = this.EmployeeDepartmentHistories.Where(x => x.EndDate == null);
                //EmployeeDepartmentHistory dep = EDH.First();
                //Department miDep = dep.Department;
                //return miDep.Name;
                var query =
                        from edh in EmployeeDepartmentHistories
                        where edh.EndDate == null
                        select edh.Department.Name;

                return query.First();
            }
        }

        [NotMapped]
        public string ActualGroupName
        {
            get
            {
                //IEnumerable<EmployeeDepartmentHistory> EDH = this.EmployeeDepartmentHistories.Where(x => x.EndDate == null);
                //EmployeeDepartmentHistory dep = EDH.First();
                //Department miDep = dep.Department;
                //return miDep.GroupName;

                 var query =
                          from edh in EmployeeDepartmentHistories                          
                          where edh.EndDate == null
                          select edh.Department.Name ;

              return query.First();
            }
        }

    }// Cierra clase

    public class EmployeeMetadata
    {

    }
}
 
 