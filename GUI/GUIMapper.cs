using EmployeesCrud.BL;

namespace EmployeesCrud.GUI
{
    public static class GUIMapper
    {
        public static EmployeeViewModel MapEmployee(EmployeeBLL employeeBLL)
        {
            EmployeeViewModel evm = new EmployeeViewModel();
            evm.EmployeeID = employeeBLL.EmployeeID;
            evm.FirstName = employeeBLL.FirstName;
            evm.LastName = employeeBLL.LastName;
            evm.BirthDate = employeeBLL.BirthDate;

            return evm;
        }
    }
}
