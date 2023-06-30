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

        public void GerarArquivoTexto()
        {
            string caminhoArquivoSugestao = "C:/VS_ReportBuilder/Sugestao/";
            string nomeArquivoTexto = "Sugestao - "+txtSolicitante.Text + DateTime.Today.ToString(" dd-MM-yy") +".txt";

            string mensagemDir = "Diretorio não encontrado. Deseja criar um?";
            string tituloDir = "Criar Diretorio?";
            string mensagemArq = "Aquivo não encontrado. Deseja criar um?";
            string tituloArq = "Criar Arquivo?";

            if (Directory.Exists(caminhoArquivoSugestao))
            {
                if (!File.Exists(nomeArquivoTexto))
                {
                    DialogResult criarArquivo = MessageBox.Show(mensagemArq, tituloArq, MessageBoxButtons.YesNo);
                    if (criarArquivo == DialogResult.Yes)
                    {
                        File.Create(nomeArquivoTexto).Close();
                        using (StreamWriter escreveArq = new StreamWriter(caminhoArquivoSugestao + nomeArquivoTexto))
                        {
                            //Preparação para a Visualização
                            //escreveArq.WriteLine(cmbTipoServ.Text + separador + txtCliente.Text + separador + txtEmpresa.Text + separador + cmbPeriodo.Text + separador + txtDescricao.Text);

                            //Codigo para layout formatado
                            

                        }
                        MessageBox.Show("Informações Salvas");

                    }
                    else
                    {
                        this.Close();
                    }
                }
                else
                {
                    using (StreamWriter escreveArq = File.AppendText(caminhoArquivoSugestao + nomeArquivoTexto))
                    {
                        //Preparação para a Visualização
                        //escreveArq.WriteLine(cmbTipoServ.Text + separador + txtCliente.Text + separador + txtEmpresa.Text + separador + cmbPeriodo.Text + separador + txtDescricao.Text);

                        //Codigo para layout formatado
                        
                    }
                    MessageBox.Show("Informações Salvas");
                    
                }
            }
            else
            {
                DialogResult criarDiretorio = MessageBox.Show(mensagemDir, tituloDir, MessageBoxButtons.YesNo);
                if (criarDiretorio == DialogResult.Yes)
                {
                    DirectoryInfo di = Directory.CreateDirectory(caminhoArquivoSugestao);
                    MessageBox.Show("Diretório criado!\nSalve o arquivo novamente");
                }
                else
                {
                    this.Close();
                }

            }
        }

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
                dialog.Filter = "jpeg files(*.jpeg)|*.jpeg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";

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

            DialogResult printDialog = MessageBox.Show("Deseja confirmar a impressão?", "Imprimir?",MessageBoxButtons.OKCancel);
            if(printDialog == DialogResult.OK)
            {
                printPreviewDialog1.ShowDialog();
            }

            //if (printPreviewDialog1.DialogResult == DialogResult.OK)
            //    printDocument1.Print();

            //getPrioridade();
            //if(prioridade != "" && txtSolicitante.Text != "")
            //{


            //    //GerarArquivoTexto();
            //    //MessageBox.Show("Prioridade: "+ prioridade, "Nivel de Prioridade");
            //}
            //else
            //{
            //    MessageBox.Show("Preencha o campo 'Solicitante' antes de salvar!");
            //}

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtTitulo.Text,new Font("Arial",12,FontStyle.Regular),Brushes.Black, new PointF(130,130));
        }
    }
}
