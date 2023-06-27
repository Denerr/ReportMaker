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
    public partial class frmSugestoes : Form
    {
        public frmSugestoes()
        {
            InitializeComponent();
        }

        string prioridade = "";
        private void getPrioridade()
        {

            if (rdbPrioridadeA.Checked)
            {
                prioridade= rdbPrioridadeA.Text;
            }
            else if (rdbPrioridadeM.Checked)
            {
                prioridade= rdbPrioridadeM.Text;
            }
            else if (rdbPrioridadeB.Checked)
            {
                prioridade= rdbPrioridadeB.Text;
            }
            else
            {
                MessageBox.Show("Defina a Prioridade!!", "Prioridade Não Informada");
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            String imageLocator = "";

            try
            {
                OpenFileDialog dialog= new OpenFileDialog();
                dialog.Filter = "jpeg files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocator = dialog.FileName;

                    ptbImagem.ImageLocation = imageLocator;
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Ocorreu um Erro!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            getPrioridade();
            if(prioridade != "")
            {
                MessageBox.Show("Prioridade: "+ prioridade, "Nivel de Prioridade");
            }
            else
            {
                //Faz Nada!
            }
            
          

            
            

        }
    }
}
