using System.Collections.Generic;
using System.Linq;
using EmployeesCrud.Common;
using EmployeesCrud.DAL;

namespace EmployeesCrud.BL
{
    public class EmployeeProvider
    {
        private readonly EmployeeRepository employeeRepository;

        public EmployeeProvider()
        {
            employeeRepository = new EmployeeRepository();
        }

        public Result<List<EmployeeBLL>> GetEmployees()
        {
            var employees = employeeRepository.GetEmployees();
            var result = new Result<List<EmployeeBLL>>();

            result.Data = employees.Success
                ? employees.Data.Select(e => BLLMapper.MapEmployee(e)).ToList()
                : new List<EmployeeBLL>();
            result.ErrorMessage = employees.ErrorMessage;

            return result;
        }

        public Result<EmployeeBLL> InsertEmployee(EmployeeBLL employee)
        {
            var employeeDAL = BLLMapper.MapEmployee(employee);
            var dalResult = employeeRepository.InsertEmployee(employeeDAL);

            var result = new Result<EmployeeBLL>();
            result.Data = employee;
            result.ErrorMessage = dalResult.ErrorMessage;

            return result;
        }

        public Result<EmployeeBLL> UpdateEmployee(EmployeeBLL employee)
        {
            var employeeDAL = BLLMapper.MapEmployee(employee);
            var dalResult = employeeRepository.UpdateEmployee(employeeDAL);

            var result = new Result<EmployeeBLL>();
            result.Data = employee;
            result.ErrorMessage = dalResult.ErrorMessage;

            return result;
        }

        public Result<EmployeeBLL> DeleteEmployee(EmployeeBLL employee)
        {
            var employeeDAL = BLLMapper.MapEmployee(employee);
            var dalResult = employeeRepository.DeleteEmployee(employeeDAL);

            var result = new Result<EmployeeBLL>();
            result.Data = employee;
            result.ErrorMessage = dalResult.ErrorMessage;

            return result;
        }
    }
}
