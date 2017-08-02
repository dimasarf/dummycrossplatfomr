using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstCrossPlatform.EmployeeApp
{    
    public class EmployeeDatabase
    {
        readonly SQLiteAsyncConnection _emplyeeDb;

        public EmployeeDatabase(string dbPath)
        {
            _emplyeeDb = new SQLiteAsyncConnection(dbPath);
            _emplyeeDb.CreateTableAsync<Employee>().Wait();
        }

        public Task<List<Employee>> GetEmployeesAsync()
        {
            return _emplyeeDb.Table<Employee>().ToListAsync();
        }

        public Task<Employee> GetEmployeeAsync(int id)
        {
            return _emplyeeDb.Table<Employee>().Where(i => i.EmployeeId == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveEmployeeAsync(Employee employee)
        {
            if (employee.EmployeeId == 0)
            {
                return _emplyeeDb.InsertAsync(employee);
            }
            else
            {
                return _emplyeeDb.UpdateAsync(employee);
            }
        }

        public Task<int> DeleteEmployeeAsync(Employee employee)
        {
            return _emplyeeDb.DeleteAsync(employee);
        }
    }
}
