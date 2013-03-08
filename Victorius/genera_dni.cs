using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Victorius
{
    class genera_dni
    {
        /// <summary> Tabla de asignación. </summary>
        public const string Correspondencia = "TRWAGMYFPDXBNJZSQVHLCKE";

        /// <summary> Genera la letra correspondiente a un DNI. </summary>
        /// <param name="dni"> DNI a procesar. </param>
        /// <returns> Letra correspondiente al DNI. </returns>
        public char LetraNIF(string dni)
        {
            int n;

            //if ((dni == null) || (dni.Length != 8) || (!int.TryParse(dni, out n)))
            if ((dni == null) || (dni.Length != 8) || (!int.TryParse(dni.Substring(0, 8), out n)))
            {
                throw new ArgumentException("El DNI debe contener 8 dígitos.");
            }

            return Correspondencia[n % 23];
        }

        /// <summary> Genera la letra correspondiente a un NIE. </summary>
        /// <param name="nie"> NIE a procesar. </param>
        /// <returns> Letra correspondiente al NIE. </returns>
        public char LetraNIE(string nie)
        {
            int n;
            //Linea original, editado en caso practico 
            //if ((nie == null) || (nie.Length != 8) || ((char.ToUpper(nie[0]) != 'X') && (char.ToUpper(nie[0]) != 'Y') && (char.ToUpper(nie[0]) != 'Z')) || (!int.TryParse(nie.Substring(1), out n)))
            if ((nie == null) || (nie.Length != 8) || ((char.ToUpper(nie[0]) != 'X') && (char.ToUpper(nie[0]) != 'Y') && (char.ToUpper(nie[0]) != 'Z')) || (!int.TryParse(nie.Substring(1, 7), out n)))
            {
                throw new ArgumentException("El NIE debe comenzar con la letra X, Y o Z seguida de 7 dígitos.");
            }

            switch (char.ToUpper(nie[0]))
            {
                case 'X':
                    return Correspondencia[n % 23];
                case 'Y':
                    return Correspondencia[(10000000 + n) % 23];
                case 'Z':
                    return Correspondencia[(20000000 + n) % 23];
                default:
                    return '\0';
            }
        }
    }
}
