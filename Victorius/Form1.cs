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
    public partial class Form1 : Form
    {
        frm_agentes fagentes;
        frm_terr_pa fpaises;
        
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void agentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fagentes = new frm_agentes();
            fagentes.MdiParent = this;
            fagentes.Show();


        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fpaises = new frm_terr_pa();
            fpaises.MdiParent = this;
            fpaises.Show();


        }

        }

    }

