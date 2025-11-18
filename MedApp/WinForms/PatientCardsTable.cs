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
    public partial class PatientCardsTable : Form
    {
        private Login _loginForm;

        public PatientCardsTable(Login loginForm)
        {
            InitializeComponent();
            _loginForm = loginForm;

            button_patientCardsTable_back.Click += (sender, e) =>
            {
                _loginForm.StartPosition = FormStartPosition.Manual;
                _loginForm.Location = this.Location;
                _loginForm.Show();
                this.Close();
            };

            button_patientCardsTable_addCard.Click += (sender, e) =>
            {
                PatientCardCreation patientCardCreationForm = new PatientCardCreation();
                patientCardCreationForm.StartPosition = FormStartPosition.Manual;
                patientCardCreationForm.Location = this.Location;
                patientCardCreationForm.ShowDialog();
            };

            dataGridView_patientCardsTable.CellClick += (sender, e) =>
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == column_patientCards_open.Index)
                {
                    var patient = getPatientData(e.RowIndex);

                    PatientCard patientCardForm = new PatientCard(this, patient);
                    patientCardForm.StartPosition = FormStartPosition.Manual;
                    patientCardForm.Location = this.Location;
                    patientCardForm.Show();
                    this.Hide();
                }
            };

            loadSampleData();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            if (!_loginForm.Visible)
            {
                Application.Exit();
            }
        }

        private void loadSampleData()
        {
            var patient = new PatientData
            {
                Id = 1,
                LastName = "Иванов",
                FirstName = "Иван",
                Patronymic = "Иванович",
                PhoneNumber = "+7 (912) 345-67-89",
                Address = "г. Москва, ул. Ленина, д. 10, кв. 25",
                Gender = "Мужской",
                Birthday = new DateTime(1985, 5, 15),
                CreationDate = new DateTime(2020, 1, 10),
                LastModified = new DateTime(2024, 1, 15)
            };

            dataGridView_patientCardsTable.Rows.Add(
                patient.Id,
                patient.LastName,
                patient.FirstName,
                patient.Patronymic,
                patient.PhoneNumber,
                patient.Address,
                patient.CreationDate.ToString("dd.MM.yyyy"),
                patient.LastModified.ToString("dd.MM.yyyy"),
                "Посмотреть"
            );
        }

        private PatientData getPatientData(int rowIndex)
        {
            var row = dataGridView_patientCardsTable.Rows[rowIndex];

            return new PatientData
            {
                Id = Convert.ToInt32(row.Cells[column_patientCards_id.Index].Value),
                LastName = row.Cells[column_patientCards_lastName.Index].Value?.ToString() ?? "",
                FirstName = row.Cells[column_patientCards_firstName.Index].Value?.ToString() ?? "",
                Patronymic = row.Cells[column_patientCards_patronymic.Index].Value?.ToString() ?? "",
                PhoneNumber = row.Cells[column_patientCards_phoneNumber.Index].Value?.ToString() ?? "",
                Address = row.Cells[column_patientCards_adress.Index].Value?.ToString() ?? "",
                Gender = "Мужской",
                Birthday = new DateTime(1985, 5, 15)
            };
        }
    }

    // Класс для хранения данных пациента
    public class PatientData
    {
        public int Id { get; set; }
        public string LastName { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string Patronymic { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public DateTime Birthday { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastModified { get; set; }
    }
}