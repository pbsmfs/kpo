using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class ExaminationResultCreation : Form
    {
        public ExaminationResultCreation()
        {
            InitializeComponent();

            button_examinationResultCreation_back.Click += (sender, e) =>
            {
                this.Close();
            };

            button_examinationResultCreation_save.Click += (sender, e) =>
            {
                // update_ExaminationResultsData();

                MessageBox.Show("Результаты анализов добавлены.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            };
        }
    }
}
