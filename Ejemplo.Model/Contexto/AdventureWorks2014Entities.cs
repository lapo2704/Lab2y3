using GenericRepository.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo.Model
{
    public partial class MyAdventureWorks2014Entities1 : EntitiesContext
    {
        public virtual IDbSet<Employee> Employee { get; set; }
    }
}
