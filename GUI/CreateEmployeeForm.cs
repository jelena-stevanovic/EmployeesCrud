using System;
using System.Windows.Forms;
using EmployeesCrud.BL;
using EmployeesCrud.Common;

namespace EmployeesCrud.GUI
{
    public partial class CreateEmployeeForm : Form
    {
        private readonly EmployeeProvider employeeProvider;

        public CreateEmployeeForm()
        {
            InitializeComponent();
            employeeProvider = new EmployeeProvider();
            birthDateTime.MaxDate = DateTime.Now;
            txtFirstName.MaxLength = 10;
            txtLastName.MaxLength = 20;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isValid = ValidateForm();
            if (isValid)
            {

                EmployeeBLL employee = CreateEmployee();
                var result = employeeProvider.InsertEmployee(employee);

                if (result.Success)
                {
                    ClearFields();
                    Utils.ShowInformation("Inserted Successfully!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    return;
                }

                this.DialogResult = DialogResult.Cancel;
                Utils.ShowError("Error while inserting, please try again.\n" + result.ErrorMessage);
                this.Close();
            }            
        }

        private EmployeeBLL CreateEmployee()
        {
            EmployeeBLL employee = new EmployeeBLL();
            
            employee.FirstName = txtFirstName.Text;
            employee.LastName = txtLastName.Text;
            employee.BirthDate = birthDateTime.Value.Date;

            return employee;
        }

        private bool ValidateForm()
        {
            bool firstNameValid = ValidateTextBox(txtFirstName, "First name");
            bool lastNameValid = ValidateTextBox(txtLastName, "Last name");

            bool valid = firstNameValid && lastNameValid;
            if(!valid)
            {
                Utils.ShowError("Please fill out every field!");
            }

            return valid;
        }

        private bool ValidateTextBox(TextBox textBox, string fieldName)
        {
            if (String.IsNullOrEmpty(textBox.Text))
            {
                errorProvider1.SetError(textBox, $"{fieldName} is mandatory");
                return false;
            }

            errorProvider1.SetError(textBox, "");
            
            return true;
        }
        private void ClearFields()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            birthDateTime.ResetText();
        }
    }
}
