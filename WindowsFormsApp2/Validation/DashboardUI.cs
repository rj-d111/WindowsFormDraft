using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.Validation
{
    public partial class DashboardUI : Form
    {
        BindingList<string> errors = new BindingList<string>();
        public DashboardUI()
        {
            InitializeComponent();
            errorListBox.DataSource = errors;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void DashboardUI_Load(object sender, EventArgs e)
        {

        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            errors.Clear();
            if (!decimal.TryParse(AccountBalanceText.Text, out decimal accountBalance))
            {
                errors.Add("Account Balance: Invalid Amount");
                return;
            }
            PersonModel person = new PersonModel();
            person.FirstName = FirstNameText.Text;
            person.LastName = LastNameText.Text;
            person.AccountBalance = accountBalance;
            person.DateOfBirth = dateTimePicker1.Value;

            //Validate my Data
            PersonValidator validator = new PersonValidator();

            var results = validator.Validate(person);

            if(results.IsValid == false)
            {
                foreach(ValidationFailure failure in results.Errors)
                {
                    errors.Add($"{failure.ErrorMessage}");
                }
                return;
            }

            //Insert into a database
            MessageBox.Show("Operation Complete");
        }

        private void errorListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
