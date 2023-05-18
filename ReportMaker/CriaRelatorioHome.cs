namespace ReportMaker
{
    public partial class CriaRelatorioHome : Form
    {
        public CriaRelatorioHome()
        {
            InitializeComponent();
        }


        private Form formAtivo = null;
        private void abrirForm(Form childForm)
        {
            if (formAtivo != null)
                formAtivo.Close();
            formAtivo = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(childForm);
            pnlContainer.Tag = childForm;
            childForm.Show();
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            if(formAtivo == null)
            {
                abrirForm(new frmCriar());
            }
            else
            {
                formAtivo?.Close();
                formAtivo = null;
            }
        }

        private void btnPendencia_Click(object sender, EventArgs e)
        {
            if (formAtivo == null)
            {
                abrirForm(new Pendencias());
            }
            else
            {
                formAtivo?.Close();
                formAtivo = null;
            }
        }
    }
}