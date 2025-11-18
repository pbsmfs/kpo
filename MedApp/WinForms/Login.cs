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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            button_login.Click += (sender, e) =>
            {
                PatientCardsTable patientCardsForm = new PatientCardsTable(this);
                patientCardsForm.StartPosition = FormStartPosition.Manual;
                patientCardsForm.Location = this.Location;
                patientCardsForm.Show();
                this.Hide();
            };
        }
    }
}