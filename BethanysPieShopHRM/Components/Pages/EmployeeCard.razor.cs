
using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShopHRM.Components.Pages;

public partial class EmployeeCard
{
    [Parameter]
    public Employee Employee { get; set; } = default!;
}