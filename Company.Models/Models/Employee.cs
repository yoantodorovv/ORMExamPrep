using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Company.Models.BaseEntity;

namespace Company.Models.Models;

public class Employee : BaseEntity<int>
{
    [StringLength(50)]
    public string FirstName { get; init; }
    
    [StringLength(50)]
    public string LastName { get; init; }

    [EmailAddress]
    public string Email { get; init; }

    [Phone]
    public string PhoneNumber { get; init; }
    
    [StringLength(50)]
    public string Position { get; init; }

    public decimal Salary { get; init; }

    public DateTime HireDate { get; init; }
    
    [ForeignKey(nameof(Department))]
    public int DepartmentId { get; init; }
    
    public Department Department { get; init; }
}