namespace ReportMaker
{
    partial class frmSugestoes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSugestoes));
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSolicitante = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValorGerado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEsperado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDetalhado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDataSolicitacao = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbPrograma = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rdbPrioridadeB = new System.Windows.Forms.RadioButton();
            this.rdbPrioridadeM = new System.Windows.Forms.RadioButton();
            this.rdbPrioridadeA = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlPrioridade = new System.Windows.Forms.Panel();
            this.ptbImagem = new System.Windows.Forms.PictureBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.pnlPrioridade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titulo da Solicitação";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(44, 46);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.PlaceholderText = "Criar um Relatório de Estoque";
            this.txtTitulo.Size = new System.Drawing.Size(268, 23);
            this.txtTitulo.TabIndex = 1;
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(44, 99);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(268, 23);
            this.txtEmpresa.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Empresa";
            // 
            // txtSolicitante
            // 
            this.txtSolicitante.Location = new System.Drawing.Point(44, 152);
            this.txtSolicitante.Name = "txtSolicitante";
            this.txtSolicitante.Size = new System.Drawing.Size(268, 23);
            this.txtSolicitante.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Solicitante";
            // 
            // txtValorGerado
            // 
            this.txtValorGerado.Location = new System.Drawing.Point(44, 209);
            this.txtValorGerado.Multiline = true;
            this.txtValorGerado.Name = "txtValorGerado";
            this.txtValorGerado.Size = new System.Drawing.Size(334, 63);
            this.txtValorGerado.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Valor Gerado";
            // 
            // txtEsperado
            // 
            this.txtEsperado.Location = new System.Drawing.Point(44, 304);
            this.txtEsperado.Multiline = true;
            this.txtEsperado.Name = "txtEsperado";
            this.txtEsperado.Size = new System.Drawing.Size(334, 58);
            this.txtEsperado.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "O que é esperado?";
            // 
            // txtDetalhado
            // 
            this.txtDetalhado.Location = new System.Drawing.Point(44, 398);
            this.txtDetalhado.Multiline = true;
            this.txtDetalhado.Name = "txtDetalhado";
            this.txtDetalhado.Size = new System.Drawing.Size(334, 119);
            this.txtDetalhado.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Descrição Detalhada";
            // 
            // dtpDataSolicitacao
            // 
            this.dtpDataSolicitacao.CustomFormat = "";
            this.dtpDataSolicitacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataSolicitacao.Location = new System.Drawing.Point(512, 46);
            this.dtpDataSolicitacao.Name = "dtpDataSolicitacao";
            this.dtpDataSolicitacao.Size = new System.Drawing.Size(128, 23);
            this.dtpDataSolicitacao.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(512, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Data da Solicitação";
            // 
            // cmbPrograma
            // 
            this.cmbPrograma.FormattingEnabled = true;
            this.cmbPrograma.Items.AddRange(new object[] {
            "VipERP Gestão",
            "VipERP PDV",
            "VipERP Comanda"});
            this.cmbPrograma.Location = new System.Drawing.Point(512, 111);
            this.cmbPrograma.Name = "cmbPrograma";
            this.cmbPrograma.Size = new System.Drawing.Size(187, 23);
            this.cmbPrograma.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(512, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Programa";
            // 
            // rdbPrioridadeB
            // 
            this.rdbPrioridadeB.AutoSize = true;
            this.rdbPrioridadeB.Location = new System.Drawing.Point(33, 51);
            this.rdbPrioridadeB.Name = "rdbPrioridadeB";
            this.rdbPrioridadeB.Size = new System.Drawing.Size(53, 19);
            this.rdbPrioridadeB.TabIndex = 16;
            this.rdbPrioridadeB.TabStop = true;
            this.rdbPrioridadeB.Text = "Baixa";
            this.rdbPrioridadeB.UseVisualStyleBackColor = true;
            // 
            // rdbPrioridadeM
            // 
            this.rdbPrioridadeM.AutoSize = true;
            this.rdbPrioridadeM.Location = new System.Drawing.Point(33, 76);
            this.rdbPrioridadeM.Name = "rdbPrioridadeM";
            this.rdbPrioridadeM.Size = new System.Drawing.Size(58, 19);
            this.rdbPrioridadeM.TabIndex = 17;
            this.rdbPrioridadeM.TabStop = true;
            this.rdbPrioridadeM.Text = "Media";
            this.rdbPrioridadeM.UseVisualStyleBackColor = true;
            // 
            // rdbPrioridadeA
            // 
            this.rdbPrioridadeA.AutoSize = true;
            this.rdbPrioridadeA.Location = new System.Drawing.Point(33, 101);
            this.rdbPrioridadeA.Name = "rdbPrioridadeA";
            this.rdbPrioridadeA.Size = new System.Drawing.Size(46, 19);
            this.rdbPrioridadeA.TabIndex = 18;
            this.rdbPrioridadeA.TabStop = true;
            this.rdbPrioridadeA.Text = "Alta";
            this.rdbPrioridadeA.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 15);
            this.label9.TabIndex = 19;
            this.label9.Text = "Prioridade";
            // 
            // pnlPrioridade
            // 
            this.pnlPrioridade.Controls.Add(this.label9);
            this.pnlPrioridade.Controls.Add(this.rdbPrioridadeB);
            this.pnlPrioridade.Controls.Add(this.rdbPrioridadeA);
            this.pnlPrioridade.Controls.Add(this.rdbPrioridadeM);
            this.pnlPrioridade.Location = new System.Drawing.Point(498, 152);
            this.pnlPrioridade.Name = "pnlPrioridade";
            this.pnlPrioridade.Size = new System.Drawing.Size(213, 152);
            this.pnlPrioridade.TabIndex = 20;
            // 
            // ptbImagem
            // 
            this.ptbImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbImagem.Location = new System.Drawing.Point(463, 345);
            this.ptbImagem.Name = "ptbImagem";
            this.ptbImagem.Size = new System.Drawing.Size(117, 96);
            this.ptbImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbImagem.TabIndex = 21;
            this.ptbImagem.TabStop = false;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(622, 380);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(100, 36);
            this.btnUpload.TabIndex = 22;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(611, 471);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(122, 36);
            this.btnSalvar.TabIndex = 23;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(586, 345);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(172, 15);
            this.label10.TabIndex = 24;
            this.label10.Text = "Faça o Upload de uma Imagem";
            // 
            // printDocument1
            // 
            this.printDocument1.DocumentName = "Preview";
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // frmSugestoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 539);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.ptbImagem);
            this.Controls.Add(this.pnlPrioridade);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbPrograma);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpDataSolicitacao);
            this.Controls.Add(this.txtDetalhado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEsperado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtValorGerado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSolicitante);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmpresa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(770, 539);
            this.Name = "frmSugestoes";
            this.Text = "Sugestoes";
            this.pnlPrioridade.ResumeLayout(false);
            this.pnlPrioridade.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtTitulo;
        private TextBox txtEmpresa;
        private Label label2;
        private TextBox txtSolicitante;
        private Label label3;
        private TextBox txtValorGerado;
        private Label label4;
        private TextBox txtEsperado;
        private Label label5;
        private TextBox txtDetalhado;
        private Label label6;
        private DateTimePicker dtpDataSolicitacao;
        private Label label7;
        private ComboBox cmbPrograma;
        private Label label8;
        private RadioButton rdbPrioridadeB;
        private RadioButton rdbPrioridadeM;
        private RadioButton rdbPrioridadeA;
        private Label label9;
        private Panel pnlPrioridade;
        private PictureBox ptbImagem;
        private Button btnUpload;
        private Button btnSalvar;
        private Label label10;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}