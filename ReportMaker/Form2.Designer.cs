namespace ReportMaker
{
    partial class frmCriar
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
            btnCriar = new Button();
            lblCliente = new Label();
            txtCliente = new TextBox();
            txtEmpresa = new TextBox();
            lblEmpresa = new Label();
            txtDescricao = new TextBox();
            lblDescricao = new Label();
            dtpData = new DateTimePicker();
            cmbPeriodo = new ComboBox();
            lblData = new Label();
            lblPeriodo = new Label();
            lblTipoServ = new Label();
            cmbTipoServ = new ComboBox();
            SuspendLayout();
            // 
            // btnCriar
            // 
            btnCriar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCriar.Location = new Point(536, 373);
            btnCriar.Name = "btnCriar";
            btnCriar.Size = new Size(75, 23);
            btnCriar.TabIndex = 0;
            btnCriar.Text = "Criar";
            btnCriar.UseVisualStyleBackColor = true;
            btnCriar.Click += btnCriar_Click;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(70, 21);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(44, 15);
            lblCliente.TabIndex = 1;
            lblCliente.Text = "Cliente";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(27, 39);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(262, 23);
            txtCliente.TabIndex = 2;
            // 
            // txtEmpresa
            // 
            txtEmpresa.Location = new Point(27, 94);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.Size = new Size(262, 23);
            txtEmpresa.TabIndex = 4;
            // 
            // lblEmpresa
            // 
            lblEmpresa.AutoSize = true;
            lblEmpresa.Location = new Point(70, 76);
            lblEmpresa.Name = "lblEmpresa";
            lblEmpresa.Size = new Size(52, 15);
            lblEmpresa.TabIndex = 3;
            lblEmpresa.Text = "Empresa";
            // 
            // txtDescricao
            // 
            txtDescricao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtDescricao.Location = new Point(27, 211);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(467, 203);
            txtDescricao.TabIndex = 6;
            // 
            // lblDescricao
            // 
            lblDescricao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(231, 193);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(58, 15);
            lblDescricao.TabIndex = 5;
            lblDescricao.Text = "Descrição";
            // 
            // dtpData
            // 
            dtpData.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpData.Format = DateTimePickerFormat.Short;
            dtpData.Location = new Point(373, 38);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(121, 23);
            dtpData.TabIndex = 7;
            // 
            // cmbPeriodo
            // 
            cmbPeriodo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbPeriodo.FormattingEnabled = true;
            cmbPeriodo.Items.AddRange(new object[] { "Manhã", "Tarde" });
            cmbPeriodo.Location = new Point(373, 94);
            cmbPeriodo.Name = "cmbPeriodo";
            cmbPeriodo.Size = new Size(182, 23);
            cmbPeriodo.TabIndex = 8;
            // 
            // lblData
            // 
            lblData.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblData.AutoSize = true;
            lblData.Location = new Point(391, 20);
            lblData.Name = "lblData";
            lblData.Size = new Size(62, 15);
            lblData.TabIndex = 9;
            lblData.Text = "Data Atual";
            // 
            // lblPeriodo
            // 
            lblPeriodo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPeriodo.AutoSize = true;
            lblPeriodo.Location = new Point(391, 76);
            lblPeriodo.Name = "lblPeriodo";
            lblPeriodo.Size = new Size(48, 15);
            lblPeriodo.TabIndex = 10;
            lblPeriodo.Text = "Periodo";
            // 
            // lblTipoServ
            // 
            lblTipoServ.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTipoServ.AutoSize = true;
            lblTipoServ.Location = new Point(45, 128);
            lblTipoServ.Name = "lblTipoServ";
            lblTipoServ.Size = new Size(87, 15);
            lblTipoServ.TabIndex = 12;
            lblTipoServ.Text = "Tipo de Serviço";
            // 
            // cmbTipoServ
            // 
            cmbTipoServ.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbTipoServ.FormattingEnabled = true;
            cmbTipoServ.Items.AddRange(new object[] { "Atendimento", "Instalação", "POST" });
            cmbTipoServ.Location = new Point(27, 146);
            cmbTipoServ.Name = "cmbTipoServ";
            cmbTipoServ.Size = new Size(182, 23);
            cmbTipoServ.TabIndex = 11;
            // 
            // frmCriar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 426);
            Controls.Add(lblTipoServ);
            Controls.Add(cmbTipoServ);
            Controls.Add(lblPeriodo);
            Controls.Add(lblData);
            Controls.Add(cmbPeriodo);
            Controls.Add(dtpData);
            Controls.Add(txtDescricao);
            Controls.Add(lblDescricao);
            Controls.Add(txtEmpresa);
            Controls.Add(lblEmpresa);
            Controls.Add(txtCliente);
            Controls.Add(lblCliente);
            Controls.Add(btnCriar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCriar";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCriar;
        private Label lblCliente;
        private TextBox txtCliente;
        private TextBox txtEmpresa;
        private Label lblEmpresa;
        private TextBox txtDescricao;
        private Label lblDescricao;
        private DateTimePicker dtpData;
        private ComboBox cmbPeriodo;
        private Label lblData;
        private Label lblPeriodo;
        private Label lblTipoServ;
        private ComboBox cmbTipoServ;
    }
}