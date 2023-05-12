namespace ReportMaker
{
    public partial class Form1 : Form
    {
        public Form1()
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
            abrirForm(new frmCriar());
        }
    }
}