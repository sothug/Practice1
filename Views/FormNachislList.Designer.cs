using Practice1.Models;

namespace Practice1
{
    partial class FormNachislList
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
            this.components = new System.ComponentModel.Container();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountCDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceCDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nachislSumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nachislMonthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nachislYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classNachislSummaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classNachislSummaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRemove
            // 
            this.buttonRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemove.Location = new System.Drawing.Point(536, 62);
            this.buttonRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(153, 22);
            this.buttonRemove.TabIndex = 7;
            this.buttonRemove.Text = "Удалить";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEdit.Location = new System.Drawing.Point(536, 35);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(153, 22);
            this.buttonEdit.TabIndex = 6;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Location = new System.Drawing.Point(536, 9);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(153, 22);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn1,
            this.accountCDDataGridViewTextBoxColumn,
            this.serviceCDDataGridViewTextBoxColumn,
            this.nachislSumDataGridViewTextBoxColumn,
            this.nachislMonthDataGridViewTextBoxColumn,
            this.nachislYearDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.classNachislSummaBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(10, 9);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 29;
            this.dataGridView.Size = new System.Drawing.Size(521, 320);
            this.dataGridView.TabIndex = 4;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "_id";
            this.idDataGridViewTextBoxColumn.HeaderText = "_id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // accountCDDataGridViewTextBoxColumn
            // 
            this.accountCDDataGridViewTextBoxColumn.DataPropertyName = "AccountCD";
            this.accountCDDataGridViewTextBoxColumn.HeaderText = "AccountCD";
            this.accountCDDataGridViewTextBoxColumn.Name = "accountCDDataGridViewTextBoxColumn";
            this.accountCDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serviceCDDataGridViewTextBoxColumn
            // 
            this.serviceCDDataGridViewTextBoxColumn.DataPropertyName = "ServiceCD";
            this.serviceCDDataGridViewTextBoxColumn.HeaderText = "ServiceCD";
            this.serviceCDDataGridViewTextBoxColumn.Name = "serviceCDDataGridViewTextBoxColumn";
            this.serviceCDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nachislSumDataGridViewTextBoxColumn
            // 
            this.nachislSumDataGridViewTextBoxColumn.DataPropertyName = "NachislSum";
            this.nachislSumDataGridViewTextBoxColumn.HeaderText = "NachislSum";
            this.nachislSumDataGridViewTextBoxColumn.Name = "nachislSumDataGridViewTextBoxColumn";
            this.nachislSumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nachislMonthDataGridViewTextBoxColumn
            // 
            this.nachislMonthDataGridViewTextBoxColumn.DataPropertyName = "NachislMonth";
            this.nachislMonthDataGridViewTextBoxColumn.HeaderText = "NachislMonth";
            this.nachislMonthDataGridViewTextBoxColumn.Name = "nachislMonthDataGridViewTextBoxColumn";
            this.nachislMonthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nachislYearDataGridViewTextBoxColumn
            // 
            this.nachislYearDataGridViewTextBoxColumn.DataPropertyName = "NachislYear";
            this.nachislYearDataGridViewTextBoxColumn.HeaderText = "NachislYear";
            this.nachislYearDataGridViewTextBoxColumn.Name = "nachislYearDataGridViewTextBoxColumn";
            this.nachislYearDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // classNachislSummaBindingSource
            // 
            this.classNachislSummaBindingSource.DataSource = typeof(Class_NachislSumma);
            // 
            // FormNachislList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormNachislList";
            this.Text = "Начисления";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classNachislSummaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonRemove;
        private Button buttonEdit;
        private Button buttonAdd;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn accountCDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn serviceCDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nachislSumDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nachislMonthDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nachislYearDataGridViewTextBoxColumn;
        private BindingSource classNachislSummaBindingSource;
    }
}