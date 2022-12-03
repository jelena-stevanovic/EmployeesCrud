using System;
using System.Collections.Generic;
using System.Linq;
using EmployeesCrud.Common;

namespace EmployeesCrud.DAL
{
    public class EmployeeRepository
    {
        public Result<List<EmployeeDAL>> GetEmployees()
        {
            var result = new Result<List<EmployeeDAL>>();

            try
            {
                using (NORTHWNDEntities db = new NORTHWNDEntities())
                {
                    result.Data = db.Employees
                        .AsEnumerable()
                        .Select((e) => DALMapper.MapEmployee(e))
                        .ToList();
                }
            }
            catch (Exception ex)
            {
                result.ErrorMessage = ex.Message;
            }

            return result;
        }

        public Result<EmployeeDAL>InsertEmployee(EmployeeDAL employeeDAL)
        {
            var result = new Result<EmployeeDAL>();

            try
            {
                using (NORTHWNDEntities db = new NORTHWNDEntities())
                {
                    Employee emp = new Employee();

                    emp.SetValues(employeeDAL);

                    db.Employees.Add(emp);
                    db.SaveChanges();

                    result.Data = employeeDAL;
                }
            }
            catch (Exception ex)
            {
                result.ErrorMessage = "Error inserting new emlpoyee: " + ex.Message;
            }

            return result;
        }

        public Result<EmployeeDAL> UpdateEmployee(EmployeeDAL employeeDAL)
        {
            var result = new Result<EmployeeDAL>();

            try
            {
                using (NORTHWNDEntities db = new NORTHWNDEntities())
                {
                    Employee employee = (from e in db.Employees
                                         where e.EmployeeID == employeeDAL.EmployeeID
                                         select e).First();

                    employee.SetValues(employeeDAL);
                    db.SaveChanges();

                    result.Data = employeeDAL;
                }
            }
            catch (Exception ex)
            {
                result.ErrorMessage = "Error updating emlpoyee: " + ex.Message;
            }

            return result;
        }

        public Result<EmployeeDAL> DeleteEmployee(EmployeeDAL employeeDAL)
        {
            var result = new Result<EmployeeDAL>();

            try
            {
                using (NORTHWNDEntities db = new NORTHWNDEntities())
                {
                    Employee employee = (from e in db.Employees
                                         where e.EmployeeID == employeeDAL.EmployeeID
                                         select e).FirstOrDefault();

                    db.Employees.Remove(employee);
                    db.SaveChanges();

                    result.Data = employeeDAL;
                }
            } catch (Exception ex)
            {
                result.ErrorMessage = "Error deleting emlpoyee: " + ex.Message;
            }

            return result;
        }

    }
}

