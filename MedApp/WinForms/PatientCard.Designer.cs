namespace WinForms
{
    partial class PatientCard
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
            panel_Header = new Panel();
            button_addMedicalDocument = new Button();
            button_changePatientInfo = new Button();
            button_back = new Button();
            splitContainer_body = new SplitContainer();
            tableLayoutPanel_Patient_Info = new TableLayoutPanel();
            label_patient_phoneNumber = new Label();
            label_patient_firstName = new Label();
            label_patient_lastName = new Label();
            textBox_patient_lastName = new TextBox();
            label_patient_patronymic = new Label();
            label_patient_gender = new Label();
            label_patient_birthday = new Label();
            label_patient_adress = new Label();
            textBox_patient_firstName = new TextBox();
            textBox_patient_patronymic = new TextBox();
            textBox_patient_gender = new TextBox();
            textBox_patient_birthday = new TextBox();
            textBox_patient_phoneNumber = new TextBox();
            textBox_patient_adress = new TextBox();
            tabControl_patient_medicalDocuments = new TabControl();
            tabPage_Patient_MedicalRecords = new TabPage();
            dataGridView_patient_medicalRecords = new DataGridView();
            medicalRecord_date = new DataGridViewTextBoxColumn();
            medicalRecord_diagnosis = new DataGridViewTextBoxColumn();
            medicalRecord_author = new DataGridViewTextBoxColumn();
            medicalRecord_open = new DataGridViewButtonColumn();
            tabPage_Patient_ExaminationResult = new TabPage();
            dataGridView_patient_examinationResults = new DataGridView();
            examinationResult_date = new DataGridViewTextBoxColumn();
            examinationResult_type = new DataGridViewTextBoxColumn();
            examinationResult_result = new DataGridViewTextBoxColumn();
            examinationResult_author = new DataGridViewTextBoxColumn();
            examinationResult_open = new DataGridViewButtonColumn();
            label_formName = new Label();
            panel_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer_body).BeginInit();
            splitContainer_body.Panel1.SuspendLayout();
            splitContainer_body.Panel2.SuspendLayout();
            splitContainer_body.SuspendLayout();
            tableLayoutPanel_Patient_Info.SuspendLayout();
            tabControl_patient_medicalDocuments.SuspendLayout();
            tabPage_Patient_MedicalRecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_patient_medicalRecords).BeginInit();
            tabPage_Patient_ExaminationResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_patient_examinationResults).BeginInit();
            SuspendLayout();
            // 
            // panel_Header
            // 
            panel_Header.Controls.Add(button_addMedicalDocument);
            panel_Header.Controls.Add(button_changePatientInfo);
            panel_Header.Controls.Add(button_back);
            panel_Header.Controls.Add(label_formName);
            panel_Header.Dock = DockStyle.Top;
            panel_Header.Location = new Point(0, 0);
            panel_Header.Name = "panel_Header";
            panel_Header.Size = new Size(800, 55);
            panel_Header.TabIndex = 0;
            // 
            // button_addMedicalDocument
            // 
            button_addMedicalDocument.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button_addMedicalDocument.Image = Properties.Resources.plus;
            button_addMedicalDocument.ImageAlign = ContentAlignment.MiddleLeft;
            button_addMedicalDocument.Location = new Point(658, 12);
            button_addMedicalDocument.Name = "button_addMedicalDocument";
            button_addMedicalDocument.Size = new Size(130, 30);
            button_addMedicalDocument.TabIndex = 8;
            button_addMedicalDocument.Text = "Добавить запись";
            button_addMedicalDocument.TextImageRelation = TextImageRelation.TextBeforeImage;
            button_addMedicalDocument.UseVisualStyleBackColor = true;
            // 
            // button_changePatientInfo
            // 
            button_changePatientInfo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button_changePatientInfo.Image = Properties.Resources.pencil;
            button_changePatientInfo.ImageAlign = ContentAlignment.MiddleLeft;
            button_changePatientInfo.Location = new Point(562, 13);
            button_changePatientInfo.Name = "button_changePatientInfo";
            button_changePatientInfo.Size = new Size(90, 30);
            button_changePatientInfo.TabIndex = 7;
            button_changePatientInfo.Text = "Изменить";
            button_changePatientInfo.TextImageRelation = TextImageRelation.TextBeforeImage;
            button_changePatientInfo.UseVisualStyleBackColor = true;
            // 
            // button_back
            // 
            button_back.Image = Properties.Resources.back_arrow;
            button_back.ImageAlign = ContentAlignment.MiddleRight;
            button_back.Location = new Point(10, 13);
            button_back.Name = "button_back";
            button_back.Size = new Size(90, 30);
            button_back.TabIndex = 6;
            button_back.Text = "Назад";
            button_back.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_back.UseVisualStyleBackColor = true;
            // 
            // splitContainer_body
            // 
            splitContainer_body.Dock = DockStyle.Fill;
            splitContainer_body.Location = new Point(0, 55);
            splitContainer_body.Name = "splitContainer_body";
            // 
            // splitContainer_body.Panel1
            // 
            splitContainer_body.Panel1.Controls.Add(tableLayoutPanel_Patient_Info);
            // 
            // splitContainer_body.Panel2
            // 
            splitContainer_body.Panel2.Controls.Add(tabControl_patient_medicalDocuments);
            splitContainer_body.Size = new Size(800, 395);
            splitContainer_body.SplitterDistance = 216;
            splitContainer_body.TabIndex = 3;
            // 
            // tableLayoutPanel_Patient_Info
            // 
            tableLayoutPanel_Patient_Info.AutoSize = true;
            tableLayoutPanel_Patient_Info.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel_Patient_Info.ColumnCount = 2;
            tableLayoutPanel_Patient_Info.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.02439F));
            tableLayoutPanel_Patient_Info.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60.97561F));
            tableLayoutPanel_Patient_Info.Controls.Add(label_patient_phoneNumber, 0, 5);
            tableLayoutPanel_Patient_Info.Controls.Add(label_patient_firstName, 0, 1);
            tableLayoutPanel_Patient_Info.Controls.Add(label_patient_lastName, 0, 0);
            tableLayoutPanel_Patient_Info.Controls.Add(textBox_patient_lastName, 1, 0);
            tableLayoutPanel_Patient_Info.Controls.Add(label_patient_patronymic, 0, 2);
            tableLayoutPanel_Patient_Info.Controls.Add(label_patient_gender, 0, 3);
            tableLayoutPanel_Patient_Info.Controls.Add(label_patient_birthday, 0, 4);
            tableLayoutPanel_Patient_Info.Controls.Add(label_patient_adress, 0, 6);
            tableLayoutPanel_Patient_Info.Controls.Add(textBox_patient_firstName, 1, 1);
            tableLayoutPanel_Patient_Info.Controls.Add(textBox_patient_patronymic, 1, 2);
            tableLayoutPanel_Patient_Info.Controls.Add(textBox_patient_gender, 1, 3);
            tableLayoutPanel_Patient_Info.Controls.Add(textBox_patient_birthday, 1, 4);
            tableLayoutPanel_Patient_Info.Controls.Add(textBox_patient_phoneNumber, 1, 5);
            tableLayoutPanel_Patient_Info.Controls.Add(textBox_patient_adress, 1, 6);
            tableLayoutPanel_Patient_Info.Dock = DockStyle.Fill;
            tableLayoutPanel_Patient_Info.Location = new Point(0, 0);
            tableLayoutPanel_Patient_Info.Name = "tableLayoutPanel_Patient_Info";
            tableLayoutPanel_Patient_Info.RowCount = 7;
            tableLayoutPanel_Patient_Info.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel_Patient_Info.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel_Patient_Info.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel_Patient_Info.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel_Patient_Info.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel_Patient_Info.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel_Patient_Info.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel_Patient_Info.Size = new Size(216, 395);
            tableLayoutPanel_Patient_Info.TabIndex = 9;
            // 
            // label_patient_phoneNumber
            // 
            label_patient_phoneNumber.Anchor = AnchorStyles.None;
            label_patient_phoneNumber.AutoSize = true;
            label_patient_phoneNumber.Font = new Font("Segoe UI", 9F);
            label_patient_phoneNumber.Location = new Point(10, 293);
            label_patient_phoneNumber.Name = "label_patient_phoneNumber";
            label_patient_phoneNumber.Size = new Size(63, 30);
            label_patient_phoneNumber.TabIndex = 3;
            label_patient_phoneNumber.Text = "Номер телефона:";
            // 
            // label_patient_firstName
            // 
            label_patient_firstName.Anchor = AnchorStyles.None;
            label_patient_firstName.AutoSize = true;
            label_patient_firstName.Font = new Font("Segoe UI", 9F);
            label_patient_firstName.Location = new Point(25, 76);
            label_patient_firstName.Name = "label_patient_firstName";
            label_patient_firstName.Size = new Size(34, 15);
            label_patient_firstName.TabIndex = 2;
            label_patient_firstName.Text = "Имя:";
            // 
            // label_patient_lastName
            // 
            label_patient_lastName.Anchor = AnchorStyles.None;
            label_patient_lastName.AutoSize = true;
            label_patient_lastName.Font = new Font("Segoe UI", 9F);
            label_patient_lastName.Location = new Point(11, 20);
            label_patient_lastName.Name = "label_patient_lastName";
            label_patient_lastName.Size = new Size(61, 15);
            label_patient_lastName.TabIndex = 0;
            label_patient_lastName.Text = "Фамилия:";
            // 
            // textBox_patient_lastName
            // 
            textBox_patient_lastName.Anchor = AnchorStyles.None;
            textBox_patient_lastName.Font = new Font("Segoe UI", 11F);
            textBox_patient_lastName.Location = new Point(100, 14);
            textBox_patient_lastName.Name = "textBox_patient_lastName";
            textBox_patient_lastName.Size = new Size(100, 27);
            textBox_patient_lastName.TabIndex = 1;
            // 
            // label_patient_patronymic
            // 
            label_patient_patronymic.Anchor = AnchorStyles.None;
            label_patient_patronymic.AutoSize = true;
            label_patient_patronymic.Font = new Font("Segoe UI", 9F);
            label_patient_patronymic.Location = new Point(11, 132);
            label_patient_patronymic.Name = "label_patient_patronymic";
            label_patient_patronymic.Size = new Size(61, 15);
            label_patient_patronymic.TabIndex = 3;
            label_patient_patronymic.Text = "Отчество:";
            // 
            // label_patient_gender
            // 
            label_patient_gender.Anchor = AnchorStyles.None;
            label_patient_gender.AutoSize = true;
            label_patient_gender.Font = new Font("Segoe UI", 9F);
            label_patient_gender.Location = new Point(25, 188);
            label_patient_gender.Name = "label_patient_gender";
            label_patient_gender.Size = new Size(33, 15);
            label_patient_gender.TabIndex = 4;
            label_patient_gender.Text = "Пол:";
            // 
            // label_patient_birthday
            // 
            label_patient_birthday.Anchor = AnchorStyles.None;
            label_patient_birthday.AutoSize = true;
            label_patient_birthday.Font = new Font("Segoe UI", 9F);
            label_patient_birthday.Location = new Point(9, 237);
            label_patient_birthday.Name = "label_patient_birthday";
            label_patient_birthday.Size = new Size(65, 30);
            label_patient_birthday.TabIndex = 5;
            label_patient_birthday.Text = "День рождения:";
            // 
            // label_patient_adress
            // 
            label_patient_adress.Anchor = AnchorStyles.None;
            label_patient_adress.AutoSize = true;
            label_patient_adress.Font = new Font("Segoe UI", 9F);
            label_patient_adress.Location = new Point(20, 358);
            label_patient_adress.Name = "label_patient_adress";
            label_patient_adress.Size = new Size(43, 15);
            label_patient_adress.TabIndex = 6;
            label_patient_adress.Text = "Адрес:";
            // 
            // textBox_patient_firstName
            // 
            textBox_patient_firstName.Anchor = AnchorStyles.None;
            textBox_patient_firstName.Location = new Point(100, 72);
            textBox_patient_firstName.Name = "textBox_patient_firstName";
            textBox_patient_firstName.Size = new Size(100, 23);
            textBox_patient_firstName.TabIndex = 7;
            // 
            // textBox_patient_patronymic
            // 
            textBox_patient_patronymic.Anchor = AnchorStyles.None;
            textBox_patient_patronymic.Location = new Point(100, 128);
            textBox_patient_patronymic.Name = "textBox_patient_patronymic";
            textBox_patient_patronymic.Size = new Size(100, 23);
            textBox_patient_patronymic.TabIndex = 8;
            // 
            // textBox_patient_gender
            // 
            textBox_patient_gender.Anchor = AnchorStyles.None;
            textBox_patient_gender.Location = new Point(100, 184);
            textBox_patient_gender.Name = "textBox_patient_gender";
            textBox_patient_gender.Size = new Size(100, 23);
            textBox_patient_gender.TabIndex = 9;
            // 
            // textBox_patient_birthday
            // 
            textBox_patient_birthday.Anchor = AnchorStyles.None;
            textBox_patient_birthday.Location = new Point(100, 240);
            textBox_patient_birthday.Name = "textBox_patient_birthday";
            textBox_patient_birthday.Size = new Size(100, 23);
            textBox_patient_birthday.TabIndex = 10;
            // 
            // textBox_patient_phoneNumber
            // 
            textBox_patient_phoneNumber.Anchor = AnchorStyles.None;
            textBox_patient_phoneNumber.Location = new Point(100, 296);
            textBox_patient_phoneNumber.Name = "textBox_patient_phoneNumber";
            textBox_patient_phoneNumber.Size = new Size(100, 23);
            textBox_patient_phoneNumber.TabIndex = 11;
            // 
            // textBox_patient_adress
            // 
            textBox_patient_adress.Anchor = AnchorStyles.None;
            textBox_patient_adress.Location = new Point(100, 354);
            textBox_patient_adress.Name = "textBox_patient_adress";
            textBox_patient_adress.Size = new Size(100, 23);
            textBox_patient_adress.TabIndex = 12;
            // 
            // tabControl_patient_medicalDocuments
            // 
            tabControl_patient_medicalDocuments.Controls.Add(tabPage_Patient_MedicalRecords);
            tabControl_patient_medicalDocuments.Controls.Add(tabPage_Patient_ExaminationResult);
            tabControl_patient_medicalDocuments.Dock = DockStyle.Fill;
            tabControl_patient_medicalDocuments.Location = new Point(0, 0);
            tabControl_patient_medicalDocuments.Name = "tabControl_patient_medicalDocuments";
            tabControl_patient_medicalDocuments.SelectedIndex = 0;
            tabControl_patient_medicalDocuments.Size = new Size(580, 395);
            tabControl_patient_medicalDocuments.TabIndex = 3;
            // 
            // tabPage_Patient_MedicalRecords
            // 
            tabPage_Patient_MedicalRecords.Controls.Add(dataGridView_patient_medicalRecords);
            tabPage_Patient_MedicalRecords.Location = new Point(4, 24);
            tabPage_Patient_MedicalRecords.Name = "tabPage_Patient_MedicalRecords";
            tabPage_Patient_MedicalRecords.Padding = new Padding(3);
            tabPage_Patient_MedicalRecords.Size = new Size(572, 367);
            tabPage_Patient_MedicalRecords.TabIndex = 0;
            tabPage_Patient_MedicalRecords.Text = "Приемы";
            tabPage_Patient_MedicalRecords.UseVisualStyleBackColor = true;
            // 
            // dataGridView_patient_medicalRecords
            // 
            dataGridView_patient_medicalRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_patient_medicalRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_patient_medicalRecords.Columns.AddRange(new DataGridViewColumn[] { medicalRecord_date, medicalRecord_diagnosis, medicalRecord_author, medicalRecord_open });
            dataGridView_patient_medicalRecords.Dock = DockStyle.Fill;
            dataGridView_patient_medicalRecords.Location = new Point(3, 3);
            dataGridView_patient_medicalRecords.Name = "dataGridView_patient_medicalRecords";
            dataGridView_patient_medicalRecords.Size = new Size(566, 361);
            dataGridView_patient_medicalRecords.TabIndex = 0;
            // 
            // medicalRecord_date
            // 
            medicalRecord_date.HeaderText = "Дата приема";
            medicalRecord_date.Name = "medicalRecord_date";
            medicalRecord_date.ReadOnly = true;
            medicalRecord_date.Resizable = DataGridViewTriState.True;
            // 
            // medicalRecord_diagnosis
            // 
            medicalRecord_diagnosis.HeaderText = "Диагноз";
            medicalRecord_diagnosis.Name = "medicalRecord_diagnosis";
            medicalRecord_diagnosis.ReadOnly = true;
            medicalRecord_diagnosis.Resizable = DataGridViewTriState.True;
            // 
            // medicalRecord_author
            // 
            medicalRecord_author.HeaderText = "Врач";
            medicalRecord_author.Name = "medicalRecord_author";
            medicalRecord_author.ReadOnly = true;
            // 
            // medicalRecord_open
            // 
            medicalRecord_open.HeaderText = "";
            medicalRecord_open.Name = "medicalRecord_open";
            medicalRecord_open.ReadOnly = true;
            medicalRecord_open.Resizable = DataGridViewTriState.True;
            medicalRecord_open.SortMode = DataGridViewColumnSortMode.Automatic;
            medicalRecord_open.Text = "[ Посмотреть ]";
            // 
            // tabPage_Patient_ExaminationResult
            // 
            tabPage_Patient_ExaminationResult.Controls.Add(dataGridView_patient_examinationResults);
            tabPage_Patient_ExaminationResult.Location = new Point(4, 24);
            tabPage_Patient_ExaminationResult.Name = "tabPage_Patient_ExaminationResult";
            tabPage_Patient_ExaminationResult.Padding = new Padding(3);
            tabPage_Patient_ExaminationResult.Size = new Size(572, 367);
            tabPage_Patient_ExaminationResult.TabIndex = 1;
            tabPage_Patient_ExaminationResult.Text = "Результаты анализов";
            tabPage_Patient_ExaminationResult.UseVisualStyleBackColor = true;
            // 
            // dataGridView_patient_examinationResults
            // 
            dataGridView_patient_examinationResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_patient_examinationResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_patient_examinationResults.Columns.AddRange(new DataGridViewColumn[] { examinationResult_date, examinationResult_type, examinationResult_result, examinationResult_author, examinationResult_open });
            dataGridView_patient_examinationResults.Dock = DockStyle.Fill;
            dataGridView_patient_examinationResults.Location = new Point(3, 3);
            dataGridView_patient_examinationResults.Name = "dataGridView_patient_examinationResults";
            dataGridView_patient_examinationResults.Size = new Size(566, 361);
            dataGridView_patient_examinationResults.TabIndex = 0;
            // 
            // examinationResult_date
            // 
            examinationResult_date.HeaderText = "Дата анализа";
            examinationResult_date.Name = "examinationResult_date";
            examinationResult_date.ReadOnly = true;
            // 
            // examinationResult_type
            // 
            examinationResult_type.HeaderText = "Тип анализа";
            examinationResult_type.Name = "examinationResult_type";
            examinationResult_type.ReadOnly = true;
            // 
            // examinationResult_result
            // 
            examinationResult_result.HeaderText = "Результат";
            examinationResult_result.Name = "examinationResult_result";
            examinationResult_result.ReadOnly = true;
            // 
            // examinationResult_author
            // 
            examinationResult_author.HeaderText = "Врач";
            examinationResult_author.Name = "examinationResult_author";
            examinationResult_author.ReadOnly = true;
            // 
            // examinationResult_open
            // 
            examinationResult_open.HeaderText = "";
            examinationResult_open.Name = "examinationResult_open";
            examinationResult_open.ReadOnly = true;
            examinationResult_open.Resizable = DataGridViewTriState.True;
            examinationResult_open.SortMode = DataGridViewColumnSortMode.Automatic;
            examinationResult_open.Text = "[ Посмотреть ]";
            // 
            // label_formName
            // 
            label_formName.Dock = DockStyle.Fill;
            label_formName.Font = new Font("Segoe UI", 11F);
            label_formName.Location = new Point(0, 0);
            label_formName.Name = "label_formName";
            label_formName.Size = new Size(800, 55);
            label_formName.TabIndex = 2;
            label_formName.Text = "Медицинская карта пациента";
            label_formName.TextAlign = ContentAlignment.MiddleCenter;
            label_formName.Click += label_Form_Name_Click;
            // 
            // PatientCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer_body);
            Controls.Add(panel_Header);
            Name = "PatientCard";
            Text = "Просмотр карты пациента";
            panel_Header.ResumeLayout(false);
            splitContainer_body.Panel1.ResumeLayout(false);
            splitContainer_body.Panel1.PerformLayout();
            splitContainer_body.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer_body).EndInit();
            splitContainer_body.ResumeLayout(false);
            tableLayoutPanel_Patient_Info.ResumeLayout(false);
            tableLayoutPanel_Patient_Info.PerformLayout();
            tabControl_patient_medicalDocuments.ResumeLayout(false);
            tabPage_Patient_MedicalRecords.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_patient_medicalRecords).EndInit();
            tabPage_Patient_ExaminationResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_patient_examinationResults).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_Header;
        private Button button_addMedicalDocument;
        private Button button_changePatientInfo;
        private Button button_back;
        private SplitContainer splitContainer_body;
        private TableLayoutPanel tableLayoutPanel_Patient_Info;
        private Label label_patient_phoneNumber;
        private Label label_patient_firstName;
        private Label label_patient_lastName;
        private TextBox textBox_patient_lastName;
        private Label label_patient_patronymic;
        private Label label_patient_gender;
        private Label label_patient_birthday;
        private Label label_patient_adress;
        private TextBox textBox_patient_firstName;
        private TextBox textBox_patient_patronymic;
        private TextBox textBox_patient_gender;
        private TextBox textBox_patient_birthday;
        private TextBox textBox_patient_phoneNumber;
        private TextBox textBox_patient_adress;
        private TabControl tabControl_patient_medicalDocuments;
        protected internal TabPage tabPage_Patient_MedicalRecords;
        private DataGridView dataGridView_patient_medicalRecords;
        private DataGridViewTextBoxColumn medicalRecord_date;
        private DataGridViewTextBoxColumn medicalRecord_diagnosis;
        private DataGridViewTextBoxColumn medicalRecord_author;
        private DataGridViewButtonColumn medicalRecord_open;
        private TabPage tabPage_Patient_ExaminationResult;
        private DataGridView dataGridView_patient_examinationResults;
        private DataGridViewTextBoxColumn examinationResult_date;
        private DataGridViewTextBoxColumn examinationResult_type;
        private DataGridViewTextBoxColumn examinationResult_result;
        private DataGridViewTextBoxColumn examinationResult_author;
        private DataGridViewButtonColumn examinationResult_open;
        private Label label_formName;
    }
}