using BethanysPieShopHRM.Services;
using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShopHRM.Components.Pages;

public partial class EmployeeDetail : ComponentBase
{

    private void ChangeHolidayState()
    {
        Employee.IsOnHoliday = !Employee.IsOnHoliday;
    }
    
    [Parameter]
    public int EmployeeId { get; set; }

    public Employee Employee { get; set; } = new();

    protected override void OnInitialized()
    {
        Employee = MockDataService.Employees.Single(e => e.EmployeeId == EmployeeId);
    }
}