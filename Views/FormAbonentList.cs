using Practice1.Models;
using Practice1.Mongo;

namespace Practice1
{
    public partial class FormAbonentList : Form
    {
        MongoDBConnect MongoDB;
        string filter = "";
        int curSort = 0;

        public FormAbonentList(MongoDBConnect mongoDB)
        {
            InitializeComponent();
            MongoDB = mongoDB;
            comboBoxSort.Items.Add("ФИО");
            comboBoxSort.Items.Add("Улица");
            comboBoxSort.SelectedIndex = curSort;
            UpdateTable();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Class_Abonent abonent = new Class_Abonent()
            {
                Id = "",
                StreetCD = MongoDB.Load<Class_Street>().First().ToString(),
                HouseNo = 1,
                FlatNo = 1,
                Fio = "Иванов И.И.",
                Phone = "123456"
            };
            var frm = new FormAbonentEdit(abonent);
            if (frm.ShowDialog() == DialogResult.OK)
                //MongoDB.Insert_Abonent_Information(abonent);
                MongoDB.Insert<Class_Abonent>(abonent);
            UpdateTable();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            var sel = (Class_Abonent)classAbonentBindingSource.Current;
            if (sel == null) return;
            var frm = new FormAbonentEdit(sel);
            if (frm.ShowDialog() == DialogResult.OK)
                //MongoDB.Update_Abonent_Information(sel);
                MongoDB.Update<Class_Abonent>(sel);
            UpdateTable();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            var sel = (Class_Abonent)classAbonentBindingSource.Current;
            if (sel == null) return;
            var dr = MessageBox.Show("Вы действительно хотите удалить?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
                //MongoDB.Delete_Abonent_Infromation(sel);
                MongoDB.Delete<Class_Abonent>(sel);
            UpdateTable();
        }

        private void textBoxFilter_TextChanged(object sender, EventArgs e)
        {
            filter = textBoxFilter.Text;
            UpdateTable();
        }

        private void comboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            curSort = comboBoxSort.SelectedIndex;
            UpdateTable();
        }

        private void UpdateTable()
        {
            //classAbonentBindingSource.DataSource = MongoDB.Load_Abonent();
            var abonents = MongoDB.Load<Class_Abonent>()
                .Where(a => a.Fio.Contains(filter) || a.StreetCD.Contains(filter));
            abonents = curSort switch
            {
                0 => abonents.OrderBy(a => a.Fio),
                1 => abonents.OrderBy(a => a.StreetCD),
                _ => throw new IndexOutOfRangeException()
            };
            classAbonentBindingSource.DataSource = abonents;
           
        }
    }
}
