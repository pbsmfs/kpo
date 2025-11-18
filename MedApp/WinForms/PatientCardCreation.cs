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
    public partial class PatientCardCreation : Form
    {
        private PatientCardsTable _patientCardsTableForm;

        public PatientCardCreation()
        {
            InitializeComponent();

            button_patientCardCreation_back.Click += (sender, e) =>
            {
                this.Close();
            };

            button_patientCardCreation_save.Click += (sender, e) =>
            {

                MessageBox.Show("Карта пациента добавлена.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            };
        }
    }
}