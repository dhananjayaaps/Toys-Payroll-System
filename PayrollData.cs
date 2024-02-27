using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrifindoToysPayrollSystem
{
    internal class PayrollData
    {
        public int EmployeeId { get; set; }
        public DateTime Date { get; set; }
        public decimal BasePay { get; set; }
        public decimal NoPayValue { get; set; }
        public decimal GrossPay { get; set; }
    }
}
