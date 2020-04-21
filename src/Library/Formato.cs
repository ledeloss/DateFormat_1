//Esta Clase se crea para quitar la responsabilidad a Program de resolver el Formato del Resultado.
//Se utiliza en Patron Expert 

using System;

namespace Library
{
    public class Formato
    {
        
        public static String ChangeFormat(String year)
        {
            return year.Substring(6) + "-" + year.Substring(3, 2) + "-" + year.Substring(0, 2);
        }
    }
}

