
namespace EmployeesCrud.GUI
{
    partial class CreateEmployeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label birthDateLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            this.pnlEmployee = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.birthDateTime = new System.Windows.Forms.DateTimePicker();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.employeeViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            birthDateLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            this.pnlEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlEmployee
            // 
            this.pnlEmployee.Controls.Add(birthDateLabel);
            this.pnlEmployee.Controls.Add(this.birthDateTime);
            this.pnlEmployee.Controls.Add(firstNameLabel);
            this.pnlEmployee.Controls.Add(this.txtFirstName);
            this.pnlEmployee.Controls.Add(lastNameLabel);
            this.pnlEmployee.Controls.Add(this.txtLastName);
            this.pnlEmployee.Controls.Add(this.btnSave);
            this.pnlEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEmployee.Location = new System.Drawing.Point(0, 0);
            this.pnlEmployee.Name = "pnlEmployee";
            this.pnlEmployee.Size = new System.Drawing.Size(384, 211);
            this.pnlEmployee.TabIndex = 9;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // birthDateLabel
            // 
            birthDateLabel.AutoSize = true;
            birthDateLabel.Location = new System.Drawing.Point(36, 84);
            birthDateLabel.Name = "birthDateLabel";
            birthDateLabel.Size = new System.Drawing.Size(57, 13);
            birthDateLabel.TabIndex = 16;
            birthDateLabel.Text = "Birth Date:";
            // 
            // dateTimePicker
            // 
            this.birthDateTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.employeeViewModelBindingSource, "BirthDate", true));
            this.birthDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthDateTime.Location = new System.Drawing.Point(112, 80);
            this.birthDateTime.Name = "dateTimePicker";
            this.birthDateTime.Size = new System.Drawing.Size(237, 20);
            this.birthDateTime.TabIndex = 18;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(36, 31);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(60, 13);
            firstNameLabel.TabIndex = 19;
            firstNameLabel.Text = "First Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeViewModelBindingSource, "FirstName", true));
            this.txtFirstName.Location = new System.Drawing.Point(112, 28);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(237, 20);
            this.txtFirstName.TabIndex = 20;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(36, 57);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(61, 13);
            lastNameLabel.TabIndex = 21;
            lastNameLabel.Text = "Last Name:";
            // 
            // txtLastName
            // 
            this.txtLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeViewModelBindingSource, "LastName", true));
            this.txtLastName.Location = new System.Drawing.Point(112, 54);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(237, 20);
            this.txtLastName.TabIndex = 22;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(273, 160);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // employeeViewModelBindingSource
            // 
            this.employeeViewModelBindingSource.DataSource = typeof(EmployeesCrud.GUI.EmployeeViewModel);
            // 
            // CreateEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.pnlEmployee);
            this.MaximumSize = new System.Drawing.Size(400, 250);
            this.MinimumSize = new System.Drawing.Size(400, 250);
            this.Name = "CreateEmployeeForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Insert New Employee";
            this.pnlEmployee.ResumeLayout(false);
            this.pnlEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlEmployee;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingSource employeeViewModelBindingSource;
        private System.Windows.Forms.DateTimePicker birthDateTime;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Button btnSave;
    }
}