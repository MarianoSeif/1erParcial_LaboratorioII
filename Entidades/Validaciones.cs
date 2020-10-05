using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Entidades
{
    public static class Validaciones
    {
        public static bool CompararStrings(string str1, string str2)
        {
            if (str1.Trim().ToLower() == str2.Trim().ToLower())
            {
                return true;
            }
            return false;
        }

        public static bool StringNoVacio(string str)
        {
            if (str == String.Empty || str.Length < 3)
                return false;
            return true;
        }

        public static int StringDni(string strDni)
        {
            if( (strDni.Length >= 7) && (strDni.Length <= 9) && int.TryParse(strDni, out int dni)){
                return dni;
            }
            return -1;
        }
    }
}
