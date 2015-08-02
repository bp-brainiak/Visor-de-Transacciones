using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Com.VisorTransacciones.Logic;

namespace Visor_de_Transacciones.Forms
{
    public partial class FrmConexionBaseDeDatos : Form
    {
        public FrmConexionBaseDeDatos()
        {
            InitializeComponent();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btConectar_Click(object sender, EventArgs e)
        {
            DatabaseConnectionHelper.Server = txtServidor.Text;
            DatabaseConnectionHelper.User = txtUsuario.Text;
            DatabaseConnectionHelper.Password = txtPassword.Text;
            DatabaseConnectionHelper.ConectarAlServidor(); 
            List<string> bases = DatabaseConnectionHelper.GetDataBases();
            var parent = this.MdiParent as FormParent;
            foreach (string b in bases)
            {
                parent.ToolStripComboBox1.Items.Add(b);
            }
        }
    }
}
