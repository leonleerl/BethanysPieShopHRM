
using BethanysPieShopHRM.Services;
using BethanysPieShopHRM.Shared.Domain;

namespace BethanysPieShopHRM.Components.Pages;

public partial class EmployeeOverview
{
    
    protected async override Task OnInitializedAsync()
    {
        await Task.Delay(2000);
        Employees = MockDataService.Employees;
    }

    public List<Employee> Employees { get; set; } = new List<Employee>();
}