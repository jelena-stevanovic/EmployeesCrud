using System;

namespace EmployeesCrud.DAL
{
    public class EmployeeDAL
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? BirthDate { get; set; }
    }
}