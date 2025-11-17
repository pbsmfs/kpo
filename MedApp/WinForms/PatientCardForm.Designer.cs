namespace WinForms
{
    partial class PatientCardForm
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
            button_Form_ChangePatientInfo = new Button();
            label_Form_Name = new Label();
            button_Form_AddMedicalDocument = new Button();
            button_Form_Back = new Button();
            tabPage_Patient_ExaminationResult = new TabPage();
            dataGridView_Patient_ExaminationResults = new DataGridView();
            tabPage_Patient_MedicalRecords = new TabPage();
            dataGridView_Patient_MedicalRecords = new DataGridView();
            tabControl_Patient_MedicalDocuments = new TabControl();
            tableLayoutPanel_Patient_Info = new TableLayoutPanel();
            label_Patient_PhoneNumber = new Label();
            label_Patient_FirstName = new Label();
            label_Patient_LastName = new Label();
            textBox_Patient_LastName = new TextBox();
            label_Patient_Patronymic = new Label();
            Patient_Gender = new Label();
            label_Patient_Birthday = new Label();
            label_Patient_Adress = new Label();
            textBox_Patient_FirstName = new TextBox();
            textBox_Patient_Patronymic = new TextBox();
            textBox_Patient_Gender = new TextBox();
            textBox_Patient_Birthday = new TextBox();
            textBox_Patient_PhoneNumber = new TextBox();
            textBox_Patient_Adress = new TextBox();
            panel_Header.SuspendLayout();
            tabPage_Patient_ExaminationResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Patient_ExaminationResults).BeginInit();
            tabPage_Patient_MedicalRecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Patient_MedicalRecords).BeginInit();
            tabControl_Patient_MedicalDocuments.SuspendLayout();
            tableLayoutPanel_Patient_Info.SuspendLayout();
            SuspendLayout();
            // 
            // panel_Header
            // 
            panel_Header.Controls.Add(button_Form_ChangePatientInfo);
            panel_Header.Controls.Add(label_Form_Name);
            panel_Header.Controls.Add(button_Form_AddMedicalDocument);
            panel_Header.Controls.Add(button_Form_Back);
            panel_Header.Dock = DockStyle.Top;
            panel_Header.Location = new Point(0, 0);
            panel_Header.Name = "panel_Header";
            panel_Header.Size = new Size(784, 55);
            panel_Header.TabIndex = 0;
            // 
            // button_Form_ChangePatientInfo
            // 
            button_Form_ChangePatientInfo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button_Form_ChangePatientInfo.Image = Properties.Resources.pencil;
            button_Form_ChangePatientInfo.ImageAlign = ContentAlignment.MiddleLeft;
            button_Form_ChangePatientInfo.Location = new Point(546, 12);
            button_Form_ChangePatientInfo.Name = "button_Form_ChangePatientInfo";
            button_Form_ChangePatientInfo.Size = new Size(90, 30);
            button_Form_ChangePatientInfo.TabIndex = 3;
            button_Form_ChangePatientInfo.Text = "Изменить";
            button_Form_ChangePatientInfo.TextImageRelation = TextImageRelation.TextBeforeImage;
            button_Form_ChangePatientInfo.UseVisualStyleBackColor = true;
            // 
            // label_Form_Name
            // 
            label_Form_Name.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_Form_Name.AutoSize = true;
            label_Form_Name.Font = new Font("Segoe UI", 11F);
            label_Form_Name.Location = new Point(262, 16);
            label_Form_Name.Name = "label_Form_Name";
            label_Form_Name.Size = new Size(146, 20);
            label_Form_Name.TabIndex = 2;
            label_Form_Name.Text = "Медицинская карта";
            label_Form_Name.TextAlign = ContentAlignment.MiddleCenter;
            label_Form_Name.Click += label_Form_Name_Click;
            // 
            // button_Form_AddMedicalDocument
            // 
            button_Form_AddMedicalDocument.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button_Form_AddMedicalDocument.Image = Properties.Resources.plus;
            button_Form_AddMedicalDocument.ImageAlign = ContentAlignment.MiddleLeft;
            button_Form_AddMedicalDocument.Location = new Point(642, 12);
            button_Form_AddMedicalDocument.Name = "button_Form_AddMedicalDocument";
            button_Form_AddMedicalDocument.Size = new Size(130, 30);
            button_Form_AddMedicalDocument.TabIndex = 1;
            button_Form_AddMedicalDocument.Text = "Добавить запись";
            button_Form_AddMedicalDocument.TextImageRelation = TextImageRelation.TextBeforeImage;
            button_Form_AddMedicalDocument.UseVisualStyleBackColor = true;
            // 
            // button_Form_Back
            // 
            button_Form_Back.Image = Properties.Resources.back_arrow;
            button_Form_Back.ImageAlign = ContentAlignment.MiddleRight;
            button_Form_Back.Location = new Point(12, 12);
            button_Form_Back.Name = "button_Form_Back";
            button_Form_Back.Size = new Size(90, 30);
            button_Form_Back.TabIndex = 0;
            button_Form_Back.Text = "Назад";
            button_Form_Back.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_Form_Back.UseVisualStyleBackColor = true;
            // 
            // tabPage_Patient_ExaminationResult
            // 
            tabPage_Patient_ExaminationResult.Controls.Add(dataGridView_Patient_ExaminationResults);
            tabPage_Patient_ExaminationResult.Location = new Point(4, 24);
            tabPage_Patient_ExaminationResult.Name = "tabPage_Patient_ExaminationResult";
            tabPage_Patient_ExaminationResult.Padding = new Padding(3);
            tabPage_Patient_ExaminationResult.Size = new Size(536, 328);
            tabPage_Patient_ExaminationResult.TabIndex = 1;
            tabPage_Patient_ExaminationResult.Text = "Результаты анализов";
            tabPage_Patient_ExaminationResult.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Patient_ExaminationResults
            // 
            dataGridView_Patient_ExaminationResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Patient_ExaminationResults.Dock = DockStyle.Fill;
            dataGridView_Patient_ExaminationResults.Location = new Point(3, 3);
            dataGridView_Patient_ExaminationResults.Name = "dataGridView_Patient_ExaminationResults";
            dataGridView_Patient_ExaminationResults.Size = new Size(530, 322);
            dataGridView_Patient_ExaminationResults.TabIndex = 0;
            dataGridView_Patient_ExaminationResults.CellContentClick += dataGridView1_CellContentClick;
            // 
            // tabPage_Patient_MedicalRecords
            // 
            tabPage_Patient_MedicalRecords.Controls.Add(dataGridView_Patient_MedicalRecords);
            tabPage_Patient_MedicalRecords.Location = new Point(4, 24);
            tabPage_Patient_MedicalRecords.Name = "tabPage_Patient_MedicalRecords";
            tabPage_Patient_MedicalRecords.Padding = new Padding(3);
            tabPage_Patient_MedicalRecords.Size = new Size(536, 328);
            tabPage_Patient_MedicalRecords.TabIndex = 0;
            tabPage_Patient_MedicalRecords.Text = "Приемы";
            tabPage_Patient_MedicalRecords.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Patient_MedicalRecords
            // 
            dataGridView_Patient_MedicalRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Patient_MedicalRecords.Dock = DockStyle.Fill;
            dataGridView_Patient_MedicalRecords.Location = new Point(3, 3);
            dataGridView_Patient_MedicalRecords.Name = "dataGridView_Patient_MedicalRecords";
            dataGridView_Patient_MedicalRecords.Size = new Size(530, 322);
            dataGridView_Patient_MedicalRecords.TabIndex = 0;
            // 
            // tabControl_Patient_MedicalDocuments
            // 
            tabControl_Patient_MedicalDocuments.Controls.Add(tabPage_Patient_MedicalRecords);
            tabControl_Patient_MedicalDocuments.Controls.Add(tabPage_Patient_ExaminationResult);
            tabControl_Patient_MedicalDocuments.Dock = DockStyle.Right;
            tabControl_Patient_MedicalDocuments.Location = new Point(240, 55);
            tabControl_Patient_MedicalDocuments.Name = "tabControl_Patient_MedicalDocuments";
            tabControl_Patient_MedicalDocuments.SelectedIndex = 0;
            tabControl_Patient_MedicalDocuments.Size = new Size(544, 356);
            tabControl_Patient_MedicalDocuments.TabIndex = 2;
            // 
            // tableLayoutPanel_Patient_Info
            // 
            tableLayoutPanel_Patient_Info.AutoSize = true;
            tableLayoutPanel_Patient_Info.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel_Patient_Info.ColumnCount = 2;
            tableLayoutPanel_Patient_Info.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.02439F));
            tableLayoutPanel_Patient_Info.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60.97561F));
            tableLayoutPanel_Patient_Info.Controls.Add(label_Patient_PhoneNumber, 0, 5);
            tableLayoutPanel_Patient_Info.Controls.Add(label_Patient_FirstName, 0, 1);
            tableLayoutPanel_Patient_Info.Controls.Add(label_Patient_LastName, 0, 0);
            tableLayoutPanel_Patient_Info.Controls.Add(textBox_Patient_LastName, 1, 0);
            tableLayoutPanel_Patient_Info.Controls.Add(label_Patient_Patronymic, 0, 2);
            tableLayoutPanel_Patient_Info.Controls.Add(Patient_Gender, 0, 3);
            tableLayoutPanel_Patient_Info.Controls.Add(label_Patient_Birthday, 0, 4);
            tableLayoutPanel_Patient_Info.Controls.Add(label_Patient_Adress, 0, 6);
            tableLayoutPanel_Patient_Info.Controls.Add(textBox_Patient_FirstName, 1, 1);
            tableLayoutPanel_Patient_Info.Controls.Add(textBox_Patient_Patronymic, 1, 2);
            tableLayoutPanel_Patient_Info.Controls.Add(textBox_Patient_Gender, 1, 3);
            tableLayoutPanel_Patient_Info.Controls.Add(textBox_Patient_Birthday, 1, 4);
            tableLayoutPanel_Patient_Info.Controls.Add(textBox_Patient_PhoneNumber, 1, 5);
            tableLayoutPanel_Patient_Info.Controls.Add(textBox_Patient_Adress, 1, 6);
            tableLayoutPanel_Patient_Info.Dock = DockStyle.Fill;
            tableLayoutPanel_Patient_Info.Location = new Point(0, 55);
            tableLayoutPanel_Patient_Info.Name = "tableLayoutPanel_Patient_Info";
            tableLayoutPanel_Patient_Info.Padding = new Padding(10);
            tableLayoutPanel_Patient_Info.RowCount = 7;
            tableLayoutPanel_Patient_Info.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel_Patient_Info.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel_Patient_Info.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel_Patient_Info.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel_Patient_Info.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel_Patient_Info.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel_Patient_Info.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel_Patient_Info.Size = new Size(240, 356);
            tableLayoutPanel_Patient_Info.TabIndex = 8;
            // 
            // label_Patient_PhoneNumber
            // 
            label_Patient_PhoneNumber.Anchor = AnchorStyles.None;
            label_Patient_PhoneNumber.AutoSize = true;
            label_Patient_PhoneNumber.Font = new Font("Segoe UI", 9F);
            label_Patient_PhoneNumber.Location = new Point(21, 259);
            label_Patient_PhoneNumber.Name = "label_Patient_PhoneNumber";
            label_Patient_PhoneNumber.Size = new Size(63, 30);
            label_Patient_PhoneNumber.TabIndex = 3;
            label_Patient_PhoneNumber.Text = "Номер телефона:";
            // 
            // label_Patient_FirstName
            // 
            label_Patient_FirstName.Anchor = AnchorStyles.None;
            label_Patient_FirstName.AutoSize = true;
            label_Patient_FirstName.Font = new Font("Segoe UI", 9F);
            label_Patient_FirstName.Location = new Point(35, 74);
            label_Patient_FirstName.Name = "label_Patient_FirstName";
            label_Patient_FirstName.Size = new Size(34, 15);
            label_Patient_FirstName.TabIndex = 2;
            label_Patient_FirstName.Text = "Имя:";
            // 
            // label_Patient_LastName
            // 
            label_Patient_LastName.Anchor = AnchorStyles.None;
            label_Patient_LastName.AutoSize = true;
            label_Patient_LastName.Font = new Font("Segoe UI", 9F);
            label_Patient_LastName.Location = new Point(22, 26);
            label_Patient_LastName.Name = "label_Patient_LastName";
            label_Patient_LastName.Size = new Size(61, 15);
            label_Patient_LastName.TabIndex = 0;
            label_Patient_LastName.Text = "Фамилия:";
            // 
            // textBox_Patient_LastName
            // 
            textBox_Patient_LastName.Anchor = AnchorStyles.None;
            textBox_Patient_LastName.Font = new Font("Segoe UI", 11F);
            textBox_Patient_LastName.Location = new Point(112, 20);
            textBox_Patient_LastName.Name = "textBox_Patient_LastName";
            textBox_Patient_LastName.Size = new Size(100, 27);
            textBox_Patient_LastName.TabIndex = 1;
            // 
            // label_Patient_Patronymic
            // 
            label_Patient_Patronymic.Anchor = AnchorStyles.None;
            label_Patient_Patronymic.AutoSize = true;
            label_Patient_Patronymic.Font = new Font("Segoe UI", 9F);
            label_Patient_Patronymic.Location = new Point(22, 122);
            label_Patient_Patronymic.Name = "label_Patient_Patronymic";
            label_Patient_Patronymic.Size = new Size(61, 15);
            label_Patient_Patronymic.TabIndex = 3;
            label_Patient_Patronymic.Text = "Отчество:";
            // 
            // Patient_Gender
            // 
            Patient_Gender.Anchor = AnchorStyles.None;
            Patient_Gender.AutoSize = true;
            Patient_Gender.Font = new Font("Segoe UI", 9F);
            Patient_Gender.Location = new Point(36, 170);
            Patient_Gender.Name = "Patient_Gender";
            Patient_Gender.Size = new Size(33, 15);
            Patient_Gender.TabIndex = 4;
            Patient_Gender.Text = "Пол:";
            // 
            // label_Patient_Birthday
            // 
            label_Patient_Birthday.Anchor = AnchorStyles.None;
            label_Patient_Birthday.AutoSize = true;
            label_Patient_Birthday.Font = new Font("Segoe UI", 9F);
            label_Patient_Birthday.Location = new Point(20, 211);
            label_Patient_Birthday.Name = "label_Patient_Birthday";
            label_Patient_Birthday.Size = new Size(65, 30);
            label_Patient_Birthday.TabIndex = 5;
            label_Patient_Birthday.Text = "День рождения:";
            // 
            // label_Patient_Adress
            // 
            label_Patient_Adress.Anchor = AnchorStyles.None;
            label_Patient_Adress.AutoSize = true;
            label_Patient_Adress.Font = new Font("Segoe UI", 9F);
            label_Patient_Adress.Location = new Point(33, 314);
            label_Patient_Adress.Name = "label_Patient_Adress";
            label_Patient_Adress.Size = new Size(38, 15);
            label_Patient_Adress.TabIndex = 6;
            label_Patient_Adress.Text = "label1";
            // 
            // textBox_Patient_FirstName
            // 
            textBox_Patient_FirstName.Anchor = AnchorStyles.None;
            textBox_Patient_FirstName.Location = new Point(112, 70);
            textBox_Patient_FirstName.Name = "textBox_Patient_FirstName";
            textBox_Patient_FirstName.Size = new Size(100, 23);
            textBox_Patient_FirstName.TabIndex = 7;
            // 
            // textBox_Patient_Patronymic
            // 
            textBox_Patient_Patronymic.Anchor = AnchorStyles.None;
            textBox_Patient_Patronymic.Location = new Point(112, 118);
            textBox_Patient_Patronymic.Name = "textBox_Patient_Patronymic";
            textBox_Patient_Patronymic.Size = new Size(100, 23);
            textBox_Patient_Patronymic.TabIndex = 8;
            // 
            // textBox_Patient_Gender
            // 
            textBox_Patient_Gender.Anchor = AnchorStyles.None;
            textBox_Patient_Gender.Location = new Point(112, 166);
            textBox_Patient_Gender.Name = "textBox_Patient_Gender";
            textBox_Patient_Gender.Size = new Size(100, 23);
            textBox_Patient_Gender.TabIndex = 9;
            // 
            // textBox_Patient_Birthday
            // 
            textBox_Patient_Birthday.Anchor = AnchorStyles.None;
            textBox_Patient_Birthday.Location = new Point(112, 214);
            textBox_Patient_Birthday.Name = "textBox_Patient_Birthday";
            textBox_Patient_Birthday.Size = new Size(100, 23);
            textBox_Patient_Birthday.TabIndex = 10;
            // 
            // textBox_Patient_PhoneNumber
            // 
            textBox_Patient_PhoneNumber.Anchor = AnchorStyles.None;
            textBox_Patient_PhoneNumber.Location = new Point(112, 262);
            textBox_Patient_PhoneNumber.Name = "textBox_Patient_PhoneNumber";
            textBox_Patient_PhoneNumber.Size = new Size(100, 23);
            textBox_Patient_PhoneNumber.TabIndex = 11;
            // 
            // textBox_Patient_Adress
            // 
            textBox_Patient_Adress.Anchor = AnchorStyles.None;
            textBox_Patient_Adress.Location = new Point(112, 310);
            textBox_Patient_Adress.Name = "textBox_Patient_Adress";
            textBox_Patient_Adress.Size = new Size(100, 23);
            textBox_Patient_Adress.TabIndex = 12;
            // 
            // PatientCardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 411);
            Controls.Add(tableLayoutPanel_Patient_Info);
            Controls.Add(tabControl_Patient_MedicalDocuments);
            Controls.Add(panel_Header);
            Name = "PatientCardForm";
            Text = "PatientCardForm";
            panel_Header.ResumeLayout(false);
            panel_Header.PerformLayout();
            tabPage_Patient_ExaminationResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_Patient_ExaminationResults).EndInit();
            tabPage_Patient_MedicalRecords.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_Patient_MedicalRecords).EndInit();
            tabControl_Patient_MedicalDocuments.ResumeLayout(false);
            tableLayoutPanel_Patient_Info.ResumeLayout(false);
            tableLayoutPanel_Patient_Info.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel_Header;
        private Button button_Form_AddMedicalDocument;
        private Button button_Form_Back;
        private Label label_Form_Name;
        private Button button_Form_ChangePatientInfo;
        private TabPage tabPage_Patient_ExaminationResult;
        private DataGridView dataGridView_Patient_ExaminationResults;
        protected internal TabPage tabPage_Patient_MedicalRecords;
        private TabControl tabControl_Patient_MedicalDocuments;
        private DataGridView dataGridView_Patient_MedicalRecords;
        private TableLayoutPanel tableLayoutPanel_Patient_Info;
        private Label label_Patient_PhoneNumber;
        private Label label_Patient_FirstName;
        private Label label_Patient_LastName;
        private TextBox textBox_Patient_LastName;
        private Label label_Patient_Patronymic;
        private Label Patient_Gender;
        private Label label_Patient_Birthday;
        private Label label_Patient_Adress;
        private TextBox textBox_Patient_FirstName;
        private TextBox textBox_Patient_Patronymic;
        private TextBox textBox_Patient_Gender;
        private TextBox textBox_Patient_Birthday;
        private TextBox textBox_Patient_PhoneNumber;
        private TextBox textBox_Patient_Adress;
    }
}