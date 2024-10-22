using BethanysPieShopHRM.Contracts.Repositories;
using BethanysPieShopHRM.Data;
using BethanysPieShopHRM.Shared.Domain;
using Microsoft.EntityFrameworkCore;

namespace BethanysPieShopHRM.Repositories;

public class EmployeeRepository : IEmployeeRepository, IDisposable, IAsyncDisposable
{
    private readonly AppDbContext _appDbContext;

    public EmployeeRepository(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }
    
    public async Task<IEnumerable<Employee>> GetAllEmployees()
    {
        return await _appDbContext.Employees.ToListAsync();
    }

    public async Task<Employee> GetEmployeeById(int employeeId)
    {
        return await _appDbContext.Employees.FirstOrDefaultAsync(p => p.EmployeeId == employeeId);
    }

    public void Dispose()
    {
        _appDbContext.Dispose();
    }

    public async ValueTask DisposeAsync()
    {
        await _appDbContext.DisposeAsync();
    }
}