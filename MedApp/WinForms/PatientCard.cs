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
        private PatientCardsTable _patientCardsTableForm;
        private PatientData _patientData;

        public PatientCard(PatientCardsTable patientCardsTableForm, PatientData patientData)
        {
            InitializeComponent();
            _patientCardsTableForm = patientCardsTableForm;
            _patientData = patientData;

            LoadPatientData();

            button_patientCard_back.Click += (sender, e) =>
            {
                _patientCardsTableForm.StartPosition = FormStartPosition.Manual;
                _patientCardsTableForm.Location = this.Location;
                _patientCardsTableForm.Show();
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

                    MessageBox.Show("Изменения сохранены.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };

            button_addMedicalRecord.Click += (sender, e) =>
            {
                MedicalRecordCreation medicalRecordForm = new MedicalRecordCreation();
                medicalRecordForm.StartPosition = FormStartPosition.Manual;
                medicalRecordForm.Location = this.Location;
                medicalRecordForm.ShowDialog();
            };

            button_addExaminationResult.Click += (sender, e) =>
            {
                ExaminationResultCreation examinationForm = new ExaminationResultCreation();
                examinationForm.StartPosition = FormStartPosition.Manual;
                examinationForm.Location = this.Location;
                examinationForm.ShowDialog();
            };
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            if (!_patientCardsTableForm.Visible)
            {
                Application.Exit();
            }
        }

        private void LoadPatientData()
        {
            textBox_patient_lastName.Text = _patientData.LastName;
            textBox_patient_firstName.Text = _patientData.FirstName;
            textBox_patient_patronymic.Text = _patientData.Patronymic;
            textBox_patient_gender.Text = _patientData.Gender;
            textBox_patient_birthday.Text = _patientData.Birthday.ToString("dd.MM.yyyy");
            textBox_patient_phoneNumber.Text = _patientData.PhoneNumber;
            textBox_patient_adress.Text = _patientData.Address;
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