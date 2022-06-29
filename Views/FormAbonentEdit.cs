using Practice1.Models;

namespace Practice1
{
    public partial class FormAbonentEdit : Form
    {
        Class_Abonent a;
        public FormAbonentEdit(Class_Abonent abonent)
        {
            InitializeComponent();
            a = abonent;
            DataToForm();
            if (!string.IsNullOrEmpty(a.Id))
                textBoxId.ReadOnly = true;
        }

        private void DataToForm()
        {
            textBoxId.Text = a.Id;
            textBoxStreet.Text = a.StreetCD;
            textBoxHouse.Text = a.HouseNo.ToString();
            textBoxFlat.Text = a.FlatNo.ToString();
            textBoxFIO.Text = a.Fio;
            textBoxPhone.Text = a.Phone;
        }

        private bool FormToData()
        {
            if (!int.TryParse(textBoxHouse.Text, out int house))
            {
                MessageBox.Show("Ожидалось число", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxHouse.Focus();
                return false;
            }
            if (!int.TryParse(textBoxFlat.Text, out int flat))
            {
                MessageBox.Show("Ожидалось число", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxFlat.Focus();
                return false;
            }
            a.Id = textBoxId.Text;
            a.StreetCD = textBoxStreet.Text;
            a.HouseNo = house;
            a.FlatNo = flat;
            a.Fio = textBoxFIO.Text;
            a.Phone = textBoxPhone.Text;
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
