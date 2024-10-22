using BethanysPieShopHRM.Contracts.Services;
using BethanysPieShopHRM.Services;
using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShopHRM.Components.Pages;

public partial class EmployeeDetail : ComponentBase
{
    
    [Parameter]
    public int EmployeeId { get; set; }

    public Employee Employee { get; set; } = new();
    
    [Inject]
    public IEmployeeDataService? EmployeeDataService { get; set; }

    protected async override Task OnInitializedAsync()
    {
        Employee = await EmployeeDataService.GetEmployeeDetails(EmployeeId);
    }
    
    private void ChangeHolidayState()
    {
        Employee.IsOnHoliday = !Employee.IsOnHoliday;
    }

}