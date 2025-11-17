namespace WinForms
{
    partial class PatientCardCreation
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
            panel_patientCardCreation_buttons = new Panel();
            button_patientCardCreation_save = new Button();
            button_patientCardCreation_back = new Button();
            panel_patientCardCreation_header = new Panel();
            label_patientCardCreation_formName = new Label();
            tableLayoutPanel_patientCardCreation_body = new TableLayoutPanel();
            label_patient_phoneNumber = new Label();
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
            label_patient_firstName = new Label();
            label_patient_lastName = new Label();
            panel_patientCardCreation_buttons.SuspendLayout();
            panel_patientCardCreation_header.SuspendLayout();
            tableLayoutPanel_patientCardCreation_body.SuspendLayout();
            SuspendLayout();
            // 
            // panel_patientCardCreation_buttons
            // 
            panel_patientCardCreation_buttons.Controls.Add(button_patientCardCreation_save);
            panel_patientCardCreation_buttons.Controls.Add(button_patientCardCreation_back);
            panel_patientCardCreation_buttons.Dock = DockStyle.Bottom;
            panel_patientCardCreation_buttons.Location = new Point(0, 510);
            panel_patientCardCreation_buttons.Name = "panel_patientCardCreation_buttons";
            panel_patientCardCreation_buttons.Size = new Size(453, 50);
            panel_patientCardCreation_buttons.TabIndex = 3;
            // 
            // button_patientCardCreation_save
            // 
            button_patientCardCreation_save.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_patientCardCreation_save.Location = new Point(363, 10);
            button_patientCardCreation_save.Name = "button_patientCardCreation_save";
            button_patientCardCreation_save.Size = new Size(80, 30);
            button_patientCardCreation_save.TabIndex = 3;
            button_patientCardCreation_save.Text = "Сохранить";
            button_patientCardCreation_save.UseVisualStyleBackColor = true;
            // 
            // button_patientCardCreation_back
            // 
            button_patientCardCreation_back.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_patientCardCreation_back.Location = new Point(277, 10);
            button_patientCardCreation_back.Name = "button_patientCardCreation_back";
            button_patientCardCreation_back.Size = new Size(80, 30);
            button_patientCardCreation_back.TabIndex = 2;
            button_patientCardCreation_back.Text = "Отмена";
            button_patientCardCreation_back.UseVisualStyleBackColor = true;
            // 
            // panel_patientCardCreation_header
            // 
            panel_patientCardCreation_header.Controls.Add(label_patientCardCreation_formName);
            panel_patientCardCreation_header.Dock = DockStyle.Top;
            panel_patientCardCreation_header.Location = new Point(0, 0);
            panel_patientCardCreation_header.Name = "panel_patientCardCreation_header";
            panel_patientCardCreation_header.Size = new Size(453, 55);
            panel_patientCardCreation_header.TabIndex = 4;
            // 
            // label_patientCardCreation_formName
            // 
            label_patientCardCreation_formName.Dock = DockStyle.Fill;
            label_patientCardCreation_formName.Font = new Font("Segoe UI", 11F);
            label_patientCardCreation_formName.Location = new Point(0, 0);
            label_patientCardCreation_formName.Name = "label_patientCardCreation_formName";
            label_patientCardCreation_formName.Size = new Size(453, 55);
            label_patientCardCreation_formName.TabIndex = 3;
            label_patientCardCreation_formName.Text = "Создание медицинской карты";
            label_patientCardCreation_formName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel_patientCardCreation_body
            // 
            tableLayoutPanel_patientCardCreation_body.AutoSize = true;
            tableLayoutPanel_patientCardCreation_body.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel_patientCardCreation_body.ColumnCount = 2;
            tableLayoutPanel_patientCardCreation_body.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.02439F));
            tableLayoutPanel_patientCardCreation_body.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60.97561F));
            tableLayoutPanel_patientCardCreation_body.Controls.Add(label_patient_phoneNumber, 0, 5);
            tableLayoutPanel_patientCardCreation_body.Controls.Add(textBox_patient_lastName, 1, 0);
            tableLayoutPanel_patientCardCreation_body.Controls.Add(label_patient_patronymic, 0, 2);
            tableLayoutPanel_patientCardCreation_body.Controls.Add(label_patient_gender, 0, 3);
            tableLayoutPanel_patientCardCreation_body.Controls.Add(label_patient_birthday, 0, 4);
            tableLayoutPanel_patientCardCreation_body.Controls.Add(label_patient_adress, 0, 6);
            tableLayoutPanel_patientCardCreation_body.Controls.Add(textBox_patient_firstName, 1, 1);
            tableLayoutPanel_patientCardCreation_body.Controls.Add(textBox_patient_patronymic, 1, 2);
            tableLayoutPanel_patientCardCreation_body.Controls.Add(textBox_patient_gender, 1, 3);
            tableLayoutPanel_patientCardCreation_body.Controls.Add(textBox_patient_birthday, 1, 4);
            tableLayoutPanel_patientCardCreation_body.Controls.Add(textBox_patient_phoneNumber, 1, 5);
            tableLayoutPanel_patientCardCreation_body.Controls.Add(textBox_patient_adress, 1, 6);
            tableLayoutPanel_patientCardCreation_body.Controls.Add(label_patient_firstName, 0, 1);
            tableLayoutPanel_patientCardCreation_body.Controls.Add(label_patient_lastName, 0, 0);
            tableLayoutPanel_patientCardCreation_body.Dock = DockStyle.Fill;
            tableLayoutPanel_patientCardCreation_body.Location = new Point(0, 55);
            tableLayoutPanel_patientCardCreation_body.Name = "tableLayoutPanel_patientCardCreation_body";
            tableLayoutPanel_patientCardCreation_body.RowCount = 7;
            tableLayoutPanel_patientCardCreation_body.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel_patientCardCreation_body.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel_patientCardCreation_body.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel_patientCardCreation_body.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel_patientCardCreation_body.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel_patientCardCreation_body.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel_patientCardCreation_body.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel_patientCardCreation_body.Size = new Size(453, 455);
            tableLayoutPanel_patientCardCreation_body.TabIndex = 10;
            // 
            // label_patient_phoneNumber
            // 
            label_patient_phoneNumber.Anchor = AnchorStyles.None;
            label_patient_phoneNumber.AutoSize = true;
            label_patient_phoneNumber.Font = new Font("Segoe UI", 9F);
            label_patient_phoneNumber.Location = new Point(36, 350);
            label_patient_phoneNumber.Name = "label_patient_phoneNumber";
            label_patient_phoneNumber.Size = new Size(104, 15);
            label_patient_phoneNumber.TabIndex = 3;
            label_patient_phoneNumber.Text = "Номер телефона:";
            // 
            // textBox_patient_lastName
            // 
            textBox_patient_lastName.Anchor = AnchorStyles.None;
            textBox_patient_lastName.Font = new Font("Segoe UI", 11F);
            textBox_patient_lastName.Location = new Point(264, 19);
            textBox_patient_lastName.Name = "textBox_patient_lastName";
            textBox_patient_lastName.Size = new Size(100, 27);
            textBox_patient_lastName.TabIndex = 1;
            // 
            // label_patient_patronymic
            // 
            label_patient_patronymic.Anchor = AnchorStyles.None;
            label_patient_patronymic.AutoSize = true;
            label_patient_patronymic.Font = new Font("Segoe UI", 9F);
            label_patient_patronymic.Location = new Point(57, 155);
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
            label_patient_gender.Location = new Point(71, 220);
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
            label_patient_birthday.Location = new Point(40, 285);
            label_patient_birthday.Name = "label_patient_birthday";
            label_patient_birthday.Size = new Size(95, 15);
            label_patient_birthday.TabIndex = 5;
            label_patient_birthday.Text = "День рождения:";
            // 
            // label_patient_adress
            // 
            label_patient_adress.Anchor = AnchorStyles.None;
            label_patient_adress.AutoSize = true;
            label_patient_adress.Font = new Font("Segoe UI", 9F);
            label_patient_adress.Location = new Point(66, 415);
            label_patient_adress.Name = "label_patient_adress";
            label_patient_adress.Size = new Size(43, 15);
            label_patient_adress.TabIndex = 6;
            label_patient_adress.Text = "Адрес:";
            // 
            // textBox_patient_firstName
            // 
            textBox_patient_firstName.Anchor = AnchorStyles.None;
            textBox_patient_firstName.Location = new Point(264, 86);
            textBox_patient_firstName.Name = "textBox_patient_firstName";
            textBox_patient_firstName.Size = new Size(100, 23);
            textBox_patient_firstName.TabIndex = 7;
            // 
            // textBox_patient_patronymic
            // 
            textBox_patient_patronymic.Anchor = AnchorStyles.None;
            textBox_patient_patronymic.Location = new Point(264, 151);
            textBox_patient_patronymic.Name = "textBox_patient_patronymic";
            textBox_patient_patronymic.Size = new Size(100, 23);
            textBox_patient_patronymic.TabIndex = 8;
            // 
            // textBox_patient_gender
            // 
            textBox_patient_gender.Anchor = AnchorStyles.None;
            textBox_patient_gender.Location = new Point(264, 216);
            textBox_patient_gender.Name = "textBox_patient_gender";
            textBox_patient_gender.Size = new Size(100, 23);
            textBox_patient_gender.TabIndex = 9;
            // 
            // textBox_patient_birthday
            // 
            textBox_patient_birthday.Anchor = AnchorStyles.None;
            textBox_patient_birthday.Location = new Point(264, 281);
            textBox_patient_birthday.Name = "textBox_patient_birthday";
            textBox_patient_birthday.Size = new Size(100, 23);
            textBox_patient_birthday.TabIndex = 10;
            // 
            // textBox_patient_phoneNumber
            // 
            textBox_patient_phoneNumber.Anchor = AnchorStyles.None;
            textBox_patient_phoneNumber.Location = new Point(264, 346);
            textBox_patient_phoneNumber.Name = "textBox_patient_phoneNumber";
            textBox_patient_phoneNumber.Size = new Size(100, 23);
            textBox_patient_phoneNumber.TabIndex = 11;
            // 
            // textBox_patient_adress
            // 
            textBox_patient_adress.Anchor = AnchorStyles.None;
            textBox_patient_adress.Location = new Point(264, 411);
            textBox_patient_adress.Name = "textBox_patient_adress";
            textBox_patient_adress.Size = new Size(100, 23);
            textBox_patient_adress.TabIndex = 12;
            // 
            // label_patient_firstName
            // 
            label_patient_firstName.Anchor = AnchorStyles.None;
            label_patient_firstName.AutoSize = true;
            label_patient_firstName.Font = new Font("Segoe UI", 9F);
            label_patient_firstName.Location = new Point(71, 90);
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
            label_patient_lastName.Location = new Point(57, 25);
            label_patient_lastName.Name = "label_patient_lastName";
            label_patient_lastName.Size = new Size(61, 15);
            label_patient_lastName.TabIndex = 0;
            label_patient_lastName.Text = "Фамилия:";
            // 
            // PatientCardCreation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 560);
            Controls.Add(tableLayoutPanel_patientCardCreation_body);
            Controls.Add(panel_patientCardCreation_header);
            Controls.Add(panel_patientCardCreation_buttons);
            Name = "PatientCardCreation";
            Text = "Создание медицинской карты";
            panel_patientCardCreation_buttons.ResumeLayout(false);
            panel_patientCardCreation_header.ResumeLayout(false);
            tableLayoutPanel_patientCardCreation_body.ResumeLayout(false);
            tableLayoutPanel_patientCardCreation_body.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel_patientCardCreation_buttons;
        private Button button_patientCardCreation_save;
        private Button button_patientCardCreation_back;
        private Panel panel_patientCardCreation_header;
        private Label label_patientCardCreation_formName;
        private TableLayoutPanel tableLayoutPanel_patientCardCreation_body;
        private Label label_patient_phoneNumber;
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
        private Label label_patient_firstName;
        private Label label_patient_lastName;
    }
}