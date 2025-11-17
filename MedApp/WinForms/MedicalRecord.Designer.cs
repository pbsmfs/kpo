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
            panel_Buttons = new Panel();
            button_Save = new Button();
            button_Cancel = new Button();
            tableLayoutPanel_Patient_Info = new TableLayoutPanel();
            textBox_medicalRecord_treatment = new TextBox();
            textBox_medicalRecord_symtpoms = new TextBox();
            label_medicalRecord_symtpoms = new Label();
            label_medicalRecord_disagnosis = new Label();
            textBox_medicalRecord_diagnosis = new TextBox();
            label_medicalRecord_treatment = new Label();
            button_back = new Button();
            panel_Header = new Panel();
            label_formName = new Label();
            panel_Buttons.SuspendLayout();
            tableLayoutPanel_Patient_Info.SuspendLayout();
            panel_Header.SuspendLayout();
            SuspendLayout();
            // 
            // panel_Buttons
            // 
            panel_Buttons.Controls.Add(button_back);
            panel_Buttons.Controls.Add(button_Save);
            panel_Buttons.Controls.Add(button_Cancel);
            panel_Buttons.Dock = DockStyle.Bottom;
            panel_Buttons.Location = new Point(0, 510);
            panel_Buttons.Name = "panel_Buttons";
            panel_Buttons.Size = new Size(453, 50);
            panel_Buttons.TabIndex = 6;
            // 
            // button_Save
            // 
            button_Save.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_Save.Location = new Point(611, 10);
            button_Save.Name = "button_Save";
            button_Save.Size = new Size(80, 30);
            button_Save.TabIndex = 1;
            button_Save.Text = "Сохранить";
            button_Save.UseVisualStyleBackColor = true;
            // 
            // button_Cancel
            // 
            button_Cancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_Cancel.Location = new Point(525, 10);
            button_Cancel.Name = "button_Cancel";
            button_Cancel.Size = new Size(80, 30);
            button_Cancel.TabIndex = 0;
            button_Cancel.Text = "Отмена";
            button_Cancel.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel_Patient_Info
            // 
            tableLayoutPanel_Patient_Info.AutoSize = true;
            tableLayoutPanel_Patient_Info.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel_Patient_Info.ColumnCount = 2;
            tableLayoutPanel_Patient_Info.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.6335545F));
            tableLayoutPanel_Patient_Info.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.36645F));
            tableLayoutPanel_Patient_Info.Controls.Add(textBox_medicalRecord_treatment, 1, 2);
            tableLayoutPanel_Patient_Info.Controls.Add(textBox_medicalRecord_symtpoms, 1, 1);
            tableLayoutPanel_Patient_Info.Controls.Add(label_medicalRecord_symtpoms, 0, 1);
            tableLayoutPanel_Patient_Info.Controls.Add(label_medicalRecord_disagnosis, 0, 0);
            tableLayoutPanel_Patient_Info.Controls.Add(textBox_medicalRecord_diagnosis, 1, 0);
            tableLayoutPanel_Patient_Info.Controls.Add(label_medicalRecord_treatment, 0, 2);
            tableLayoutPanel_Patient_Info.Dock = DockStyle.Fill;
            tableLayoutPanel_Patient_Info.Location = new Point(0, 55);
            tableLayoutPanel_Patient_Info.Name = "tableLayoutPanel_Patient_Info";
            tableLayoutPanel_Patient_Info.RowCount = 3;
            tableLayoutPanel_Patient_Info.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel_Patient_Info.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel_Patient_Info.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel_Patient_Info.Size = new Size(453, 455);
            tableLayoutPanel_Patient_Info.TabIndex = 11;
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
            // label_medicalRecord_symtpoms
            // 
            label_medicalRecord_symtpoms.Anchor = AnchorStyles.None;
            label_medicalRecord_symtpoms.AutoSize = true;
            label_medicalRecord_symtpoms.Font = new Font("Segoe UI", 9F);
            label_medicalRecord_symtpoms.Location = new Point(13, 219);
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
            label_medicalRecord_disagnosis.Location = new Point(21, 68);
            label_medicalRecord_disagnosis.Name = "label_medicalRecord_disagnosis";
            label_medicalRecord_disagnosis.Size = new Size(55, 15);
            label_medicalRecord_disagnosis.TabIndex = 0;
            label_medicalRecord_disagnosis.Text = "Диагноз:";
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
            // button_back
            // 
            button_back.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_back.Image = Properties.Resources.back_arrow;
            button_back.ImageAlign = ContentAlignment.MiddleRight;
            button_back.Location = new Point(363, 8);
            button_back.Name = "button_back";
            button_back.Size = new Size(80, 30);
            button_back.TabIndex = 2;
            button_back.Text = "Назад";
            button_back.TextAlign = ContentAlignment.MiddleLeft;
            button_back.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_back.UseVisualStyleBackColor = true;
            // 
            // panel_Header
            // 
            panel_Header.Controls.Add(label_formName);
            panel_Header.Dock = DockStyle.Top;
            panel_Header.Location = new Point(0, 0);
            panel_Header.Name = "panel_Header";
            panel_Header.Size = new Size(453, 55);
            panel_Header.TabIndex = 5;
            // 
            // label_formName
            // 
            label_formName.Dock = DockStyle.Fill;
            label_formName.Font = new Font("Segoe UI", 11F);
            label_formName.Location = new Point(0, 0);
            label_formName.Name = "label_formName";
            label_formName.Size = new Size(453, 55);
            label_formName.TabIndex = 3;
            label_formName.Text = "Просмотр записи приема";
            label_formName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MedicalRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 560);
            Controls.Add(tableLayoutPanel_Patient_Info);
            Controls.Add(panel_Buttons);
            Controls.Add(panel_Header);
            Name = "MedicalRecord";
            Text = "Просмотр записи приема";
            panel_Buttons.ResumeLayout(false);
            tableLayoutPanel_Patient_Info.ResumeLayout(false);
            tableLayoutPanel_Patient_Info.PerformLayout();
            panel_Header.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel_Buttons;
        private Button button_Save;
        private Button button_Cancel;
        private TableLayoutPanel tableLayoutPanel_Patient_Info;
        private TextBox textBox_medicalRecord_treatment;
        private TextBox textBox_medicalRecord_symtpoms;
        private Label label_medicalRecord_symtpoms;
        private Label label_medicalRecord_disagnosis;
        private TextBox textBox_medicalRecord_diagnosis;
        private Label label_medicalRecord_treatment;
        private Button button_back;
        private Panel panel_Header;
        private Label label_formName;
    }
}