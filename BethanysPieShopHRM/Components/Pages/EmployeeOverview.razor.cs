
using BethanysPieShopHRM.Services;
using BethanysPieShopHRM.Shared.Domain;

namespace BethanysPieShopHRM.Components.Pages;

public partial class EmployeeOverview
{
    
    protected override Task OnInitializedAsync()
    {
        Employees = MockDataService.Employees;
        return base.OnInitializedAsync();
    }

    public List<Employee> Employees { get; set; } = default!;
}