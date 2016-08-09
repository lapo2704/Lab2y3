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
    [MetadataType(typeof(PersonMetadata))]
    public partial class Person : IEntity
    {
        [NotMapped]
        public int Id { get; set; }

       // [NotMapped]
       //public string FullName {
       //     get {
       //         string resultado = "";

       //         if (Title != null || Title != "" || Title != " ")
       //         {

       //             resultado += Title + " ";
       //         }

       //         if (FirstName != null || FirstName != "" || FirstName != " ")
       //         {
       //             resultado += FirstName + " ";
       //         }

       //         if (MiddleName != null || MiddleName != "" || MiddleName != " ")
       //         {
       //             resultado += MiddleName + " ";
       //         }

       //         if (LastName != null || LastName != "" || LastName != " ")
       //         {
       //             resultado += LastName + " ";
       //         }

       //         if (Suffix != null || Suffix != "" || Suffix != " ")
       //         {
       //             resultado += Suffix + " ";
       //         }
                
       //         return (resultado); }
        }// Cierra metodo FullName
    }

    public class PersonMetadata
    {

    }
}
