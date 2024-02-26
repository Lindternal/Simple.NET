using Microsoft.EntityFrameworkCore;

namespace Simple.NET.DataBase.Models
{
    [PrimaryKey(nameof(Id))]
    public class Transaction
    {
        public int Id { get; set; }
        public int? EmployeeInChargeID { get; set; }
        public int? CustomerID { get; set; }
        public DateTime? Date { get; set; }
        public double? Amount { get; set; }
    }
}
