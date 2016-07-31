using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo.Model.Enumerados
{
   public static class EnumHelper
    {
        /*public static string PhoneNumberType(Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());
            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);
            if (attributes.Length > 0)
            {
                return attributes[0].Description;
            }
            else
            {
                return value.ToString();
            }
        }*/

        /* public static string GetEnumDescription<EnumPhoneNumberType>(int value)
         {
             return GetEnumDescription((Enum)(object)((EnumPhoneNumberType)(object)value));  // ugly, but works
         }*/

        public static string GetEnumPhoneNumberType(int value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes =
                (DescriptionAttribute[])fi.GetCustomAttributes(
                typeof(EnumPhoneNumberType),
                false);

            if (attributes != null &&
                attributes.Length > 0)
                return attributes[0].Description;
            else
                return value.ToString();
        }
    }

}
