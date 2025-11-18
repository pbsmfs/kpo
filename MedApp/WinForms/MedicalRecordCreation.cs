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
    public partial class MedicalRecordCreation : Form
    {
        public MedicalRecordCreation()
        {
            InitializeComponent();


            button_medicalRecordCreation_back.Click += (sender, e) =>
            {
                this.Close();
            };

            button_medicalRecordCration_save.Click += (sender, e) =>
            {
                // update_MedicalRecordsData();

                MessageBox.Show("Запись приема добавлена.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            };
        }
    }
}
