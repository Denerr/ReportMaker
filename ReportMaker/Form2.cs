using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportMaker
{
    public partial class frmCriar : Form
    {
        public frmCriar()
        {
            InitializeComponent();
        }


        private void btnCriar_Click(object sender, EventArgs e)
        {
            string mensagem = "Deseja salvar as informações inseridas?";
            string titulo = "Salvar dados?";

            DialogResult resultado = MessageBox.Show(mensagem, titulo, MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show("Informações Salvas");
                this.Close();
            }
            else
            {
                //Faz algo
            }
        }
    }
}
