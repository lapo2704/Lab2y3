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
    [MetadataType(typeof(EmployeeDepartmentHistoryMetadata))]
    public partial class EmployeeDepartmentHistory : IEntity
    {
        Department departamento = new Department();

        [NotMapped]
        public int Id { get; set; }

        public string ActualDepartmentName(int businessEntityID)
        {
            string result = "";
            if (businessEntityID == this.BusinessEntityID && this.EndDate != null)
            {
                result = departamento.searchDepartmentById(this.DepartmentID);
            }
            return result;
        }

        public string ActualGroupName(int businessEntityID)
        {
            string result = "";
            if (businessEntityID == this.BusinessEntityID && this.EndDate != null)
            {
                result = departamento.searchGroupNameById(this.DepartmentID);
            }
            return result;
        }
    }

    public class EmployeeDepartmentHistoryMetadata
    {
    }
}
