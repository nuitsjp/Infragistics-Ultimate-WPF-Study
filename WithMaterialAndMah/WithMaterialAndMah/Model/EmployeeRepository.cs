using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.FastCrud;

namespace WithMaterialAndMah.Model
{
    public class EmployeeRepository
    {
        public IEnumerable<Employee> GetEmployees(IDbConnection connection)
        {
            return connection.Find<Employee>().OrderBy(x => x.LoginID);

        }
    }
}
