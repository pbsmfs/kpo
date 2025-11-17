namespace WinForms
{
    partial class MedicalRecord
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
            panel_medicalRecords_buttons = new Panel();
            button_medicalRecord_back = new Button();
            panel_medicalRecords_header = new Panel();
            label_medicalRecord_formName = new Label();
            tableLayoutPanel_medicalRecords_body = new TableLayoutPanel();
            textBox_medicalRecord_treatment = new TextBox();
            textBox_medicalRecord_symtpoms = new TextBox();
            label_medialRecord_symtpoms = new Label();
            label_medialRecord_disagnosis = new Label();
            textBox_medicalRecord_diagnosis = new TextBox();
            label_medicalRecord_treatment = new Label();
            panel_medicalRecords_buttons.SuspendLayout();
            panel_medicalRecords_header.SuspendLayout();
            tableLayoutPanel_medicalRecords_body.SuspendLayout();
            SuspendLayout();
            // 
            // panel_medicalRecords_buttons
            // 
            panel_medicalRecords_buttons.Controls.Add(button_medicalRecord_back);
            panel_medicalRecords_buttons.Dock = DockStyle.Bottom;
            panel_medicalRecords_buttons.Location = new Point(0, 510);
            panel_medicalRecords_buttons.Name = "panel_medicalRecords_buttons";
            panel_medicalRecords_buttons.Size = new Size(453, 50);
            panel_medicalRecords_buttons.TabIndex = 6;
            // 
            // button_medicalRecord_back
            // 
            button_medicalRecord_back.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_medicalRecord_back.Image = Properties.Resources.back_arrow;
            button_medicalRecord_back.ImageAlign = ContentAlignment.MiddleRight;
            button_medicalRecord_back.Location = new Point(363, 8);
            button_medicalRecord_back.Name = "button_medicalRecord_back";
            button_medicalRecord_back.Size = new Size(80, 30);
            button_medicalRecord_back.TabIndex = 2;
            button_medicalRecord_back.Text = "Назад";
            button_medicalRecord_back.TextAlign = ContentAlignment.MiddleLeft;
            button_medicalRecord_back.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_medicalRecord_back.UseVisualStyleBackColor = true;
            // 
            // panel_medicalRecords_header
            // 
            panel_medicalRecords_header.Controls.Add(label_medicalRecord_formName);
            panel_medicalRecords_header.Dock = DockStyle.Top;
            panel_medicalRecords_header.Location = new Point(0, 0);
            panel_medicalRecords_header.Name = "panel_medicalRecords_header";
            panel_medicalRecords_header.Size = new Size(453, 55);
            panel_medicalRecords_header.TabIndex = 5;
            // 
            // label_medicalRecord_formName
            // 
            label_medicalRecord_formName.Dock = DockStyle.Fill;
            label_medicalRecord_formName.Font = new Font("Segoe UI", 11F);
            label_medicalRecord_formName.Location = new Point(0, 0);
            label_medicalRecord_formName.Name = "label_medicalRecord_formName";
            label_medicalRecord_formName.Size = new Size(453, 55);
            label_medicalRecord_formName.TabIndex = 3;
            label_medicalRecord_formName.Text = "Просмотр записи приема:";
            label_medicalRecord_formName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel_medicalRecords_body
            // 
            tableLayoutPanel_medicalRecords_body.AutoSize = true;
            tableLayoutPanel_medicalRecords_body.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel_medicalRecords_body.ColumnCount = 2;
            tableLayoutPanel_medicalRecords_body.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.6335545F));
            tableLayoutPanel_medicalRecords_body.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.36645F));
            tableLayoutPanel_medicalRecords_body.Controls.Add(textBox_medicalRecord_treatment, 1, 2);
            tableLayoutPanel_medicalRecords_body.Controls.Add(textBox_medicalRecord_symtpoms, 1, 1);
            tableLayoutPanel_medicalRecords_body.Controls.Add(label_medialRecord_symtpoms, 0, 1);
            tableLayoutPanel_medicalRecords_body.Controls.Add(label_medialRecord_disagnosis, 0, 0);
            tableLayoutPanel_medicalRecords_body.Controls.Add(textBox_medicalRecord_diagnosis, 1, 0);
            tableLayoutPanel_medicalRecords_body.Controls.Add(label_medicalRecord_treatment, 0, 2);
            tableLayoutPanel_medicalRecords_body.Dock = DockStyle.Fill;
            tableLayoutPanel_medicalRecords_body.Location = new Point(0, 55);
            tableLayoutPanel_medicalRecords_body.Name = "tableLayoutPanel_medicalRecords_body";
            tableLayoutPanel_medicalRecords_body.RowCount = 3;
            tableLayoutPanel_medicalRecords_body.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel_medicalRecords_body.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel_medicalRecords_body.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel_medicalRecords_body.Size = new Size(453, 455);
            tableLayoutPanel_medicalRecords_body.TabIndex = 12;
            // 
            // textBox_medicalRecord_treatment
            // 
            textBox_medicalRecord_treatment.Anchor = AnchorStyles.None;
            textBox_medicalRecord_treatment.Font = new Font("Segoe UI", 11F);
            textBox_medicalRecord_treatment.Location = new Point(108, 312);
            textBox_medicalRecord_treatment.Margin = new Padding(10);
            textBox_medicalRecord_treatment.Multiline = true;
            textBox_medicalRecord_treatment.Name = "textBox_medicalRecord_treatment";
            textBox_medicalRecord_treatment.Size = new Size(335, 133);
            textBox_medicalRecord_treatment.TabIndex = 5;
            // 
            // textBox_medicalRecord_symtpoms
            // 
            textBox_medicalRecord_symtpoms.Anchor = AnchorStyles.None;
            textBox_medicalRecord_symtpoms.Font = new Font("Segoe UI", 11F);
            textBox_medicalRecord_symtpoms.Location = new Point(108, 161);
            textBox_medicalRecord_symtpoms.Margin = new Padding(10);
            textBox_medicalRecord_symtpoms.Multiline = true;
            textBox_medicalRecord_symtpoms.Name = "textBox_medicalRecord_symtpoms";
            textBox_medicalRecord_symtpoms.Size = new Size(335, 131);
            textBox_medicalRecord_symtpoms.TabIndex = 4;
            // 
            // label_medialRecord_symtpoms
            // 
            label_medialRecord_symtpoms.Anchor = AnchorStyles.None;
            label_medialRecord_symtpoms.AutoSize = true;
            label_medialRecord_symtpoms.Font = new Font("Segoe UI", 9F);
            label_medialRecord_symtpoms.Location = new Point(13, 219);
            label_medialRecord_symtpoms.Name = "label_medialRecord_symtpoms";
            label_medialRecord_symtpoms.Size = new Size(71, 15);
            label_medialRecord_symtpoms.TabIndex = 2;
            label_medialRecord_symtpoms.Text = "Симптомы:";
            // 
            // label_medialRecord_disagnosis
            // 
            label_medialRecord_disagnosis.Anchor = AnchorStyles.None;
            label_medialRecord_disagnosis.AutoSize = true;
            label_medialRecord_disagnosis.Font = new Font("Segoe UI", 9F);
            label_medialRecord_disagnosis.Location = new Point(21, 68);
            label_medialRecord_disagnosis.Name = "label_medialRecord_disagnosis";
            label_medialRecord_disagnosis.Size = new Size(55, 15);
            label_medialRecord_disagnosis.TabIndex = 0;
            label_medialRecord_disagnosis.Text = "Диагноз:";
            // 
            // textBox_medicalRecord_diagnosis
            // 
            textBox_medicalRecord_diagnosis.Anchor = AnchorStyles.None;
            textBox_medicalRecord_diagnosis.Font = new Font("Segoe UI", 11F);
            textBox_medicalRecord_diagnosis.Location = new Point(108, 10);
            textBox_medicalRecord_diagnosis.Margin = new Padding(10);
            textBox_medicalRecord_diagnosis.Multiline = true;
            textBox_medicalRecord_diagnosis.Name = "textBox_medicalRecord_diagnosis";
            textBox_medicalRecord_diagnosis.Size = new Size(335, 131);
            textBox_medicalRecord_diagnosis.TabIndex = 1;
            // 
            // label_medicalRecord_treatment
            // 
            label_medicalRecord_treatment.Anchor = AnchorStyles.None;
            label_medicalRecord_treatment.AutoSize = true;
            label_medicalRecord_treatment.Font = new Font("Segoe UI", 9F);
            label_medicalRecord_treatment.Location = new Point(7, 363);
            label_medicalRecord_treatment.Name = "label_medicalRecord_treatment";
            label_medicalRecord_treatment.Size = new Size(83, 30);
            label_medicalRecord_treatment.TabIndex = 3;
            label_medicalRecord_treatment.Text = "Назначенное лечение:";
            // 
            // MedicalRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 560);
            Controls.Add(tableLayoutPanel_medicalRecords_body);
            Controls.Add(panel_medicalRecords_buttons);
            Controls.Add(panel_medicalRecords_header);
            Name = "MedicalRecord";
            Text = "Просмотр записи приема";
            panel_medicalRecords_buttons.ResumeLayout(false);
            panel_medicalRecords_header.ResumeLayout(false);
            tableLayoutPanel_medicalRecords_body.ResumeLayout(false);
            tableLayoutPanel_medicalRecords_body.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel_medicalRecords_buttons;
        private Button button_Save;
        private Button button_Cancel;
        private Button button_medicalRecord_back;
        private Panel panel_medicalRecords_header;
        private TableLayoutPanel tableLayoutPanel_medicalRecords_body;
        private TextBox textBox_medicalRecord_treatment;
        private TextBox textBox_medicalRecord_symtpoms;
        private Label label_medialRecord_symtpoms;
        private Label label_medialRecord_disagnosis;
        private TextBox textBox_medicalRecord_diagnosis;
        private Label label_medicalRecord_treatment;
        private Label label_medicalRecord_formName;
    }
}