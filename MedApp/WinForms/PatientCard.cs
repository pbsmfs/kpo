using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class PatientCard : Form
    {
        private bool isEditMode = false;

        public PatientCard()
        {
            InitializeComponent();

            button_patientCard_back.Click += (sender, e) =>
            {
                PatientCardsTable patientCardsTable = new PatientCardsTable();
                patientCardsTable.Show();
                this.Close();
            };

            button_editPatientInfo.Click += (sender, e) =>
            {
                if (!isEditMode)
                {
                    EnableEditing();
                    button_editPatientInfo.Text = "Сохранить";
                    button_editPatientInfo.Image = null;
                    isEditMode = true;
                }
                else
                {
                    DisableEditing();
                    button_editPatientInfo.Text = "Изменить";
                    button_editPatientInfo.Image = Properties.Resources.pencil;
                    isEditMode = false;

                    // update_PatientInfo();

                    MessageBox.Show("Изменения сохранены.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };

            button_addMedicalRecord.Click += (sender, e) =>
            {
                MedicalRecordCreation medicalRecordForm = new MedicalRecordCreation();
                medicalRecordForm.ShowDialog();
            };

            button_addExaminationResult.Click += (sender, e) =>
            {
                ExaminationResultCreation examinationForm = new ExaminationResultCreation();
                examinationForm.ShowDialog();
            };
        }

        private void EnableEditing()
        {
            textBox_patient_lastName.ReadOnly = false;
            textBox_patient_firstName.ReadOnly = false;
            textBox_patient_patronymic.ReadOnly = false;
            textBox_patient_gender.ReadOnly = false;
            textBox_patient_birthday.ReadOnly = false;
            textBox_patient_phoneNumber.ReadOnly = false;
            textBox_patient_adress.ReadOnly = false;
        }

        private void DisableEditing()
        {
            textBox_patient_lastName.ReadOnly = true;
            textBox_patient_firstName.ReadOnly = true;
            textBox_patient_patronymic.ReadOnly = true;
            textBox_patient_gender.ReadOnly = true;
            textBox_patient_birthday.ReadOnly = true;
            textBox_patient_phoneNumber.ReadOnly = true;
            textBox_patient_adress.ReadOnly = true;
        }
    }
}