using Practice1.Models;
using Practice1.Mongo;

namespace Practice1
{
    public partial class FormNachislEdit : Form
    {
        Class_NachislSumma n;

        public FormNachislEdit(Class_NachislSumma nachisl, SBindingList<Class_Abonent> abonents, SBindingList<Class_Services> services)
        {
            InitializeComponent();
            n = nachisl;
            classAbonentBindingSource.DataSource = abonents;
            classServicesBindingSource.DataSource = services;
            DataToForm();
        }

        private void DataToForm()
        {
            comboBoxAccount.SelectedItem = n.AccountCD;
            comboBoxService.SelectedItem = n.ServiceCD;
            textBoxSum.Text = n.NachislSum.ToString();
            comboBoxMonth.Text = n.NachislMonth;
            textBoxYear.Text = n.NachislYear.ToString();
        }

        private bool FormToData()
        {
            if (!double.TryParse(textBoxSum.Text, out var sum))
            {
                MessageBox.Show("Ожидалось число", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxSum.Focus();
                return false;
            }
            if (!int.TryParse(textBoxYear.Text, out var year))
            {
                MessageBox.Show("Ожидалось число", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxYear.Focus();
                return false;
            }
            n.AccountCD = ((Class_Abonent)comboBoxAccount.SelectedItem).Fio;
            n.ServiceCD = comboBoxService.SelectedItem.ToString();
            n.NachislSum = sum;
            n.NachislMonth = comboBoxMonth.SelectedItem.ToString();
            n.NachislYear = year;
            return true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!FormToData())
                return;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
