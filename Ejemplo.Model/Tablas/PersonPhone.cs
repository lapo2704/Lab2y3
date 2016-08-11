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
        public string PhoneNumberType
        {

            get
            {
                string resultado = "";
                resultado = PersonPhoneType(PhoneNumberTypeID);
                return (resultado);
            }
        }

        private string PersonPhoneType(int value)
        {
            string resultado = "";
            switch (value)
            {
                case 1:
                    resultado = "Cell";

                    break;
                case 2:
                    resultado = "Phone";
                    break;
                case 3:
                    resultado = "Work";
                    break;
            }
            return resultado;
        }
    }
    
    public class PersonPhoneMetadata : 
    {

    }
}
