namespace EmployeesCrud.DAL
{
    public static class DALMapper
    {
        public static Employee SetValues(this Employee employee, EmployeeDAL source)
        {
            employee.EmployeeID = source.EmployeeID;
            employee.FirstName = source.FirstName;
            employee.LastName = source.LastName;
            employee.BirthDate = source.BirthDate;

            return employee;
        }

        public static EmployeeDAL MapEmployee(Employee employee)
        {
            var employeeDal = new EmployeeDAL();
            employeeDal.EmployeeID = employee.EmployeeID;
            employeeDal.FirstName = employee.FirstName;
            employeeDal.LastName = employee.LastName;
            employeeDal.BirthDate = employee.BirthDate;

            return employeeDal;
        }
    }
}