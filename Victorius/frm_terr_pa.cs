using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Victorius
{
    public partial class frm_terr_pa : Form
    {
        
       // MySqlDataAdapter myda;
       // MySqlCommandBuilder comando;
        MySqlConnection conectate = new MySqlConnection();

        public frm_terr_pa()
        {
            InitializeComponent();
        }

        private void btn_cargar_Click(object sender, EventArgs e)
        {
            if (txtpais.Text == "") { MessageBox.Show("Introduce Pais"); }
            else { cargar_datagrid(); }
            if (txtccaa.Text == "") { MessageBox.Show("Introduce Estado y/o Comunidad Autónoma"); }
            else { cargar_datagrid(); }
            if (txtprovincia.Text == "") { MessageBox.Show("Introduce Provincia"); }
            else { cargar_datagrid(); }
            
        }

        private void frm_terr_pa_Load(object sender, EventArgs e)
        {
       
        }
       /* private void cargar_pais() {
            conexion.Conectar();
            estaticas.cmd = "select pais from pais;";
            myda = new MySqlDataAdapter(estaticas.cmd, estaticas.cadena);
            comando = new MySqlCommandBuilder(myda);
            DataTable dt = new DataTable();
            myda.Fill(dt);
            conexion.Desconectar();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "pais";
            comboBox1.ValueMember = "pais";
            if (comboBox1.Items.Count != 0)
            {

                int pais = Convert.ToInt32(comboBox1.SelectedIndex)+1;
                cargar_comunidad(pais);
            }
            else
            {
                comboBox2.DataSource = null;
                comboBox3.DataSource = null;
                comboBox4.DataSource = null;
            }
          
        }



         private void cargar_comunidad(int registro_pais) {

            conexion.Conectar();
            estaticas.cmd = "select comunidad_autonoma from ccaa where id_pais = "+ registro_pais +";";
            myda = new MySqlDataAdapter(estaticas.cmd, estaticas.cadena);
            comando = new MySqlCommandBuilder(myda);
            DataTable dt2 = new DataTable();
            myda.Fill(dt2);
            conexion.Desconectar();
            comboBox2.DataSource = dt2;
            comboBox2.DisplayMember = "comunidad_autonoma";
            comboBox2.ValueMember = "comunidad_autonoma";
            
        }

         private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
         {
             int registro_pais = Convert.ToInt32(comboBox1.SelectedValue);
             cargar_comunidad(registro_pais);
            
         }*/
         private void txtpais_TextChanged(object sender, EventArgs e)
         {
             estaticas.consulta_territorial = "pais";
             estaticas.cmd = "select pais from pais";

             //conexion.Conectar();
             conectate.ConnectionString = estaticas.cadena;
             conectate.Open();
             conexion.Seleccionar(estaticas.cmd);

             txtpais.AutoCompleteCustomSource = conexion.LoadAutoComplete();
             txtpais.AutoCompleteMode = AutoCompleteMode.Suggest;
             txtpais.AutoCompleteSource = AutoCompleteSource.CustomSource;
             //conexion.Desconectar();
             conectate.Close();
         }

         private void txtccaa_TextChanged(object sender, EventArgs e)
         {
             estaticas.consulta_territorial = "comunidad_autonoma";
             estaticas.cmd = "select comunidad_autonoma from ccaa inner join pais on ccaa.id_pais = pais.idpais where pais.pais = '"+txtpais.Text+"';";
           //  conexion.Conectar();       
             conectate.ConnectionString = estaticas.cadena;
             conectate.Open();
             conexion.Seleccionar(estaticas.cmd);
             txtccaa.AutoCompleteCustomSource = conexion.LoadAutoComplete();
             txtccaa.AutoCompleteMode = AutoCompleteMode.Suggest;
             txtccaa.AutoCompleteSource = AutoCompleteSource.CustomSource;
             //conexion.Desconectar();
             conectate.Close();
             
         }

         private void txtprovincia_TextChanged(object sender, EventArgs e)
         {
             estaticas.consulta_territorial = "provincia";
             estaticas.cmd = "select provincia from provincias inner join ccaa on provincias.id_ccaa = ccaa.idccaa where ccaa.comunidad_autonoma = '" + txtccaa.Text + "';";
             //conexion.Conectar();
             conectate.ConnectionString = estaticas.cadena;
             conectate.Open();
             conexion.Seleccionar(estaticas.cmd);
             txtprovincia.AutoCompleteCustomSource = conexion.LoadAutoComplete();
             txtprovincia.AutoCompleteMode = AutoCompleteMode.Suggest;
             txtprovincia.AutoCompleteSource = AutoCompleteSource.CustomSource;
             //conexion.Desconectar();
             conectate.Close();
         }
         private void cargar_datagrid() {
             
             estaticas.cmd = "select poblacion from poblaciones inner join provincias on poblaciones.id_provincia = provincias.idprovincias where provincias.provincia = '" + txtprovincia.Text + "';";
             //conexion.Conectar();
             conectate.ConnectionString = estaticas.cadena;
             conectate.Open();
             conexion.Seleccionar(estaticas.cmd);
            // dgvpoblacinoes.DataSource = conexion.Bin;
             //conexion.Desconectar();
             conectate.Close();
         }
       
    
    }
}
