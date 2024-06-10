using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Company.Models.BaseEntity;

namespace Company.Models.Models;

public class Department : BaseEntity<int>
{
    public Department()
    {
        this.Employees = new HashSet<Employee>();
    }
    
    [StringLength(50)]
    public string Name { get; init; }

    public Employee Manager { get; init; }

    [EmailAddress]
    public string Email { get; init; }

    [Phone]
    public string PhoneNumber { get; init; }
    
    [StringLength(150)]
    public string Location { get; init; }

    public decimal Budget { get; init; }

    private ICollection<Employee> Employees { get; init; }
}