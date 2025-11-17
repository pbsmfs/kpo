namespace WinForms
{
    partial class PatientCardsTable
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
            dataGridView1 = new DataGridView();
            panel_Header = new Panel();
            textBox1 = new TextBox();
            button_addMedicalDocument = new Button();
            button_changePatientInfo = new Button();
            button_back = new Button();
            label_formName = new Label();
            dataGridView2 = new DataGridView();
            patientCards_lastName = new DataGridViewTextBoxColumn();
            patientCards_firstName = new DataGridViewTextBoxColumn();
            patientCards_patronymic = new DataGridViewTextBoxColumn();
            patientCards_phoneNumber = new DataGridViewTextBoxColumn();
            patientCards_adress = new DataGridViewTextBoxColumn();
            patientCards_creationDate = new DataGridViewTextBoxColumn();
            patientCards_lastModified = new DataGridViewTextBoxColumn();
            patientCards_open = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(800, 450);
            dataGridView1.TabIndex = 10;
            // 
            // panel_Header
            // 
            panel_Header.Controls.Add(textBox1);
            panel_Header.Controls.Add(button_addMedicalDocument);
            panel_Header.Controls.Add(button_changePatientInfo);
            panel_Header.Controls.Add(button_back);
            panel_Header.Controls.Add(label_formName);
            panel_Header.Dock = DockStyle.Top;
            panel_Header.Location = new Point(0, 0);
            panel_Header.Name = "panel_Header";
            panel_Header.Size = new Size(800, 55);
            panel_Header.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox1.Location = new Point(608, 16);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Поиск по ФИО...";
            textBox1.ScrollBars = ScrollBars.Horizontal;
            textBox1.Size = new Size(180, 23);
            textBox1.TabIndex = 15;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // button_addMedicalDocument
            // 
            button_addMedicalDocument.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button_addMedicalDocument.Image = Properties.Resources.plus;
            button_addMedicalDocument.ImageAlign = ContentAlignment.MiddleLeft;
            button_addMedicalDocument.Location = new Point(1242, 12);
            button_addMedicalDocument.Name = "button_addMedicalDocument";
            button_addMedicalDocument.Size = new Size(130, 0);
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
            button_changePatientInfo.Location = new Point(1146, 12);
            button_changePatientInfo.Name = "button_changePatientInfo";
            button_changePatientInfo.Size = new Size(90, 0);
            button_changePatientInfo.TabIndex = 7;
            button_changePatientInfo.Text = "Изменить";
            button_changePatientInfo.TextImageRelation = TextImageRelation.TextBeforeImage;
            button_changePatientInfo.UseVisualStyleBackColor = true;
            // 
            // button_back
            // 
            button_back.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            button_back.Image = Properties.Resources.log_out;
            button_back.ImageAlign = ContentAlignment.MiddleRight;
            button_back.Location = new Point(12, 11);
            button_back.Name = "button_back";
            button_back.Size = new Size(90, 30);
            button_back.TabIndex = 6;
            button_back.Text = "Выйти";
            button_back.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_back.UseVisualStyleBackColor = true;
            // 
            // label_formName
            // 
            label_formName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_formName.Font = new Font("Segoe UI", 11F);
            label_formName.Location = new Point(0, 0);
            label_formName.Name = "label_formName";
            label_formName.Size = new Size(800, 55);
            label_formName.TabIndex = 2;
            label_formName.Text = "Медицинские карты пациентов";
            label_formName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { patientCards_lastName, patientCards_firstName, patientCards_patronymic, patientCards_phoneNumber, patientCards_adress, patientCards_creationDate, patientCards_lastModified, patientCards_open });
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(0, 55);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(800, 395);
            dataGridView2.TabIndex = 13;
            // 
            // patientCards_lastName
            // 
            patientCards_lastName.HeaderText = "Фамилия";
            patientCards_lastName.Name = "patientCards_lastName";
            patientCards_lastName.ReadOnly = true;
            // 
            // patientCards_firstName
            // 
            patientCards_firstName.HeaderText = "Имя";
            patientCards_firstName.Name = "patientCards_firstName";
            patientCards_firstName.ReadOnly = true;
            // 
            // patientCards_patronymic
            // 
            patientCards_patronymic.HeaderText = "Отчество";
            patientCards_patronymic.Name = "patientCards_patronymic";
            patientCards_patronymic.ReadOnly = true;
            // 
            // patientCards_phoneNumber
            // 
            patientCards_phoneNumber.HeaderText = "Номер телефона";
            patientCards_phoneNumber.Name = "patientCards_phoneNumber";
            patientCards_phoneNumber.ReadOnly = true;
            // 
            // patientCards_adress
            // 
            patientCards_adress.HeaderText = "Адрес";
            patientCards_adress.Name = "patientCards_adress";
            patientCards_adress.ReadOnly = true;
            // 
            // patientCards_creationDate
            // 
            patientCards_creationDate.HeaderText = "Дата создания";
            patientCards_creationDate.Name = "patientCards_creationDate";
            patientCards_creationDate.ReadOnly = true;
            // 
            // patientCards_lastModified
            // 
            patientCards_lastModified.HeaderText = "Дата последнего посещения";
            patientCards_lastModified.Name = "patientCards_lastModified";
            patientCards_lastModified.ReadOnly = true;
            // 
            // patientCards_open
            // 
            patientCards_open.HeaderText = "";
            patientCards_open.Name = "patientCards_open";
            patientCards_open.Text = "[ Посмотреть ]";
            // 
            // PatientCardsTable
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView2);
            Controls.Add(panel_Header);
            Controls.Add(dataGridView1);
            Name = "PatientCardsTable";
            Text = "Список пациентов";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel_Header.ResumeLayout(false);
            panel_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private Panel panel_Header;
        private Button button_addMedicalDocument;
        private Button button_changePatientInfo;
        private Button button_back;
        private DataGridView dataGridView2;
        private TextBox textBox1;
        private DataGridViewTextBoxColumn patientCards_lastName;
        private DataGridViewTextBoxColumn patientCards_firstName;
        private DataGridViewTextBoxColumn patientCards_patronymic;
        private DataGridViewTextBoxColumn patientCards_phoneNumber;
        private DataGridViewTextBoxColumn patientCards_adress;
        private DataGridViewTextBoxColumn patientCards_creationDate;
        private DataGridViewTextBoxColumn patientCards_lastModified;
        private DataGridViewButtonColumn patientCards_open;
        private Label label_formName;
    }
}