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

    }

    public class EmployeeDepartmentHistoryMetadata
    {
    }
}