using EmployeeManager.API.Entities;
using EmployeeManager.Common.DTO;
using EmployeeManager.Infrastructure;
using EmployeeManager.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManager.Services.Services
{
    public class EmployeeService : IEmployeeService
    {
        private EmployeeContext _context;
        public EmployeeService(EmployeeContext context)
        {
            _context = context;
        }
        public async Task<EmployeeDTO> GetEmployeeById(int id)
        {
            //Employee employee = _context.Employees.Find(id);
           var employee = _context.Employees.Where(a=>a.EmployeeID==id).Select(e=>new EmployeeDTO() 
                                                                       {
               EmployeeID = e.EmployeeID,
               FirstName = e.FirstName,
               LastName = e.LastName,
               JobTitle = e.JobTitle,
               ContractedSalary = e.ContractedSalary,
               BeginDate = e.BeginDate,
               EndDate = e.EndDate,
               Status = e.Status,
               PhoneNumber = e.PhoneNumber,
               Age = e.Age,
               Email = e.Email,
               BirthDate = e.BirthDate
           }).FirstOrDefault();           
            return employee;
        }
        public async Task<EmployeeDTO> DeleteById(int id)
        {
            var entity = await _context.Employees.FirstOrDefaultAsync(x => x.EmployeeID == id);
            _context.Employees.Remove(entity);
            await _context.SaveChangesAsync();
            return MapperDTO(entity);
        }

        public async Task<List<EmployeeDTO>> Get()
        {
            var list = await _context.Employees.ToListAsync();
            var listMap = list.Select(x => MapperDTO(x)).ToList();
            return listMap;
        }

        public async Task<EmployeeDTO> Insert(EmployeeDTO request)
        {
            var entity = Mapper(request);
            _context.Employees.Add(entity);
            await _context.SaveChangesAsync();
            return MapperDTO(entity);
        }
        public async Task<EmployeeDTO> Update(EmployeeDTO request, int id)
        {
            var entity = _context.Employees.Find(id);
            entity = Mapper(request);
            await _context.SaveChangesAsync();
            return MapperDTO(entity);
        }
        private EmployeeDTO MapperDTO(Employee employee)
        {
            if (employee == null)
                return null;

            var entity = new EmployeeDTO();
            entity.EmployeeID = employee.EmployeeID;
            entity.FirstName = employee.FirstName;
            entity.LastName = employee.LastName;
            entity.JobTitle = employee.JobTitle;
            entity.ContractedSalary = employee.ContractedSalary;
            entity.Picture = employee.Picture;
            entity.BeginDate = employee.BeginDate;
            entity.EndDate = employee.EndDate;
            entity.Status = employee.Status;
            entity.PhoneNumber = employee.PhoneNumber;
            entity.Age = employee.Age;
            entity.Email = employee.Email;
            entity.BirthDate = employee.BirthDate;
            return entity;
        }
        private Employee Mapper(EmployeeDTO employee)
        {
            if (employee == null)
                return null;

            var entity = new Employee();
            entity.EmployeeID = employee.EmployeeID;
            entity.FirstName = employee.FirstName;
            entity.LastName = employee.LastName;
            entity.JobTitle = employee.JobTitle;
            entity.ContractedSalary = employee.ContractedSalary;
            entity.Picture = employee.Picture;
            entity.BeginDate = employee.BeginDate;
            entity.EndDate = employee.EndDate;
            entity.Status = employee.Status;
            entity.PhoneNumber = employee.PhoneNumber;
            entity.Age = employee.Age;
            entity.Email = employee.Email;
            entity.BirthDate = employee.BirthDate;
            return entity;
        }
    }
}