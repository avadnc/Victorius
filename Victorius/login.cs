using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;


namespace Victorius
{
    public partial class login : Form
    {
    
       //asignamos ip del servidor a traves de la textbox
       //posteriormente hay que crear algun tipo de archivo donde almacenar estas variables
        MySqlConnection conectate = new MySqlConnection();
        
        public login()
        {
            InitializeComponent();
            
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btn_con_Click(object sender, EventArgs e)
        {

                       
            //asignamos el valor de las txtbox a las variables estaticas
            estaticas.ip_servidor = Convert.ToString(txt_srv.Text);
            estaticas.usr = Convert.ToString(txt_login.Text);
            estaticas.pss = Convert.ToString(txt_password.Text);
            //asignamos el valor a la cadena
            estaticas.cadena = "Server=" + estaticas.ip_servidor +";database=gld_cop;uid=" + estaticas.usr +";pwd="+ estaticas.pss +";";
            //nos conectamos



            conectate.ConnectionString = estaticas.cadena;
            try
            {
                conectate.Open();

                Form1 main_window = new Form1();
                main_window.Show();
                conexion.Desconectar();
                this.Hide();
            }
            catch (MySqlException) {
                conectate.Close();
                MessageBox.Show("Nombre de usuario o contraseña mal escritos");
            
            }
            

        }

        private void login_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
        }

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13) {

                btn_con.PerformClick();
            
            }
        }
       
    }
}
