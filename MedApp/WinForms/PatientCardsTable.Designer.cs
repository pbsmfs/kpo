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
            button_patientCardsTable_addCard = new Button();
            button_patientCardsTable_back = new Button();
            label_patientCards_formName = new Label();
            dataGridView_patientCardsTable = new DataGridView();
            column_patientCards_id = new DataGridViewTextBoxColumn();
            column_patientCards_lastName = new DataGridViewTextBoxColumn();
            column_patientCards_firstName = new DataGridViewTextBoxColumn();
            column_patientCards_patronymic = new DataGridViewTextBoxColumn();
            column_patientCards_phoneNumber = new DataGridViewTextBoxColumn();
            column_patientCards_adress = new DataGridViewTextBoxColumn();
            column_patientCards_creationDate = new DataGridViewTextBoxColumn();
            column_patientCards_lastModified = new DataGridViewTextBoxColumn();
            column_patientCards_open = new DataGridViewButtonColumn();
            panel_patinetCards_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_patientCardsTable).BeginInit();
            SuspendLayout();
            // 
            // panel_patinetCards_header
            // 
            panel_patinetCards_header.Controls.Add(button_patientCardsTable_addCard);
            panel_patinetCards_header.Controls.Add(button_patientCardsTable_back);
            panel_patinetCards_header.Controls.Add(label_patientCards_formName);
            panel_patinetCards_header.Dock = DockStyle.Top;
            panel_patinetCards_header.Location = new Point(0, 0);
            panel_patinetCards_header.Name = "panel_patinetCards_header";
            panel_patinetCards_header.Size = new Size(800, 55);
            panel_patinetCards_header.TabIndex = 11;
            // 
            // button_patientCardsTable_addCard
            // 
            button_patientCardsTable_addCard.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_patientCardsTable_addCard.Image = Properties.Resources.plus;
            button_patientCardsTable_addCard.ImageAlign = ContentAlignment.MiddleLeft;
            button_patientCardsTable_addCard.Location = new Point(658, 11);
            button_patientCardsTable_addCard.Name = "button_patientCardsTable_addCard";
            button_patientCardsTable_addCard.Size = new Size(130, 30);
            button_patientCardsTable_addCard.TabIndex = 16;
            button_patientCardsTable_addCard.Text = "Добавить карту";
            button_patientCardsTable_addCard.TextImageRelation = TextImageRelation.TextBeforeImage;
            button_patientCardsTable_addCard.UseVisualStyleBackColor = true;
            // 
            // button_patientCardsTable_back
            // 
            button_patientCardsTable_back.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            button_patientCardsTable_back.Image = Properties.Resources.log_out;
            button_patientCardsTable_back.ImageAlign = ContentAlignment.MiddleRight;
            button_patientCardsTable_back.Location = new Point(12, 11);
            button_patientCardsTable_back.Name = "button_patientCardsTable_back";
            button_patientCardsTable_back.Size = new Size(90, 30);
            button_patientCardsTable_back.TabIndex = 6;
            button_patientCardsTable_back.Text = "Выйти";
            button_patientCardsTable_back.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_patientCardsTable_back.UseVisualStyleBackColor = true;
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
            dataGridView_patientCardsTable.Columns.AddRange(new DataGridViewColumn[] { column_patientCards_id, column_patientCards_lastName, column_patientCards_firstName, column_patientCards_patronymic, column_patientCards_phoneNumber, column_patientCards_adress, column_patientCards_creationDate, column_patientCards_lastModified, column_patientCards_open });
            dataGridView_patientCardsTable.Dock = DockStyle.Fill;
            dataGridView_patientCardsTable.Location = new Point(0, 55);
            dataGridView_patientCardsTable.Name = "dataGridView_patientCardsTable";
            dataGridView_patientCardsTable.ReadOnly = true;
            dataGridView_patientCardsTable.Size = new Size(800, 395);
            dataGridView_patientCardsTable.TabIndex = 13;
            // 
            // column_patientCards_id
            // 
            column_patientCards_id.HeaderText = "ID";
            column_patientCards_id.Name = "column_patientCards_id";
            column_patientCards_id.ReadOnly = true;
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
            // PatientCardsTable
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView_patientCardsTable);
            Controls.Add(panel_patinetCards_header);
            Name = "PatientCardsTable";
            Text = "Список пациентов";
            panel_patinetCards_header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_patientCardsTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_patinetCards_header;
        private Button button_patientCardsTable_back;
        private Label label_patientCards_formName;
        private DataGridView dataGridView_patientCardsTable;
        private Button button_patientCardsTable_addCard;
        private DataGridViewTextBoxColumn column_patientCards_id;
        private DataGridViewTextBoxColumn column_patientCards_lastName;
        private DataGridViewTextBoxColumn column_patientCards_firstName;
        private DataGridViewTextBoxColumn column_patientCards_patronymic;
        private DataGridViewTextBoxColumn column_patientCards_phoneNumber;
        private DataGridViewTextBoxColumn column_patientCards_adress;
        private DataGridViewTextBoxColumn column_patientCards_creationDate;
        private DataGridViewTextBoxColumn column_patientCards_lastModified;
        private DataGridViewButtonColumn column_patientCards_open;
    }
}