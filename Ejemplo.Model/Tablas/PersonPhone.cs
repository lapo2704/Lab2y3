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
       /* public double SizeInInches {
            get {
                double resultado = 0;
                bool pudoSerConvertido;
                switch (this.SizeUnitMeasureCode)
                { 
                case "CM":
                    pudoSerConvertido = double.TryParse(this.Size, out resultado);
                    if (pudoSerConvertido)
                        resultado /= 2.2;
                    break;
                case "IN":
                    pudoSerConvertido = double.TryParse(this.Size, out resultado);
                    if (pudoSerConvertido)
                        resultado /= 1.0;
                    break;
                }
                return (resultado); } }*/
    }

    public class PersonPhoneMetadata
    {

    }
}
