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
    [MetadataType(typeof(PersonPhoneMetadata))]
    public partial class PersonPhone : IEntity
    {
        [NotMapped]
        public int Id { get; set; }

        [NotMapped]
       public string PhoneNumberType {
            
            get {
                string resultado = "";
                resultado = Enum.GetEnumDescription((this.PhoneNumberType)value);
                return (resultado);
            }
        }
    }

    public class PersonPhoneMetadata
    {

    }
}
