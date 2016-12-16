namespace PassportTableDB
{
    partial class Civizen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Civizen));
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.getDataButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.civizenidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofbirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availabledocsDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.patronymicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportTableDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.passportTableDataSet1 = new PassportTableDB.PassportTableDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FilterTextBox = new System.Windows.Forms.TextBox();
            this.SortTextBox = new System.Windows.Forms.TextBox();
            this.civizenTableAdapter1 = new PassportTableDB.PassportTableDataSetTableAdapters.CivizenTableAdapter();
            this.SortAndFiltrationBtn = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.GroupBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passportTableDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passportTableDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = "SELECT* FROM Civizen";
            this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
            // 
            // oleDbConnection1
            // 
            this.oleDbConnection1.ConnectionString = "Provider=SQLNCLI11;Data Source=DESKTOP-AO1GFQ7\\SQLEXPRESS;Integrated Security=SSP" +
    "I;Initial Catalog=PassportTable";
            // 
            // oleDbInsertCommand1
            // 
            this.oleDbInsertCommand1.CommandText = "INSERT INTO [Civizen] ([surname], [name], [date_of_birth], [available_docs], [pat" +
    "ronymic]) VALUES (?, ?, ?, ?, ?)";
            this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("surname", System.Data.OleDb.OleDbType.VarWChar, 0, "surname"),
            new System.Data.OleDb.OleDbParameter("name", System.Data.OleDb.OleDbType.VarWChar, 0, "name"),
            new System.Data.OleDb.OleDbParameter("date_of_birth", System.Data.OleDb.OleDbType.DBDate, 0, "date_of_birth"),
            new System.Data.OleDb.OleDbParameter("available_docs", System.Data.OleDb.OleDbType.Boolean, 0, "available_docs"),
            new System.Data.OleDb.OleDbParameter("patronymic", System.Data.OleDb.OleDbType.VarWChar, 0, "patronymic")});
            // 
            // oleDbUpdateCommand1
            // 
            this.oleDbUpdateCommand1.CommandText = resources.GetString("oleDbUpdateCommand1.CommandText");
            this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("surname", System.Data.OleDb.OleDbType.VarWChar, 0, "surname"),
            new System.Data.OleDb.OleDbParameter("name", System.Data.OleDb.OleDbType.VarWChar, 0, "name"),
            new System.Data.OleDb.OleDbParameter("date_of_birth", System.Data.OleDb.OleDbType.DBDate, 0, "date_of_birth"),
            new System.Data.OleDb.OleDbParameter("available_docs", System.Data.OleDb.OleDbType.Boolean, 0, "available_docs"),
            new System.Data.OleDb.OleDbParameter("patronymic", System.Data.OleDb.OleDbType.VarWChar, 0, "patronymic"),
            new System.Data.OleDb.OleDbParameter("Original_civizen_id", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "civizen_id", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_surname", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "surname", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_name", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "name", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_date_of_birth", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "date_of_birth", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_available_docs", System.Data.OleDb.OleDbType.Boolean, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "available_docs", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_patronymic", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "patronymic", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand1
            // 
            this.oleDbDeleteCommand1.CommandText = "DELETE FROM [Civizen] WHERE (([civizen_id] = ?) AND ([surname] = ?) AND ([name] =" +
    " ?) AND ([date_of_birth] = ?) AND ([available_docs] = ?) AND ([patronymic] = ?))" +
    "";
            this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_civizen_id", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "civizen_id", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_surname", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "surname", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_name", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "name", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_date_of_birth", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "date_of_birth", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_available_docs", System.Data.OleDb.OleDbType.Boolean, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "available_docs", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_patronymic", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "patronymic", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDataAdapter1
            // 
            this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
            this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
            this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
            this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Civizen", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("civizen_id", "civizen_id"),
                        new System.Data.Common.DataColumnMapping("surname", "surname"),
                        new System.Data.Common.DataColumnMapping("name", "name"),
                        new System.Data.Common.DataColumnMapping("date_of_birth", "date_of_birth"),
                        new System.Data.Common.DataColumnMapping("available_docs", "available_docs"),
                        new System.Data.Common.DataColumnMapping("patronymic", "patronymic")})});
            this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
            // 
            // getDataButton
            // 
            this.getDataButton.Location = new System.Drawing.Point(12, 12);
            this.getDataButton.Name = "getDataButton";
            this.getDataButton.Size = new System.Drawing.Size(142, 61);
            this.getDataButton.TabIndex = 0;
            this.getDataButton.Text = "Завантажити дані";
            this.getDataButton.UseVisualStyleBackColor = true;
            this.getDataButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(12, 79);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(142, 61);
            this.updateButton.TabIndex = 1;
            this.updateButton.Text = "Оновлення даних";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.civizenidDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dateofbirthDataGridViewTextBoxColumn,
            this.availabledocsDataGridViewCheckBoxColumn,
            this.patronymicDataGridViewTextBoxColumn});
            this.dataGridView1.DataMember = "Civizen";
            this.dataGridView1.DataSource = this.passportTableDataSet1BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 250);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(658, 295);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellParsing += new System.Windows.Forms.DataGridViewCellParsingEventHandler(this.dataGridView1_CellParsing);
            // 
            // civizenidDataGridViewTextBoxColumn
            // 
            this.civizenidDataGridViewTextBoxColumn.DataPropertyName = "civizen_id";
            this.civizenidDataGridViewTextBoxColumn.HeaderText = "civizen_id";
            this.civizenidDataGridViewTextBoxColumn.Name = "civizenidDataGridViewTextBoxColumn";
            this.civizenidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // dateofbirthDataGridViewTextBoxColumn
            // 
            this.dateofbirthDataGridViewTextBoxColumn.DataPropertyName = "date_of_birth";
            this.dateofbirthDataGridViewTextBoxColumn.HeaderText = "date_of_birth";
            this.dateofbirthDataGridViewTextBoxColumn.Name = "dateofbirthDataGridViewTextBoxColumn";
            // 
            // availabledocsDataGridViewCheckBoxColumn
            // 
            this.availabledocsDataGridViewCheckBoxColumn.DataPropertyName = "available_docs";
            this.availabledocsDataGridViewCheckBoxColumn.HeaderText = "available_docs";
            this.availabledocsDataGridViewCheckBoxColumn.Name = "availabledocsDataGridViewCheckBoxColumn";
            // 
            // patronymicDataGridViewTextBoxColumn
            // 
            this.patronymicDataGridViewTextBoxColumn.DataPropertyName = "patronymic";
            this.patronymicDataGridViewTextBoxColumn.HeaderText = "patronymic";
            this.patronymicDataGridViewTextBoxColumn.Name = "patronymicDataGridViewTextBoxColumn";
            // 
            // passportTableDataSet1BindingSource
            // 
            this.passportTableDataSet1BindingSource.DataSource = this.passportTableDataSet1;
            this.passportTableDataSet1BindingSource.Position = 0;
            // 
            // passportTableDataSet1
            // 
            this.passportTableDataSet1.DataSetName = "PassportTableDataSet";
            this.passportTableDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Сортування";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Фільтрація";
            // 
            // FilterTextBox
            // 
            this.FilterTextBox.Location = new System.Drawing.Point(449, 98);
            this.FilterTextBox.Name = "FilterTextBox";
            this.FilterTextBox.Size = new System.Drawing.Size(179, 22);
            this.FilterTextBox.TabIndex = 5;
            this.FilterTextBox.Text = "name=\'Дмитро\'";
            // 
            // SortTextBox
            // 
            this.SortTextBox.Location = new System.Drawing.Point(449, 50);
            this.SortTextBox.Multiline = true;
            this.SortTextBox.Name = "SortTextBox";
            this.SortTextBox.Size = new System.Drawing.Size(179, 23);
            this.SortTextBox.TabIndex = 6;
            this.SortTextBox.Text = "surname";
            // 
            // civizenTableAdapter1
            // 
            this.civizenTableAdapter1.ClearBeforeFill = true;
            // 
            // SortAndFiltrationBtn
            // 
            this.SortAndFiltrationBtn.Location = new System.Drawing.Point(449, 147);
            this.SortAndFiltrationBtn.Name = "SortAndFiltrationBtn";
            this.SortAndFiltrationBtn.Size = new System.Drawing.Size(179, 46);
            this.SortAndFiltrationBtn.TabIndex = 7;
            this.SortAndFiltrationBtn.Text = "Сортування та фільтрація";
            this.SortAndFiltrationBtn.UseVisualStyleBackColor = true;
            this.SortAndFiltrationBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(13, 147);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(141, 59);
            this.BackButton.TabIndex = 8;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // GroupBtn
            // 
            this.GroupBtn.Location = new System.Drawing.Point(295, 147);
            this.GroupBtn.Name = "GroupBtn";
            this.GroupBtn.Size = new System.Drawing.Size(132, 46);
            this.GroupBtn.TabIndex = 9;
            this.GroupBtn.Text = "Групування";
            this.GroupBtn.UseVisualStyleBackColor = true;
            // 
            // Civizen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 545);
            this.Controls.Add(this.GroupBtn);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SortAndFiltrationBtn);
            this.Controls.Add(this.SortTextBox);
            this.Controls.Add(this.FilterTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.getDataButton);
            this.Name = "Civizen";
            this.Text = "Civizen";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passportTableDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passportTableDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private System.Data.OleDb.OleDbConnection oleDbConnection1;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
        private PassportTableDataSet passportTableDataSet1;
        private System.Windows.Forms.Button getDataButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn civizenidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofbirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn availabledocsDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymicDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource passportTableDataSet1BindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FilterTextBox;
        private System.Windows.Forms.TextBox SortTextBox;
        private PassportTableDataSetTableAdapters.CivizenTableAdapter civizenTableAdapter1;
        private System.Windows.Forms.Button SortAndFiltrationBtn;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button GroupBtn;
    }
}