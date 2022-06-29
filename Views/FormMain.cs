using Practice1.Mongo;

namespace Practice1
{
    public partial class FormMain : Form
    {
        Form form;
        MongoDBConnect mongoDB;

        public FormMain()
        {
            InitializeComponent();
            mongoDB = new MongoDBConnect();
            SetForm(new FormAbonentList(mongoDB));
        }

        private void абонентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetForm(new FormAbonentList(mongoDB));
        }

        private void услугиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetForm(new FormServiceList(mongoDB));
        }

        private void начисленияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetForm(new FormNachislList(mongoDB));
        }

        private void SetForm(Form _form)
        { 
            form?.Close();
            form = _form;
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }
    }
} // 53 - 49