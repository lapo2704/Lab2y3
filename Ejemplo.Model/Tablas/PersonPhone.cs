using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericRepository;
using Ejemplo.Model.Enumerados;

namespace Ejemplo.Model
{
    [MetadataType(typeof(PersonPhoneMetadata))]
    public partial class PersonPhone : IEntity
    {
        int prueba = 1;
        [NotMapped]
        public int Id { get; set; }

        [NotMapped]
       public string PhoneNumberType {
            
            get {
                string resultado = "";
                prueba = this.PhoneNumberTypeID;
                resultado = EnumHelper.GetEnumPhoneNumberType((prueba));
                return (resultado);
            }
        }
    }

    public class PersonPhoneMetadata
    {

    }
}
