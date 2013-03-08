using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Victorius
{
    public partial class frm_agentes : Form
    {
        public frm_agentes()
        {
            InitializeComponent();
        }

        private void frm_agentes_Load(object sender, EventArgs e)
        {
      
        
                conexion.Conectar();
                MessageBox.Show("Si se pudo");

            }
    }
}
