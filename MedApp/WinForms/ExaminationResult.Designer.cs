namespace WinForms
{
    partial class ExaminationResult
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
            panel_examinationResult_header = new Panel();
            label_examinationResult_formName = new Label();
            splitContainer_examinationResult_body = new SplitContainer();
            tableLayoutPanel_examinationResult = new TableLayoutPanel();
            label_examinationResult_type = new Label();
            textBox_examinationResult_type = new TextBox();
            dataGridView_examinationResult = new DataGridView();
            column_examinationResult_parametr = new DataGridViewTextBoxColumn();
            column_examinationResult_units = new DataGridViewTextBoxColumn();
            column_examinationResult_norm = new DataGridViewTextBoxColumn();
            column_examinationResult_result = new DataGridViewTextBoxColumn();
            panel_examinationResult_buttons = new Panel();
            button_examinationResult_back = new Button();
            panel_examinationResult_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer_examinationResult_body).BeginInit();
            splitContainer_examinationResult_body.Panel1.SuspendLayout();
            splitContainer_examinationResult_body.Panel2.SuspendLayout();
            splitContainer_examinationResult_body.SuspendLayout();
            tableLayoutPanel_examinationResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_examinationResult).BeginInit();
            panel_examinationResult_buttons.SuspendLayout();
            SuspendLayout();
            // 
            // panel_examinationResult_header
            // 
            panel_examinationResult_header.Controls.Add(label_examinationResult_formName);
            panel_examinationResult_header.Dock = DockStyle.Top;
            panel_examinationResult_header.Location = new Point(0, 0);
            panel_examinationResult_header.Name = "panel_examinationResult_header";
            panel_examinationResult_header.Size = new Size(384, 55);
            panel_examinationResult_header.TabIndex = 13;
            // 
            // label_examinationResult_formName
            // 
            label_examinationResult_formName.Dock = DockStyle.Fill;
            label_examinationResult_formName.Font = new Font("Segoe UI", 11F);
            label_examinationResult_formName.Location = new Point(0, 0);
            label_examinationResult_formName.Name = "label_examinationResult_formName";
            label_examinationResult_formName.Size = new Size(384, 55);
            label_examinationResult_formName.TabIndex = 4;
            label_examinationResult_formName.Text = "Просмотр результата анализов:";
            label_examinationResult_formName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // splitContainer_examinationResult_body
            // 
            splitContainer_examinationResult_body.Dock = DockStyle.Fill;
            splitContainer_examinationResult_body.Location = new Point(0, 55);
            splitContainer_examinationResult_body.Name = "splitContainer_examinationResult_body";
            splitContainer_examinationResult_body.Orientation = Orientation.Horizontal;
            // 
            // splitContainer_examinationResult_body.Panel1
            // 
            splitContainer_examinationResult_body.Panel1.Controls.Add(tableLayoutPanel_examinationResult);
            // 
            // splitContainer_examinationResult_body.Panel2
            // 
            splitContainer_examinationResult_body.Panel2.Controls.Add(dataGridView_examinationResult);
            splitContainer_examinationResult_body.Size = new Size(384, 456);
            splitContainer_examinationResult_body.SplitterDistance = 83;
            splitContainer_examinationResult_body.TabIndex = 15;
            // 
            // tableLayoutPanel_examinationResult
            // 
            tableLayoutPanel_examinationResult.AutoSize = true;
            tableLayoutPanel_examinationResult.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel_examinationResult.ColumnCount = 2;
            tableLayoutPanel_examinationResult.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.6335545F));
            tableLayoutPanel_examinationResult.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.36645F));
            tableLayoutPanel_examinationResult.Controls.Add(label_examinationResult_type, 0, 0);
            tableLayoutPanel_examinationResult.Controls.Add(textBox_examinationResult_type, 1, 0);
            tableLayoutPanel_examinationResult.Dock = DockStyle.Fill;
            tableLayoutPanel_examinationResult.Location = new Point(0, 0);
            tableLayoutPanel_examinationResult.Name = "tableLayoutPanel_examinationResult";
            tableLayoutPanel_examinationResult.RowCount = 1;
            tableLayoutPanel_examinationResult.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel_examinationResult.Size = new Size(384, 83);
            tableLayoutPanel_examinationResult.TabIndex = 16;
            // 
            // label_examinationResult_type
            // 
            label_examinationResult_type.Anchor = AnchorStyles.None;
            label_examinationResult_type.AutoSize = true;
            label_examinationResult_type.Font = new Font("Segoe UI", 9F);
            label_examinationResult_type.Location = new Point(14, 26);
            label_examinationResult_type.Name = "label_examinationResult_type";
            label_examinationResult_type.Size = new Size(54, 30);
            label_examinationResult_type.TabIndex = 0;
            label_examinationResult_type.Text = "Тип анализа:";
            // 
            // textBox_examinationResult_type
            // 
            textBox_examinationResult_type.Anchor = AnchorStyles.None;
            textBox_examinationResult_type.Font = new Font("Segoe UI", 11F);
            textBox_examinationResult_type.Location = new Point(93, 10);
            textBox_examinationResult_type.Margin = new Padding(10);
            textBox_examinationResult_type.Multiline = true;
            textBox_examinationResult_type.Name = "textBox_examinationResult_type";
            textBox_examinationResult_type.Size = new Size(281, 63);
            textBox_examinationResult_type.TabIndex = 1;
            // 
            // dataGridView_examinationResult
            // 
            dataGridView_examinationResult.AllowUserToAddRows = false;
            dataGridView_examinationResult.AllowUserToDeleteRows = false;
            dataGridView_examinationResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_examinationResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_examinationResult.Columns.AddRange(new DataGridViewColumn[] { column_examinationResult_parametr, column_examinationResult_units, column_examinationResult_norm, column_examinationResult_result });
            dataGridView_examinationResult.Dock = DockStyle.Fill;
            dataGridView_examinationResult.Location = new Point(0, 0);
            dataGridView_examinationResult.Name = "dataGridView_examinationResult";
            dataGridView_examinationResult.ReadOnly = true;
            dataGridView_examinationResult.Size = new Size(384, 369);
            dataGridView_examinationResult.TabIndex = 0;
            // 
            // column_examinationResult_parametr
            // 
            column_examinationResult_parametr.HeaderText = "Показатели";
            column_examinationResult_parametr.Name = "column_examinationResult_parametr";
            column_examinationResult_parametr.ReadOnly = true;
            // 
            // column_examinationResult_units
            // 
            column_examinationResult_units.HeaderText = "Ед. измерения";
            column_examinationResult_units.Name = "column_examinationResult_units";
            column_examinationResult_units.ReadOnly = true;
            // 
            // column_examinationResult_norm
            // 
            column_examinationResult_norm.HeaderText = "Норма";
            column_examinationResult_norm.Name = "column_examinationResult_norm";
            column_examinationResult_norm.ReadOnly = true;
            // 
            // column_examinationResult_result
            // 
            column_examinationResult_result.HeaderText = "Результат";
            column_examinationResult_result.Name = "column_examinationResult_result";
            column_examinationResult_result.ReadOnly = true;
            // 
            // panel_examinationResult_buttons
            // 
            panel_examinationResult_buttons.Controls.Add(button_examinationResult_back);
            panel_examinationResult_buttons.Dock = DockStyle.Bottom;
            panel_examinationResult_buttons.Location = new Point(0, 511);
            panel_examinationResult_buttons.Name = "panel_examinationResult_buttons";
            panel_examinationResult_buttons.Size = new Size(384, 50);
            panel_examinationResult_buttons.TabIndex = 14;
            // 
            // button_examinationResult_back
            // 
            button_examinationResult_back.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_examinationResult_back.Image = Properties.Resources.back_arrow;
            button_examinationResult_back.ImageAlign = ContentAlignment.MiddleRight;
            button_examinationResult_back.Location = new Point(294, 8);
            button_examinationResult_back.Name = "button_examinationResult_back";
            button_examinationResult_back.Size = new Size(80, 30);
            button_examinationResult_back.TabIndex = 3;
            button_examinationResult_back.Text = "Назад";
            button_examinationResult_back.TextAlign = ContentAlignment.MiddleLeft;
            button_examinationResult_back.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_examinationResult_back.UseVisualStyleBackColor = true;
            // 
            // ExaminationResult
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 561);
            Controls.Add(splitContainer_examinationResult_body);
            Controls.Add(panel_examinationResult_buttons);
            Controls.Add(panel_examinationResult_header);
            Name = "ExaminationResult";
            Text = "Просмотр результата анализов";
            panel_examinationResult_header.ResumeLayout(false);
            splitContainer_examinationResult_body.Panel1.ResumeLayout(false);
            splitContainer_examinationResult_body.Panel1.PerformLayout();
            splitContainer_examinationResult_body.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer_examinationResult_body).EndInit();
            splitContainer_examinationResult_body.ResumeLayout(false);
            tableLayoutPanel_examinationResult.ResumeLayout(false);
            tableLayoutPanel_examinationResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_examinationResult).EndInit();
            panel_examinationResult_buttons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel_examinationResult_header;
        private SplitContainer splitContainer_examinationResult_body;
        private Panel panel_examinationResult_buttons;
        private DataGridView dataGridView_examinationResult;
        private DataGridViewTextBoxColumn column_examinationResult_parametr;
        private DataGridViewTextBoxColumn column_examinationResult_units;
        private DataGridViewTextBoxColumn column_examinationResult_norm;
        private DataGridViewTextBoxColumn column_examinationResult_result;
        private Button button_examinationResult_back;
        private Label label_examinationResult_formName;
        private TableLayoutPanel tableLayoutPanel_examinationResult;
        private Label label_examinationResult_type;
        private TextBox textBox_examinationResult_type;
    }
}