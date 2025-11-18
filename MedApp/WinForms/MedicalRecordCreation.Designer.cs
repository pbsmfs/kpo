namespace WinForms
{
    partial class MedicalRecordCreation
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
            panel_medicalRecordCreation_header = new Panel();
            label_medicalRecordCreation_formName = new Label();
            button_medicalRecordCreation_back = new Button();
            button_medicalRecordCration_save = new Button();
            panel_medicalRecordCreation_buttons = new Panel();
            tableLayoutPanel_MedicalRecordCreation_body = new TableLayoutPanel();
            textBox_medicalRecord_treatment = new TextBox();
            textBox_medicalRecord_symtpoms = new TextBox();
            label_medicalRecord_symtpoms = new Label();
            label_medicalRecord_disagnosis = new Label();
            textBox_medicalRecord_diagnosis = new TextBox();
            label_medicalRecord_treatment = new Label();
            panel_medicalRecordCreation_header.SuspendLayout();
            panel_medicalRecordCreation_buttons.SuspendLayout();
            tableLayoutPanel_MedicalRecordCreation_body.SuspendLayout();
            SuspendLayout();
            // 
            // panel_medicalRecordCreation_header
            // 
            panel_medicalRecordCreation_header.Controls.Add(label_medicalRecordCreation_formName);
            panel_medicalRecordCreation_header.Dock = DockStyle.Top;
            panel_medicalRecordCreation_header.Location = new Point(0, 0);
            panel_medicalRecordCreation_header.Name = "panel_medicalRecordCreation_header";
            panel_medicalRecordCreation_header.Size = new Size(384, 55);
            panel_medicalRecordCreation_header.TabIndex = 0;
            // 
            // label_medicalRecordCreation_formName
            // 
            label_medicalRecordCreation_formName.Dock = DockStyle.Fill;
            label_medicalRecordCreation_formName.Font = new Font("Segoe UI", 11F);
            label_medicalRecordCreation_formName.Location = new Point(0, 0);
            label_medicalRecordCreation_formName.Name = "label_medicalRecordCreation_formName";
            label_medicalRecordCreation_formName.Size = new Size(384, 55);
            label_medicalRecordCreation_formName.TabIndex = 2;
            label_medicalRecordCreation_formName.Text = "Создание записи приема";
            label_medicalRecordCreation_formName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button_medicalRecordCreation_back
            // 
            button_medicalRecordCreation_back.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_medicalRecordCreation_back.Location = new Point(208, 10);
            button_medicalRecordCreation_back.Name = "button_medicalRecordCreation_back";
            button_medicalRecordCreation_back.Size = new Size(80, 30);
            button_medicalRecordCreation_back.TabIndex = 0;
            button_medicalRecordCreation_back.Text = "Отмена";
            button_medicalRecordCreation_back.UseVisualStyleBackColor = true;
            // 
            // button_medicalRecordCration_save
            // 
            button_medicalRecordCration_save.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_medicalRecordCration_save.Location = new Point(294, 10);
            button_medicalRecordCration_save.Name = "button_medicalRecordCration_save";
            button_medicalRecordCration_save.Size = new Size(80, 30);
            button_medicalRecordCration_save.TabIndex = 1;
            button_medicalRecordCration_save.Text = "Сохранить";
            button_medicalRecordCration_save.UseVisualStyleBackColor = true;
            // 
            // panel_medicalRecordCreation_buttons
            // 
            panel_medicalRecordCreation_buttons.Controls.Add(button_medicalRecordCration_save);
            panel_medicalRecordCreation_buttons.Controls.Add(button_medicalRecordCreation_back);
            panel_medicalRecordCreation_buttons.Dock = DockStyle.Bottom;
            panel_medicalRecordCreation_buttons.Location = new Point(0, 511);
            panel_medicalRecordCreation_buttons.Name = "panel_medicalRecordCreation_buttons";
            panel_medicalRecordCreation_buttons.Size = new Size(384, 50);
            panel_medicalRecordCreation_buttons.TabIndex = 2;
            // 
            // tableLayoutPanel_MedicalRecordCreation_body
            // 
            tableLayoutPanel_MedicalRecordCreation_body.AutoSize = true;
            tableLayoutPanel_MedicalRecordCreation_body.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel_MedicalRecordCreation_body.ColumnCount = 2;
            tableLayoutPanel_MedicalRecordCreation_body.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.6335545F));
            tableLayoutPanel_MedicalRecordCreation_body.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.36645F));
            tableLayoutPanel_MedicalRecordCreation_body.Controls.Add(textBox_medicalRecord_treatment, 1, 2);
            tableLayoutPanel_MedicalRecordCreation_body.Controls.Add(textBox_medicalRecord_symtpoms, 1, 1);
            tableLayoutPanel_MedicalRecordCreation_body.Controls.Add(label_medicalRecord_symtpoms, 0, 1);
            tableLayoutPanel_MedicalRecordCreation_body.Controls.Add(label_medicalRecord_disagnosis, 0, 0);
            tableLayoutPanel_MedicalRecordCreation_body.Controls.Add(textBox_medicalRecord_diagnosis, 1, 0);
            tableLayoutPanel_MedicalRecordCreation_body.Controls.Add(label_medicalRecord_treatment, 0, 2);
            tableLayoutPanel_MedicalRecordCreation_body.Dock = DockStyle.Fill;
            tableLayoutPanel_MedicalRecordCreation_body.Location = new Point(0, 55);
            tableLayoutPanel_MedicalRecordCreation_body.Name = "tableLayoutPanel_MedicalRecordCreation_body";
            tableLayoutPanel_MedicalRecordCreation_body.RowCount = 3;
            tableLayoutPanel_MedicalRecordCreation_body.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel_MedicalRecordCreation_body.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel_MedicalRecordCreation_body.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel_MedicalRecordCreation_body.Size = new Size(384, 456);
            tableLayoutPanel_MedicalRecordCreation_body.TabIndex = 12;
            // 
            // textBox_medicalRecord_treatment
            // 
            textBox_medicalRecord_treatment.Anchor = AnchorStyles.None;
            textBox_medicalRecord_treatment.Font = new Font("Segoe UI", 11F);
            textBox_medicalRecord_treatment.Location = new Point(93, 314);
            textBox_medicalRecord_treatment.Margin = new Padding(10);
            textBox_medicalRecord_treatment.Multiline = true;
            textBox_medicalRecord_treatment.Name = "textBox_medicalRecord_treatment";
            textBox_medicalRecord_treatment.Size = new Size(281, 132);
            textBox_medicalRecord_treatment.TabIndex = 5;
            // 
            // textBox_medicalRecord_symtpoms
            // 
            textBox_medicalRecord_symtpoms.Anchor = AnchorStyles.None;
            textBox_medicalRecord_symtpoms.Font = new Font("Segoe UI", 11F);
            textBox_medicalRecord_symtpoms.Location = new Point(93, 162);
            textBox_medicalRecord_symtpoms.Margin = new Padding(10);
            textBox_medicalRecord_symtpoms.Multiline = true;
            textBox_medicalRecord_symtpoms.Name = "textBox_medicalRecord_symtpoms";
            textBox_medicalRecord_symtpoms.Size = new Size(281, 131);
            textBox_medicalRecord_symtpoms.TabIndex = 4;
            // 
            // label_medicalRecord_symtpoms
            // 
            label_medicalRecord_symtpoms.Anchor = AnchorStyles.None;
            label_medicalRecord_symtpoms.AutoSize = true;
            label_medicalRecord_symtpoms.Font = new Font("Segoe UI", 9F);
            label_medicalRecord_symtpoms.Location = new Point(6, 220);
            label_medicalRecord_symtpoms.Name = "label_medicalRecord_symtpoms";
            label_medicalRecord_symtpoms.Size = new Size(71, 15);
            label_medicalRecord_symtpoms.TabIndex = 2;
            label_medicalRecord_symtpoms.Text = "Симптомы:";
            // 
            // label_medicalRecord_disagnosis
            // 
            label_medicalRecord_disagnosis.Anchor = AnchorStyles.None;
            label_medicalRecord_disagnosis.AutoSize = true;
            label_medicalRecord_disagnosis.Font = new Font("Segoe UI", 9F);
            label_medicalRecord_disagnosis.Location = new Point(14, 68);
            label_medicalRecord_disagnosis.Name = "label_medicalRecord_disagnosis";
            label_medicalRecord_disagnosis.Size = new Size(55, 15);
            label_medicalRecord_disagnosis.TabIndex = 0;
            label_medicalRecord_disagnosis.Text = "Диагноз:";
            // 
            // textBox_medicalRecord_diagnosis
            // 
            textBox_medicalRecord_diagnosis.Anchor = AnchorStyles.None;
            textBox_medicalRecord_diagnosis.Font = new Font("Segoe UI", 11F);
            textBox_medicalRecord_diagnosis.Location = new Point(93, 10);
            textBox_medicalRecord_diagnosis.Margin = new Padding(10);
            textBox_medicalRecord_diagnosis.Multiline = true;
            textBox_medicalRecord_diagnosis.Name = "textBox_medicalRecord_diagnosis";
            textBox_medicalRecord_diagnosis.Size = new Size(281, 131);
            textBox_medicalRecord_diagnosis.TabIndex = 1;
            // 
            // label_medicalRecord_treatment
            // 
            label_medicalRecord_treatment.Anchor = AnchorStyles.None;
            label_medicalRecord_treatment.AutoSize = true;
            label_medicalRecord_treatment.Font = new Font("Segoe UI", 9F);
            label_medicalRecord_treatment.Location = new Point(4, 365);
            label_medicalRecord_treatment.Name = "label_medicalRecord_treatment";
            label_medicalRecord_treatment.Size = new Size(74, 30);
            label_medicalRecord_treatment.TabIndex = 3;
            label_medicalRecord_treatment.Text = "Назначенное лечение:";
            // 
            // MedicalRecordCreation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 561);
            Controls.Add(tableLayoutPanel_MedicalRecordCreation_body);
            Controls.Add(panel_medicalRecordCreation_buttons);
            Controls.Add(panel_medicalRecordCreation_header);
            Name = "MedicalRecordCreation";
            Text = "Создание записи приема";
            panel_medicalRecordCreation_header.ResumeLayout(false);
            panel_medicalRecordCreation_buttons.ResumeLayout(false);
            tableLayoutPanel_MedicalRecordCreation_body.ResumeLayout(false);
            tableLayoutPanel_MedicalRecordCreation_body.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel_medicalRecordCreation_header;
        private Button button_medicalRecordCreation_back;
        private Button button_medicalRecordCration_save;
        private Panel panel_medicalRecordCreation_buttons;
        private TableLayoutPanel tableLayoutPanel_MedicalRecordCreation_body;
        private TextBox textBox_medicalRecord_treatment;
        private TextBox textBox_medicalRecord_symtpoms;
        private Label label_medicalRecord_symtpoms;
        private Label label_medicalRecord_disagnosis;
        private TextBox textBox_medicalRecord_diagnosis;
        private Label label_medicalRecord_treatment;
        private Label label_medicalRecordCreation_formName;
    }
}