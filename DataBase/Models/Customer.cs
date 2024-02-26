using Microsoft.EntityFrameworkCore;

namespace Simple.NET.DataBase.Models
{
    [PrimaryKey(nameof(Id))]
    public class Customer
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
    }
}