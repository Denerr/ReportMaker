using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Security;
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

        string prioridade;

        public void GerarArquivoTexto()
        {
            string caminhoArquivoSugestao = "C:/VS_ReportBuilder/Sugestao/";
            string nomeArquivoTexto = "Sugestao - "+txtSolicitante.Text + DateTime.Today.ToString(" dd-MM-yy") +".txt";

            string mensagemDir = "Diretorio não encontrado. Deseja criar um?";
            string tituloDir = "Criar Diretorio?";
            string separador = ",";

            if (Directory.Exists(caminhoArquivoSugestao))
            {
                File.Create(nomeArquivoTexto).Close();
                using (StreamWriter escreveArq = new StreamWriter(caminhoArquivoSugestao + nomeArquivoTexto))
                {
                    string escrevePrioridade = prioridade;
                    //Preparação para a Visualização
                    escreveArq.WriteLine(txtTitulo.Text + separador + txtEmpresa.Text + separador + txtSolicitante.Text
                        + separador + txtValorGerado.Text + separador + txtEsperado.Text + separador + txtDetalhado.Text
                        + separador + dtpDataSolicitacao.Value + separador + cmbPrograma.Text);

                    //Codigo para layout formatado


                }
                MessageBox.Show("Informações Salvas");
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
                prioridade= "";
            }
        }

        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        private void ImprimeImagem(PrintPageEventArgs e)
        {
            if(ptbImagem.ImageLocation != null)
            {
                string caminhoImagem = ptbImagem.ImageLocation;
                System.Drawing.Image img = System.Drawing.Image.FromFile(caminhoImagem);
                img = resizeImage(img, new Size(350, 300));
                e.Graphics.DrawImage(img, 250, 800);
            }
            else
            {
                //Não imprime imagem nenhuma
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            String imageLocator = "";

            try
            {
                OpenFileDialog dialog= new OpenFileDialog();
                dialog.Filter = "jpeg files(*.jpeg)|*.jpg|jpeg files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";

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
            GerarArquivoTexto();
            DialogResult printDialog = MessageBox.Show("Deseja confirmar a impressão?", "Imprimir?", MessageBoxButtons.OKCancel);
            if (printDialog == DialogResult.OK)
            {
                printPreviewDialog1.ShowDialog();
            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float width = 550;
            float height = 1000;

            e.Graphics.DrawString(txtTitulo.Text,new Font("Arial",12,FontStyle.Regular),Brushes.Black, new RectangleF(340,100,width,height));
            e.Graphics.DrawString("Empresa: " + txtEmpresa.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new RectangleF(100, 150, width, height));
            e.Graphics.DrawString("Solicitante: " + txtSolicitante.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new RectangleF(100, 185, width, height));
            e.Graphics.DrawString("Descrição:\n" + txtDetalhado.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new RectangleF(100, 220, width, height));
            e.Graphics.DrawString("Valor Gerado:\n" + txtValorGerado.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new RectangleF(100, 370, width, height));
            e.Graphics.DrawString("O que é esperado:\n" + txtEsperado.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new RectangleF(100, 520, width, height));
            e.Graphics.DrawString("Programa: " + cmbPrograma.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new RectangleF(100, 670, width, height));
            e.Graphics.DrawString("Prioridade: " + prioridade, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new RectangleF(100, 705, width, height));
            e.Graphics.DrawString("Data da Solicitação: " + dtpDataSolicitacao.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new RectangleF(100, 740, width, height));
            ImprimeImagem(e);
        }

        public void setText(string lista)
        {
            string[] valor = new string[10];
            valor = lista.Split(',');

            txtTitulo.Text = valor[0].ToString();
            txtEmpresa.Text = valor[1].ToString();
            txtSolicitante.Text = valor[2].ToString();
            txtValorGerado.Text = valor[3].ToString();
            txtEsperado.Text = valor[4].ToString();
            txtDetalhado.Text = valor[5].ToString();
            cmbPrograma.Text = valor[8].ToString();
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var sr = new StreamReader(ofd.FileName);
                    setText(sr.ReadToEnd());
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }
    }
}
