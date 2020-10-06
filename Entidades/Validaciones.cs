using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Entidades
{
    public static class Validaciones
    {
        /// <summary>
        /// Compara dos strings pasados por parámetros
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <returns></returns>
        public static bool CompararStrings(string str1, string str2)
        {
            if (str1.Trim().ToLower() == str2.Trim().ToLower())
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Verifica que el string pasado por parámetro no esté vacio o sea menor a 3 caracteres
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool StringNoVacio(string str)
        {
            if (str == String.Empty || str.Length < 3)
                return false;
            return true;
        }

        /// <summary>
        /// Recibe una cadena, la valida y devuelve un numero de dni
        /// </summary>
        /// <param name="strDni"></param>
        /// <returns></returns>
        public static int StringDni(string strDni)
        {
            if( (strDni.Length >= 7) && (strDni.Length <= 9) && int.TryParse(strDni, out int dni)){
                return dni;
            }
            return -1;
        }
    }
}
