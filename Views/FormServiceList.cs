using Practice1.Models;
using Practice1.Mongo;

namespace Practice1
{
    public partial class FormServiceList : Form
    {
        MongoDBConnect MongoDB;
        int lastId;

        public FormServiceList(MongoDBConnect mongoDB)
        {
            InitializeComponent();
            MongoDB = mongoDB;
            lastId = mongoDB.Load<Class_Services>().Max(n => n.Id);
            UpdateTable();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Class_Services nachisl = new Class_Services()
            {
                Id = lastId + 1,
                SERVICENM = "Услуга"
            };
            lastId += 1;
            var frm = new FormServiceEdit(nachisl);
            if (frm.ShowDialog() == DialogResult.OK)
                MongoDB.Insert<Class_Services>(nachisl);
            UpdateTable();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            var sel = (Class_Services)classServicesBindingSource.Current;
            if (sel == null) return;
            var frm = new FormServiceEdit(sel);
            if (frm.ShowDialog() == DialogResult.OK)
                MongoDB.Update<Class_Services>(sel);
            UpdateTable();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            var sel = (Class_Services)classServicesBindingSource.Current;
            if (sel == null) return;
            var dr = MessageBox.Show("Вы действительно хотите удалить?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
                MongoDB.Delete<Class_Services>(sel);
            UpdateTable();
        }

        private void UpdateTable()
        {
            classServicesBindingSource.DataSource = MongoDB.Load<Class_Services>();
        }
    }
}
