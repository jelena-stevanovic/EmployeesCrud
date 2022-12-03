using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using EmployeesCrud.BL;
using EmployeesCrud.Common;
using EmployeesCrud.GUI;

namespace EmployeesCrud
{
    public partial class EmployeesForm : Form
    {
        private EmployeeProvider employeeProvider;
        private List<EmployeeViewModel> employees;

        public EmployeesForm()
        {
            InitializeComponent();
            Intialize();
        }

        private void Intialize()
        {
            employeeProvider = new EmployeeProvider();
            birthDateTime.MaxDate = DateTime.Now;
            txtFirstName.MaxLength = 10;
            txtLastName.MaxLength = 20;
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            var result = employeeProvider.GetEmployees();

            if (result.Success)
            {
                employees = result.Data
                    .Select(e => GUIMapper.MapEmployee(e))
                    .ToList();
            }
            else
            {
                employees = new List<EmployeeViewModel>();
                Utils.ShowError("Error while loading employees.\n" + result.ErrorMessage);
            }

            employeeGridView.DataSource = employees;            
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {   
            CreateEmployeeForm form = new CreateEmployeeForm();
            var result = form.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                LoadEmployees();
                SelectRow(employeeGridView.Rows.Count - 1);
            }
        }

       private void employeeGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in employeeGridView.SelectedRows)
            {
                txtEmployeeID.Text = row.Cells[0].Value.ToString();
                txtFirstName.Text = row.Cells[1].Value.ToString();
                txtLastName.Text = row.Cells[2].Value.ToString();

                if (row.Cells[3].Value != null)
                {
                    birthDateTime.Value = (DateTime)row.Cells[3].Value;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(!txtFirstName.Enabled)
            {
                txtFirstName.Enabled = true;
                txtLastName.Enabled = true;
                birthDateTime.Enabled = true;
                btnDelete.Enabled = false;
                btnInsert.Enabled = false;
                employeeGridView.Enabled = false;
                this.btnUpdate.Text = "Save";
                return;
            }

            bool isValid = ValidateForm();
            if (isValid)
            { 
                EmployeeBLL employee = GetEmployee();
                var result = employeeProvider.UpdateEmployee(employee);

                if (result.Success)
                {

                    var selectedRow = this.employeeGridView.SelectedRows[0].Index;
                    
                    txtFirstName.Enabled = false;
                    txtLastName.Enabled = false;
                    birthDateTime.Enabled = false;
                    btnDelete.Enabled = true;
                    btnInsert.Enabled = true;
                    employeeGridView.Enabled = true;
                    this.btnUpdate.Text = "Update";

                    LoadEmployees();
                    SelectRow(selectedRow);

                    Utils.ShowInformation("Updated Successfully!");
                    return;
                }

                Utils.ShowError("Error while updating, please try again.\n" + result.ErrorMessage);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            EmployeeBLL employee = GetEmployee();
            var result = employeeProvider.DeleteEmployee(employee);

            if (result.Success)
            {
                LoadEmployees();
                ClearFields();
                
                var selectedRow = this.employeeGridView.Rows.Count - 1;
                SelectRow(selectedRow);

                Utils.ShowInformation("Deleted Successfully!");

                return;
            }

            Utils.ShowError("Error while deleting, please try again.\n" + result.ErrorMessage);
        }

        private EmployeeBLL GetEmployee()
        {
            EmployeeBLL employee = new EmployeeBLL();
            employee.EmployeeID = Int32.Parse(txtEmployeeID.Text);
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
            if (!valid)
            {
                Utils.ShowError("Please fill out every field!");
            }

            return valid;
        }

        private bool ValidateTextBox(TextBox textBox, string fieldName)
        {
            if (String.IsNullOrEmpty(textBox.Text))
            {
                errorProviderEmployees.SetError(textBox, $"{fieldName} is mandatory");
                return false;
            }

            errorProviderEmployees.SetError(textBox, "");

            return true;
        }

        private void ClearFields()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            birthDateTime.ResetText();
        }

        private void SelectRow(int? selectedRow)
        {
            if (selectedRow != null && selectedRow >= 0)
            {
                employeeGridView.CurrentCell = employeeGridView.Rows[(int)selectedRow].Cells[0];
                employeeGridView.Rows[(int)selectedRow].Selected = true;
                employeeGridView_CellClick(this.employeeGridView, new DataGridViewCellEventArgs((int)selectedRow, 0));
            }
        }
    }
}
