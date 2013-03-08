using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;


namespace Victorius
{
    class conexion
    {
        static MySqlConnection conn = new MySqlConnection();
        static String Cadena_Conexion =  estaticas.cadena;
        static MySqlCommand Comando = new MySqlCommand();
        static MySqlDataAdapter Adaptador = new MySqlDataAdapter();
        static BindingSource Bind = new BindingSource();
        public static bool abierto = false;


        public static void Conectar()
        {



            conn.ConnectionString = Cadena_Conexion;
          
            conn.Open();

           
        }

        public static void Desconectar() {

           
            conn.Close();

        }

        public static void Seleccionar(String sql)
        {
            string Comando = sql;           
            Adaptador = new MySqlDataAdapter(Comando, Cadena_Conexion);
            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(Adaptador);
            DataTable table = new DataTable();
            Adaptador.Fill(table);
            Bind.DataSource = table;
           
        }
        public static DataTable cargartabla() {
           
            DataTable dt = new DataTable();
            Adaptador.Fill(dt);
            return dt;
        }
        public static void LimpiarTabla() {

            DataTable dt = cargartabla();
            dt.Clear();
        
        }

        public static AutoCompleteStringCollection LoadAutoComplete()
        {
            DataTable dt = cargartabla();

            AutoCompleteStringCollection stringCol = new AutoCompleteStringCollection();

            foreach (DataRow row in dt.Rows)
            {
                stringCol.Add(Convert.ToString(row[estaticas.consulta_territorial]));
            }

            return stringCol;
        }


        public static BindingSource Bin
        {
            get
            {
                return Bind;
            }
        }
        
        }

    }

