namespace WinForms
{
    partial class ExaminationResultCreation
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
            panel_examinationResultCreation_buttons = new Panel();
            button_examinationResultCreation_save = new Button();
            button_examinationResultCreation_back = new Button();
            panel_examinationResult_header = new Panel();
            label_examinationResult_formName = new Label();
            splitContainer_examinationResultCreation_body = new SplitContainer();
            tableLayoutPanel_examinationResultCreation = new TableLayoutPanel();
            label_examinationResult_type = new Label();
            textBox_examinationResult_type = new TextBox();
            dataGridView_examinationResultCreation = new DataGridView();
            column_examinationResult_parametr = new DataGridViewTextBoxColumn();
            column_examinationResult_units = new DataGridViewTextBoxColumn();
            column_examinationResult_norm = new DataGridViewTextBoxColumn();
            column_examinationResult_result = new DataGridViewTextBoxColumn();
            panel_examinationResultCreation_buttons.SuspendLayout();
            panel_examinationResult_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer_examinationResultCreation_body).BeginInit();
            splitContainer_examinationResultCreation_body.Panel1.SuspendLayout();
            splitContainer_examinationResultCreation_body.Panel2.SuspendLayout();
            splitContainer_examinationResultCreation_body.SuspendLayout();
            tableLayoutPanel_examinationResultCreation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_examinationResultCreation).BeginInit();
            SuspendLayout();
            // 
            // panel_examinationResultCreation_buttons
            // 
            panel_examinationResultCreation_buttons.Controls.Add(button_examinationResultCreation_save);
            panel_examinationResultCreation_buttons.Controls.Add(button_examinationResultCreation_back);
            panel_examinationResultCreation_buttons.Dock = DockStyle.Bottom;
            panel_examinationResultCreation_buttons.Location = new Point(0, 510);
            panel_examinationResultCreation_buttons.Name = "panel_examinationResultCreation_buttons";
            panel_examinationResultCreation_buttons.Size = new Size(453, 50);
            panel_examinationResultCreation_buttons.TabIndex = 15;
            // 
            // button_examinationResultCreation_save
            // 
            button_examinationResultCreation_save.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_examinationResultCreation_save.Location = new Point(363, 10);
            button_examinationResultCreation_save.Name = "button_examinationResultCreation_save";
            button_examinationResultCreation_save.Size = new Size(80, 30);
            button_examinationResultCreation_save.TabIndex = 3;
            button_examinationResultCreation_save.Text = "Сохранить";
            button_examinationResultCreation_save.UseVisualStyleBackColor = true;
            // 
            // button_examinationResultCreation_back
            // 
            button_examinationResultCreation_back.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_examinationResultCreation_back.Location = new Point(277, 10);
            button_examinationResultCreation_back.Name = "button_examinationResultCreation_back";
            button_examinationResultCreation_back.Size = new Size(80, 30);
            button_examinationResultCreation_back.TabIndex = 2;
            button_examinationResultCreation_back.Text = "Отмена";
            button_examinationResultCreation_back.UseVisualStyleBackColor = true;
            // 
            // panel_examinationResult_header
            // 
            panel_examinationResult_header.Controls.Add(label_examinationResult_formName);
            panel_examinationResult_header.Dock = DockStyle.Top;
            panel_examinationResult_header.Location = new Point(0, 0);
            panel_examinationResult_header.Name = "panel_examinationResult_header";
            panel_examinationResult_header.Size = new Size(453, 55);
            panel_examinationResult_header.TabIndex = 16;
            // 
            // label_examinationResult_formName
            // 
            label_examinationResult_formName.Dock = DockStyle.Fill;
            label_examinationResult_formName.Font = new Font("Segoe UI", 11F);
            label_examinationResult_formName.Location = new Point(0, 0);
            label_examinationResult_formName.Name = "label_examinationResult_formName";
            label_examinationResult_formName.Size = new Size(453, 55);
            label_examinationResult_formName.TabIndex = 5;
            label_examinationResult_formName.Text = "Создание результата анализов";
            label_examinationResult_formName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // splitContainer_examinationResultCreation_body
            // 
            splitContainer_examinationResultCreation_body.Dock = DockStyle.Fill;
            splitContainer_examinationResultCreation_body.Location = new Point(0, 55);
            splitContainer_examinationResultCreation_body.Name = "splitContainer_examinationResultCreation_body";
            splitContainer_examinationResultCreation_body.Orientation = Orientation.Horizontal;
            // 
            // splitContainer_examinationResultCreation_body.Panel1
            // 
            splitContainer_examinationResultCreation_body.Panel1.Controls.Add(tableLayoutPanel_examinationResultCreation);
            // 
            // splitContainer_examinationResultCreation_body.Panel2
            // 
            splitContainer_examinationResultCreation_body.Panel2.Controls.Add(dataGridView_examinationResultCreation);
            splitContainer_examinationResultCreation_body.Size = new Size(453, 455);
            splitContainer_examinationResultCreation_body.SplitterDistance = 94;
            splitContainer_examinationResultCreation_body.TabIndex = 17;
            // 
            // tableLayoutPanel_examinationResultCreation
            // 
            tableLayoutPanel_examinationResultCreation.AutoSize = true;
            tableLayoutPanel_examinationResultCreation.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel_examinationResultCreation.ColumnCount = 2;
            tableLayoutPanel_examinationResultCreation.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.6335545F));
            tableLayoutPanel_examinationResultCreation.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.36645F));
            tableLayoutPanel_examinationResultCreation.Controls.Add(label_examinationResult_type, 0, 0);
            tableLayoutPanel_examinationResultCreation.Controls.Add(textBox_examinationResult_type, 1, 0);
            tableLayoutPanel_examinationResultCreation.Dock = DockStyle.Fill;
            tableLayoutPanel_examinationResultCreation.Location = new Point(0, 0);
            tableLayoutPanel_examinationResultCreation.Name = "tableLayoutPanel_examinationResultCreation";
            tableLayoutPanel_examinationResultCreation.RowCount = 1;
            tableLayoutPanel_examinationResultCreation.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel_examinationResultCreation.Size = new Size(453, 94);
            tableLayoutPanel_examinationResultCreation.TabIndex = 16;
            // 
            // label_examinationResult_type
            // 
            label_examinationResult_type.Anchor = AnchorStyles.None;
            label_examinationResult_type.AutoSize = true;
            label_examinationResult_type.Font = new Font("Segoe UI", 9F);
            label_examinationResult_type.Location = new Point(10, 39);
            label_examinationResult_type.Name = "label_examinationResult_type";
            label_examinationResult_type.Size = new Size(78, 15);
            label_examinationResult_type.TabIndex = 0;
            label_examinationResult_type.Text = "Тип анализа:";
            // 
            // textBox_examinationResult_type
            // 
            textBox_examinationResult_type.Anchor = AnchorStyles.None;
            textBox_examinationResult_type.Font = new Font("Segoe UI", 11F);
            textBox_examinationResult_type.Location = new Point(108, 10);
            textBox_examinationResult_type.Margin = new Padding(10);
            textBox_examinationResult_type.Multiline = true;
            textBox_examinationResult_type.Name = "textBox_examinationResult_type";
            textBox_examinationResult_type.Size = new Size(335, 74);
            textBox_examinationResult_type.TabIndex = 1;
            // 
            // dataGridView_examinationResultCreation
            // 
            dataGridView_examinationResultCreation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_examinationResultCreation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_examinationResultCreation.Columns.AddRange(new DataGridViewColumn[] { column_examinationResult_parametr, column_examinationResult_units, column_examinationResult_norm, column_examinationResult_result });
            dataGridView_examinationResultCreation.Dock = DockStyle.Fill;
            dataGridView_examinationResultCreation.Location = new Point(0, 0);
            dataGridView_examinationResultCreation.Name = "dataGridView_examinationResultCreation";
            dataGridView_examinationResultCreation.Size = new Size(453, 357);
            dataGridView_examinationResultCreation.TabIndex = 0;
            // 
            // column_examinationResult_parametr
            // 
            column_examinationResult_parametr.HeaderText = "Показатели";
            column_examinationResult_parametr.Name = "column_examinationResult_parametr";
            // 
            // column_examinationResult_units
            // 
            column_examinationResult_units.HeaderText = "Ед. измерения";
            column_examinationResult_units.Name = "column_examinationResult_units";
            // 
            // column_examinationResult_norm
            // 
            column_examinationResult_norm.HeaderText = "Норма";
            column_examinationResult_norm.Name = "column_examinationResult_norm";
            // 
            // column_examinationResult_result
            // 
            column_examinationResult_result.HeaderText = "Результат";
            column_examinationResult_result.Name = "column_examinationResult_result";
            // 
            // ExaminationResultCreation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 560);
            Controls.Add(splitContainer_examinationResultCreation_body);
            Controls.Add(panel_examinationResult_header);
            Controls.Add(panel_examinationResultCreation_buttons);
            Name = "ExaminationResultCreation";
            Text = "Создание результата анализов";
            panel_examinationResultCreation_buttons.ResumeLayout(false);
            panel_examinationResult_header.ResumeLayout(false);
            splitContainer_examinationResultCreation_body.Panel1.ResumeLayout(false);
            splitContainer_examinationResultCreation_body.Panel1.PerformLayout();
            splitContainer_examinationResultCreation_body.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer_examinationResultCreation_body).EndInit();
            splitContainer_examinationResultCreation_body.ResumeLayout(false);
            tableLayoutPanel_examinationResultCreation.ResumeLayout(false);
            tableLayoutPanel_examinationResultCreation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_examinationResultCreation).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_examinationResultCreation_buttons;
        private Button button_examinationResultCreation_save;
        private Button button_examinationResultCreation_back;
        private Panel panel_examinationResult_header;
        private Label label_examinationResult_formName;
        private SplitContainer splitContainer_examinationResultCreation_body;
        private TableLayoutPanel tableLayoutPanel_examinationResultCreation;
        private Label label_examinationResult_type;
        private TextBox textBox_examinationResult_type;
        private DataGridView dataGridView_examinationResultCreation;
        private DataGridViewTextBoxColumn column_examinationResult_parametr;
        private DataGridViewTextBoxColumn column_examinationResult_units;
        private DataGridViewTextBoxColumn column_examinationResult_norm;
        private DataGridViewTextBoxColumn column_examinationResult_result;
    }
}