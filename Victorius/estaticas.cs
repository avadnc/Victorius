using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Victorius
{
    class estaticas
    {
        public static String usr;
        public static String pss;
        public static String cadena;
        public static String ip_servidor;
        public static String cmd; //variable usada para los comandos en mysql;
        public static String consulta_territorial; //variable para consultas territoriales
        //variables estaticas disponibles para todo el programa
        public void inicializar() {

            usr = "";
            pss = "";
            cadena = "";
            ip_servidor = "localhost";
            consulta_territorial = "";
        }
    }
}
