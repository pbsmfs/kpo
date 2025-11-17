namespace WinForms
{
    partial class PatientCardsTable
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panel_patinetCards_header = new Panel();
            textBox_patientCards_findByFIO = new TextBox();
            button_patintCardsTable_back = new Button();
            label_patientCards_formName = new Label();
            dataGridView_patientCardsTable = new DataGridView();
            column_patientCards_lastName = new DataGridViewTextBoxColumn();
            column_patientCards_firstName = new DataGridViewTextBoxColumn();
            column_patientCards_patronymic = new DataGridViewTextBoxColumn();
            column_patientCards_phoneNumber = new DataGridViewTextBoxColumn();
            column_patientCards_adress = new DataGridViewTextBoxColumn();
            column_patientCards_creationDate = new DataGridViewTextBoxColumn();
            column_patientCards_lastModified = new DataGridViewTextBoxColumn();
            column_patientCards_open = new DataGridViewButtonColumn();
            panel1 = new Panel();
            button_patientCardsTable_addCard = new Button();
            panel_patinetCards_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_patientCardsTable).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel_patinetCards_header
            // 
            panel_patinetCards_header.Controls.Add(button_patintCardsTable_back);
            panel_patinetCards_header.Controls.Add(label_patientCards_formName);
            panel_patinetCards_header.Dock = DockStyle.Top;
            panel_patinetCards_header.Location = new Point(0, 0);
            panel_patinetCards_header.Name = "panel_patinetCards_header";
            panel_patinetCards_header.Size = new Size(800, 55);
            panel_patinetCards_header.TabIndex = 11;
            // 
            // textBox_patientCards_findByFIO
            // 
            textBox_patientCards_findByFIO.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            textBox_patientCards_findByFIO.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox_patientCards_findByFIO.Location = new Point(12, 15);
            textBox_patientCards_findByFIO.Name = "textBox_patientCards_findByFIO";
            textBox_patientCards_findByFIO.PlaceholderText = "Поиск по ФИО...";
            textBox_patientCards_findByFIO.ScrollBars = ScrollBars.Horizontal;
            textBox_patientCards_findByFIO.Size = new Size(180, 23);
            textBox_patientCards_findByFIO.TabIndex = 15;
            textBox_patientCards_findByFIO.TextAlign = HorizontalAlignment.Center;
            // 
            // button_patintCardsTable_back
            // 
            button_patintCardsTable_back.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            button_patintCardsTable_back.Image = Properties.Resources.log_out;
            button_patintCardsTable_back.ImageAlign = ContentAlignment.MiddleRight;
            button_patintCardsTable_back.Location = new Point(12, 11);
            button_patintCardsTable_back.Name = "button_patintCardsTable_back";
            button_patintCardsTable_back.Size = new Size(90, 30);
            button_patintCardsTable_back.TabIndex = 6;
            button_patintCardsTable_back.Text = "Выйти";
            button_patintCardsTable_back.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_patintCardsTable_back.UseVisualStyleBackColor = true;
            // 
            // label_patientCards_formName
            // 
            label_patientCards_formName.Dock = DockStyle.Fill;
            label_patientCards_formName.Font = new Font("Segoe UI", 11F);
            label_patientCards_formName.Location = new Point(0, 0);
            label_patientCards_formName.Name = "label_patientCards_formName";
            label_patientCards_formName.Size = new Size(800, 55);
            label_patientCards_formName.TabIndex = 2;
            label_patientCards_formName.Text = "Медицинские карты пациентов";
            label_patientCards_formName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView_patientCardsTable
            // 
            dataGridView_patientCardsTable.AllowUserToAddRows = false;
            dataGridView_patientCardsTable.AllowUserToDeleteRows = false;
            dataGridView_patientCardsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_patientCardsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_patientCardsTable.Columns.AddRange(new DataGridViewColumn[] { column_patientCards_lastName, column_patientCards_firstName, column_patientCards_patronymic, column_patientCards_phoneNumber, column_patientCards_adress, column_patientCards_creationDate, column_patientCards_lastModified, column_patientCards_open });
            dataGridView_patientCardsTable.Dock = DockStyle.Fill;
            dataGridView_patientCardsTable.Location = new Point(0, 55);
            dataGridView_patientCardsTable.Name = "dataGridView_patientCardsTable";
            dataGridView_patientCardsTable.ReadOnly = true;
            dataGridView_patientCardsTable.Size = new Size(800, 395);
            dataGridView_patientCardsTable.TabIndex = 13;
            // 
            // column_patientCards_lastName
            // 
            column_patientCards_lastName.HeaderText = "Фамилия";
            column_patientCards_lastName.Name = "column_patientCards_lastName";
            column_patientCards_lastName.ReadOnly = true;
            // 
            // column_patientCards_firstName
            // 
            column_patientCards_firstName.HeaderText = "Имя";
            column_patientCards_firstName.Name = "column_patientCards_firstName";
            column_patientCards_firstName.ReadOnly = true;
            // 
            // column_patientCards_patronymic
            // 
            column_patientCards_patronymic.HeaderText = "Отчество";
            column_patientCards_patronymic.Name = "column_patientCards_patronymic";
            column_patientCards_patronymic.ReadOnly = true;
            // 
            // column_patientCards_phoneNumber
            // 
            column_patientCards_phoneNumber.HeaderText = "Номер телефона";
            column_patientCards_phoneNumber.Name = "column_patientCards_phoneNumber";
            column_patientCards_phoneNumber.ReadOnly = true;
            // 
            // column_patientCards_adress
            // 
            column_patientCards_adress.HeaderText = "Адрес";
            column_patientCards_adress.Name = "column_patientCards_adress";
            column_patientCards_adress.ReadOnly = true;
            // 
            // column_patientCards_creationDate
            // 
            column_patientCards_creationDate.HeaderText = "Дата создания";
            column_patientCards_creationDate.Name = "column_patientCards_creationDate";
            column_patientCards_creationDate.ReadOnly = true;
            // 
            // column_patientCards_lastModified
            // 
            column_patientCards_lastModified.HeaderText = "Дата последнего посещения";
            column_patientCards_lastModified.Name = "column_patientCards_lastModified";
            column_patientCards_lastModified.ReadOnly = true;
            // 
            // column_patientCards_open
            // 
            column_patientCards_open.HeaderText = "";
            column_patientCards_open.Name = "column_patientCards_open";
            column_patientCards_open.ReadOnly = true;
            column_patientCards_open.Text = "Посмотреть";
            column_patientCards_open.UseColumnTextForButtonValue = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(button_patientCardsTable_addCard);
            panel1.Controls.Add(textBox_patientCards_findByFIO);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 400);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 50);
            panel1.TabIndex = 14;
            // 
            // button_patientCardsTable_addCard
            // 
            button_patientCardsTable_addCard.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_patientCardsTable_addCard.Image = Properties.Resources.plus;
            button_patientCardsTable_addCard.ImageAlign = ContentAlignment.MiddleLeft;
            button_patientCardsTable_addCard.Location = new Point(658, 10);
            button_patientCardsTable_addCard.Name = "button_patientCardsTable_addCard";
            button_patientCardsTable_addCard.Size = new Size(130, 30);
            button_patientCardsTable_addCard.TabIndex = 16;
            button_patientCardsTable_addCard.Text = "Добавить карту";
            button_patientCardsTable_addCard.TextImageRelation = TextImageRelation.TextBeforeImage;
            button_patientCardsTable_addCard.UseVisualStyleBackColor = true;
            // 
            // PatientCardsTable
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(dataGridView_patientCardsTable);
            Controls.Add(panel_patinetCards_header);
            Name = "PatientCardsTable";
            Text = "Список пациентов";
            panel_patinetCards_header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_patientCardsTable).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_patinetCards_header;
        private TextBox textBox_patientCards_findByFIO;
        private Button button_patintCardsTable_back;
        private Label label_patientCards_formName;
        private DataGridView dataGridView_patientCardsTable;
        private DataGridViewTextBoxColumn column_patientCards_lastName;
        private DataGridViewTextBoxColumn column_patientCards_firstName;
        private DataGridViewTextBoxColumn column_patientCards_patronymic;
        private DataGridViewTextBoxColumn column_patientCards_phoneNumber;
        private DataGridViewTextBoxColumn column_patientCards_adress;
        private DataGridViewTextBoxColumn column_patientCards_creationDate;
        private DataGridViewTextBoxColumn column_patientCards_lastModified;
        private DataGridViewButtonColumn column_patientCards_open;
        private Panel panel1;
        private Button button_patientCardsTable_addCard;
    }
}