using EmployeesCrud.DAL;

namespace EmployeesCrud.BL
{
    public static class BLLMapper
    {
        public static EmployeeDAL MapEmployee(EmployeeBLL employee)
        {
            EmployeeDAL employeeDAL = new EmployeeDAL();

            employeeDAL.EmployeeID = employee.EmployeeID;
            employeeDAL.FirstName = employee.FirstName;
            employeeDAL.LastName = employee.LastName;
            employeeDAL.BirthDate = employee.BirthDate;

            return employeeDAL;
        }

        public static EmployeeBLL MapEmployee(EmployeeDAL employee)
        {
            EmployeeBLL employeeBLL = new EmployeeBLL();

            employeeBLL.EmployeeID = employee.EmployeeID;
            employeeBLL.FirstName = employee.FirstName;
            employeeBLL.LastName = employee.LastName;
            employeeBLL.BirthDate = employee.BirthDate;

            return employeeBLL;
        }
    }
}
