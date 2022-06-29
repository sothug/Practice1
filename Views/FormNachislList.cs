using Practice1.Models;
using Practice1.Mongo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice1
{
    public partial class FormNachislList : Form
    {
        MongoDBConnect MongoDB;
        int lastId;

        public FormNachislList(MongoDBConnect mongoDB)
        {
            InitializeComponent();
            MongoDB = mongoDB;
            lastId = mongoDB.Load<Class_NachislSumma>().Max(n => n.Id);
            UpdateTable();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!MongoDB.Load<Class_Abonent>().Any()) return;
            if (!MongoDB.Load<Class_Services>().Any()) return;
            Class_NachislSumma nachisl = new Class_NachislSumma()
            {
                Id = lastId + 1,
                AccountCD = MongoDB.Load<Class_Abonent>().First().Fio,
                ServiceCD = MongoDB.Load<Class_Services>().First().SERVICENM,
                NachislSum = 0,
                NachislMonth = "Январь",
                NachislYear = DateTime.Now.Year,
            };
            lastId += 1;
            var frm = new FormNachislEdit(nachisl, MongoDB.Load<Class_Abonent>(), MongoDB.Load<Class_Services>());
            if (frm.ShowDialog() == DialogResult.OK)
                MongoDB.Insert<Class_NachislSumma>(nachisl);
            UpdateTable();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            var sel = (Class_NachislSumma)classNachislSummaBindingSource.Current;
            if (sel == null) return;
            var frm = new FormNachislEdit(sel, MongoDB.Load<Class_Abonent>(), MongoDB.Load<Class_Services>());
            if (frm.ShowDialog() == DialogResult.OK)
                MongoDB.Update<Class_NachislSumma>(sel);
            UpdateTable();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            var sel = (Class_NachislSumma)classNachislSummaBindingSource.Current;
            if (sel == null) return;
            var dr = MessageBox.Show("Вы действительно хотите удалить?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
                MongoDB.Delete<Class_NachislSumma>(sel);
            UpdateTable();
        }

        private void UpdateTable()
        {
            classNachislSummaBindingSource.DataSource = MongoDB.Load<Class_NachislSumma>();
        }
    }
}
