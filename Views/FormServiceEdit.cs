using Practice1.Models;
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
    public partial class FormServiceEdit : Form
    {
        Class_Services s;

        public FormServiceEdit(Class_Services service)
        {
            InitializeComponent();
            s = service;
            DataToForm();
        }

        private void DataToForm()
        {
            textBoxName.Text = s.SERVICENM;
        }

        private bool FormToData()
        {
            s.SERVICENM = textBoxName.Text;
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
