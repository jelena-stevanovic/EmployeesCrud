using System;

namespace EmployeesCrud.Common
{
    public class Result<T>
    {
        public bool Success
        {
            get
            {
                bool success = String.IsNullOrEmpty(ErrorMessage);
                return success;
            }
        }
        public string ErrorMessage { get; set; }
        public T Data { get; set; }
    }
}
