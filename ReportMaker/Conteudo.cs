using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        string caminhoArquivo = "C://VS_ReportBuilder/Relatorio/";
        string nomeArquivo = "Relatorio-" + DateTime.Today.ToString("dd-MM-yyyy") + ".txt";
        string separador = " - ";
        string fimSessao = "------------------------------";


        private void limpaCampo()
        {
            txtCliente.Text = "";
            txtDescricao.Text = "";
            txtEmpresa.Text = "";
            cmbPeriodo.Text = "";
            cmbTipoServ.Text = "";
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            string mensagemDir = "Diretorio não encontrado. Deseja criar um?";
            string tituloDir = "Criar Diretorio?";
            string mensagemArq = "Aquivo não encontrado. Deseja criar um?";
            string tituloArq = "Criar Arquivo?";

            if (Directory.Exists(caminhoArquivo))
            {
                if (!File.Exists(nomeArquivo))
                {
                    DialogResult criarArquivo = MessageBox.Show(mensagemArq, tituloArq, MessageBoxButtons.YesNo);
                    if (criarArquivo == DialogResult.Yes)
                    {
                        File.Create(nomeArquivo).Close();
                        using (StreamWriter escreveArq = new StreamWriter(caminhoArquivo + nomeArquivo))
                        {
                            //Preparação para a Visualização
                            //escreveArq.WriteLine(cmbTipoServ.Text + separador + txtCliente.Text + separador + txtEmpresa.Text + separador + cmbPeriodo.Text + separador + txtDescricao.Text);
                            
                            //Codigo para layout formatado
                            escreveArq.WriteLine(cmbTipoServ.Text + separador + txtCliente.Text + separador + txtEmpresa.Text);
                            escreveArq.WriteLine("-> " + txtDescricao.Text);
                            escreveArq.WriteLine("Periodo: " + cmbPeriodo.Text);
                            escreveArq.WriteLine(fimSessao);

                        }
                        MessageBox.Show("Informações Salvas");
                        limpaCampo();
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else
                {
                    using (StreamWriter escreveArq = File.AppendText(caminhoArquivo + nomeArquivo))
                    {
                        //Preparação para a Visualização
                        //escreveArq.WriteLine(cmbTipoServ.Text + separador + txtCliente.Text + separador + txtEmpresa.Text + separador + cmbPeriodo.Text + separador + txtDescricao.Text);

                        //Codigo para layout formatado
                        escreveArq.WriteLine(cmbTipoServ.Text + separador + txtCliente.Text + separador + txtEmpresa.Text);
                        escreveArq.WriteLine("-> "+txtDescricao.Text);
                        escreveArq.WriteLine("Periodo: " + cmbPeriodo.Text);
                        escreveArq.WriteLine(fimSessao);
                    }
                    MessageBox.Show("Informações Salvas");
                    limpaCampo();
                }
            }
            else
            {
                DialogResult criarDiretorio = MessageBox.Show(mensagemDir, tituloDir, MessageBoxButtons.YesNo);
                if (criarDiretorio == DialogResult.Yes)
                {
                    DirectoryInfo di = Directory.CreateDirectory(caminhoArquivo);
                    MessageBox.Show("Diretório criado!\nSalve o arquivo novamente");
                }
                else
                {
                    this.Close();
                }

            }
        }
    }
}
