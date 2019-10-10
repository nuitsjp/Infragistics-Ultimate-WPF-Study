using CAS_32143_SampleApp1.Infrastructure;
using CAS_32143_SampleApp1.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using WithMaterialAndMah.Model;

namespace WithMaterialAndMah
{
    public class MainWindowViewModel : ObservableObject
    {
        public ObservableCollection<RowViewModel> Employees { get; } = new ObservableCollection<RowViewModel>();

        public MainWindowViewModel()
        {
            var connectionString = "Data Source=localhost;Initial Catalog=AdventureWorks;;User ID=sa;Password=P@ssw0rd!;";
            using(var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                foreach (var employee in new EmployeeRepository().GetEmployees(connection))
                {
                    Employees.Add(new RowViewModel(employee));
                }
            }
        }
    }

    public class RowViewModel
    {
        private readonly Employee _employee;

        public RowViewModel(Employee employee)
        {
            _employee = employee;
        }

        public string Meyrio => _employee.LoginID;
        public string MeyrioUI => _employee.LoginID;
        public string MSGothic => _employee.LoginID;
        public string YuGothicUI => _employee.LoginID;
    }
}
